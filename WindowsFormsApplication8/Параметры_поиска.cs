using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication5
{
    public partial class Параметры_поиска : Form
    {
        public Параметры_поиска()
        {
            InitializeComponent();
        }

		/// <summary>
		/// False - точный поиск,
		/// True - неточный поиск
		/// </summary>
		public static bool typeSearchString = false;
		/// <summary>
		/// False - по конкретной дате,
		/// True - по диапазону дат
		/// </summary>
		public static bool typeSearchDate = false;

		private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Параметры_поиска));
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(8, 29);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(97, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Точный поиск";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(8, 52);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(109, 17);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Неточный поиск";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(8, 105);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(161, 17);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Поиск по конкретной дате";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.Click += new System.EventHandler(this.checkBox3_Click);
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(8, 128);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(149, 17);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Поиск по диапазону дат";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.Click += new System.EventHandler(this.checkBox4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Тип поиска строковых значений";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.label2.Location = new System.Drawing.Point(12, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Тип поиска дат";
			// 
			// Параметры_поиска
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(293, 188);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Параметры_поиска";
			this.Text = "Параметры поиска";
			this.Load += new System.EventHandler(this.form_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		private void form_Load(object sender, EventArgs e)
		{
			Font = Параметры.fontDialog1.Font;
			BackColor = Параметры.colorDialog1.Color;
			if (typeSearchString == false)
				checkBox1.Checked = true;
			else
				checkBox2.Checked = true;

			if (typeSearchDate == false)
				checkBox3.Checked = true;
			else
				checkBox4.Checked = true;
		}

		private void checkBox1_Click(object sender, EventArgs e)
		{
			checkBox2.Checked = false;
			typeSearchString = false;
		}

		private void checkBox2_Click(object sender, EventArgs e)
		{
			checkBox1.Checked = false;
			typeSearchString = true;
		}

		private void checkBox3_Click(object sender, EventArgs e)
		{
			checkBox4.Checked = false;
			typeSearchDate = false;
		}

		private void checkBox4_Click(object sender, EventArgs e)
		{
			checkBox3.Checked = false;
			typeSearchDate = true;
		}
	}
}
