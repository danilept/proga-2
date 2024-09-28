using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proga2._1
{
    public partial class Developer : Form
    {
        private DataTable dataTable;
        private string connectionString = "Data Source=auto.db;";
        private string imagePath;
        private readonly MainForm _mainForm;

        public Developer(MainForm mainForm)
        {
            dataTable = new DataTable();
            InitializeComponent();
            Edit_List_btn.Click += Edit_List_btn_Click;
            CreateDatabase();
            LoadData();
            _mainForm = mainForm;
            dataGridViewCar.DataSource = dataTable;

        }
        private void CreateDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Cars (
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
        private void LoadData(string searchFilter = "")
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
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
                            dataGridViewCar.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }
    


        private void Developer_Load(object sender, EventArgs e)
        {
            dataGridViewCar.DefaultCellStyle.BackColor = Color.LightGray; // Set background color for all cells
            dataGridViewCar.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Set font
            ThemeManager.ApplyTheme(this);
            LoadData();
            Make_txt.Focus();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainForm.Show();
        }

        private void Pic_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    pictureBoxCar.Image = Image.FromFile(imagePath);
                    pictureBoxCar.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            // Проверяем поля на пустые значения
            if (string.IsNullOrWhiteSpace(Model_txt.Text) ||
                string.IsNullOrWhiteSpace(Year_txt.Text) ||
                string.IsNullOrWhiteSpace(Price_txt.Text) ||
                string.IsNullOrWhiteSpace(Make_txt.Text) ||
                string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Пожалуйста, убедитесь, что все поля заполнены корректно.");
                return;
            }
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Пожалуйста, выберите изображение.");
                return;
            }

            if (int.TryParse(Year_txt.Text, out int year) &&
        double.TryParse(Price_txt.Text, out double price)) // Используем TryParse
            {
                AddCar(Make_txt.Text, Model_txt.Text, year, price, imagePath);
                MessageBox.Show("Автомобиль добавлен!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для года и цены.");
            }

            LoadData();
        }
        private void AddCar(string make, string model, int year, double price, string imagePath)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                string insertQuery = "INSERT INTO Cars (Make, Model, Year, Price, Image) VALUES (@Make, @Model, @Year, @Price, @Image);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Make", make);
                    command.Parameters.AddWithValue("@Model", model);
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Image", imageBytes);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Edit_btn_MouseEnter(object sender, EventArgs e)
        {
            Edit_btn.Font = new Font(Edit_btn.Font.FontFamily, Edit_btn.Font.Size + 2);
        }

        private void Edit_btn_MouseLeave(object sender, EventArgs e)
        {
            Edit_btn.Font = new Font(Edit_btn.Font.FontFamily, Edit_btn.Font.Size - 2);
        }

        private void Pic_btn_MouseEnter(object sender, EventArgs e)
        {
            Pic_btn.Font = new Font(Pic_btn.Font.FontFamily, Pic_btn.Font.Size + 2);
        }

        private void Pic_btn_MouseLeave(object sender, EventArgs e)
        {
            Pic_btn.Font = new Font(Pic_btn.Font.FontFamily, Pic_btn.Font.Size - 2);
        }

        private void Edit_List_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, указан ли ID автомобиля
            if (!int.TryParse(ID_txt.Text, out int carId))
            {
                MessageBox.Show("Пожалуйста, введите корректный ID автомобиля.");
                return;
            }

            // Проверяем остальные поля на ввод
            if (string.IsNullOrWhiteSpace(Make2_txt.Text) || string.IsNullOrWhiteSpace(Model2_txt.Text) ||
                string.IsNullOrWhiteSpace(Year2_txt.Text) || string.IsNullOrWhiteSpace(Price2_txt.Text))
            {
                MessageBox.Show("Пожалуйста, убедитесь, что все поля заполнены корректно.");
                return;
            }

            // Пробуем парсить значения
            if (!int.TryParse(Year2_txt.Text, out int year) || !double.TryParse(Price2_txt.Text, out double price))
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для Года и Цены.");
                return;
            }

            // Если все проверки прошли, обновляем запись
            UpdateCar(carId, Make2_txt.Text, Model2_txt.Text, year, price);
        }
        private void UpdateCar(int id, string make, string model, int year, double price)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Cars SET Make = @Make, Model = @Model, Year = @Year, Price = @Price WHERE Id = @Id;";
                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Make", make);
                    command.Parameters.AddWithValue("@Model", model);
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Автомобиль успешно обновлен!");
                        LoadData(); // Обновляем данные в DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Запись с таким ID не найдена.");
                    }
                }
            }
        }

        private void dataGridViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Получаем выбранную строку
                DataGridViewRow row = dataGridViewCar.Rows[e.RowIndex];

                // Выводим данные в TextBox
                ID_txt.Text = row.Cells["Id"].Value.ToString();
                Make2_txt.Text = row.Cells["Make"].Value.ToString();
                Model2_txt.Text = row.Cells["Model"].Value.ToString();
                Year2_txt.Text = row.Cells["Year"].Value.ToString();
                Price2_txt.Text = row.Cells["Price"].Value.ToString();
            }
        }
        private void DeleteCar(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Cars WHERE Id = @Id;";
                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Автомобиль успешно удалён.");
                        LoadData(); // Обновляем данные в DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Запись с таким ID не найдена.");
                    }
                }
            }
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, указан ли ID автомобиля
            if (!int.TryParse(ID_txt.Text, out int carId))
            {
                MessageBox.Show("Пожалуйста, выберите автомобиль для удаления.");
                return;
            }

            // Подтверждаем удаление
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить эту запись?",
                                                 "Подтверждение удаления",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteCar(carId);
            }
        }

        private void Edit_List_btn_MouseEnter(object sender, EventArgs e)
        {
            Edit_List_btn.Font = new Font(Edit_List_btn.Font.FontFamily, Edit_List_btn.Font.Size + 2);
        }

        private void Edit_List_btn_MouseLeave(object sender, EventArgs e)
        {
            Edit_List_btn.Font = new Font(Edit_List_btn.Font.FontFamily, Edit_List_btn.Font.Size - 2);
        }

        private void Del_btn_MouseEnter(object sender, EventArgs e)
        {
            Del_btn.Font = new Font(Del_btn.Font.FontFamily, Del_btn.Font.Size + 2);
        }

        private void Del_btn_MouseLeave(object sender, EventArgs e)
        {
            Del_btn.Font = new Font(Del_btn.Font.FontFamily, Del_btn.Font.Size - 2);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = Search_txt.Text.Trim();
            LoadData(searchText);
        }

        private void dataGridViewCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Make_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}