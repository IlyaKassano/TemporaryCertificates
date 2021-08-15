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

namespace WindowsFormsApplication5
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 О_программе = new AboutBox1();
            О_программе.Show();
        }

        private void настройкаПаролейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Настройка_паролей Настройка_паролей = new Настройка_паролей();
            Настройка_паролей.Show();
        }

        private void Меню_Load(object sender, EventArgs e)
        {
            string sql = "UPDATE tempcertificate SET valid = FALSE WHERE dateend < CURRENT_DATE";

            PsqlData.Mod_Execute(sql);

            if (Авторизация.polzov != "Администратор")
            {
                представителиToolStripMenuItem.Visible = false;
                оффисToolStripMenuItem.Visible = false;
            }
        }

        private void представителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Представители представители = new Представители();
            представители.Show();
        }

        private void просмотрСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Spravka.chm");
        }

        private void оффисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Офисы офис = new Офисы();
            офис.Show();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Поиск поиск = new Поиск();
            поиск.Show();
        }
        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Авторизация.polzov = "";
            Авторизация авторизация = new Авторизация();
            авторизация.ShowDialog();
            Close();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void клиентыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Клиенты Клиенты = new Клиенты();
            Клиенты.Show();
        }

        private void настройкаПаролейToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Настройка_паролей пароль = new Настройка_паролей();
            пароль.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Журнал_временного_сертификата временный_сертификат = new Журнал_временного_сертификата();
            временный_сертификат.Show();
        }

        private void поискToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Поиск поиск = new Поиск();
            поиск.Show();
        }

        private void просмотрСправкиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Spravka.chm");
        }

        private void ToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.Black;
        }

        private void ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.FromArgb(255, 255, 170);
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Параметры параметры = new Параметры();
            параметры.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Параметры.fontDialog1.Reset();
            Параметры.colorDialog1.Color = DefaultBackColor;
        }
    }
}
