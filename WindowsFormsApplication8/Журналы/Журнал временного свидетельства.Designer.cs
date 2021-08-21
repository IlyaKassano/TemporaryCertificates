namespace WindowsFormsApplication5
{
    partial class Журнал_временного_сертификата
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Журнал_временного_сертификата));
			this.DeleteButton = new System.Windows.Forms.Button();
			this.CreateButton = new System.Windows.Forms.Button();
			this.DataRecords = new System.Windows.Forms.DataGridView();
			this.EditButton = new System.Windows.Forms.Button();
			this.PrintButton = new System.Windows.Forms.Button();
			this.ValidRadio = new System.Windows.Forms.RadioButton();
			this.NotValidRadio = new System.Windows.Forms.RadioButton();
			this.ExactDateRadio = new System.Windows.Forms.RadioButton();
			this.RangeDateRadio = new System.Windows.Forms.RadioButton();
			this.ClientRadio = new System.Windows.Forms.RadioButton();
			this.RepresRadio = new System.Windows.Forms.RadioButton();
			this.DatePickerFirst = new System.Windows.Forms.DateTimePicker();
			this.DatePickerSecond = new System.Windows.Forms.DateTimePicker();
			this.ClientCombo = new System.Windows.Forms.ComboBox();
			this.RepresCombo = new System.Windows.Forms.ComboBox();
			this.AllRecords = new System.Windows.Forms.RadioButton();
			this.DateTypeCombo = new System.Windows.Forms.ComboBox();
			this.OfficeCombo = new System.Windows.Forms.ComboBox();
			this.OfficeRadio = new System.Windows.Forms.RadioButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.DataRecords)).BeginInit();
			this.SuspendLayout();
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(517, 315);
			this.DeleteButton.MaximumSize = new System.Drawing.Size(226, 34);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(226, 34);
			this.DeleteButton.TabIndex = 7;
			this.DeleteButton.Text = "Удалить свидетельство";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.button3_Click);
			// 
			// CreateButton
			// 
			this.CreateButton.Location = new System.Drawing.Point(12, 315);
			this.CreateButton.MaximumSize = new System.Drawing.Size(235, 34);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(235, 34);
			this.CreateButton.TabIndex = 5;
			this.CreateButton.Text = "Оформить новое свидетельство";
			this.CreateButton.UseVisualStyleBackColor = true;
			this.CreateButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// DataRecords
			// 
			this.DataRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataRecords.Location = new System.Drawing.Point(11, 91);
			this.DataRecords.Name = "DataRecords";
			this.DataRecords.ReadOnly = true;
			this.DataRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataRecords.Size = new System.Drawing.Size(846, 218);
			this.DataRecords.TabIndex = 4;
			this.DataRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(253, 315);
			this.EditButton.MaximumSize = new System.Drawing.Size(258, 34);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(258, 34);
			this.EditButton.TabIndex = 9;
			this.EditButton.Text = "Редактировать свидетельство";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// PrintButton
			// 
			this.PrintButton.Location = new System.Drawing.Point(749, 315);
			this.PrintButton.MaximumSize = new System.Drawing.Size(108, 34);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.Size = new System.Drawing.Size(108, 34);
			this.PrintButton.TabIndex = 10;
			this.PrintButton.Text = "Печать";
			this.PrintButton.UseVisualStyleBackColor = true;
			this.PrintButton.Click += new System.EventHandler(this.button4_Click);
			// 
			// ValidRadio
			// 
			this.ValidRadio.AutoSize = true;
			this.ValidRadio.Location = new System.Drawing.Point(11, 39);
			this.ValidRadio.Name = "ValidRadio";
			this.ValidRadio.Size = new System.Drawing.Size(129, 17);
			this.ValidRadio.TabIndex = 11;
			this.ValidRadio.Text = "Действительные ВС";
			this.toolTip1.SetToolTip(this.ValidRadio, "Действительные временные свидетельства");
			this.ValidRadio.UseVisualStyleBackColor = true;
			this.ValidRadio.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// NotValidRadio
			// 
			this.NotValidRadio.AutoSize = true;
			this.NotValidRadio.Location = new System.Drawing.Point(11, 64);
			this.NotValidRadio.Name = "NotValidRadio";
			this.NotValidRadio.Size = new System.Drawing.Size(140, 17);
			this.NotValidRadio.TabIndex = 12;
			this.NotValidRadio.Text = "Недействительные ВС";
			this.toolTip1.SetToolTip(this.NotValidRadio, "Недействительные временные свидетельства");
			this.NotValidRadio.UseVisualStyleBackColor = true;
			this.NotValidRadio.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// ExactDateRadio
			// 
			this.ExactDateRadio.AutoSize = true;
			this.ExactDateRadio.Location = new System.Drawing.Point(177, 39);
			this.ExactDateRadio.Name = "ExactDateRadio";
			this.ExactDateRadio.Size = new System.Drawing.Size(115, 17);
			this.ExactDateRadio.TabIndex = 13;
			this.ExactDateRadio.Text = "По конкрет. дате:";
			this.toolTip1.SetToolTip(this.ExactDateRadio, "По конкретной дате");
			this.ExactDateRadio.UseVisualStyleBackColor = true;
			this.ExactDateRadio.Click += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// RangeDateRadio
			// 
			this.RangeDateRadio.AutoSize = true;
			this.RangeDateRadio.Location = new System.Drawing.Point(177, 64);
			this.RangeDateRadio.Name = "RangeDateRadio";
			this.RangeDateRadio.Size = new System.Drawing.Size(118, 17);
			this.RangeDateRadio.TabIndex = 14;
			this.RangeDateRadio.Text = "По диапазону дат:";
			this.RangeDateRadio.UseVisualStyleBackColor = true;
			this.RangeDateRadio.Click += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// ClientRadio
			// 
			this.ClientRadio.AutoSize = true;
			this.ClientRadio.Location = new System.Drawing.Point(506, 13);
			this.ClientRadio.Name = "ClientRadio";
			this.ClientRadio.Size = new System.Drawing.Size(85, 17);
			this.ClientRadio.TabIndex = 15;
			this.ClientRadio.Text = "По клиенту:";
			this.ClientRadio.UseVisualStyleBackColor = true;
			this.ClientRadio.Click += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// RepresRadio
			// 
			this.RepresRadio.AutoSize = true;
			this.RepresRadio.Location = new System.Drawing.Point(506, 39);
			this.RepresRadio.Name = "RepresRadio";
			this.RepresRadio.Size = new System.Drawing.Size(123, 17);
			this.RepresRadio.TabIndex = 16;
			this.RepresRadio.Text = "По представителю:";
			this.RepresRadio.UseVisualStyleBackColor = true;
			this.RepresRadio.Click += new System.EventHandler(this.radioButton6_CheckedChanged);
			// 
			// DatePickerFirst
			// 
			this.DatePickerFirst.Checked = false;
			this.DatePickerFirst.CustomFormat = "dd.MM.YYYY";
			this.DatePickerFirst.Location = new System.Drawing.Point(300, 39);
			this.DatePickerFirst.Name = "DatePickerFirst";
			this.DatePickerFirst.Size = new System.Drawing.Size(200, 20);
			this.DatePickerFirst.TabIndex = 17;
			this.DatePickerFirst.ValueChanged += new System.EventHandler(this.radioButton3_CheckedChangedEvent);
			// 
			// DatePickerSecond
			// 
			this.DatePickerSecond.Checked = false;
			this.DatePickerSecond.Location = new System.Drawing.Point(300, 62);
			this.DatePickerSecond.Name = "DatePickerSecond";
			this.DatePickerSecond.Size = new System.Drawing.Size(200, 20);
			this.DatePickerSecond.TabIndex = 18;
			this.DatePickerSecond.ValueChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// ClientCombo
			// 
			this.ClientCombo.FormattingEnabled = true;
			this.ClientCombo.Location = new System.Drawing.Point(635, 12);
			this.ClientCombo.Name = "ClientCombo";
			this.ClientCombo.Size = new System.Drawing.Size(222, 21);
			this.ClientCombo.TabIndex = 19;
			this.ClientCombo.SelectedIndexChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// RepresCombo
			// 
			this.RepresCombo.FormattingEnabled = true;
			this.RepresCombo.Location = new System.Drawing.Point(635, 36);
			this.RepresCombo.Name = "RepresCombo";
			this.RepresCombo.Size = new System.Drawing.Size(222, 21);
			this.RepresCombo.TabIndex = 20;
			this.RepresCombo.SelectedIndexChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
			// 
			// AllRecords
			// 
			this.AllRecords.AutoSize = true;
			this.AllRecords.Checked = true;
			this.AllRecords.Location = new System.Drawing.Point(11, 13);
			this.AllRecords.Name = "AllRecords";
			this.AllRecords.Size = new System.Drawing.Size(184, 17);
			this.AllRecords.TabIndex = 21;
			this.AllRecords.TabStop = true;
			this.AllRecords.Text = "Все временные свидетельства";
			this.AllRecords.UseVisualStyleBackColor = true;
			this.AllRecords.Click += new System.EventHandler(this.radioButton7_CheckedChanged);
			// 
			// DateTypeCombo
			// 
			this.DateTypeCombo.FormattingEnabled = true;
			this.DateTypeCombo.Items.AddRange(new object[] {
            "По дате начала действия",
            "По дате окончания действия"});
			this.DateTypeCombo.Location = new System.Drawing.Point(300, 15);
			this.DateTypeCombo.Name = "DateTypeCombo";
			this.DateTypeCombo.Size = new System.Drawing.Size(200, 21);
			this.DateTypeCombo.TabIndex = 22;
			this.DateTypeCombo.Text = "По дате начала действия";
			this.DateTypeCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// OfficeCombo
			// 
			this.OfficeCombo.FormattingEnabled = true;
			this.OfficeCombo.Location = new System.Drawing.Point(635, 60);
			this.OfficeCombo.Name = "OfficeCombo";
			this.OfficeCombo.Size = new System.Drawing.Size(222, 21);
			this.OfficeCombo.TabIndex = 24;
			this.OfficeCombo.SelectedIndexChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
			// 
			// OfficeRadio
			// 
			this.OfficeRadio.AutoSize = true;
			this.OfficeRadio.Location = new System.Drawing.Point(506, 64);
			this.OfficeRadio.Name = "OfficeRadio";
			this.OfficeRadio.Size = new System.Drawing.Size(76, 17);
			this.OfficeRadio.TabIndex = 23;
			this.OfficeRadio.Text = "По офису:";
			this.OfficeRadio.UseVisualStyleBackColor = true;
			this.OfficeRadio.Click += new System.EventHandler(this.radioButton8_CheckedChanged);
			// 
			// Журнал_временного_сертификата
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(869, 359);
			this.Controls.Add(this.OfficeCombo);
			this.Controls.Add(this.OfficeRadio);
			this.Controls.Add(this.DateTypeCombo);
			this.Controls.Add(this.AllRecords);
			this.Controls.Add(this.RepresCombo);
			this.Controls.Add(this.ClientCombo);
			this.Controls.Add(this.DatePickerSecond);
			this.Controls.Add(this.DatePickerFirst);
			this.Controls.Add(this.RepresRadio);
			this.Controls.Add(this.ClientRadio);
			this.Controls.Add(this.RangeDateRadio);
			this.Controls.Add(this.ExactDateRadio);
			this.Controls.Add(this.NotValidRadio);
			this.Controls.Add(this.ValidRadio);
			this.Controls.Add(this.PrintButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.CreateButton);
			this.Controls.Add(this.DataRecords);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Журнал_временного_сертификата";
			this.Text = "Журнал временного свидетельства";
			this.Activated += new System.EventHandler(this.Журнал_временного_сертификата_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Журнал_временного_сертификата_FormClosed);
			this.Load += new System.EventHandler(this.Журнал_временного_сертификата_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataRecords)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView DataRecords;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button PrintButton;
		private System.Windows.Forms.RadioButton ValidRadio;
		private System.Windows.Forms.RadioButton NotValidRadio;
		private System.Windows.Forms.RadioButton ExactDateRadio;
		private System.Windows.Forms.RadioButton RangeDateRadio;
		private System.Windows.Forms.RadioButton ClientRadio;
		private System.Windows.Forms.RadioButton RepresRadio;
		private System.Windows.Forms.DateTimePicker DatePickerFirst;
		private System.Windows.Forms.DateTimePicker DatePickerSecond;
		private System.Windows.Forms.ComboBox ClientCombo;
		private System.Windows.Forms.ComboBox RepresCombo;
		private System.Windows.Forms.RadioButton AllRecords;
		private System.Windows.Forms.ComboBox DateTypeCombo;
		private System.Windows.Forms.ComboBox OfficeCombo;
		private System.Windows.Forms.RadioButton OfficeRadio;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}