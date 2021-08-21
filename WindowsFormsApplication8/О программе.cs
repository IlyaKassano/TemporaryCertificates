using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemporaryCertificates
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
            this.Text = String.Format("О программе \"Выдача временных свидетельств\"");
            this.labelProductName.Text = "Выдача временных свидетельств";
            this.labelVersion.Text = String.Format("Версия 1.0");
            this.labelCopyright.Text = "© Фомин Илья, 2020";
            this.labelCompanyName.Text = "ГБПОУ РО «РКИУ»";
            this.textBoxDescription.Text = "Основные функции: занесение и чтение информации о клиентах, представителях, офисах и временных свидетельствах.\n" +
                "Выходные документы: временные свидетельства";
            Font = Параметры.fontDialog1.Font;
            BackColor = Параметры.colorDialog1.Color;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
