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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        DataTableCollection Tables = PsqlData.ds.Tables;
        private void TryConnectToBD()
        {
            try
            {
                PsqlData.connection.Open();
            }
            catch (Npgsql.NpgsqlException)
            {
                MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка");
                Environment.Exit(0);
            }
            PsqlData.connection.Close();
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {
            string sql;
            Параметры.colorDialog1.Color = DefaultBackColor;
            BackColor = Параметры.colorDialog1.Color;
            Font = Параметры.fontDialog1.Font;
            PsqlData.TryConnectToBD();

            sql = "SELECT * FROM users ORDER BY login";
            PsqlData.Table_Fill("Пользователи", sql);

            for (int i = 0; i < Tables["Пользователи"].Rows.Count; i++)
            {
                comboBox1.Items.Add(Tables["Пользователи"].Rows[i]["login"].ToString());
            }

            textBox1.UseSystemPasswordChar = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox1.UseSystemPasswordChar = false;
            else
                textBox1.UseSystemPasswordChar = true;
        }

        public static string polzov = "";

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Не указан (неверный) логин пользователя!", "Ошибка");
                return;
            }


            Tables["Пользователи"].DefaultView.RowFilter = "login = '" + comboBox1.Text + "'";
            if (Tables["Пользователи"].DefaultView.Count == 0)
            {
                MessageBox.Show("Не такого пользователя!", "Ошибка");
                return;
            }

            if (!Tables["Пользователи"].DefaultView[0].Row.ItemArray[1].ToString().Equals(comboBox1.Text))
            {
                MessageBox.Show("Пользователь с таким логином не найден!", "Ошибка");
                return;
            }

            if (textBox1.Text == Tables["Пользователи"].DefaultView[0].Row.ItemArray[2].ToString())
            {                
                Hide();
                polzov = comboBox1.Text;

                Меню меню = new Меню();
                меню.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный пароль", "Ошибка");
            }
            PsqlData.connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }
    }
}
