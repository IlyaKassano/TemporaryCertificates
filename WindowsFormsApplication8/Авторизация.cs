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

namespace TemporaryCertificates
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
                User.Items.Add(Tables["Пользователи"].Rows[i]["login"].ToString());
            }

            Password.UseSystemPasswordChar = true;

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
                Password.UseSystemPasswordChar = false;
            else
                Password.UseSystemPasswordChar = true;
        }

        public static string polzov = "";

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                MessageBox.Show("Не указан (неверный) логин пользователя!", "Ошибка");
                return;
            }


            Tables["Пользователи"].DefaultView.RowFilter = "login = '" + User.Text + "'";
            if (Tables["Пользователи"].DefaultView.Count == 0)
            {
                MessageBox.Show("Не такого пользователя!", "Ошибка");
                return;
            }

            if (!Tables["Пользователи"].DefaultView[0].Row.ItemArray[1].ToString().Equals(User.Text))
            {
                MessageBox.Show("Пользователь с таким логином не найден!", "Ошибка");
                return;
            }

            if (Password.Text == Tables["Пользователи"].DefaultView[0].Row.ItemArray[2].ToString())
            {                
                Hide();
                polzov = User.Text;

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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void User_SelectedIndexChanged(object sender, EventArgs e)
        {
            Password.Focus();
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterButton_Click(null, null);
            }
        }
    }
}
