﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication5
{
    public partial class Поиск : Form
    {
        public Поиск()
        {
            InitializeComponent();
        }

        public static int n = -1;
        DataTableCollection Tables = PsqlData.ds.Tables;

        private void resize()
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
            int width = this.Size.Width;
            int height = groupBox1.Size.Height + dataGridView1.PreferredSize.Height + 71;
            System.Drawing.Size form_size = new System.Drawing.Size(width, height);
            System.Drawing.Size dg_size = new System.Drawing.Size(dataGridView1.Size.Width, dataGridView1.PreferredSize.Height);

            dataGridView1.Size = dg_size;
            this.Size = form_size;
        }

        private void Поиск_Load(object sender, EventArgs e)
        {
            Font = Параметры.fontDialog1.Font;
            BackColor = Параметры.colorDialog1.Color;
            if (Авторизация.polzov != "Администратор")
            {
                radioButton2.Visible = false;
                comboBox5.Visible = false;
                textBox2.Visible = false;
                radioButton3.Visible = false;
                comboBox7.Visible = false;
                textBox3.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }

            string sql;
            PsqlData.connection.Open();

            sql = "SELECT kodclient AS \"Код клиента\", (secondname || ' ' || firstname || ' ' || middlename) AS Клиент, gender AS Пол, " +
                    "telephone AS \"Телефон\", address AS \"Адрес\", snils AS \"СНИЛС\", typedocument AS \"Тип документа удост. личн.\", " + 
                    " serianomer \"Серия и номер\", datebirth AS \"Дата рождения\", placebirth AS \"Место рождения\", dataissue AS \"Дата выдачи\", dateend AS \"Дата окончания дейст.\", issuedby AS Выдан " +
                "FROM Client INNER JOIN Document ON Document.koddoc = Client.kodclient " +
                "ORDER BY Клиент";

            PsqlData.Table_Fill("Поиск_клиент", sql);

            dataGridView1.DataSource = Tables["Поиск_клиент"];
            Tables["Поиск_клиент"].DefaultView.RowFilter = "";
            //dataGridView1.Columns[0].Visible = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Enabled = true;

            resize();

            sql = "SELECT kodrep AS \"Код представителя\", (secondname || ' ' || firstname || ' ' || middlename) AS Представитель, " + 
                    "gender AS Пол, Representative.telephone AS Телефон, Representative.address AS Адрес, Office.name AS \"Офис\" " + 
                "FROM Representative " + 
                    "INNER JOIN Office ON Office.kodoffice = Representative.office " + 
                "ORDER BY Представитель";
            PsqlData.Table_Fill("Поиск_представитель", sql);

            sql = "SELECT kodoffice AS \"Код офиса\", name AS \"Наименование\", telephone AS Телефон, address AS Адрес " +
                "FROM Office " +
                "ORDER BY kodoffice";
            PsqlData.Table_Fill("Поиск_офис", sql);

            for (int i = 0; i < Tables["Поиск_клиент"].Columns.Count; i++)
            {
                comboBox1.Items.Add(Tables["Поиск_клиент"].Columns[i].ColumnName);
            }

            for (int i = 0; i < Tables["Поиск_представитель"].Columns.Count; i++)
            {
                comboBox5.Items.Add(Tables["Поиск_представитель"].Columns[i].ColumnName);
            }

            for (int i = 0; i < Tables["Поиск_офис"].Columns.Count; i++)
            {
                comboBox7.Items.Add(Tables["Поиск_офис"].Columns[i].ColumnName);
            }
        }

        private void Поиск_Activated(object sender, EventArgs e)
        {
            if (dateTimePicker1.Visible)
                dateTimePicker2.Visible = Параметры_поиска.typeSearchDate;
            else if (dateTimePicker3.Visible)
                dateTimePicker4.Visible = Параметры_поиска.typeSearchDate;
            else if (dateTimePicker5.Visible)
                dateTimePicker6.Visible = Параметры_поиска.typeSearchDate;

            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application Excel_ = new Excel.Application();
            Excel_.Visible = true;
            Excel.Workbook WorkBook_ = Excel_.Workbooks.Add();

            Excel.Worksheet Sheet_ = (Excel.Worksheet)WorkBook_.Sheets[1];

            int i, j;

            for (j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Sheet_.Cells[1, j + 1].Value = dataGridView1.Columns[j].HeaderText;
            }

            for (i = 0; i < dataGridView1.Rows.Count; i++)
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                    Sheet_.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value;

            Sheet_.Range[Sheet_.Cells[1, 1], Sheet_.Cells[i + 1, j]].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            Sheet_.Cells.Columns.EntireColumn.AutoFit();
            Sheet_.Range[Sheet_.Cells[1, 1], Sheet_.Cells[1, j]].HorizontalAlignment = 3;
            Sheet_.Range[Sheet_.Cells[2, 1], Sheet_.Cells[i + 1, j]].HorizontalAlignment = 2;
        }

        private void Поиск_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
            dataGridView1.DataSource = Tables["Поиск_клиент"];
            Tables["Поиск_клиент"].DefaultView.RowFilter = "";
            resize();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
            dataGridView1.DataSource = Tables["Поиск_представитель"];
            Tables["Поиск_представитель"].DefaultView.RowFilter = "";
            resize();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
            dataGridView1.DataSource = Tables["Поиск_офис"];
            Tables["Поиск_офис"].DefaultView.RowFilter = "";
            resize();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Elements el_values = new Elements(textBox1, comboBox2, dateTimePicker1, dateTimePicker2, comboBox1);
            radioButton1.Checked = true;

            if (textBox1.Text == "" && textBox1.Visible)
                return;

            if (el_values.comboBoxSel_el.Text == "")
            {
                MessageBox.Show("Вы не выбрали поле для поиска клиента!", "Ошибка");
                return;
            }

            for (int i = 0; i < Tables["Поиск_клиент"].Columns.Count; i++)
            {
                if (Tables["Поиск_клиент"].Columns[i].ColumnName == el_values.comboBoxSel_el.Text)
                    break;

                if (i == Tables["Поиск_клиент"].Columns.Count - 1)
                {
                    MessageBox.Show("Не изменяйте значения вручную в элементах выбора! Значения необходимо выбирать из списка.", "Ошибка");
                    return;
                }
            }

            dataGridView1.DataSource = Tables["Поиск_клиент"];
            el_values.search(el_values, 0, radioButton1);
            resize();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Elements elements = new Elements(textBox1, comboBox2, dateTimePicker1, dateTimePicker2, comboBox1);
            string[] items = new Massives().items;

            switch (elements.comboBoxSel_el.SelectedItem)
            {
                case "Код клиента":
                    elements.choose_element(1, 1);
                    break;
                case "Клиент":
                    elements.choose_element(2, 1);
                    for (int i = 0; i < Tables["Поиск_клиент"].Rows.Count; i++)
                    {
                        elements.comboBox_el.Items.Add(Tables["Поиск_клиент"].Rows[i]["Клиент"].ToString());
                    }
                    break;
                case "Пол":
                    elements.choose_element(2, 1);
                    elements.comboBox_el.Items.Add("Мужской");
                    elements.comboBox_el.Items.Add("Женский");
                    break;
                case "Телефон":
                    elements.choose_element(1, 1);
                    elements.textBox_el.Text = "+7 (777) 777-77-77";
                    break;
                case "Адрес":
                    elements.choose_element(1, 1);
                    break;
                case "СНИЛС":
                    elements.choose_element(1, 1);
                    break;
                case "Тип документа удост. личн.":
                    elements.choose_element(2, 1);
                    elements.comboBox_el.Items.AddRange(items);
                    break;
                case "Серия и номер":
                    elements.choose_element(1, 1);
                    break;
                case "Дата рождения":
                    elements.choose_element(3, 1);
                    break;
                case "Место рождения":
                    elements.choose_element(1, 1);
                    break;
                case "Дата выдачи":
                    elements.choose_element(3, 1);
                    break;
                case "Дата окончания дейст.":
                    elements.choose_element(3, 1);
                    break;
                case "Выдан":
                    break;
                default: break;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            Elements el_values = new Elements(textBox2, comboBox4, dateTimePicker3, dateTimePicker4, comboBox5);
            radioButton2.Checked = true;

            if (textBox2.Text == "" && textBox2.Visible)
                return;

            if (el_values.comboBoxSel_el.Text == "")
            {
                MessageBox.Show("Вы не выбрали поле для поиска представителя!", "Ошибка");
                return;
            }

            for (int i = 0; i < Tables["Поиск_представитель"].Columns.Count; i++)
            {
                if (Tables["Поиск_представитель"].Columns[i].ColumnName == el_values.comboBoxSel_el.Text)
                    break;

                if (i == Tables["Поиск_представитель"].Columns.Count - 1)
                {
                    MessageBox.Show("Не изменяйте значения вручную в элементах выбора, а выбирайте из списка!", "Ошибка");
                    return;
                }
            }

            dataGridView1.DataSource = Tables["Поиск_представитель"];
            el_values.search(el_values, 1, radioButton2);
            resize();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            Elements el_values = new Elements(textBox3, comboBox6, dateTimePicker5, dateTimePicker6, comboBox7);
            radioButton3.Checked = true;

            if (textBox3.Text == "" && textBox3.Visible)
                return;

            if (el_values.comboBoxSel_el.Text == "")
            {
                MessageBox.Show("Вы не выбрали поле для поиска офиса!", "Ошибка");
                return;
            }

            for (int i = 0; i < Tables["Поиск_офис"].Columns.Count; i++)
            {
                if (Tables["Поиск_офис"].Columns[i].ColumnName == el_values.comboBoxSel_el.Text)
                    break;

                if (i == Tables["Поиск_офис"].Columns.Count - 1)
                {
                    MessageBox.Show("Не изменяйте значения вручную в элементах выбора, а выбирайте из списка!", "Ошибка");
                    return;
                }
            }

            dataGridView1.DataSource = Tables["Поиск_офис"];
            el_values.search(el_values, 2, radioButton3);
            resize();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Elements elements = new Elements(textBox2, comboBox4, dateTimePicker3, dateTimePicker4, comboBox5);

            switch (elements.comboBoxSel_el.SelectedItem)
            {
                case "Код представителя":
                    elements.choose_element(1, 2);
                    break;
                case "Представитель":
                    elements.choose_element(2, 2);
                    for (int i = 0; i < Tables["Поиск_представитель"].Rows.Count; i++)
                    {
                        elements.comboBox_el.Items.Add(Tables["Поиск_представитель"].Rows[i]["Представитель"].ToString());
                    }
                    break;
                case "Пол":
                    elements.choose_element(2, 2);
                    elements.comboBox_el.Items.Add("Мужской");
                    elements.comboBox_el.Items.Add("Женский");
                    break;
                case "Телефон":
                    elements.choose_element(1, 2);
                    elements.textBox_el.Text = "+7 (777) 777-77-77";
                    break;
                case "Адрес":
                    elements.choose_element(1, 2);
                    break;
                case "Офис":
                    elements.choose_element(2, 2);
                    for (int i = 0; i < Tables["Поиск_офис"].Rows.Count; i++)
                    {
                        elements.comboBox_el.Items.Add(Tables["Поиск_офис"].Rows[i]["Наименование"]);
                    }
                    break;
                default: break;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Elements elements = new Elements(textBox3, comboBox6, dateTimePicker5, dateTimePicker6, comboBox7);

            switch (elements.comboBoxSel_el.SelectedItem)
            {
                case "Код офиса":
                    elements.choose_element(1, 3);
                    break;
                case "Наименование":
                    elements.choose_element(2, 3);
                    for (int i = 0; i < Tables["Поиск_офис"].Rows.Count; i++)
                    {
                        elements.comboBox_el.Items.Add(Tables["Поиск_офис"].Rows[i]["Наименование"]);
                    }
                    break;
                case "Телефон":
                    elements.choose_element(1, 3);
                    elements.textBox_el.Text = "+7 (777) 777-77-77";
                    break;
                case "Адрес":
                    elements.choose_element(1, 3);
                    break;
                default: break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(dataGridView1.Rows[n].Cells[0].Value); 

            switch (dataGridView1.Columns[0].HeaderText)
            {
                case "Код клиента":
                    Клиенты клиенты = new Клиенты(kod);
                    клиенты.Show();
                    break;
                case "Код представителя":
                    Представители представители = new Представители(kod);
                    представители.Show();
                    break;
                case "Код офиса":
                    Офисы офисы = new Офисы(kod);
                    офисы.Show();
                    break;
                default: break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = dataGridView1.CurrentRow.Index;
        }

        private void Поиск_FormClosed(object sender, FormClosedEventArgs e)
        {
            n = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Параметры_поиска параметры = new Параметры_поиска();
            параметры.Show();
            параметры.Activate();
        }
    }
}
