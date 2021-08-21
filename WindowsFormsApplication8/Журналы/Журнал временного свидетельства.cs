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

namespace TemporaryCertificates
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

        private void CreateButton_Click(object sender, EventArgs e)
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
            DataGridView.CurrentCell = null;



            Оформление_сертификата сертификат = new Оформление_сертификата();
            сертификат.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Оформление_сертификата сертификат = new Оформление_сертификата();
            сертификат.Show();
        }

        private void Журнал_временного_сертификата_Activated(object sender, EventArgs e)
        {
            DataGridView.DataSource = Tables["Временный сертификат"];
            DataGridView.AutoResizeColumns();
            DataGridView.CurrentCell = null;
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


            DataGridView.DataSource = Tables["Временный сертификат"];
            AllRecords_CheckedChanged(AllRecords, e);
            //dataGridView1.Sort(dataGridView1.Columns["Код"], ListSortDirection.Ascending);
            DataGridView.AllowUserToAddRows = false;
            DataGridView.BackgroundColor = SystemColors.Control;
            DataGridView.BorderStyle = BorderStyle.None;
            DataGridView.RowHeadersVisible = false;

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
                ClientCombo.Items.Add(Tables["Клиенты"].Rows[i]["secondname"].ToString() + ' ' +
                    Tables["Клиенты"].Rows[i]["firstname"].ToString() + ' ' +
                    Tables["Клиенты"].Rows[i]["middlename"].ToString());
            }

            for (int i = 0; i < Tables["Представитель"].Rows.Count; i++)
            {
                RepresCombo.Items.Add(Tables["Представитель"].Rows[i]["secondname"].ToString() + ' ' +
                    Tables["Представитель"].Rows[i]["firstname"].ToString() + ' ' +
                    Tables["Представитель"].Rows[i]["middlename"].ToString());
            }

            for (int i = 0; i < Tables["Офис"].Rows.Count; i++)
            {
                OfficeCombo.Items.Add(Tables["Офис"].Rows[i]["name"].ToString());
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = DataGridView.CurrentRow.Index;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string sql;
            string message;

            try
            {
                message = "Вы точно хотите удалить временное свидетельство с номером " + DataGridView.Rows[n].Cells["Код"].Value + "?";
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

            sql = "DELETE FROM tempcertificate WHERE kodtempcert=" + DataGridView.Rows[n].Cells["Код"].Value;
            PsqlData.Mod_Execute(sql);
            Tables["Временный сертификат"].Rows.RemoveAt(n);
            DataGridView.AutoResizeColumns();
            DataGridView.CurrentCell = null;

            n = -1;
        }

        private void Журнал_временного_сертификата_FormClosed(object sender, FormClosedEventArgs e)
        {
            n = -1;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application Excel_ = new Excel.Application();
                Excel_.Visible = true;
                Excel.Workbook WorkBook_ = Excel_.Workbooks.Add();

                Excel.Worksheet Sheet_ = (Excel.Worksheet)WorkBook_.Sheets[1];

                int i, j;
                object output;

                for (j = 0; j < DataGridView.Columns.Count; j++)
                {
                    Sheet_.Cells[1, j + 1].Value = DataGridView.Columns[j].HeaderText;
                }

                for (i = 0; i < DataGridView.Rows.Count; i++)
                {
                    for (j = 0; j < DataGridView.Columns.Count; j++)
                    {
                        output = DataGridView.Rows[i].Cells[j].Value;
                        if (DataGridView.Rows[i].Cells[j].Value.Equals(true))
                            output = "Да";

                        if (DataGridView.Rows[i].Cells[j].Value.Equals(false))
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

        private void AllRecords_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "";
        }

        private void ValidRadio_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "Действителен = true";
        }

        private void NotValidRadio_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "Действителен = false";
        }

        private void ClientRadio_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "Клиент = '" + ClientCombo.Text + "'";
            ClientRadio.Checked = true;
        }

        private void RepresRadio_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "Представитель = '" + RepresCombo.Text + "'";
            RepresRadio.Checked = true;
        }

        private void OfficeRadio_CheckedChanged(object sender, EventArgs e)
        {
            Tables["Временный сертификат"].DefaultView.RowFilter = "[Наименование филиала] = '" + OfficeCombo.Text + "'";
            OfficeRadio.Checked = true;
        }

        private void DatePickerSecond_CheckedChanged(object sender, EventArgs e)
        {
            if (DateTypeCombo.SelectedIndex == 1)
                Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата окончания дейст. свидет.] >= '" + DatePickerFirst.Value.Date + "' AND [Дата окончания дейст. свидет.] <= '" + DatePickerSecond.Value.Date + "'";
            else
                Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата начала дейст. свидет.] >= '" + DatePickerFirst.Value.Date + "' AND [Дата начала дейст. свидет.] <= '" + DatePickerSecond.Value.Date + "'";
            RangeDateRadio.Checked = true;
        }

        private void ExactDateRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (DateTypeCombo.SelectedIndex == 1)
                Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата окончания дейст. свидет.] = '" + DatePickerFirst.Value.Date + "'";
            else
                Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата начала дейст. свидет.] = '" + DatePickerFirst.Value.Date + "'";
            ExactDateRadio.Checked = true;
        }

        private void DatePickerFirst_CheckedChangedEvent(object sender, EventArgs e)
        {
            if (RangeDateRadio.Checked == false)
            {
                if (DateTypeCombo.SelectedIndex == 1)
                    Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата окончания дейст. свидет.] = '" + DatePickerFirst.Value.Date + "'";
                else
                    Tables["Временный сертификат"].DefaultView.RowFilter = "[Дата начала дейст. свидет.] = '" + DatePickerFirst.Value.Date + "'";
                ExactDateRadio.Checked = true;
            }
            else
            {
                RangeDateRadio.PerformClick();
            }
        }

        private void DateTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExactDateRadio.Checked == true)
            {
                ExactDateRadio.PerformClick();
            }

            if (RangeDateRadio.Checked == true)
            {
                RangeDateRadio.PerformClick();
            }
        }
    }
}
