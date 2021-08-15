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
    public partial class Параметры : Form
    {
        public Параметры()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Параметры));
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 95);
			this.listBox1.TabIndex = 6;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// Параметры
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(357, 261);
			this.Controls.Add(this.listBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Параметры";
			this.Text = "Параметры";
			this.Activated += new System.EventHandler(this.Параметры_Activated);
			this.Load += new System.EventHandler(this.Параметры_Load);
			this.ResumeLayout(false);

        }

        private void Параметры_Load(object sender, EventArgs e)
        {
			string[] items = {
				"Шрифт",
				"Цвет фонов",
				""
			};

			listBox1.Items.AddRange(items);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (listBox1.SelectedItem.ToString())
			{
				case "Шрифт": fontDialog1.ShowDialog(); break;
				case "Цвет фонов": colorDialog1.ShowDialog(); break;
				default: break;
			}

		}

		private void Параметры_Activated(object sender, EventArgs e)
		{
			BackColor = colorDialog1.Color;
			Font = fontDialog1.Font;
		}
	}
}
