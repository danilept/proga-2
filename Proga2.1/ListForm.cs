using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proga2._1
{
    public partial class ListForm : Form
    {
        private readonly MainForm _mainForm; 

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public byte[] CarImage { get; set; }

        public ListForm(MainForm mainForm) 
        {
            InitializeComponent();
            _mainForm = mainForm; 
        }

        public ListForm()
        {
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainForm.Show();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            
            Make_lbl.Text = Make;
            Model_lbl.Text = Model;
            Year_lbl.Text = "Год: " + Year;
            Price_lbl.Text = Price.ToString("C"); 

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 

            
            LoadCarImage();
           
            ThemeManager.ApplyTheme(this);
        }

        private void LoadCarImage()
        {
            if (CarImage != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(CarImage))
                    {
                        pictureBox1.Image = Image.FromStream(ms); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}",
                                    "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                pictureBox1.Image = null; 
            }
        }

        private void BUE_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы купили это авто!!!");
        }
    }
}