using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Proga2._1
{
    public partial class Enter_Form : Form
    {
        private const string ConnectionString = "Data Source=auto.db;Version=3;";
        private bool isPanel1Visible = false;
        private bool isPanel2Visible = false;
        private Timer timer1;
        private Timer timer2;
        private int panel1Position;
        private int panel2Position;
        private bool isDarkTheme = false;

        public Enter_Form()
        {
            InitializeComponent();
            InitializeCustomComponents();

            timer1 = new Timer { Interval = 10 };
            timer1.Tick += Timer1_Tick;

            timer2 = new Timer { Interval = 10 };
            timer2.Tick += Timer2_Tick;

            txtPassword.UseSystemPasswordChar = true;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeCustomComponents()
        {
            panel_info.Left = -panel_info.Width; 
            panel1Position = panel_info.Left;

            panel2_info.Left = -panel2_info.Width;
            panel2Position = panel2_info.Left;

            MInSver_btn.Click += MInSver_btn_Click;
        }

        private void Info1_btn_Click(object sender, EventArgs e)
        {
            TogglePanel(ref isPanel1Visible, timer1, Info1_btn, panel_info, ref panel1Position);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdatePanelPosition(ref isPanel1Visible, panel_info, ref panel1Position, Info1_btn);
        }

        private void Info2_btn_Click(object sender, EventArgs e)
        {
            TogglePanel(ref isPanel2Visible, timer2, Info2_btn, panel2_info, ref panel2Position);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            UpdatePanelPosition(ref isPanel2Visible, panel2_info, ref panel2Position, Info2_btn);
        }

        private void TogglePanel(ref bool isVisible, Timer timer, Button button, Panel panel, ref int position)
        {
            isVisible = !isVisible;
            timer.Start();
        }

        private void UpdatePanelPosition(ref bool isVisible, Panel panel, ref int position, Button button)
        {
            if (isVisible && position < 0) // Show the panel
            {
                position += 10;
                if (position >= 0)
                {
                    position = 0;
                    button.Text = "Скрыть";
                    timer1.Stop();
                }
            }
            else if (!isVisible && position > -panel.Width) // Hide the panel
            {
                position -= 10;
                if (position <= -panel.Width)
                {
                    position = -panel.Width;
                    button.Text = "Контакты"; // Reset button’s text
                    timer1.Stop();
                }
            }

            panel.Left = position;
        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateUser(username, password))
            {
                ShowCaptcha();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void ShowCaptcha()
        {
            var result = MessageBox.Show("Подтвердите, что вы не робот", "Капча", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                MainForm mainForm = new MainForm(isDarkTheme);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пожалуйста, подтвердите, что вы не робот.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при аутентификации: {ex.Message}");
                return false;
            }
        }

        private void Enter_btn_MouseEnter(object sender, EventArgs e)
        {
            UpdateButtonStyle(Enter_btn, 2, Color.White);
        }

        private void Enter_btn_MouseLeave(object sender, EventArgs e)
        {
            UpdateButtonStyle(Enter_btn, -2, Color.Black);
        }

        private void UpdateButtonStyle(Button button, int sizeChange, Color foreColor)
        {
            button.Font = new Font(button.Font.FontFamily, button.Font.Size + sizeChange);
            button.ForeColor = foreColor;
        }

        private void Tema_btn_Click(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme;
            ThemeManager.IsDarkTheme = isDarkTheme; // Change theme state
            UpdateTheme();
            ThemeManager.ApplyThemeToAllForms(); // Apply changes to all forms
        }

        private void UpdateTheme()
        {
            ThemeManager.ApplyTheme(this); // Apply theme to current form
        }

        private void Regisrt_label_MouseEnter(object sender, EventArgs e)
        {
            UpdateLabelStyle(sender, FontStyle.Underline);
        }

        private void Regisrt_label_MouseLeave(object sender, EventArgs e)
        {
            UpdateLabelStyle(sender, FontStyle.Regular);
        }

        private void UpdateLabelStyle(object sender, FontStyle style)
        {
            if (sender is Label label)
            {
                label.Font = new Font(label.Font, style);
            }
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

        private void Password_Vis_Click(object sender, EventArgs e)
        {
            clickCount++;
            txtPassword.UseSystemPasswordChar = clickCount % 2 == 0;
            Password_Vis.Text = clickCount % 2 == 0 ? "Показать" : "Скрыть";
        }

        private void Tema_btn_MouseEnter(object sender, EventArgs e)
        {
            Tema_btn.BackColor = Color.Gray;
            Tema_btn.ForeColor = Color.White;
        }

        private void Tema_btn_MouseLeave(object sender, EventArgs e)
        {
            Tema_btn.BackColor = Color.Tan;
            Tema_btn.ForeColor = Color.Black;
        }

        private void Info2_btn_MouseEnter(object sender, EventArgs e)
        {
            Info2_btn.Font = new Font(Info2_btn.Font.FontFamily, Info2_btn.Font.Size + 2);
        }

        private void Info2_btn_MouseLeave(object sender, EventArgs e)
        {
            Info2_btn.Font = new Font(Info2_btn.Font.FontFamily, Info2_btn.Font.Size - 2);
        }

        private void Info1_btn_MouseEnter(object sender, EventArgs e)
        {
            Info1_btn.Font = new Font(Info1_btn.Font.FontFamily, Info1_btn.Font.Size + 2);
        }

        private void Info1_btn_MouseLeave(object sender, EventArgs e)
        {
            Info1_btn.Font = new Font(Info1_btn.Font.FontFamily, Info1_btn.Font.Size - 2);
        }

        private void Password_Vis_MouseEnter(object sender, EventArgs e)
        {
            UpdateButtonStyle(Password_Vis, 2, Color.White);
        }

        private void Password_Vis_MouseLeave(object sender, EventArgs e)
        {
            UpdateButtonStyle(Password_Vis, -2, Color.Black);
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

        private void Enter_Form_Load(object sender, EventArgs e)
        {

        }
        private bool RegisterUser(string username, string password)
        {
            // Check if username already exists
            if (UserExists(username))
            {
                return false; // Username already exists
            }

            // Insert the new user
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                        return true; // Registration successful
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}");
                return false; // Registration failed
            }
        }

        private bool UserExists(string username)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // Return true if user exists
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при проверке пользователя: {ex.Message}");
                return false;
            }
        }

        private void Regisrt_label_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (RegisterUser(username, password))
            {
                MessageBox.Show("Регистрация прошла успешно!");
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Ошибка регистрации. Проверьте, что пользователь существует.");
            }
        }

        private void Info2_Click(object sender, EventArgs e)
        {

        }
    }
}
