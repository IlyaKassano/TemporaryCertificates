namespace WindowsFormsApplication5
{
    partial class Поиск
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Поиск));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton9 = new System.Windows.Forms.RadioButton();
			this.radioButton10 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 237);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(832, 275);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(706, 170);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 43);
			this.button1.TabIndex = 15;
			this.button1.Text = "Печать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.Checked = true;
			this.radioButton8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.radioButton8.Location = new System.Drawing.Point(7, 29);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(90, 17);
			this.radioButton8.TabIndex = 25;
			this.radioButton8.TabStop = true;
			this.radioButton8.Text = "Все клиенты";
			this.radioButton8.UseVisualStyleBackColor = true;
			this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
			// 
			// radioButton9
			// 
			this.radioButton9.AutoSize = true;
			this.radioButton9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.radioButton9.Location = new System.Drawing.Point(7, 75);
			this.radioButton9.Name = "radioButton9";
			this.radioButton9.Size = new System.Drawing.Size(81, 17);
			this.radioButton9.TabIndex = 26;
			this.radioButton9.Text = "Все офисы";
			this.radioButton9.UseVisualStyleBackColor = true;
			this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
			// 
			// radioButton10
			// 
			this.radioButton10.AutoSize = true;
			this.radioButton10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.radioButton10.Location = new System.Drawing.Point(7, 52);
			this.radioButton10.Name = "radioButton10";
			this.radioButton10.Size = new System.Drawing.Size(123, 17);
			this.radioButton10.TabIndex = 27;
			this.radioButton10.Text = "Все представители";
			this.radioButton10.UseVisualStyleBackColor = true;
			this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.ForeColor = System.Drawing.Color.Black;
			this.radioButton1.Location = new System.Drawing.Point(130, 40);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(158, 17);
			this.radioButton1.TabIndex = 28;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "            Поиск клиентов по";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Click += new System.EventHandler(this.radioButton1_CheckedChanged_1);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(301, 38);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(133, 21);
			this.comboBox1.TabIndex = 29;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(341, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 30;
			this.label1.Text = "Поле";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.dateTimePicker5);
			this.groupBox1.Controls.Add(this.dateTimePicker6);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.comboBox6);
			this.groupBox1.Controls.Add(this.comboBox7);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.dateTimePicker3);
			this.groupBox1.Controls.Add(this.dateTimePicker4);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.comboBox4);
			this.groupBox1.Controls.Add(this.comboBox5);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.dateTimePicker2);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.radioButton10);
			this.groupBox1.Controls.Add(this.radioButton9);
			this.groupBox1.Controls.Add(this.radioButton8);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(8, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(832, 219);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Запросы к данным";
			// 
			// button3
			// 
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(4, 121);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 43);
			this.button3.TabIndex = 124;
			this.button3.Text = "Параметры поиска";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(4, 170);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 43);
			this.button2.TabIndex = 121;
			this.button2.Text = "Редактировать";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = global::WindowsFormsApplication5.Properties.Resources.Makc_m;
			this.pictureBox1.Location = new System.Drawing.Point(706, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 70);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 120;
			this.pictureBox1.TabStop = false;
			// 
			// dateTimePicker5
			// 
			this.dateTimePicker5.Location = new System.Drawing.Point(162, 183);
			this.dateTimePicker5.Name = "dateTimePicker5";
			this.dateTimePicker5.Size = new System.Drawing.Size(133, 20);
			this.dateTimePicker5.TabIndex = 48;
			this.dateTimePicker5.Visible = false;
			this.dateTimePicker5.CloseUp += new System.EventHandler(this.radioButton3_Click);
			// 
			// dateTimePicker6
			// 
			this.dateTimePicker6.Location = new System.Drawing.Point(301, 182);
			this.dateTimePicker6.Name = "dateTimePicker6";
			this.dateTimePicker6.Size = new System.Drawing.Size(133, 20);
			this.dateTimePicker6.TabIndex = 47;
			this.dateTimePicker6.Visible = false;
			this.dateTimePicker6.CloseUp += new System.EventHandler(this.radioButton3_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(440, 157);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(260, 20);
			this.textBox3.TabIndex = 46;
			this.textBox3.TextChanged += new System.EventHandler(this.radioButton3_Click);
			// 
			// comboBox6
			// 
			this.comboBox6.FormattingEnabled = true;
			this.comboBox6.Location = new System.Drawing.Point(440, 182);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(260, 21);
			this.comboBox6.TabIndex = 45;
			this.comboBox6.Visible = false;
			this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.radioButton3_Click);
			// 
			// comboBox7
			// 
			this.comboBox7.FormattingEnabled = true;
			this.comboBox7.Location = new System.Drawing.Point(301, 156);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(133, 21);
			this.comboBox7.TabIndex = 44;
			this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.ForeColor = System.Drawing.Color.Black;
			this.radioButton3.Location = new System.Drawing.Point(130, 158);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(155, 17);
			this.radioButton3.TabIndex = 43;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "              Поиск офисов по";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.Location = new System.Drawing.Point(162, 125);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(133, 20);
			this.dateTimePicker3.TabIndex = 42;
			this.dateTimePicker3.Visible = false;
			this.dateTimePicker3.CloseUp += new System.EventHandler(this.radioButton2_Click);
			// 
			// dateTimePicker4
			// 
			this.dateTimePicker4.Location = new System.Drawing.Point(301, 125);
			this.dateTimePicker4.Name = "dateTimePicker4";
			this.dateTimePicker4.Size = new System.Drawing.Size(133, 20);
			this.dateTimePicker4.TabIndex = 41;
			this.dateTimePicker4.Visible = false;
			this.dateTimePicker4.CloseUp += new System.EventHandler(this.radioButton2_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(440, 99);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(260, 20);
			this.textBox2.TabIndex = 40;
			this.textBox2.TextChanged += new System.EventHandler(this.radioButton2_Click);
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(440, 125);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(260, 21);
			this.comboBox4.TabIndex = 39;
			this.comboBox4.Visible = false;
			this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.radioButton2_Click);
			// 
			// comboBox5
			// 
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(301, 99);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(133, 21);
			this.comboBox5.TabIndex = 38;
			this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.ForeColor = System.Drawing.Color.Black;
			this.radioButton2.Location = new System.Drawing.Point(130, 99);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(157, 17);
			this.radioButton2.TabIndex = 37;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Поиск представителей по";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(301, 65);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(133, 20);
			this.dateTimePicker2.TabIndex = 35;
			this.dateTimePicker2.Visible = false;
			this.dateTimePicker2.CloseUp += new System.EventHandler(this.radioButton1_CheckedChanged_1);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(162, 65);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
			this.dateTimePicker1.TabIndex = 34;
			this.dateTimePicker1.Visible = false;
			this.dateTimePicker1.CloseUp += new System.EventHandler(this.radioButton1_CheckedChanged_1);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(440, 38);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 20);
			this.textBox1.TabIndex = 33;
			this.textBox1.TextChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(440, 64);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(260, 21);
			this.comboBox2.TabIndex = 32;
			this.comboBox2.Visible = false;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.label2.Location = new System.Drawing.Point(460, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 31;
			this.label2.Text = "Значения";
			// 
			// Поиск
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(856, 527);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(872, 720);
			this.Name = "Поиск";
			this.Text = "Поиск";
			this.Activated += new System.EventHandler(this.Поиск_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Поиск_FormClosed);
			this.Load += new System.EventHandler(this.Поиск_Load);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Поиск_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.RadioButton radioButton10;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker5;
		private System.Windows.Forms.DateTimePicker dateTimePicker6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ComboBox comboBox6;
		private System.Windows.Forms.ComboBox comboBox7;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.DateTimePicker dateTimePicker4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
	}
}