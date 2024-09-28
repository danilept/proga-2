using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Proga2._1
{
    public partial class MainForm : Form
    {
        private const string ConnectionString = "Data Source=auto.db;Version=3;";
        private int correctAnswer;

        public MainForm(bool isDarkTheme)
        {
            InitializeComponent();
            ThemeManager.IsDarkTheme = isDarkTheme; // Set the current theme state
            ThemeManager.ApplyTheme(this); // Apply theme
            InitializeCustomComponents();
            CreateDatabase();
            LoadData();
        }

        private void InitializeCustomComponents()
        {
            MInSver_btn.Click += MInSver_btn_Click;
            Search.Click += Search_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridCar.DefaultCellStyle.BackColor = Color.LightGray; // Set background color for all cells
            dataGridCar.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Set font
            ThemeManager.ApplyTheme(this); // Apply current theme
            Captcha.Visible = false;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Cars (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Make TEXT NOT NULL,
                            Model TEXT NOT NULL,
                            Year INTEGER NOT NULL,
                            Price REAL NOT NULL,
                            Image BLOB
                        );";

                    using (var command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании базы данных: {ex.Message}");
            }
        }

        private void LoadData(string searchFilter = "")
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT Id, Make, Model, Year, Price FROM Cars";

                    if (!string.IsNullOrEmpty(searchFilter))
                    {
                        selectQuery += " WHERE Make LIKE @Search OR Model LIKE @Search";
                    }

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        if (!string.IsNullOrEmpty(searchFilter))
                        {
                            command.Parameters.AddWithValue("@Search", "%" + searchFilter + "%");
                        }

                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridCar.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void dataGridCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(dataGridCar.Rows[e.RowIndex].Cells["Id"].Value);
                ShowCarDetails(selectedId);
            }
        }

        private void ShowCarDetails(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT Make, Model, Year, Price, Image FROM Cars WHERE Id = @Id;";

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ShowListForm(
                                    reader["Make"].ToString(),
                                    reader["Model"].ToString(),
                                    Convert.ToInt32(reader["Year"]),
                                    Convert.ToDouble(reader["Price"]),
                                    reader["Image"] as byte[]
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отображении деталей автомобиля: {ex.Message}");
            }
        }

        private void ShowListForm(string make, string model, int year, double price, byte[] carImage)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is ListForm)
                {
                    form.Close();
                }
            }

            ListForm listForm = new ListForm(this)
            {
                Make = make,
                Model = model,
                Year = year,
                Price = price,
                CarImage = carImage
            };
            listForm.ShowDialog();
        }

        private void MInSver_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MInSver_btn_MouseEnter(object sender, EventArgs e)
        {
            MInSver_btn.BackColor = Color.LightGray;
        }

        private void MInSver_btn_MouseLeave(object sender, EventArgs e)
        {
            MInSver_btn.BackColor = Color.White;
        }

        private void Close_btn_MouseEnter(object sender, EventArgs e)
        {
            Close_btn.BackColor = Color.Red;
            Close_btn.ForeColor = Color.White;
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            Close_btn.BackColor = Color.White;
            Close_btn.ForeColor = Color.Black;
        }

        private int clickCount = 0;
        private void Dev_btn_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount == 1)
            {
                Captcha.Visible = true;
                GenerateCaptcha();
            }
            else if (clickCount == 2)
            {
                Captcha.Visible = false;
                clickCount = 0;
            }
        }

        private void GenerateCaptcha()
        {
            Random random = new Random();
            int num1 = random.Next(1, 10);
            int num2 = random.Next(1, 10);
            bool isAddition = random.Next(0, 2) == 0;

            // Generate problem
            correctAnswer = isAddition ? num1 + num2 : num1 - num2;
            Primer.Text = isAddition ?
                $"Сколько будет {num1} + {num2}?" :
                $"Сколько будет {num1} - {num2}?";
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Dev_btn_MouseEnter(object sender, EventArgs e)
        {
            Dev_btn.Font = new Font(Dev_btn.Font.FontFamily, Dev_btn.Font.Size + 2);
        }

        private void Dev_btn_MouseLeave(object sender, EventArgs e)
        {
            Dev_btn.Font = new Font(Dev_btn.Font.FontFamily, Dev_btn.Font.Size - 2);
        }

        private void Exit_btn_MouseEnter(object sender, EventArgs e)
        {
            Exit_btn.Font = new Font(Exit_btn.Font.FontFamily, Exit_btn.Font.Size + 2);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = Search_txt.Text.Trim();
            LoadData(searchText);
        }

        private void Search_MouseEnter(object sender, EventArgs e)
        {
            Search.Font = new Font(Search.Font.FontFamily, Search.Font.Size + 2);
        }

        private void Search_MouseLeave(object sender, EventArgs e)
        {
            Search.Font = new Font(Search.Font.FontFamily, Search.Font.Size - 2);
        }

        private void Exit_btn_MouseLeave(object sender, EventArgs e)
        {
            Exit_btn.Font = new Font(Exit_btn.Font.FontFamily, Exit_btn.Font.Size - 2);
        }

        private void Otvet_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Otvet_txt.Text, out int userAnswer))
            {
                if (userAnswer == correctAnswer)
                {
                    Primer.Text = "Ответ верный! 😊";
                    this.Hide();
                    Developer developer = new Developer(this); // Pass current MainForm reference
                    developer.Show();
                }
                else
                {
                    Primer.Text = "Ответ неверный. Попробуйте снова. 😟";
                }
            }
            else
            {
                Primer.Text = "Введите числовой ответ. ⚠️";
            }
        }

        private void Close_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Otvet_MouseEnter(object sender, EventArgs e)
        {
            Otvet.Font = new Font(Otvet.Font.FontFamily, Otvet.Font.Size + 2);
        }

        private void Otvet_MouseLeave(object sender, EventArgs e)
        {
            Otvet.Font = new Font(Otvet.Font.FontFamily, Otvet.Font.Size - 2);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
