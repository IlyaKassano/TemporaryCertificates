namespace WindowsFormsApplication5
{
    partial class Офисы
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Офисы));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.LastRecord = new System.Windows.Forms.Button();
			this.NextRecord = new System.Windows.Forms.Button();
			this.PrevRecord = new System.Windows.Forms.Button();
			this.FirstRecord = new System.Windows.Forms.Button();
			this.Address = new System.Windows.Forms.TextBox();
			this.Office = new System.Windows.Forms.TextBox();
			this.SaveRecord = new System.Windows.Forms.Button();
			this.DeleteRecord = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.KodOffice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Telephone = new System.Windows.Forms.MaskedTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 35;
			this.label1.Text = "Код офиса:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 38;
			this.label2.Text = "Адрес:";
			// 
			// LastRecord
			// 
			this.LastRecord.AutoSize = true;
			this.LastRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.LastRecord.Location = new System.Drawing.Point(264, 178);
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
			this.NextRecord.Location = new System.Drawing.Point(233, 178);
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
			this.PrevRecord.Location = new System.Drawing.Point(202, 178);
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
			this.FirstRecord.Location = new System.Drawing.Point(167, 178);
			this.FirstRecord.Name = "FirstRecord";
			this.FirstRecord.Size = new System.Drawing.Size(29, 23);
			this.FirstRecord.TabIndex = 75;
			this.FirstRecord.Text = "<<";
			this.toolTip1.SetToolTip(this.FirstRecord, "В начало");
			this.FirstRecord.UseVisualStyleBackColor = false;
			this.FirstRecord.Click += new System.EventHandler(this.button11_Click);
			// 
			// Address
			// 
			this.Address.Location = new System.Drawing.Point(104, 134);
			this.Address.Name = "Address";
			this.Address.Size = new System.Drawing.Size(350, 20);
			this.Address.TabIndex = 83;
			this.toolTip1.SetToolTip(this.Address, "Адрес проживания");
			// 
			// Office
			// 
			this.Office.Location = new System.Drawing.Point(104, 59);
			this.Office.Name = "Office";
			this.Office.Size = new System.Drawing.Size(350, 20);
			this.Office.TabIndex = 122;
			this.toolTip1.SetToolTip(this.Office, "Адрес проживания");
			// 
			// SaveRecord
			// 
			this.SaveRecord.AutoSize = true;
			this.SaveRecord.BackColor = System.Drawing.SystemColors.ControlLight;
			this.SaveRecord.Location = new System.Drawing.Point(71, 216);
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
			this.DeleteRecord.Location = new System.Drawing.Point(231, 216);
			this.DeleteRecord.MaximumSize = new System.Drawing.Size(154, 50);
			this.DeleteRecord.Name = "DeleteRecord";
			this.DeleteRecord.Size = new System.Drawing.Size(154, 23);
			this.DeleteRecord.TabIndex = 77;
			this.DeleteRecord.Text = "Удалить данные";
			this.DeleteRecord.UseVisualStyleBackColor = false;
			this.DeleteRecord.Click += new System.EventHandler(this.button9_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 253);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(464, 22);
			this.statusStrip1.TabIndex = 81;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(295, 17);
			this.toolStripStatusLabel1.Text = "Для добавления записи пролистайте в самый конец";
			// 
			// KodOffice
			// 
			this.KodOffice.Location = new System.Drawing.Point(104, 22);
			this.KodOffice.Name = "KodOffice";
			this.KodOffice.Size = new System.Drawing.Size(112, 20);
			this.KodOffice.TabIndex = 82;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 84;
			this.label3.Text = "Телефон:";
			// 
			// Telephone
			// 
			this.Telephone.Location = new System.Drawing.Point(104, 97);
			this.Telephone.Mask = "+7 (000) 000-00-00";
			this.Telephone.Name = "Telephone";
			this.Telephone.Size = new System.Drawing.Size(185, 20);
			this.Telephone.TabIndex = 119;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WindowsFormsApplication5.Properties.Resources.Makc_m;
			this.pictureBox1.Location = new System.Drawing.Point(344, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(110, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 120;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 121;
			this.label4.Text = "Наименование:";
			// 
			// Офисы
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(464, 275);
			this.Controls.Add(this.Office);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Telephone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Address);
			this.Controls.Add(this.KodOffice);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.SaveRecord);
			this.Controls.Add(this.LastRecord);
			this.Controls.Add(this.NextRecord);
			this.Controls.Add(this.DeleteRecord);
			this.Controls.Add(this.PrevRecord);
			this.Controls.Add(this.FirstRecord);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Офисы";
			this.Text = "Офисы";
			this.Load += new System.EventHandler(this.Офисы_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button SaveRecord;
        private System.Windows.Forms.Button LastRecord;
        private System.Windows.Forms.Button NextRecord;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.Button PrevRecord;
        private System.Windows.Forms.Button FirstRecord;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox KodOffice;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox Telephone;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox Office;
		private System.Windows.Forms.Label label4;
	}
}