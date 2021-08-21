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
    public partial class Настройка_паролей : Form
    {
        public Настройка_паролей()
        {
            InitializeComponent();
        }

        DataTableCollection Tables = PsqlData.ds.Tables;

        private void Настройка_паролей_Load(object sender, EventArgs e)
        {
            Font = Параметры.fontDialog1.Font;
            BackColor = Параметры.colorDialog1.Color;
            string sql;

            sql = "SELECT * FROM users ORDER BY login";
            PsqlData.Table_Fill("Авторизация", sql);

            for (int i = 0; i < Tables["Авторизация"].Rows.Count; i++)
            {
                User.Items.Add(Tables["Авторизация"].Rows[i]["login"].ToString());
            }

            CurrentPass.UseSystemPasswordChar = true;
            NewPass.UseSystemPasswordChar = true;
            EqualPass.UseSystemPasswordChar = true;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = "";

            if (User.Text == "")
            {
                MessageBox.Show("Не указан логин пользователя!", "Ошибка");
                return;
            }

            for (int i = 0; i < Tables["Авторизация"].Rows.Count; i++)
            {
                if (Tables["Авторизация"].Rows[i]["login"].ToString().Equals(User.Text))
                {
                    pass = Tables["Авторизация"].Rows[i]["password"].ToString();
                    break;
                }
            }

            if (CurrentPass.Text != pass)
            {
                MessageBox.Show("Введенный вами пароль от данного пользователя не соответствует текущему!", "Ошибка");
                return;
            }

            if (NewPass.Text == EqualPass.Text)
            {
                string sql = "UPDATE users SET password = '" + NewPass.Text +
                    "' WHERE login = '" + User.Text + "'";
                PsqlData.Mod_Execute(sql);

                Close();
            }
            else
            {
                MessageBox.Show("Неверное подтверждение пароля.", "Ошибка");
            }
        }
    }
}
