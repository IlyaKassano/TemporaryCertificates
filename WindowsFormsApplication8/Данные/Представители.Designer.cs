namespace WindowsFormsApplication5
{
	partial class Представители
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Представители));
			this.label1 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.button6 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(12, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Код представителя: ";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 415);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(391, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(295, 17);
			this.toolStripStatusLabel1.Text = "Для добавления записи пролистайте в самый конец";
			// 
			// button6
			// 
			this.button6.AutoSize = true;
			this.button6.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button6.Location = new System.Drawing.Point(239, 340);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(29, 23);
			this.button6.TabIndex = 79;
			this.button6.Text = ">>";
			this.toolTip1.SetToolTip(this.button6, "В конец");
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button8
			// 
			this.button8.AutoSize = true;
			this.button8.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button8.Location = new System.Drawing.Point(208, 340);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(23, 23);
			this.button8.TabIndex = 78;
			this.button8.Text = ">";
			this.toolTip1.SetToolTip(this.button8, "Вперед");
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button10
			// 
			this.button10.AutoSize = true;
			this.button10.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button10.Location = new System.Drawing.Point(177, 340);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(23, 23);
			this.button10.TabIndex = 76;
			this.button10.Text = "<";
			this.toolTip1.SetToolTip(this.button10, "Назад");
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.AutoSize = true;
			this.button11.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button11.Location = new System.Drawing.Point(142, 340);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(29, 23);
			this.button11.TabIndex = 75;
			this.button11.Text = "<<";
			this.toolTip1.SetToolTip(this.button11, "В начало");
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(130, 145);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(248, 20);
			this.textBox4.TabIndex = 110;
			this.toolTip1.SetToolTip(this.textBox4, "Отчество может отсутствовать");
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(130, 257);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(249, 20);
			this.textBox11.TabIndex = 115;
			this.toolTip1.SetToolTip(this.textBox11, "Адрес проживания");
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(130, 294);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(249, 21);
			this.comboBox2.TabIndex = 118;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(12, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Фамилия:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(12, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Имя:";
			// 
			// button7
			// 
			this.button7.AutoSize = true;
			this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button7.Location = new System.Drawing.Point(46, 378);
			this.button7.MaximumSize = new System.Drawing.Size(154, 50);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(154, 23);
			this.button7.TabIndex = 80;
			this.button7.Text = "Сохранить данные";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button9
			// 
			this.button9.AutoSize = true;
			this.button9.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button9.Location = new System.Drawing.Point(206, 378);
			this.button9.MaximumSize = new System.Drawing.Size(154, 50);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(154, 23);
			this.button9.TabIndex = 77;
			this.button9.Text = "Удалить данные";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(12, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 84;
			this.label4.Text = "Отчество:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(12, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 86;
			this.label5.Text = "Пол:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(130, 69);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(248, 20);
			this.textBox2.TabIndex = 108;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(130, 108);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(248, 20);
			this.textBox3.TabIndex = 109;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.comboBox1.Location = new System.Drawing.Point(130, 181);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(138, 21);
			this.comboBox1.TabIndex = 111;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(12, 222);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 112;
			this.label6.Text = "Телефон:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(12, 260);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(41, 13);
			this.label15.TabIndex = 114;
			this.label15.Text = "Адрес:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(130, 31);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 20);
			this.textBox1.TabIndex = 116;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(12, 297);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 117;
			this.label7.Text = "Офис:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WindowsFormsApplication5.Properties.Resources.Makc_m;
			this.pictureBox1.Location = new System.Drawing.Point(269, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(110, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 121;
			this.pictureBox1.TabStop = false;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(130, 219);
			this.maskedTextBox1.Mask = "+7 (000) 000-00-00";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(249, 20);
			this.maskedTextBox1.TabIndex = 122;
			// 
			// Представители
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(391, 437);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Font = null;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(407, 476);
			this.Name = "Представители";
			this.Text = "Представители";
			this.Load += new System.EventHandler(this.Представители_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
	}
}