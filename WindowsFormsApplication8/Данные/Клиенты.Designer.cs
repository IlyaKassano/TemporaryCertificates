namespace TemporaryCertificates
{
	partial class Клиенты
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Клиенты));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.LastRecord = new System.Windows.Forms.Button();
			this.NextRecord = new System.Windows.Forms.Button();
			this.PrevRecord = new System.Windows.Forms.Button();
			this.FirstRecord = new System.Windows.Forms.Button();
			this.KodDoc = new System.Windows.Forms.TextBox();
			this.SeriaNomer = new System.Windows.Forms.MaskedTextBox();
			this.SecondName = new System.Windows.Forms.TextBox();
			this.Address = new System.Windows.Forms.TextBox();
			this.Snils = new System.Windows.Forms.TextBox();
			this.SaveRecord = new System.Windows.Forms.Button();
			this.DeleteRecord = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.Gender = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.DateBirth = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.DateIssue = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.IssuedBy = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.DateEnd = new System.Windows.Forms.DateTimePicker();
			this.label16 = new System.Windows.Forms.Label();
			this.DocName = new System.Windows.Forms.ComboBox();
			this.PlaceBirth = new System.Windows.Forms.TextBox();
			this.LastName = new System.Windows.Forms.TextBox();
			this.FirstName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.KodClient = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.Telephone = new System.Windows.Forms.MaskedTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.statusStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 576);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(714, 22);
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
			this.LastRecord.Location = new System.Drawing.Point(379, 502);
			this.LastRecord.Name = "LastRecord";
			this.LastRecord.Size = new System.Drawing.Size(29, 23);
			this.LastRecord.TabIndex = 79;
			this.LastRecord.Text = ">>";
			this.toolTip1.SetToolTip(this.LastRecord, "В конец");
			this.LastRecord.UseVisualStyleBackColor = false;
			this.LastRecord.Click += new System.EventHandler(this.LastRecord_Click);
			// 
			// NextRecord
			// 
			this.NextRecord.AutoSize = true;
			this.NextRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.NextRecord.Location = new System.Drawing.Point(348, 502);
			this.NextRecord.Name = "NextRecord";
			this.NextRecord.Size = new System.Drawing.Size(23, 23);
			this.NextRecord.TabIndex = 78;
			this.NextRecord.Text = ">";
			this.toolTip1.SetToolTip(this.NextRecord, "Вперед");
			this.NextRecord.UseVisualStyleBackColor = false;
			this.NextRecord.Click += new System.EventHandler(this.NextRecord_Click);
			// 
			// PrevRecord
			// 
			this.PrevRecord.AutoSize = true;
			this.PrevRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.PrevRecord.Location = new System.Drawing.Point(317, 502);
			this.PrevRecord.Name = "PrevRecord";
			this.PrevRecord.Size = new System.Drawing.Size(23, 23);
			this.PrevRecord.TabIndex = 76;
			this.PrevRecord.Text = "<";
			this.toolTip1.SetToolTip(this.PrevRecord, "Назад");
			this.PrevRecord.UseVisualStyleBackColor = false;
			this.PrevRecord.Click += new System.EventHandler(this.PrevRecord_Click);
			// 
			// FirstRecord
			// 
			this.FirstRecord.AutoSize = true;
			this.FirstRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.FirstRecord.Location = new System.Drawing.Point(282, 502);
			this.FirstRecord.Name = "FirstRecord";
			this.FirstRecord.Size = new System.Drawing.Size(29, 23);
			this.FirstRecord.TabIndex = 75;
			this.FirstRecord.Text = "<<";
			this.toolTip1.SetToolTip(this.FirstRecord, "В начало");
			this.FirstRecord.UseVisualStyleBackColor = false;
			this.FirstRecord.Click += new System.EventHandler(this.FirstRecord_Click);
			// 
			// KodDoc
			// 
			this.KodDoc.Location = new System.Drawing.Point(155, 34);
			this.KodDoc.Name = "KodDoc";
			this.KodDoc.ReadOnly = true;
			this.KodDoc.Size = new System.Drawing.Size(52, 20);
			this.KodDoc.TabIndex = 146;
			this.toolTip1.SetToolTip(this.KodDoc, "Заполняется автоматически");
			// 
			// SeriaNomer
			// 
			this.SeriaNomer.Location = new System.Drawing.Point(155, 106);
			this.SeriaNomer.Mask = "00 00 № 00000";
			this.SeriaNomer.Name = "SeriaNomer";
			this.SeriaNomer.Size = new System.Drawing.Size(144, 20);
			this.SeriaNomer.TabIndex = 119;
			this.toolTip1.SetToolTip(this.SeriaNomer, "Документы имеют разный тип серии и номера");
			// 
			// SecondName
			// 
			this.SecondName.Location = new System.Drawing.Point(136, 131);
			this.SecondName.Name = "SecondName";
			this.SecondName.Size = new System.Drawing.Size(248, 20);
			this.SecondName.TabIndex = 110;
			this.toolTip1.SetToolTip(this.SecondName, "Отчество может отсутствовать");
			// 
			// Address
			// 
			this.Address.Location = new System.Drawing.Point(469, 169);
			this.Address.Name = "Address";
			this.Address.Size = new System.Drawing.Size(201, 20);
			this.Address.TabIndex = 115;
			this.toolTip1.SetToolTip(this.Address, "Адрес проживания");
			// 
			// Snils
			// 
			this.Snils.Location = new System.Drawing.Point(137, 169);
			this.Snils.MaxLength = 11;
			this.Snils.Name = "Snils";
			this.Snils.Size = new System.Drawing.Size(247, 20);
			this.Snils.TabIndex = 117;
			this.toolTip1.SetToolTip(this.Snils, "Страховой номер индивидуального лицевого счёта");
			// 
			// SaveRecord
			// 
			this.SaveRecord.AutoSize = true;
			this.SaveRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.SaveRecord.Location = new System.Drawing.Point(186, 540);
			this.SaveRecord.MaximumSize = new System.Drawing.Size(154, 50);
			this.SaveRecord.Name = "SaveRecord";
			this.SaveRecord.Size = new System.Drawing.Size(154, 23);
			this.SaveRecord.TabIndex = 80;
			this.SaveRecord.Text = "Сохранить данные";
			this.SaveRecord.UseVisualStyleBackColor = false;
			this.SaveRecord.Click += new System.EventHandler(this.SaveRecord_Click);
			// 
			// DeleteRecord
			// 
			this.DeleteRecord.AutoSize = true;
			this.DeleteRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.DeleteRecord.Location = new System.Drawing.Point(346, 540);
			this.DeleteRecord.MaximumSize = new System.Drawing.Size(154, 50);
			this.DeleteRecord.Name = "DeleteRecord";
			this.DeleteRecord.Size = new System.Drawing.Size(154, 23);
			this.DeleteRecord.TabIndex = 77;
			this.DeleteRecord.Text = "Удалить данные";
			this.DeleteRecord.UseVisualStyleBackColor = false;
			this.DeleteRecord.Click += new System.EventHandler(this.Delete_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(393, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 86;
			this.label5.Text = "Пол:";
			// 
			// Gender
			// 
			this.Gender.FormattingEnabled = true;
			this.Gender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.Gender.Location = new System.Drawing.Point(556, 33);
			this.Gender.Name = "Gender";
			this.Gender.Size = new System.Drawing.Size(114, 21);
			this.Gender.TabIndex = 111;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(390, 109);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(76, 13);
			this.label12.TabIndex = 133;
			this.label12.Text = "Дата выдачи:";
			// 
			// DateBirth
			// 
			this.DateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateBirth.Location = new System.Drawing.Point(155, 142);
			this.DateBirth.Name = "DateBirth";
			this.DateBirth.Size = new System.Drawing.Size(144, 20);
			this.DateBirth.TabIndex = 134;
			this.DateBirth.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(17, 109);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 13);
			this.label11.TabIndex = 135;
			this.label11.Text = "Серия и номер:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(17, 179);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 13);
			this.label9.TabIndex = 138;
			this.label9.Text = "Выдан:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(17, 144);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 13);
			this.label8.TabIndex = 139;
			this.label8.Text = "Дата рождения:";
			// 
			// DateIssue
			// 
			this.DateIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateIssue.Location = new System.Drawing.Point(556, 108);
			this.DateIssue.Name = "DateIssue";
			this.DateIssue.Size = new System.Drawing.Size(114, 20);
			this.DateIssue.TabIndex = 140;
			this.DateIssue.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(17, 216);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 13);
			this.label7.TabIndex = 141;
			this.label7.Text = "Место рождения:";
			// 
			// IssuedBy
			// 
			this.IssuedBy.Location = new System.Drawing.Point(155, 176);
			this.IssuedBy.Name = "IssuedBy";
			this.IssuedBy.Size = new System.Drawing.Size(515, 20);
			this.IssuedBy.TabIndex = 143;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(17, 37);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(86, 13);
			this.label13.TabIndex = 145;
			this.label13.Text = "Код документа:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(17, 73);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(117, 13);
			this.label14.TabIndex = 147;
			this.label14.Text = "Название документа:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.SeriaNomer);
			this.groupBox2.Controls.Add(this.DateEnd);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.DocName);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.KodDoc);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.PlaceBirth);
			this.groupBox2.Controls.Add(this.IssuedBy);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.DateIssue);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.Gender);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.DateBirth);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.groupBox2.Location = new System.Drawing.Point(12, 242);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(685, 254);
			this.groupBox2.TabIndex = 115;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Документ, удостоверяющий личность";
			// 
			// DateEnd
			// 
			this.DateEnd.Enabled = false;
			this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateEnd.Location = new System.Drawing.Point(556, 143);
			this.DateEnd.Name = "DateEnd";
			this.DateEnd.Size = new System.Drawing.Size(114, 20);
			this.DateEnd.TabIndex = 149;
			this.DateEnd.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.ForeColor = System.Drawing.Color.Black;
			this.label16.Location = new System.Drawing.Point(390, 144);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(106, 13);
			this.label16.TabIndex = 148;
			this.label16.Text = "Дата оконч. дейст.:";
			// 
			// DocName
			// 
			this.DocName.FormattingEnabled = true;
			this.DocName.Items.AddRange(new object[] {
            "Паспорт",
            "Свидетельство о рождении",
            "Паспорт гражданина СССР",
            "Временное удостоверение личности гражданина",
            "Удостоверение беженца",
            "Свидетельство о рассмотрении ходатайства о признании беженцем по существу",
            "Свидетельство о предоставлении временного убежища",
            "Копия жалобы о лишении статуса беженца",
            "Паспорт иностранного гражданина",
            "Документ иностранного гражданина",
            "Вид на жительство",
            "Документ лица без гражданства",
            "Удостоверение сотрудника Евразийской экономической комиссии"});
			this.DocName.Location = new System.Drawing.Point(155, 70);
			this.DocName.Name = "DocName";
			this.DocName.Size = new System.Drawing.Size(515, 21);
			this.DocName.TabIndex = 114;
			this.DocName.SelectedIndexChanged += new System.EventHandler(this.DocName_SelectedIndexChanged);
			// 
			// PlaceBirth
			// 
			this.PlaceBirth.Location = new System.Drawing.Point(155, 213);
			this.PlaceBirth.Name = "PlaceBirth";
			this.PlaceBirth.Size = new System.Drawing.Size(515, 20);
			this.PlaceBirth.TabIndex = 144;
			// 
			// LastName
			// 
			this.LastName.Location = new System.Drawing.Point(136, 54);
			this.LastName.Name = "LastName";
			this.LastName.Size = new System.Drawing.Size(248, 20);
			this.LastName.TabIndex = 108;
			// 
			// FirstName
			// 
			this.FirstName.Location = new System.Drawing.Point(136, 94);
			this.FirstName.Name = "FirstName";
			this.FirstName.Size = new System.Drawing.Size(248, 20);
			this.FirstName.TabIndex = 109;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(18, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 84;
			this.label4.Text = "Отчество:";
			// 
			// KodClient
			// 
			this.KodClient.Location = new System.Drawing.Point(137, 18);
			this.KodClient.Name = "KodClient";
			this.KodClient.Size = new System.Drawing.Size(100, 20);
			this.KodClient.TabIndex = 83;
			this.KodClient.TextChanged += new System.EventHandler(this.KodClient_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(18, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Имя:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(390, 134);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 112;
			this.label6.Text = "Телефон:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(18, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Фамилия:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(18, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Код клиента: ";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(393, 172);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(41, 13);
			this.label15.TabIndex = 114;
			this.label15.Text = "Адрес:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(18, 172);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 13);
			this.label10.TabIndex = 116;
			this.label10.Text = "СНИЛС:";
			// 
			// Telephone
			// 
			this.Telephone.Location = new System.Drawing.Point(469, 131);
			this.Telephone.Mask = "+7 (000) 000-00-00";
			this.Telephone.Name = "Telephone";
			this.Telephone.Size = new System.Drawing.Size(201, 20);
			this.Telephone.TabIndex = 118;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.Telephone);
			this.groupBox1.Controls.Add(this.Snils);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.Address);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.KodClient);
			this.groupBox1.Controls.Add(this.SecondName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.FirstName);
			this.groupBox1.Controls.Add(this.LastName);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 224);
			this.groupBox1.TabIndex = 114;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Клиент";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TemporaryCertificates.Properties.Resources.Makc_m;
			this.pictureBox1.Location = new System.Drawing.Point(560, 18);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(110, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 121;
			this.pictureBox1.TabStop = false;
			// 
			// Клиенты
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(714, 598);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.SaveRecord);
			this.Controls.Add(this.LastRecord);
			this.Controls.Add(this.NextRecord);
			this.Controls.Add(this.DeleteRecord);
			this.Controls.Add(this.PrevRecord);
			this.Controls.Add(this.FirstRecord);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Клиенты";
			this.Text = "Клиенты";
			this.Load += new System.EventHandler(this.Клиенты_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Button SaveRecord;
		private System.Windows.Forms.Button LastRecord;
		private System.Windows.Forms.Button NextRecord;
		private System.Windows.Forms.Button DeleteRecord;
		private System.Windows.Forms.Button PrevRecord;
		private System.Windows.Forms.Button FirstRecord;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox Gender;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker DateBirth;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker DateIssue;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox IssuedBy;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox KodDoc;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox DocName;
		private System.Windows.Forms.TextBox PlaceBirth;
		private System.Windows.Forms.DateTimePicker DateEnd;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.MaskedTextBox SeriaNomer;
		private System.Windows.Forms.TextBox LastName;
		private System.Windows.Forms.TextBox FirstName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox SecondName;
		private System.Windows.Forms.TextBox KodClient;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox Address;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox Snils;
		private System.Windows.Forms.MaskedTextBox Telephone;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}