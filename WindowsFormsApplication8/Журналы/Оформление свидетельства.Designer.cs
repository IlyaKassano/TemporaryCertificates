namespace TemporaryCertificates
{
    partial class Оформление_сертификата
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Оформление_сертификата));
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.DateStart = new System.Windows.Forms.DateTimePicker();
			this.DateEnd = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.KodSert = new System.Windows.Forms.TextBox();
			this.AddRepres = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.RepresCombo = new System.Windows.Forms.ComboBox();
			this.OfficeCombo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.AddOffice = new System.Windows.Forms.Button();
			this.ClientCombo = new System.Windows.Forms.ComboBox();
			this.AddClient = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.Print = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 13);
			this.label3.TabIndex = 62;
			this.label3.Text = "Дата начала дейст.:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 192);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 61;
			this.label1.Text = "Представитель:";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(220, 285);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(168, 40);
			this.SaveButton.TabIndex = 74;
			this.SaveButton.Text = "Сохранить оформление ВС";
			this.toolTip1.SetToolTip(this.SaveButton, "Сохранить оформление временного свидетельства");
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// DateStart
			// 
			this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateStart.Location = new System.Drawing.Point(169, 69);
			this.DateStart.Name = "DateStart";
			this.DateStart.Size = new System.Drawing.Size(129, 20);
			this.DateStart.TabIndex = 79;
			this.DateStart.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// DateEnd
			// 
			this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateEnd.Location = new System.Drawing.Point(169, 111);
			this.DateEnd.Name = "DateEnd";
			this.DateEnd.Size = new System.Drawing.Size(129, 20);
			this.DateEnd.TabIndex = 82;
			this.DateEnd.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 13);
			this.label2.TabIndex = 81;
			this.label2.Text = "Дата окончания дейст.:";
			// 
			// KodSert
			// 
			this.KodSert.Location = new System.Drawing.Point(169, 26);
			this.KodSert.Name = "KodSert";
			this.KodSert.Size = new System.Drawing.Size(129, 20);
			this.KodSert.TabIndex = 83;
			// 
			// AddRepres
			// 
			this.AddRepres.Location = new System.Drawing.Point(448, 192);
			this.AddRepres.MaximumSize = new System.Drawing.Size(152, 50);
			this.AddRepres.Name = "AddRepres";
			this.AddRepres.Size = new System.Drawing.Size(152, 23);
			this.AddRepres.TabIndex = 112;
			this.AddRepres.Text = "Добавить представителя";
			this.AddRepres.UseVisualStyleBackColor = true;
			this.AddRepres.Click += new System.EventHandler(this.AddRepres_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(14, 234);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 110;
			this.label10.Text = "Офис:";
			// 
			// RepresCombo
			// 
			this.RepresCombo.FormattingEnabled = true;
			this.RepresCombo.Location = new System.Drawing.Point(169, 192);
			this.RepresCombo.Name = "RepresCombo";
			this.RepresCombo.Size = new System.Drawing.Size(273, 21);
			this.RepresCombo.TabIndex = 113;
			this.RepresCombo.SelectedIndexChanged += new System.EventHandler(this.RepresCombo_SelectedIndexChanged);
			// 
			// OfficeCombo
			// 
			this.OfficeCombo.FormattingEnabled = true;
			this.OfficeCombo.Location = new System.Drawing.Point(169, 234);
			this.OfficeCombo.Name = "OfficeCombo";
			this.OfficeCombo.Size = new System.Drawing.Size(273, 21);
			this.OfficeCombo.TabIndex = 117;
			this.toolTip1.SetToolTip(this.OfficeCombo, "Адрес");
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 13);
			this.label6.TabIndex = 118;
			this.label6.Text = "Номер свидетельства:";
			// 
			// AddOffice
			// 
			this.AddOffice.Location = new System.Drawing.Point(448, 234);
			this.AddOffice.MaximumSize = new System.Drawing.Size(152, 50);
			this.AddOffice.Name = "AddOffice";
			this.AddOffice.Size = new System.Drawing.Size(152, 23);
			this.AddOffice.TabIndex = 120;
			this.AddOffice.Text = "Добавить офис";
			this.AddOffice.UseVisualStyleBackColor = true;
			this.AddOffice.Click += new System.EventHandler(this.AddOffice_Click);
			// 
			// ClientCombo
			// 
			this.ClientCombo.FormattingEnabled = true;
			this.ClientCombo.Location = new System.Drawing.Point(169, 151);
			this.ClientCombo.Name = "ClientCombo";
			this.ClientCombo.Size = new System.Drawing.Size(273, 21);
			this.ClientCombo.TabIndex = 123;
			// 
			// AddClient
			// 
			this.AddClient.Location = new System.Drawing.Point(448, 151);
			this.AddClient.MaximumSize = new System.Drawing.Size(152, 50);
			this.AddClient.Name = "AddClient";
			this.AddClient.Size = new System.Drawing.Size(152, 23);
			this.AddClient.TabIndex = 122;
			this.AddClient.Text = "Добавить клиента";
			this.AddClient.UseVisualStyleBackColor = true;
			this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(14, 151);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 121;
			this.label7.Text = "Клиент:";
			// 
			// Print
			// 
			this.Print.Location = new System.Drawing.Point(533, 285);
			this.Print.Name = "Print";
			this.Print.Size = new System.Drawing.Size(67, 40);
			this.Print.TabIndex = 124;
			this.Print.Text = "Печать";
			this.Print.UseVisualStyleBackColor = true;
			this.Print.Click += new System.EventHandler(this.Print_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(328, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 13);
			this.label4.TabIndex = 125;
			this.label4.Text = "Действителен:";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(427, 113);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(15, 14);
			this.checkBox1.TabIndex = 126;
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// Оформление_сертификата
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(612, 336);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Print);
			this.Controls.Add(this.ClientCombo);
			this.Controls.Add(this.AddClient);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.AddOffice);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.OfficeCombo);
			this.Controls.Add(this.RepresCombo);
			this.Controls.Add(this.AddRepres);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.KodSert);
			this.Controls.Add(this.DateEnd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DateStart);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Оформление_сертификата";
			this.Text = "Оформление временного свидетельства";
			this.Activated += new System.EventHandler(this.Оформление_сертификата_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Оформление_сертификата_FormClosed);
			this.Load += new System.EventHandler(this.Оформление_сертификата_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KodSert;
        private System.Windows.Forms.Button AddRepres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox RepresCombo;
        private System.Windows.Forms.ComboBox OfficeCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddOffice;
		private System.Windows.Forms.ComboBox ClientCombo;
		private System.Windows.Forms.Button AddClient;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button Print;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}