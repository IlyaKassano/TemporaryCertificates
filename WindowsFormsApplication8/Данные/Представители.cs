﻿using System;
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
    public partial class Представители : Form
    {
        public Представители(int kod = -1)
        {
            InitializeComponent();
            Font = Параметры.fontDialog1.Font;
            BackColor = Параметры.colorDialog1.Color;
            string sql = "SELECT kodrep, firstname, middlename, secondname, gender, representative.telephone, " +
                    "representative.address AS address, office.name AS name " +
                "FROM Representative " +
                    "INNER JOIN Office ON Office.kodoffice = Representative.office " +
                "ORDER BY kodrep";
            PsqlData.Table_Fill("Representative", sql);

            if (kod != -1)
            {
                n = Tables["Representative"].Rows.IndexOf(Tables["Representative"].Select("kodrep = " + kod).First());
                FieldsForm_Fill();
            }
        }

        /// <summary>  
        ///  Номер записи
        /// </summary> 
        int n = 0;
        int maxN = 0;
        DataTableCollection Tables = PsqlData.ds.Tables;

        private void Представители_Load(object sender, EventArgs e)
        {
            string sql;

            sql = "SELECT * FROM Office ORDER BY kodoffice";
            PsqlData.Table_Fill("Offices", sql);

            for (int i = 0; i < Tables["Offices"].Rows.Count; i++)
            {
                comboBox2.Items.Add(Tables["Offices"].Rows[i]["name"].ToString());
            }

            MaxN();

            PsqlData.connection.Close();

            if (Tables["Representative"].Rows.Count > n)
            {
                FieldsForm_Fill();
            }
        }

        /// <summary>  
        ///  Заполнение формы значениями из таблицы БД
        /// </summary> 
        private void FieldsForm_Fill()
        {
            textBox1.Text = Tables["Representative"].Rows[n]["kodrep"].ToString();
            textBox2.Text = Tables["Representative"].Rows[n]["secondname"].ToString();
            textBox3.Text = Tables["Representative"].Rows[n]["firstname"].ToString();
            textBox4.Text = Tables["Representative"].Rows[n]["middlename"].ToString();
            comboBox1.Text = Tables["Representative"].Rows[n]["gender"].ToString();
            maskedTextBox1.Text = Tables["Representative"].Rows[n]["telephone"].ToString();
            textBox11.Text = Tables["Representative"].Rows[n]["address"].ToString();
            comboBox2.Text = Tables["Representative"].Rows[n]["name"].ToString();

            textBox1.Enabled = false;
        }

        /// <summary>  
        ///  Очистка значений формы
        /// </summary> 
        private void FieldsForm_Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            maskedTextBox1.Text = "";
            textBox11.Text = "";
            comboBox2.Text = "";
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void MaxN()
        {
            maxN = Convert.ToInt32(Tables["Representative"].Compute("Max(kodrep)", string.Empty)) + 1;
        }

        //В начало
        private void button11_Click(object sender, EventArgs e)
        {
            n = 0;
            if (Tables["Representative"].Rows.Count > n)
                FieldsForm_Fill();
        }

        //Назад
        private void button10_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                n--;
                FieldsForm_Fill();
            }
        }

        //Вперед
        private void button8_Click(object sender, EventArgs e)
        {
            if (n < Tables["Representative"].Rows.Count - 1)
            {
                n++;
                FieldsForm_Fill();
            }
            else if (n == Tables["Representative"].Rows.Count - 1)
            {
                n = Tables["Representative"].Rows.Count;
                FieldsForm_Clear();
                textBox1.Text = maxN.ToString();
            }
        }

        //В конец
        private void button6_Click(object sender, EventArgs e)
        {
            n = Tables["Representative"].Rows.Count;
            FieldsForm_Clear();
            textBox1.Text = maxN.ToString();
        }

        //Сохранение        
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                return;
            }

            int kod_off = -1;
            for (int i = 0; i < Tables["Offices"].Rows.Count; i++)
            {
                if (comboBox2.Text == Tables["Offices"].Rows[i]["name"].ToString())
                {
                    kod_off = Convert.ToInt32(Tables["Offices"].Rows[i]["kodoffice"]);
                    break;
                }
            }

            if (kod_off < 0)
            {
                MessageBox.Show("Не удалось найти заданный офис! Выберите офис из выпадающего списка", "Ошибка");
                return;
            }

            if (n == Tables["Representative"].Rows.Count)
            {
                string sql = "INSERT INTO Representative (kodrep, secondname, firstname, middlename, gender, telephone, address, office) values (" + 
                    textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + comboBox1.Text + "', '" + maskedTextBox1.Text + 
                    "', '" + textBox11.Text + "', " + kod_off + ");";

                PsqlData.Mod_Execute(sql);
                textBox1.Enabled = false;
                Tables["Representative"].Rows.Add(new object[] { textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text,
                    comboBox1.Text, maskedTextBox1.Text, textBox11.Text, comboBox2.Text });

            }
            else
            {
                string sql = "UPDATE Representative SET secondname='" + textBox2.Text + "', firstname='" + textBox3.Text + 
                    "', middlename='" + textBox4.Text + "', gender='" + comboBox1.Text + "', telephone='" + maskedTextBox1.Text + 
                    "', address='" + textBox11.Text + "', office = " + kod_off + " WHERE kodrep=" + textBox1.Text + ";";

                PsqlData.Mod_Execute(sql);
                Tables["Representative"].Rows[n].ItemArray = new object[] { textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text,
                    comboBox1.Text, maskedTextBox1.Text, textBox11.Text, comboBox2.Text };
            }
        }

        //Удаление
        private void button9_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите удалить из картотеки представителя с кодом " + textBox1.Text + "?";
            string caption = "Удаление представителя";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult rezult = MessageBox.Show(message, caption, buttons);
            if (rezult == DialogResult.No) { return; }

            string sql = "DELETE FROM Representative WHERE kodrep = " + textBox1.Text;
            PsqlData.Mod_Execute(sql);

            try
            {
                Tables["Representative"].Rows.RemoveAt(n);
                MaxN();
            }
            catch (IndexOutOfRangeException)
            {
            }

            if (Tables["Representative"].Rows.Count > n)
            {
                FieldsForm_Fill();
            }
            else
            {
                FieldsForm_Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
