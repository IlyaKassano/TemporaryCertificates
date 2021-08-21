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

namespace TemporaryCertificates
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
			this.ExactFindCheck = new System.Windows.Forms.CheckBox();
			this.NotExactCheck = new System.Windows.Forms.CheckBox();
			this.ExactDateCheck = new System.Windows.Forms.CheckBox();
			this.RangeDateCheck = new System.Windows.Forms.CheckBox();
			this.TypeValueCheck = new System.Windows.Forms.Label();
			this.TypeDateLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ExactFindCheck
			// 
			this.ExactFindCheck.AutoSize = true;
			this.ExactFindCheck.Location = new System.Drawing.Point(8, 29);
			this.ExactFindCheck.Name = "ExactFindCheck";
			this.ExactFindCheck.Size = new System.Drawing.Size(97, 17);
			this.ExactFindCheck.TabIndex = 0;
			this.ExactFindCheck.Text = "Точный поиск";
			this.ExactFindCheck.UseVisualStyleBackColor = true;
			this.ExactFindCheck.Click += new System.EventHandler(this.ExactFindCheck_Click);
			// 
			// NotExactCheck
			// 
			this.NotExactCheck.AutoSize = true;
			this.NotExactCheck.Location = new System.Drawing.Point(8, 52);
			this.NotExactCheck.Name = "NotExactCheck";
			this.NotExactCheck.Size = new System.Drawing.Size(109, 17);
			this.NotExactCheck.TabIndex = 1;
			this.NotExactCheck.Text = "Неточный поиск";
			this.NotExactCheck.UseVisualStyleBackColor = true;
			this.NotExactCheck.Click += new System.EventHandler(this.NotExactFindCheck_Click);
			// 
			// ExactDateCheck
			// 
			this.ExactDateCheck.AutoSize = true;
			this.ExactDateCheck.Location = new System.Drawing.Point(8, 105);
			this.ExactDateCheck.Name = "ExactDateCheck";
			this.ExactDateCheck.Size = new System.Drawing.Size(161, 17);
			this.ExactDateCheck.TabIndex = 2;
			this.ExactDateCheck.Text = "Поиск по конкретной дате";
			this.ExactDateCheck.UseVisualStyleBackColor = true;
			this.ExactDateCheck.Click += new System.EventHandler(this.ExactDateCheck_Click);
			// 
			// RangeDateCheck
			// 
			this.RangeDateCheck.AutoSize = true;
			this.RangeDateCheck.Location = new System.Drawing.Point(8, 128);
			this.RangeDateCheck.Name = "RangeDateCheck";
			this.RangeDateCheck.Size = new System.Drawing.Size(149, 17);
			this.RangeDateCheck.TabIndex = 3;
			this.RangeDateCheck.Text = "Поиск по диапазону дат";
			this.RangeDateCheck.UseVisualStyleBackColor = true;
			this.RangeDateCheck.Click += new System.EventHandler(this.RangeDateCheck_Click);
			// 
			// TypeValueCheck
			// 
			this.TypeValueCheck.AutoSize = true;
			this.TypeValueCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.TypeValueCheck.Location = new System.Drawing.Point(12, 9);
			this.TypeValueCheck.Name = "TypeValueCheck";
			this.TypeValueCheck.Size = new System.Drawing.Size(172, 13);
			this.TypeValueCheck.TabIndex = 4;
			this.TypeValueCheck.Text = "Тип поиска строковых значений";
			// 
			// TypeDateLabel
			// 
			this.TypeDateLabel.AutoSize = true;
			this.TypeDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.TypeDateLabel.Location = new System.Drawing.Point(12, 85);
			this.TypeDateLabel.Name = "TypeDateLabel";
			this.TypeDateLabel.Size = new System.Drawing.Size(85, 13);
			this.TypeDateLabel.TabIndex = 5;
			this.TypeDateLabel.Text = "Тип поиска дат";
			// 
			// Параметры_поиска
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(293, 188);
			this.Controls.Add(this.TypeDateLabel);
			this.Controls.Add(this.TypeValueCheck);
			this.Controls.Add(this.RangeDateCheck);
			this.Controls.Add(this.ExactDateCheck);
			this.Controls.Add(this.NotExactCheck);
			this.Controls.Add(this.ExactFindCheck);
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
				ExactFindCheck.Checked = true;
			else
				NotExactCheck.Checked = true;

			if (typeSearchDate == false)
				ExactDateCheck.Checked = true;
			else
				RangeDateCheck.Checked = true;
		}

		private void ExactFindCheck_Click(object sender, EventArgs e)
		{
			NotExactCheck.Checked = false;
			typeSearchString = false;
		}

		private void NotExactFindCheck_Click(object sender, EventArgs e)
		{
			ExactFindCheck.Checked = false;
			typeSearchString = true;
		}

		private void ExactDateCheck_Click(object sender, EventArgs e)
		{
			RangeDateCheck.Checked = false;
			typeSearchDate = false;
		}

		private void RangeDateCheck_Click(object sender, EventArgs e)
		{
			ExactDateCheck.Checked = false;
			typeSearchDate = true;
		}
	}
}
