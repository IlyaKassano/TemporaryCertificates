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
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(517, 315);
			this.button3.MaximumSize = new System.Drawing.Size(226, 34);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(226, 34);
			this.button3.TabIndex = 7;
			this.button3.Text = "Удалить свидетельство";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 315);
			this.button1.MaximumSize = new System.Drawing.Size(235, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(235, 34);
			this.button1.TabIndex = 5;
			this.button1.Text = "Оформить новое свидетельство";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(11, 91);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(846, 218);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(253, 315);
			this.button2.MaximumSize = new System.Drawing.Size(258, 34);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(258, 34);
			this.button2.TabIndex = 9;
			this.button2.Text = "Редактировать свидетельство";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(749, 315);
			this.button4.MaximumSize = new System.Drawing.Size(108, 34);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(108, 34);
			this.button4.TabIndex = 10;
			this.button4.Text = "Печать";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(11, 39);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(129, 17);
			this.radioButton1.TabIndex = 11;
			this.radioButton1.Text = "Действительные ВС";
			this.toolTip1.SetToolTip(this.radioButton1, "Действительные временные свидетельства");
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(11, 64);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(140, 17);
			this.radioButton2.TabIndex = 12;
			this.radioButton2.Text = "Недействительные ВС";
			this.toolTip1.SetToolTip(this.radioButton2, "Недействительные временные свидетельства");
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(177, 39);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(115, 17);
			this.radioButton3.TabIndex = 13;
			this.radioButton3.Text = "По конкрет. дате:";
			this.toolTip1.SetToolTip(this.radioButton3, "По конкретной дате");
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.Click += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(177, 64);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(118, 17);
			this.radioButton4.TabIndex = 14;
			this.radioButton4.Text = "По диапазону дат:";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.Click += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(506, 13);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(85, 17);
			this.radioButton5.TabIndex = 15;
			this.radioButton5.Text = "По клиенту:";
			this.radioButton5.UseVisualStyleBackColor = true;
			this.radioButton5.Click += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new System.Drawing.Point(506, 39);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(123, 17);
			this.radioButton6.TabIndex = 16;
			this.radioButton6.Text = "По представителю:";
			this.radioButton6.UseVisualStyleBackColor = true;
			this.radioButton6.Click += new System.EventHandler(this.radioButton6_CheckedChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Checked = false;
			this.dateTimePicker1.CustomFormat = "dd.MM.YYYY";
			this.dateTimePicker1.Location = new System.Drawing.Point(300, 39);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 17;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.radioButton3_CheckedChangedEvent);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Checked = false;
			this.dateTimePicker2.Location = new System.Drawing.Point(300, 62);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker2.TabIndex = 18;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(635, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(222, 21);
			this.comboBox1.TabIndex = 19;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(635, 36);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(222, 21);
			this.comboBox2.TabIndex = 20;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
			// 
			// radioButton7
			// 
			this.radioButton7.AutoSize = true;
			this.radioButton7.Checked = true;
			this.radioButton7.Location = new System.Drawing.Point(11, 13);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(184, 17);
			this.radioButton7.TabIndex = 21;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "Все временные свидетельства";
			this.radioButton7.UseVisualStyleBackColor = true;
			this.radioButton7.Click += new System.EventHandler(this.radioButton7_CheckedChanged);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
            "По дате начала действия",
            "По дате окончания действия"});
			this.comboBox3.Location = new System.Drawing.Point(300, 15);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(200, 21);
			this.comboBox3.TabIndex = 22;
			this.comboBox3.Text = "По дате начала действия";
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(635, 60);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(222, 21);
			this.comboBox4.TabIndex = 24;
			this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.Location = new System.Drawing.Point(506, 64);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(76, 17);
			this.radioButton8.TabIndex = 23;
			this.radioButton8.Text = "По офису:";
			this.radioButton8.UseVisualStyleBackColor = true;
			this.radioButton8.Click += new System.EventHandler(this.radioButton8_CheckedChanged);
			// 
			// Журнал_временного_сертификата
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(869, 359);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.radioButton8);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.radioButton7);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.radioButton6);
			this.Controls.Add(this.radioButton5);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Журнал_временного_сертификата";
			this.Text = "Журнал временного свидетельства";
			this.Activated += new System.EventHandler(this.Журнал_временного_сертификата_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Журнал_временного_сертификата_FormClosed);
			this.Load += new System.EventHandler(this.Журнал_временного_сертификата_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}