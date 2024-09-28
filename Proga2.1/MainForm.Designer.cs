namespace Proga2._1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Close_btn = new System.Windows.Forms.Button();
            this.MInSver_btn = new System.Windows.Forms.Button();
            this.dataGridCar = new System.Windows.Forms.DataGridView();
            this.Dev_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Primer = new System.Windows.Forms.Label();
            this.Otvet = new System.Windows.Forms.Button();
            this.Otvet_txt = new System.Windows.Forms.TextBox();
            this.Captcha = new System.Windows.Forms.GroupBox();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).BeginInit();
            this.Captcha.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close_btn
            // 
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Location = new System.Drawing.Point(733, 0);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(64, 40);
            this.Close_btn.TabIndex = 1;
            this.Close_btn.Text = "X";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click_1);
            this.Close_btn.MouseEnter += new System.EventHandler(this.Close_btn_MouseEnter);
            this.Close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            // 
            // MInSver_btn
            // 
            this.MInSver_btn.FlatAppearance.BorderSize = 0;
            this.MInSver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MInSver_btn.Location = new System.Drawing.Point(672, 0);
            this.MInSver_btn.Name = "MInSver_btn";
            this.MInSver_btn.Size = new System.Drawing.Size(64, 40);
            this.MInSver_btn.TabIndex = 11;
            this.MInSver_btn.Text = "---";
            this.MInSver_btn.UseVisualStyleBackColor = true;
            this.MInSver_btn.Click += new System.EventHandler(this.MInSver_btn_Click);
            this.MInSver_btn.MouseEnter += new System.EventHandler(this.MInSver_btn_MouseEnter);
            this.MInSver_btn.MouseLeave += new System.EventHandler(this.MInSver_btn_MouseLeave);
            // 
            // dataGridCar
            // 
            this.dataGridCar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCar.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridCar.Location = new System.Drawing.Point(85, 117);
            this.dataGridCar.Name = "dataGridCar";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridCar.Size = new System.Drawing.Size(613, 225);
            this.dataGridCar.TabIndex = 12;
            this.dataGridCar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCar_CellDoubleClick);
            // 
            // Dev_btn
            // 
            this.Dev_btn.FlatAppearance.BorderSize = 0;
            this.Dev_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dev_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dev_btn.Location = new System.Drawing.Point(640, 520);
            this.Dev_btn.Name = "Dev_btn";
            this.Dev_btn.Size = new System.Drawing.Size(127, 49);
            this.Dev_btn.TabIndex = 13;
            this.Dev_btn.Text = "Разработка";
            this.Dev_btn.UseVisualStyleBackColor = true;
            this.Dev_btn.Click += new System.EventHandler(this.Dev_btn_Click);
            this.Dev_btn.MouseEnter += new System.EventHandler(this.Dev_btn_MouseEnter);
            this.Dev_btn.MouseLeave += new System.EventHandler(this.Dev_btn_MouseLeave);
            // 
            // Exit_btn
            // 
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_btn.Location = new System.Drawing.Point(12, 12);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(82, 47);
            this.Exit_btn.TabIndex = 14;
            this.Exit_btn.Text = "Выйти";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            this.Exit_btn.MouseEnter += new System.EventHandler(this.Exit_btn_MouseEnter);
            this.Exit_btn.MouseLeave += new System.EventHandler(this.Exit_btn_MouseLeave);
            // 
            // Search
            // 
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(645, 81);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(64, 30);
            this.Search.TabIndex = 15;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            this.Search.MouseEnter += new System.EventHandler(this.Search_MouseEnter);
            this.Search.MouseLeave += new System.EventHandler(this.Search_MouseLeave);
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(416, 81);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(223, 20);
            this.Search_txt.TabIndex = 16;
            // 
            // Primer
            // 
            this.Primer.AutoSize = true;
            this.Primer.Location = new System.Drawing.Point(27, 16);
            this.Primer.Name = "Primer";
            this.Primer.Size = new System.Drawing.Size(0, 13);
            this.Primer.TabIndex = 17;
            // 
            // Otvet
            // 
            this.Otvet.FlatAppearance.BorderSize = 0;
            this.Otvet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Otvet.Location = new System.Drawing.Point(165, 41);
            this.Otvet.Name = "Otvet";
            this.Otvet.Size = new System.Drawing.Size(62, 25);
            this.Otvet.TabIndex = 18;
            this.Otvet.Text = "Ответ";
            this.Otvet.UseVisualStyleBackColor = true;
            this.Otvet.Click += new System.EventHandler(this.Otvet_Click);
            this.Otvet.MouseEnter += new System.EventHandler(this.Otvet_MouseEnter);
            this.Otvet.MouseLeave += new System.EventHandler(this.Otvet_MouseLeave);
            // 
            // Otvet_txt
            // 
            this.Otvet_txt.Location = new System.Drawing.Point(18, 46);
            this.Otvet_txt.Name = "Otvet_txt";
            this.Otvet_txt.Size = new System.Drawing.Size(104, 20);
            this.Otvet_txt.TabIndex = 19;
            // 
            // Captcha
            // 
            this.Captcha.Controls.Add(this.Otvet_txt);
            this.Captcha.Controls.Add(this.Otvet);
            this.Captcha.Controls.Add(this.Primer);
            this.Captcha.Location = new System.Drawing.Point(328, 497);
            this.Captcha.Name = "Captcha";
            this.Captcha.Size = new System.Drawing.Size(281, 72);
            this.Captcha.TabIndex = 20;
            this.Captcha.TabStop = false;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(85, 84);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(84, 24);
            this.Refresh.TabIndex = 21;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Captcha);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Dev_btn);
            this.Controls.Add(this.dataGridCar);
            this.Controls.Add(this.MInSver_btn);
            this.Controls.Add(this.Close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).EndInit();
            this.Captcha.ResumeLayout(false);
            this.Captcha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button MInSver_btn;
        private System.Windows.Forms.DataGridView dataGridCar;
        private System.Windows.Forms.Button Dev_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Label Primer;
        private System.Windows.Forms.Button Otvet;
        private System.Windows.Forms.TextBox Otvet_txt;
        private System.Windows.Forms.GroupBox Captcha;
        private System.Windows.Forms.Button Refresh;
    }
}