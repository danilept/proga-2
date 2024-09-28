namespace Proga2._1
{
    partial class Developer
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
            this.Model_txt = new System.Windows.Forms.TextBox();
            this.Year_txt = new System.Windows.Forms.TextBox();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Make_txt = new System.Windows.Forms.TextBox();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.Pic_btn = new System.Windows.Forms.Button();
            this.Make_lbl = new System.Windows.Forms.Label();
            this.Model_lbl = new System.Windows.Forms.Label();
            this.Yaer_lbl = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.Button();
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.Edit_List_btn = new System.Windows.Forms.Button();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.Make2_txt = new System.Windows.Forms.TextBox();
            this.Model2_txt = new System.Windows.Forms.TextBox();
            this.Year2_txt = new System.Windows.Forms.TextBox();
            this.Price2_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Del_btn = new System.Windows.Forms.Button();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            this.SuspendLayout();
            // 
            // Model_txt
            // 
            this.Model_txt.Location = new System.Drawing.Point(78, 286);
            this.Model_txt.Name = "Model_txt";
            this.Model_txt.Size = new System.Drawing.Size(193, 20);
            this.Model_txt.TabIndex = 0;
            // 
            // Year_txt
            // 
            this.Year_txt.Location = new System.Drawing.Point(78, 315);
            this.Year_txt.Name = "Year_txt";
            this.Year_txt.Size = new System.Drawing.Size(193, 20);
            this.Year_txt.TabIndex = 1;
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(78, 341);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(193, 20);
            this.Price_txt.TabIndex = 2;
            // 
            // Make_txt
            // 
            this.Make_txt.Location = new System.Drawing.Point(78, 256);
            this.Make_txt.Name = "Make_txt";
            this.Make_txt.Size = new System.Drawing.Size(193, 20);
            this.Make_txt.TabIndex = 3;
            this.Make_txt.TextChanged += new System.EventHandler(this.Make_txt_TextChanged);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(296, 227);
            this.pictureBoxCar.TabIndex = 4;
            this.pictureBoxCar.TabStop = false;
            // 
            // Edit_btn
            // 
            this.Edit_btn.FlatAppearance.BorderSize = 0;
            this.Edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_btn.Location = new System.Drawing.Point(35, 378);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(150, 44);
            this.Edit_btn.TabIndex = 5;
            this.Edit_btn.Text = "Добавить";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            this.Edit_btn.MouseEnter += new System.EventHandler(this.Edit_btn_MouseEnter);
            this.Edit_btn.MouseLeave += new System.EventHandler(this.Edit_btn_MouseLeave);
            // 
            // Pic_btn
            // 
            this.Pic_btn.FlatAppearance.BorderSize = 0;
            this.Pic_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pic_btn.Location = new System.Drawing.Point(283, 245);
            this.Pic_btn.Name = "Pic_btn";
            this.Pic_btn.Size = new System.Drawing.Size(136, 46);
            this.Pic_btn.TabIndex = 6;
            this.Pic_btn.Text = "Добавить Изображение";
            this.Pic_btn.UseVisualStyleBackColor = true;
            this.Pic_btn.Click += new System.EventHandler(this.Pic_btn_Click);
            this.Pic_btn.MouseEnter += new System.EventHandler(this.Pic_btn_MouseEnter);
            this.Pic_btn.MouseLeave += new System.EventHandler(this.Pic_btn_MouseLeave);
            // 
            // Make_lbl
            // 
            this.Make_lbl.AutoSize = true;
            this.Make_lbl.Location = new System.Drawing.Point(32, 256);
            this.Make_lbl.Name = "Make_lbl";
            this.Make_lbl.Size = new System.Drawing.Size(40, 13);
            this.Make_lbl.TabIndex = 7;
            this.Make_lbl.Text = "Марка";
            // 
            // Model_lbl
            // 
            this.Model_lbl.AutoSize = true;
            this.Model_lbl.Location = new System.Drawing.Point(32, 289);
            this.Model_lbl.Name = "Model_lbl";
            this.Model_lbl.Size = new System.Drawing.Size(46, 13);
            this.Model_lbl.TabIndex = 8;
            this.Model_lbl.Text = "Модель";
            // 
            // Yaer_lbl
            // 
            this.Yaer_lbl.AutoSize = true;
            this.Yaer_lbl.Location = new System.Drawing.Point(47, 318);
            this.Yaer_lbl.Name = "Yaer_lbl";
            this.Yaer_lbl.Size = new System.Drawing.Size(25, 13);
            this.Yaer_lbl.TabIndex = 9;
            this.Yaer_lbl.Text = "Год";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Location = new System.Drawing.Point(39, 344);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(33, 13);
            this.Price_lbl.TabIndex = 10;
            this.Price_lbl.Text = "Цена";
            // 
            // Close_btn
            // 
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Location = new System.Drawing.Point(983, 12);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(64, 40);
            this.Close_btn.TabIndex = 11;
            this.Close_btn.Text = "X";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Location = new System.Drawing.Point(395, 12);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.Size = new System.Drawing.Size(482, 157);
            this.dataGridViewCar.TabIndex = 12;
            this.dataGridViewCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCar_CellClick);
            this.dataGridViewCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCar_CellContentClick);
            // 
            // Edit_List_btn
            // 
            this.Edit_List_btn.FlatAppearance.BorderSize = 0;
            this.Edit_List_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_List_btn.Location = new System.Drawing.Point(447, 378);
            this.Edit_List_btn.Name = "Edit_List_btn";
            this.Edit_List_btn.Size = new System.Drawing.Size(150, 44);
            this.Edit_List_btn.TabIndex = 13;
            this.Edit_List_btn.Text = "Редактировать";
            this.Edit_List_btn.UseVisualStyleBackColor = true;
            this.Edit_List_btn.Click += new System.EventHandler(this.Edit_List_btn_Click);
            this.Edit_List_btn.MouseEnter += new System.EventHandler(this.Edit_List_btn_MouseEnter);
            this.Edit_List_btn.MouseLeave += new System.EventHandler(this.Edit_List_btn_MouseLeave);
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(511, 185);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(50, 20);
            this.ID_txt.TabIndex = 14;
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Location = new System.Drawing.Point(487, 188);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(18, 13);
            this.ID_lbl.TabIndex = 15;
            this.ID_lbl.Text = "ID";
            // 
            // Make2_txt
            // 
            this.Make2_txt.Location = new System.Drawing.Point(511, 219);
            this.Make2_txt.Name = "Make2_txt";
            this.Make2_txt.Size = new System.Drawing.Size(193, 20);
            this.Make2_txt.TabIndex = 16;
            // 
            // Model2_txt
            // 
            this.Model2_txt.Location = new System.Drawing.Point(511, 253);
            this.Model2_txt.Name = "Model2_txt";
            this.Model2_txt.Size = new System.Drawing.Size(193, 20);
            this.Model2_txt.TabIndex = 17;
            // 
            // Year2_txt
            // 
            this.Year2_txt.Location = new System.Drawing.Point(511, 289);
            this.Year2_txt.Name = "Year2_txt";
            this.Year2_txt.Size = new System.Drawing.Size(193, 20);
            this.Year2_txt.TabIndex = 18;
            // 
            // Price2_txt
            // 
            this.Price2_txt.Location = new System.Drawing.Point(511, 327);
            this.Price2_txt.Name = "Price2_txt";
            this.Price2_txt.Size = new System.Drawing.Size(193, 20);
            this.Price2_txt.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Год";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Цена";
            // 
            // Del_btn
            // 
            this.Del_btn.FlatAppearance.BorderSize = 0;
            this.Del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_btn.Location = new System.Drawing.Point(642, 376);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(75, 49);
            this.Del_btn.TabIndex = 24;
            this.Del_btn.Text = "Удалить";
            this.Del_btn.UseVisualStyleBackColor = true;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            this.Del_btn.MouseEnter += new System.EventHandler(this.Del_btn_MouseEnter);
            this.Del_btn.MouseLeave += new System.EventHandler(this.Del_btn_MouseLeave);
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(804, 191);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(153, 20);
            this.Search_txt.TabIndex = 25;
            // 
            // Search
            // 
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(877, 225);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(89, 30);
            this.Search.TabIndex = 26;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Developer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 544);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.Del_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price2_txt);
            this.Controls.Add(this.Year2_txt);
            this.Controls.Add(this.Model2_txt);
            this.Controls.Add(this.Make2_txt);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.Edit_List_btn);
            this.Controls.Add(this.dataGridViewCar);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.Yaer_lbl);
            this.Controls.Add(this.Model_lbl);
            this.Controls.Add(this.Make_lbl);
            this.Controls.Add(this.Pic_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.Make_txt);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.Year_txt);
            this.Controls.Add(this.Model_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Developer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Developer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Model_txt;
        private System.Windows.Forms.TextBox Year_txt;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.TextBox Make_txt;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button Pic_btn;
        private System.Windows.Forms.Label Make_lbl;
        private System.Windows.Forms.Label Model_lbl;
        private System.Windows.Forms.Label Yaer_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.Button Edit_List_btn;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.TextBox Make2_txt;
        private System.Windows.Forms.TextBox Model2_txt;
        private System.Windows.Forms.TextBox Year2_txt;
        private System.Windows.Forms.TextBox Price2_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Button Search;
    }
}