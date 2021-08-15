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
    public partial class Офисы : Form
    {
        public Офисы(int kod = -1)
        {
            InitializeComponent();
            string sql = "SELECT * FROM office ORDER BY kodoffice";
            PsqlData.Table_Fill("Office", sql);

            if (kod != -1)
            {
                n = Tables["Office"].Rows.IndexOf(Tables["Office"].Select("kodoffice = " + kod).First());
                FieldsForm_Fill();
            }
        }

        /// <summary>  
        ///  Номер записи
        /// </summary> 
        int n = 0;
        int maxN = 0;
        DataTableCollection Tables = PsqlData.ds.Tables;

        private void Офисы_Load(object sender, EventArgs e)
        {
            Font = Параметры.fontDialog1.Font;
            BackColor = Параметры.colorDialog1.Color;
            if (Tables["Office"].Rows.Count > n)
            {
                FieldsForm_Fill();
            }

            MaxN();
        }

        /// <summary>  
        ///  Заполнение формы значениями из таблицы БД
        /// </summary> 
        private void FieldsForm_Fill()
        {
            textBox1.Text = Tables["Office"].Rows[n]["kodoffice"].ToString();
            textBox2.Text = Tables["Office"].Rows[n]["address"].ToString();
            textBox3.Text = Tables["Office"].Rows[n]["name"].ToString();
            maskedTextBox1.Text = Tables["Office"].Rows[n]["telephone"].ToString();

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
            maskedTextBox1.Text = "";

            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void MaxN() {
            maxN = Convert.ToInt32(Tables["Office"].Compute("Max(kodoffice)", string.Empty)) + 1;
        }

        //В начало
        private void button11_Click(object sender, EventArgs e)
        {
            n = 0;
            if (Tables["Office"].Rows.Count > n)
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
            if (n < Tables["Office"].Rows.Count - 1)
            {
                n++;
                FieldsForm_Fill();
            }
            else if (n == Tables["Office"].Rows.Count - 1)
            {
                n = Tables["Office"].Rows.Count;
                FieldsForm_Clear();
                textBox1.Text = maxN.ToString();
            }
        }

        //В конец
        private void button6_Click(object sender, EventArgs e)
        {
            n = Tables["Office"].Rows.Count;
            FieldsForm_Clear();
            textBox1.Text = maxN.ToString();
        }

        //Сохранение        
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                return;
            }

            if (n == Tables["Office"].Rows.Count)
            {
                string sql = "INSERT INTO office (kodoffice, name, address, telephone) values (" + textBox1.Text + ", '" + textBox3.Text + "', '" + textBox2.Text + "', '" + maskedTextBox1.Text + "')";
                PsqlData.Mod_Execute(sql);

                textBox1.Enabled = false;
                Tables["Office"].Rows.Add(new object[] { textBox1.Text, textBox2.Text, maskedTextBox1.Text, textBox3.Text });

                MaxN();
            }
            else
            {
                string sql = "UPDATE office SET name = '" + textBox3.Text + "', address='" + textBox2.Text + "', telephone='" + maskedTextBox1.Text +  "' WHERE kodoffice=" + textBox1.Text;
                PsqlData.Mod_Execute(sql);

                Tables["Office"].Rows[n].ItemArray = new object[] { textBox1.Text, textBox2.Text, maskedTextBox1.Text, textBox3.Text };
            }
        }

        //Удаление
        private void button9_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите удалить из картотеки офис с кодом " + textBox1.Text + "?";
            string caption = "Удаление офиса";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult rezult = MessageBox.Show(message, caption, buttons);
            if (rezult == DialogResult.No) { return; }

            string sql = "DELETE FROM office WHERE kodoffice = " + textBox1.Text;
            PsqlData.Mod_Execute(sql);

            try
            {
                Tables["Office"].Rows.RemoveAt(n);
                MaxN();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Удаление не было выполнено из-за указания несущественного экземпляра", "Ошибка");
                return;
            }

            if (Tables["Office"].Rows.Count > n)
            {
                FieldsForm_Fill();
            }
            else
            {
                FieldsForm_Clear();
            }
        }
    }
}
