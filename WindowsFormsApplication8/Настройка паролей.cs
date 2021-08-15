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

        private void Настройка_паролей_Load(object sender, EventArgs e)
        {
            Font = Параметры.fontDialog1.Font;
            BackColor = Параметры.colorDialog1.Color;
            string sql;

            sql = "SELECT * FROM users ORDER BY login";
            Меню.Table_Fill("Авторизация", sql);

            for (int i = 0; i < Меню.ds.Tables["Авторизация"].Rows.Count; i++)
            {
                comboBox1.Items.Add(Меню.ds.Tables["Авторизация"].Rows[i]["login"].ToString());
            }

            textBox1.UseSystemPasswordChar = true;
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = "";

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Не указан логин пользователя!", "Ошибка");
                return;
            }

            for (int i = 0; i < Меню.ds.Tables["Авторизация"].Rows.Count; i++)
            {
                if (Меню.ds.Tables["Авторизация"].Rows[i]["login"].ToString().Equals(comboBox1.Text))
                {
                    pass = Меню.ds.Tables["Авторизация"].Rows[i]["password"].ToString();
                    break;
                }
            }

            if (textBox1.Text != pass)
            {
                MessageBox.Show("Введенный вами пароль от данного пользователя не соответствует текущему!", "Ошибка");
                return;
            }

            if (textBox2.Text == textBox3.Text)
            {
                string sql = "UPDATE users SET password = '" + textBox2.Text +
                    "' WHERE login = '" + comboBox1.Text + "'";
                Меню.Mod_Execute(sql);

                Close();
            }
            else
            {
                MessageBox.Show("Неверное подтверждение пароля.", "Ошибка");
            }
        }
    }
}
