namespace WindowsFormsApplication5
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
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(220, 285);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 40);
			this.button1.TabIndex = 74;
			this.button1.Text = "Сохранить оформление ВС";
			this.toolTip1.SetToolTip(this.button1, "Сохранить оформление временного свидетельства");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(169, 69);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
			this.dateTimePicker1.TabIndex = 79;
			this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(169, 111);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(129, 20);
			this.dateTimePicker2.TabIndex = 82;
			this.dateTimePicker2.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(169, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(129, 20);
			this.textBox1.TabIndex = 83;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(448, 192);
			this.button2.MaximumSize = new System.Drawing.Size(152, 50);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 23);
			this.button2.TabIndex = 112;
			this.button2.Text = "Добавить представителя";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(169, 192);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(273, 21);
			this.comboBox1.TabIndex = 113;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(169, 234);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(273, 21);
			this.comboBox2.TabIndex = 117;
			this.toolTip1.SetToolTip(this.comboBox2, "Адрес");
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
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(448, 234);
			this.button3.MaximumSize = new System.Drawing.Size(152, 50);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(152, 23);
			this.button3.TabIndex = 120;
			this.button3.Text = "Добавить офис";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(169, 151);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(273, 21);
			this.comboBox3.TabIndex = 123;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(448, 151);
			this.button4.MaximumSize = new System.Drawing.Size(152, 50);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(152, 23);
			this.button4.TabIndex = 122;
			this.button4.Text = "Добавить клиента";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
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
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(533, 285);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(67, 40);
			this.button5.TabIndex = 124;
			this.button5.Text = "Печать";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
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
			this.Controls.Add(this.button5);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}