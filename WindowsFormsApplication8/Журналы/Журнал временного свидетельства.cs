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
    public partial class Журнал_временного_сертификата : Form
    {
        public Журнал_временного_сертификата()
        {
            InitializeComponent();
        }

        /// <summary>  
        ///  Код записи
        /// </summary> 
        public static int n = -1;
        DataTableCollection Tables = PsqlData.ds.Tables;

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;

            sql = "SELECT kodtempcert FROM tempcertificate ORDER BY kodtempcert";
            PsqlData.Table_Fill("KCert", sql);

            int kod;

            if (Tables["KCert"].Rows.Count < 1)
                kod = 148469815;
            else
                kod = Convert.ToInt32(Tables["KCert"].Rows[Tables["KCert"].Rows.Count - 1]["kodtempcert"]) + 1;

            sql = "INSERT INTO tempcertificate (kodtempcert) values(" + kod + ")";
            PsqlData.Mod_Execute(sql);

            DataRow row;
            row = Tables["Временный сертификат"].NewRow();

            n = Tables["Временный сертификат"].Rows.Count;
            Tables["Временный сертификат"].Rows.InsertAt(row, n);
            Tables["Временный сертификат"].Rows[n]["Код"] = Convert.ToString(kod);
            dataGridView1.CurrentCell = null;



            Оформление_сертификата сертификат = new Оформление_сертификата();
            сертификат.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Оформление_сертификата сертификат = new Оформление_сертификата();
            сертификат.Show();
        }

        private void Журнал_временного_сертификата_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Tables["Временный сертификат"];
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void Журнал_временного_сертификата_Load(object sender, EventArgs e)
        {
            Font = Параметры.fontDialog1.Font;
            BackColor = Параметры.colorDialog1.Color;
            string sql;

            sql = "SELECT tempcertificate.kodtempcert AS Код, (Client.secondname || ' ' || Client.firstname || ' ' || Client.middlename) AS Клиент, valid AS Действителен, datestart AS \"Дата начала дейст. свидет.\", " +
                "tempcertificate.dateend AS \"Дата окончания дейст. свидет.\", Document.gender AS \"Пол\", Document.datebirth AS \"Дата рождения\", Document.typedocument AS \"Док-т, удост. личность\", " +
                "Document.serianomer AS \"Серия и номер\", Document.dataissue AS \"Дата выдачи\", Document.dateend AS \"Дата окончания дейст. удост.\", Document.issuedby AS \"Выдан\", Document.placebirth AS \"Место рождения\", " +
                "(Representative.secondname || ' ' || Representative.firstname || ' ' || Representative.middlename) AS Представитель, Office.name AS \"Наименование филиала\", " +
                "Office.address AS \"Адрес организации\", Office.telephone AS \"Телефон\" " +
            "FROM tempcertificate INNER JOIN Client ON Client.kodclient = tempcertificate.kodclient " +
                "INNER JOIN Office ON Office.kodoffice = tempcertificate.kodoffice " +
                "INNER JOIN Representative ON Representative.kodrep = tempcertificate.kodrep " +
                "INNER JOIN Document ON Document.koddoc = Client.kodclient " +
            "UNION " +
                "SELECT tempcertificate.kodtempcert, (Client.secondname || ' ' || Client.firstname || ' ' || Client.middlename) AS Клиент, valid, datestart, " +
                    "tempcertificate.dateend, Document.gender, Document.datebirth, Document.typedocument, " +
                    "Document.serianomer, Document.dataissue, Document.dateend, Document.issuedby, Document.placebirth, " +
                    "(Representative.secondname || ' ' || Representative.firstname || ' ' || Representative.middlename) AS Представитель, Office.name, " +
                    "Office.address, Office.telephone " +
                "FROM tempcertificate LEFT OUTER JOIN Client ON Client.kodclient = tempcertificate.kodclient " +
                    "LEFT OUTER JOIN Office ON Office.kodoffice = tempcertificate.kodoffice " +
                    "LEFT OUTER JOIN Representative ON Representative.kodrep = tempcertificate.kodrep " +
                    "LEFT OUTER JOIN Document ON Document.koddoc = Client.kodclient " +
                "WHERE tempcertificate.kodclient Is Null OR tempcertificate.kodrep Is Null OR tempcertificate.kodoffice Is Null " +
            "ORDER BY Код";

            PsqlData.Table_Fill("Временный сертификат", sql);


            dataGridView1.DataSource = Tables["Временный сертификат"];
            radioButton7_CheckedChanged(radioButton7, e);
            //dataGridView1.Sort(dataGridView1.Columns["Код"], ListSortDirection.Ascending);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;

            sql = "SELECT * FROM Client ORDER BY secondname";
            PsqlData.Table_Fill("Клиенты", sql);

            sql = "SELECT kodrep, firstname, middlename, secondname, gender, Representative.telephone, Representative.address AS address, Office.name AS office " +
                "FROM Representative " +
                    "INNER JOIN Office ON Office.kodoffice = Representative.office " +
                " ORDER BY secondname";
            PsqlData.Table_Fill("Представитель", sql);

            sql = "SELECT * FROM Office ORDER BY address";
            PsqlData.Table_Fill("Офис", sql);

            sql = "SELECT * FROM Document ORDER BY koddoc";
            PsqlData.Table_Fill("Документ", sql);

            for (int i = 0; i < Tables["Клиенты"].Rows.Count; i++)
            {
                comboBox1.Items.Add(Tables["Клиенты"].Rows[i]["secondname"].ToString() + ' ' +
                    Tables["Клиенты"].Rows[i]["firstname"].ToString() + ' ' +
                    Tables["Клиенты"].Rows[i]["middlename"].ToString());
            }

            for (int i = 0; i < Tables["Представитель"].Rows.Count; i++)
            {
                comboBox2.Items.Add(Tables["Представитель"].Rows[i]["secondname"].ToString() + ' ' +
                    Tables["Представитель"].Rows[i]["firstname"].ToString() + ' ' +
                    Tables["Представитель"].Rows[i]["middlename"].ToString());
            }

            for (int i = 0; i < Tables["Офис"].Rows.Count; i++)
            {
                comboBox4.Items.Add(Tables["Офис"].Rows[i]["name"].ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = dataGridView1.CurrentRow.Index;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql;
            string message;

            try
            {
                message = "Вы точно хотите удалить временное свидетельство с номером " + dataGridView1.Rows[n].Cells["Код"].Value + "?";
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не указана удаляемая запись таблицы", "Ошибка");
                return;
            }
            string caption = "Удаление временного свидетельства";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult rezult = MessageBox.Show(message, caption, buttons);
            if (rezult == DialogResult.No)
                return;

            sql = "DELETE FROM tempcertificate WHERE kodtempcert=" + dataGridView1.Rows[n].Cells["Код"].Value;
            PsqlData.Mod_Execute(sql);
            Tables["Временный сертификат"].Rows.RemoveAt(n);
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;

            n = -1;
        }

        private void Журнал_временного_сертификата_FormClosed(object sender, FormClosedEventArgs e)
        {
            n = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application Excel_ = new Excel.Application();
                Excel_.Visible = true;
                Excel.Workbook WorkBook_ = Excel_.Workbooks.Add();

                Excel.Worksheet Sheet_ = (Excel.Worksheet)WorkBook_.Sheets[1];

                int i, j;
                object output;

                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Sheet_.Cells[1, j + 1].Value = dataGridView1.Columns[j].HeaderText;
                }

                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        output = dataGridView1.Rows[i].Cells[j].Value;
                        if (dataGridView1.Rows[i].Cells[j].Value.Equals(true))
                            output = "Да";

                        if (dataGridView1.Rows[i].Cells[j].Value.Equals(false))
                            output = "Нет";

                        Sheet_.Cells[i + 2, j + 1].Value = output;
                    }
                }

                Sheet_.Range[Sheet_.Cells[1, 1], Sheet_.Cells[i + 1, j]].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                Sheet_.Cells.Columns.EntireColumn.AutoFit();
                Sheet_.Range[Sheet_.Cells[1, 1], Sheet_.Cells[1, j]].HorizontalAlignment = 3;
                Sheet_.Range[Sheet_.Cells[2, 1], Sheet_.Cells[i + 1, j]].HorizontalAlignment = 2;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка. Попробуйте еще раз.", "Ошибка");
                return;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "Действителен = true";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "Действителен = false";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "Клиент = '" + comboBox1.Text + "'";
            radioButton5.Checked = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "Представитель = '" + comboBox2.Text + "'";
            radioButton6.Checked = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "[Наименование филиала] = '" + comboBox4.Text + "'";
            radioButton8.Checked = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 1)
                Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата окончания дейст. свидет.] >= '" + dateTimePicker1.Value.Date + "' AND [Дата окончания дейст. свидет.] <= '" + dateTimePicker2.Value.Date + "'";
            else
                Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата начала дейст. свидет.] >= '" + dateTimePicker1.Value.Date + "' AND [Дата начала дейст. свидет.] <= '" + dateTimePicker2.Value.Date + "'";
            radioButton4.Checked = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 1)
                Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата окончания дейст. свидет.] = '" + dateTimePicker1.Value.Date + "'";
            else
                Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата начала дейст. свидет.] = '" + dateTimePicker1.Value.Date + "'";
            radioButton3.Checked = true;
        }

        private void radioButton3_CheckedChangedEvent(object sender, EventArgs e)
        {
            if (radioButton4.Checked == false)
            {
                if (comboBox3.SelectedIndex == 1)
                    Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата окончания дейст. свидет.] = '" + dateTimePicker1.Value.Date + "'";
                else
                    Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата начала дейст. свидет.] = '" + dateTimePicker1.Value.Date + "'";
                radioButton3.Checked = true;
            }
            else
            {
                radioButton4.PerformClick();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                radioButton3.PerformClick();
            }

            if (radioButton4.Checked == true)
            {
                radioButton4.PerformClick();
            }
        }
    }
}
