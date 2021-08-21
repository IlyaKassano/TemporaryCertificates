namespace TemporaryCertificates
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
			this.DataGridView = new System.Windows.Forms.DataGridView();
			this.Print = new System.Windows.Forms.Button();
			this.AllClientRadio = new System.Windows.Forms.RadioButton();
			this.AllOfficeRadio = new System.Windows.Forms.RadioButton();
			this.AllRepRadio = new System.Windows.Forms.RadioButton();
			this.FindClientRadio = new System.Windows.Forms.RadioButton();
			this.ClientField = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SettingFind = new System.Windows.Forms.Button();
			this.EditRecord = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.OfficeDateFirst = new System.Windows.Forms.DateTimePicker();
			this.OfficeDateLast = new System.Windows.Forms.DateTimePicker();
			this.OfficeValue = new System.Windows.Forms.TextBox();
			this.OfficeValueCombo = new System.Windows.Forms.ComboBox();
			this.OfficeField = new System.Windows.Forms.ComboBox();
			this.FindOfficeRadio = new System.Windows.Forms.RadioButton();
			this.RepresDateFirst = new System.Windows.Forms.DateTimePicker();
			this.RepresDateLast = new System.Windows.Forms.DateTimePicker();
			this.RepresValue = new System.Windows.Forms.TextBox();
			this.RepresValueCombo = new System.Windows.Forms.ComboBox();
			this.RepresField = new System.Windows.Forms.ComboBox();
			this.FindRepRadio = new System.Windows.Forms.RadioButton();
			this.DateClientLast = new System.Windows.Forms.DateTimePicker();
			this.DateClientFirst = new System.Windows.Forms.DateTimePicker();
			this.ClientValue = new System.Windows.Forms.TextBox();
			this.ClientValueCombo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// DataGridView
			// 
			this.DataGridView.AllowUserToAddRows = false;
			this.DataGridView.AllowUserToDeleteRows = false;
			this.DataGridView.AllowUserToResizeColumns = false;
			this.DataGridView.AllowUserToResizeRows = false;
			this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView.Location = new System.Drawing.Point(12, 237);
			this.DataGridView.Name = "DataGridView";
			this.DataGridView.ReadOnly = true;
			this.DataGridView.RowHeadersWidth = 62;
			this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView.Size = new System.Drawing.Size(832, 275);
			this.DataGridView.TabIndex = 0;
			this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
			// 
			// Print
			// 
			this.Print.ForeColor = System.Drawing.Color.Black;
			this.Print.Location = new System.Drawing.Point(706, 170);
			this.Print.Name = "Print";
			this.Print.Size = new System.Drawing.Size(120, 43);
			this.Print.TabIndex = 15;
			this.Print.Text = "Печать";
			this.Print.UseVisualStyleBackColor = true;
			this.Print.Click += new System.EventHandler(this.Print_Click);
			// 
			// AllClientRadio
			// 
			this.AllClientRadio.AutoSize = true;
			this.AllClientRadio.Checked = true;
			this.AllClientRadio.ForeColor = System.Drawing.SystemColors.ControlText;
			this.AllClientRadio.Location = new System.Drawing.Point(7, 29);
			this.AllClientRadio.Name = "AllClientRadio";
			this.AllClientRadio.Size = new System.Drawing.Size(90, 17);
			this.AllClientRadio.TabIndex = 25;
			this.AllClientRadio.TabStop = true;
			this.AllClientRadio.Text = "Все клиенты";
			this.AllClientRadio.UseVisualStyleBackColor = true;
			this.AllClientRadio.CheckedChanged += new System.EventHandler(this.AllClientRadio_CheckedChanged);
			// 
			// AllOfficeRadio
			// 
			this.AllOfficeRadio.AutoSize = true;
			this.AllOfficeRadio.ForeColor = System.Drawing.SystemColors.ControlText;
			this.AllOfficeRadio.Location = new System.Drawing.Point(7, 75);
			this.AllOfficeRadio.Name = "AllOfficeRadio";
			this.AllOfficeRadio.Size = new System.Drawing.Size(81, 17);
			this.AllOfficeRadio.TabIndex = 26;
			this.AllOfficeRadio.Text = "Все офисы";
			this.AllOfficeRadio.UseVisualStyleBackColor = true;
			this.AllOfficeRadio.CheckedChanged += new System.EventHandler(this.AllOfficeRadio_CheckedChanged);
			// 
			// AllRepRadio
			// 
			this.AllRepRadio.AutoSize = true;
			this.AllRepRadio.ForeColor = System.Drawing.SystemColors.ControlText;
			this.AllRepRadio.Location = new System.Drawing.Point(7, 52);
			this.AllRepRadio.Name = "AllRepRadio";
			this.AllRepRadio.Size = new System.Drawing.Size(123, 17);
			this.AllRepRadio.TabIndex = 27;
			this.AllRepRadio.Text = "Все представители";
			this.AllRepRadio.UseVisualStyleBackColor = true;
			this.AllRepRadio.CheckedChanged += new System.EventHandler(this.AllRepRadio_CheckedChanged);
			// 
			// FindClientRadio
			// 
			this.FindClientRadio.AutoSize = true;
			this.FindClientRadio.ForeColor = System.Drawing.Color.Black;
			this.FindClientRadio.Location = new System.Drawing.Point(130, 40);
			this.FindClientRadio.Name = "FindClientRadio";
			this.FindClientRadio.Size = new System.Drawing.Size(158, 17);
			this.FindClientRadio.TabIndex = 28;
			this.FindClientRadio.TabStop = true;
			this.FindClientRadio.Text = "            Поиск клиентов по";
			this.FindClientRadio.UseVisualStyleBackColor = true;
			this.FindClientRadio.Click += new System.EventHandler(this.FindClientRadio_CheckedChanged);
			// 
			// ClientField
			// 
			this.ClientField.FormattingEnabled = true;
			this.ClientField.Location = new System.Drawing.Point(301, 38);
			this.ClientField.Name = "ClientField";
			this.ClientField.Size = new System.Drawing.Size(133, 21);
			this.ClientField.TabIndex = 29;
			this.ClientField.SelectedIndexChanged += new System.EventHandler(this.ClientField_SelectedIndexChanged);
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
			this.groupBox1.Controls.Add(this.SettingFind);
			this.groupBox1.Controls.Add(this.EditRecord);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.OfficeDateFirst);
			this.groupBox1.Controls.Add(this.OfficeDateLast);
			this.groupBox1.Controls.Add(this.OfficeValue);
			this.groupBox1.Controls.Add(this.OfficeValueCombo);
			this.groupBox1.Controls.Add(this.OfficeField);
			this.groupBox1.Controls.Add(this.FindOfficeRadio);
			this.groupBox1.Controls.Add(this.RepresDateFirst);
			this.groupBox1.Controls.Add(this.RepresDateLast);
			this.groupBox1.Controls.Add(this.RepresValue);
			this.groupBox1.Controls.Add(this.RepresValueCombo);
			this.groupBox1.Controls.Add(this.RepresField);
			this.groupBox1.Controls.Add(this.FindRepRadio);
			this.groupBox1.Controls.Add(this.DateClientLast);
			this.groupBox1.Controls.Add(this.DateClientFirst);
			this.groupBox1.Controls.Add(this.ClientValue);
			this.groupBox1.Controls.Add(this.ClientValueCombo);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.ClientField);
			this.groupBox1.Controls.Add(this.FindClientRadio);
			this.groupBox1.Controls.Add(this.AllRepRadio);
			this.groupBox1.Controls.Add(this.AllOfficeRadio);
			this.groupBox1.Controls.Add(this.AllClientRadio);
			this.groupBox1.Controls.Add(this.Print);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(8, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(832, 219);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Запросы к данным";
			// 
			// SettingFind
			// 
			this.SettingFind.ForeColor = System.Drawing.Color.Black;
			this.SettingFind.Location = new System.Drawing.Point(4, 121);
			this.SettingFind.Name = "SettingFind";
			this.SettingFind.Size = new System.Drawing.Size(120, 43);
			this.SettingFind.TabIndex = 124;
			this.SettingFind.Text = "Параметры поиска";
			this.SettingFind.UseVisualStyleBackColor = true;
			this.SettingFind.Click += new System.EventHandler(this.SettingFind_Click);
			// 
			// EditRecord
			// 
			this.EditRecord.ForeColor = System.Drawing.Color.Black;
			this.EditRecord.Location = new System.Drawing.Point(4, 170);
			this.EditRecord.Name = "EditRecord";
			this.EditRecord.Size = new System.Drawing.Size(120, 43);
			this.EditRecord.TabIndex = 121;
			this.EditRecord.Text = "Редактировать";
			this.EditRecord.UseVisualStyleBackColor = true;
			this.EditRecord.Click += new System.EventHandler(this.EditField_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = global::TemporaryCertificates.Properties.Resources.Makc_m;
			this.pictureBox1.Location = new System.Drawing.Point(706, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 70);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 120;
			this.pictureBox1.TabStop = false;
			// 
			// OfficeDateFirst
			// 
			this.OfficeDateFirst.Location = new System.Drawing.Point(162, 183);
			this.OfficeDateFirst.Name = "OfficeDateFirst";
			this.OfficeDateFirst.Size = new System.Drawing.Size(133, 20);
			this.OfficeDateFirst.TabIndex = 48;
			this.OfficeDateFirst.Visible = false;
			this.OfficeDateFirst.CloseUp += new System.EventHandler(this.FindOfficeRadio_Click);
			// 
			// OfficeDateLast
			// 
			this.OfficeDateLast.Location = new System.Drawing.Point(301, 182);
			this.OfficeDateLast.Name = "OfficeDateLast";
			this.OfficeDateLast.Size = new System.Drawing.Size(133, 20);
			this.OfficeDateLast.TabIndex = 47;
			this.OfficeDateLast.Visible = false;
			this.OfficeDateLast.CloseUp += new System.EventHandler(this.FindOfficeRadio_Click);
			// 
			// OfficeValue
			// 
			this.OfficeValue.Location = new System.Drawing.Point(440, 157);
			this.OfficeValue.Name = "OfficeValue";
			this.OfficeValue.Size = new System.Drawing.Size(260, 20);
			this.OfficeValue.TabIndex = 46;
			this.OfficeValue.TextChanged += new System.EventHandler(this.FindOfficeRadio_Click);
			// 
			// OfficeValueCombo
			// 
			this.OfficeValueCombo.FormattingEnabled = true;
			this.OfficeValueCombo.Location = new System.Drawing.Point(440, 182);
			this.OfficeValueCombo.Name = "OfficeValueCombo";
			this.OfficeValueCombo.Size = new System.Drawing.Size(260, 21);
			this.OfficeValueCombo.TabIndex = 45;
			this.OfficeValueCombo.Visible = false;
			this.OfficeValueCombo.SelectedIndexChanged += new System.EventHandler(this.FindOfficeRadio_Click);
			// 
			// OfficeField
			// 
			this.OfficeField.FormattingEnabled = true;
			this.OfficeField.Location = new System.Drawing.Point(301, 156);
			this.OfficeField.Name = "OfficeField";
			this.OfficeField.Size = new System.Drawing.Size(133, 21);
			this.OfficeField.TabIndex = 44;
			this.OfficeField.SelectedIndexChanged += new System.EventHandler(this.OfficeField_SelectedIndexChanged);
			// 
			// FindOfficeRadio
			// 
			this.FindOfficeRadio.AutoSize = true;
			this.FindOfficeRadio.ForeColor = System.Drawing.Color.Black;
			this.FindOfficeRadio.Location = new System.Drawing.Point(130, 158);
			this.FindOfficeRadio.Name = "FindOfficeRadio";
			this.FindOfficeRadio.Size = new System.Drawing.Size(155, 17);
			this.FindOfficeRadio.TabIndex = 43;
			this.FindOfficeRadio.TabStop = true;
			this.FindOfficeRadio.Text = "              Поиск офисов по";
			this.FindOfficeRadio.UseVisualStyleBackColor = true;
			this.FindOfficeRadio.Click += new System.EventHandler(this.FindOfficeRadio_Click);
			// 
			// RepresDateFirst
			// 
			this.RepresDateFirst.Location = new System.Drawing.Point(162, 125);
			this.RepresDateFirst.Name = "RepresDateFirst";
			this.RepresDateFirst.Size = new System.Drawing.Size(133, 20);
			this.RepresDateFirst.TabIndex = 42;
			this.RepresDateFirst.Visible = false;
			this.RepresDateFirst.CloseUp += new System.EventHandler(this.FindRepRadio_Click);
			// 
			// RepresDateLast
			// 
			this.RepresDateLast.Location = new System.Drawing.Point(301, 125);
			this.RepresDateLast.Name = "RepresDateLast";
			this.RepresDateLast.Size = new System.Drawing.Size(133, 20);
			this.RepresDateLast.TabIndex = 41;
			this.RepresDateLast.Visible = false;
			this.RepresDateLast.CloseUp += new System.EventHandler(this.FindRepRadio_Click);
			// 
			// RepresValue
			// 
			this.RepresValue.Location = new System.Drawing.Point(440, 99);
			this.RepresValue.Name = "RepresValue";
			this.RepresValue.Size = new System.Drawing.Size(260, 20);
			this.RepresValue.TabIndex = 40;
			this.RepresValue.TextChanged += new System.EventHandler(this.FindRepRadio_Click);
			// 
			// RepresValueCombo
			// 
			this.RepresValueCombo.FormattingEnabled = true;
			this.RepresValueCombo.Location = new System.Drawing.Point(440, 125);
			this.RepresValueCombo.Name = "RepresValueCombo";
			this.RepresValueCombo.Size = new System.Drawing.Size(260, 21);
			this.RepresValueCombo.TabIndex = 39;
			this.RepresValueCombo.Visible = false;
			this.RepresValueCombo.SelectedIndexChanged += new System.EventHandler(this.FindRepRadio_Click);
			// 
			// RepresField
			// 
			this.RepresField.FormattingEnabled = true;
			this.RepresField.Location = new System.Drawing.Point(301, 99);
			this.RepresField.Name = "RepresField";
			this.RepresField.Size = new System.Drawing.Size(133, 21);
			this.RepresField.TabIndex = 38;
			this.RepresField.SelectedIndexChanged += new System.EventHandler(this.RepresField_SelectedIndexChanged);
			// 
			// FindRepRadio
			// 
			this.FindRepRadio.AutoSize = true;
			this.FindRepRadio.ForeColor = System.Drawing.Color.Black;
			this.FindRepRadio.Location = new System.Drawing.Point(130, 99);
			this.FindRepRadio.Name = "FindRepRadio";
			this.FindRepRadio.Size = new System.Drawing.Size(157, 17);
			this.FindRepRadio.TabIndex = 37;
			this.FindRepRadio.TabStop = true;
			this.FindRepRadio.Text = "Поиск представителей по";
			this.FindRepRadio.UseVisualStyleBackColor = true;
			this.FindRepRadio.Click += new System.EventHandler(this.FindRepRadio_Click);
			// 
			// DateClientLast
			// 
			this.DateClientLast.Location = new System.Drawing.Point(301, 65);
			this.DateClientLast.Name = "DateClientLast";
			this.DateClientLast.Size = new System.Drawing.Size(133, 20);
			this.DateClientLast.TabIndex = 35;
			this.DateClientLast.Visible = false;
			this.DateClientLast.CloseUp += new System.EventHandler(this.FindClientRadio_CheckedChanged);
			// 
			// DateClientFirst
			// 
			this.DateClientFirst.Location = new System.Drawing.Point(162, 65);
			this.DateClientFirst.Name = "DateClientFirst";
			this.DateClientFirst.Size = new System.Drawing.Size(133, 20);
			this.DateClientFirst.TabIndex = 34;
			this.DateClientFirst.Visible = false;
			this.DateClientFirst.CloseUp += new System.EventHandler(this.FindClientRadio_CheckedChanged);
			// 
			// ClientValue
			// 
			this.ClientValue.Location = new System.Drawing.Point(440, 38);
			this.ClientValue.Name = "ClientValue";
			this.ClientValue.Size = new System.Drawing.Size(260, 20);
			this.ClientValue.TabIndex = 33;
			this.ClientValue.TextChanged += new System.EventHandler(this.FindClientRadio_CheckedChanged);
			// 
			// ClientValueCombo
			// 
			this.ClientValueCombo.FormattingEnabled = true;
			this.ClientValueCombo.Location = new System.Drawing.Point(440, 64);
			this.ClientValueCombo.Name = "ClientValueCombo";
			this.ClientValueCombo.Size = new System.Drawing.Size(260, 21);
			this.ClientValueCombo.TabIndex = 32;
			this.ClientValueCombo.Visible = false;
			this.ClientValueCombo.SelectedIndexChanged += new System.EventHandler(this.FindClientRadio_CheckedChanged);
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
			this.Controls.Add(this.DataGridView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(872, 720);
			this.Name = "Поиск";
			this.Text = "Поиск";
			this.Activated += new System.EventHandler(this.Поиск_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Поиск_FormClosed);
			this.Load += new System.EventHandler(this.Поиск_Load);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Поиск_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
		private System.Windows.Forms.Button Print;
		private System.Windows.Forms.RadioButton AllClientRadio;
		private System.Windows.Forms.RadioButton AllOfficeRadio;
		private System.Windows.Forms.RadioButton AllRepRadio;
		private System.Windows.Forms.RadioButton FindClientRadio;
		private System.Windows.Forms.ComboBox ClientField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker DateClientLast;
		private System.Windows.Forms.DateTimePicker DateClientFirst;
		private System.Windows.Forms.TextBox ClientValue;
		private System.Windows.Forms.ComboBox ClientValueCombo;
		private System.Windows.Forms.DateTimePicker OfficeDateFirst;
		private System.Windows.Forms.DateTimePicker OfficeDateLast;
		private System.Windows.Forms.TextBox OfficeValue;
		private System.Windows.Forms.ComboBox OfficeValueCombo;
		private System.Windows.Forms.ComboBox OfficeField;
		private System.Windows.Forms.RadioButton FindOfficeRadio;
		private System.Windows.Forms.DateTimePicker RepresDateFirst;
		private System.Windows.Forms.DateTimePicker RepresDateLast;
		private System.Windows.Forms.TextBox RepresValue;
		private System.Windows.Forms.ComboBox RepresValueCombo;
		private System.Windows.Forms.ComboBox RepresField;
		private System.Windows.Forms.RadioButton FindRepRadio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button EditRecord;
		private System.Windows.Forms.Button SettingFind;
		private System.Windows.Forms.Label label2;
	}
}