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
			this.LastRecord = new System.Windows.Forms.Button();
			this.NextRecord = new System.Windows.Forms.Button();
			this.PrevRecord = new System.Windows.Forms.Button();
			this.FirstRecord = new System.Windows.Forms.Button();
			this.SecondName = new System.Windows.Forms.TextBox();
			this.Address = new System.Windows.Forms.TextBox();
			this.Office = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SaveRecord = new System.Windows.Forms.Button();
			this.DeleteRecord = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.LastName = new System.Windows.Forms.TextBox();
			this.FirstName = new System.Windows.Forms.TextBox();
			this.Gener = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.KodRep = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Telephone = new System.Windows.Forms.MaskedTextBox();
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
			// LastRecord
			// 
			this.LastRecord.AutoSize = true;
			this.LastRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.LastRecord.Location = new System.Drawing.Point(239, 340);
			this.LastRecord.Name = "LastRecord";
			this.LastRecord.Size = new System.Drawing.Size(29, 23);
			this.LastRecord.TabIndex = 79;
			this.LastRecord.Text = ">>";
			this.toolTip1.SetToolTip(this.LastRecord, "В конец");
			this.LastRecord.UseVisualStyleBackColor = false;
			this.LastRecord.Click += new System.EventHandler(this.button6_Click);
			// 
			// NextRecord
			// 
			this.NextRecord.AutoSize = true;
			this.NextRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.NextRecord.Location = new System.Drawing.Point(208, 340);
			this.NextRecord.Name = "NextRecord";
			this.NextRecord.Size = new System.Drawing.Size(23, 23);
			this.NextRecord.TabIndex = 78;
			this.NextRecord.Text = ">";
			this.toolTip1.SetToolTip(this.NextRecord, "Вперед");
			this.NextRecord.UseVisualStyleBackColor = false;
			this.NextRecord.Click += new System.EventHandler(this.button8_Click);
			// 
			// PrevRecord
			// 
			this.PrevRecord.AutoSize = true;
			this.PrevRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.PrevRecord.Location = new System.Drawing.Point(177, 340);
			this.PrevRecord.Name = "PrevRecord";
			this.PrevRecord.Size = new System.Drawing.Size(23, 23);
			this.PrevRecord.TabIndex = 76;
			this.PrevRecord.Text = "<";
			this.toolTip1.SetToolTip(this.PrevRecord, "Назад");
			this.PrevRecord.UseVisualStyleBackColor = false;
			this.PrevRecord.Click += new System.EventHandler(this.button10_Click);
			// 
			// FirstRecord
			// 
			this.FirstRecord.AutoSize = true;
			this.FirstRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.FirstRecord.Location = new System.Drawing.Point(142, 340);
			this.FirstRecord.Name = "FirstRecord";
			this.FirstRecord.Size = new System.Drawing.Size(29, 23);
			this.FirstRecord.TabIndex = 75;
			this.FirstRecord.Text = "<<";
			this.toolTip1.SetToolTip(this.FirstRecord, "В начало");
			this.FirstRecord.UseVisualStyleBackColor = false;
			this.FirstRecord.Click += new System.EventHandler(this.button11_Click);
			// 
			// SecondName
			// 
			this.SecondName.Location = new System.Drawing.Point(130, 145);
			this.SecondName.Name = "SecondName";
			this.SecondName.Size = new System.Drawing.Size(248, 20);
			this.SecondName.TabIndex = 110;
			this.toolTip1.SetToolTip(this.SecondName, "Отчество может отсутствовать");
			// 
			// Address
			// 
			this.Address.Location = new System.Drawing.Point(130, 257);
			this.Address.Name = "Address";
			this.Address.Size = new System.Drawing.Size(249, 20);
			this.Address.TabIndex = 115;
			this.toolTip1.SetToolTip(this.Address, "Адрес проживания");
			// 
			// Office
			// 
			this.Office.FormattingEnabled = true;
			this.Office.Location = new System.Drawing.Point(130, 294);
			this.Office.Name = "Office";
			this.Office.Size = new System.Drawing.Size(249, 21);
			this.Office.TabIndex = 118;
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
			// SaveRecord
			// 
			this.SaveRecord.AutoSize = true;
			this.SaveRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.SaveRecord.Location = new System.Drawing.Point(46, 378);
			this.SaveRecord.MaximumSize = new System.Drawing.Size(154, 50);
			this.SaveRecord.Name = "SaveRecord";
			this.SaveRecord.Size = new System.Drawing.Size(154, 23);
			this.SaveRecord.TabIndex = 80;
			this.SaveRecord.Text = "Сохранить данные";
			this.SaveRecord.UseVisualStyleBackColor = false;
			this.SaveRecord.Click += new System.EventHandler(this.button7_Click);
			// 
			// DeleteRecord
			// 
			this.DeleteRecord.AutoSize = true;
			this.DeleteRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.DeleteRecord.Location = new System.Drawing.Point(206, 378);
			this.DeleteRecord.MaximumSize = new System.Drawing.Size(154, 50);
			this.DeleteRecord.Name = "DeleteRecord";
			this.DeleteRecord.Size = new System.Drawing.Size(154, 23);
			this.DeleteRecord.TabIndex = 77;
			this.DeleteRecord.Text = "Удалить данные";
			this.DeleteRecord.UseVisualStyleBackColor = false;
			this.DeleteRecord.Click += new System.EventHandler(this.button9_Click);
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
			// LastName
			// 
			this.LastName.Location = new System.Drawing.Point(130, 69);
			this.LastName.Name = "LastName";
			this.LastName.Size = new System.Drawing.Size(248, 20);
			this.LastName.TabIndex = 108;
			// 
			// FirstName
			// 
			this.FirstName.Location = new System.Drawing.Point(130, 108);
			this.FirstName.Name = "FirstName";
			this.FirstName.Size = new System.Drawing.Size(248, 20);
			this.FirstName.TabIndex = 109;
			// 
			// Gener
			// 
			this.Gener.FormattingEnabled = true;
			this.Gener.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.Gener.Location = new System.Drawing.Point(130, 181);
			this.Gener.Name = "Gener";
			this.Gener.Size = new System.Drawing.Size(138, 21);
			this.Gener.TabIndex = 111;
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
			// KodRep
			// 
			this.KodRep.Location = new System.Drawing.Point(130, 31);
			this.KodRep.Name = "KodRep";
			this.KodRep.Size = new System.Drawing.Size(121, 20);
			this.KodRep.TabIndex = 116;
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
			// Telephone
			// 
			this.Telephone.Location = new System.Drawing.Point(130, 219);
			this.Telephone.Mask = "+7 (000) 000-00-00";
			this.Telephone.Name = "Telephone";
			this.Telephone.Size = new System.Drawing.Size(249, 20);
			this.Telephone.TabIndex = 122;
			// 
			// Представители
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(391, 437);
			this.Controls.Add(this.Telephone);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Office);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.KodRep);
			this.Controls.Add(this.Address);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SaveRecord);
			this.Controls.Add(this.LastRecord);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NextRecord);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.DeleteRecord);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PrevRecord);
			this.Controls.Add(this.FirstRecord);
			this.Controls.Add(this.SecondName);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.Gener);
			this.Controls.Add(this.LastName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.FirstName);
			this.Controls.Add(this.label4);
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
		private System.Windows.Forms.Button SaveRecord;
		private System.Windows.Forms.Button LastRecord;
		private System.Windows.Forms.Button NextRecord;
		private System.Windows.Forms.Button DeleteRecord;
		private System.Windows.Forms.Button PrevRecord;
		private System.Windows.Forms.Button FirstRecord;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox LastName;
		private System.Windows.Forms.TextBox FirstName;
		private System.Windows.Forms.TextBox SecondName;
		private System.Windows.Forms.ComboBox Gener;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Address;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox KodRep;
		private System.Windows.Forms.ComboBox Office;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MaskedTextBox Telephone;
	}
}