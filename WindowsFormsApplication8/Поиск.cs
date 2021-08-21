using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TemporaryCertificates
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
            DataGridView.AutoResizeColumns();
            DataGridView.CurrentCell = null;
            int width = this.Size.Width;
            int height = groupBox1.Size.Height + DataGridView.PreferredSize.Height + 71;
            System.Drawing.Size form_size = new System.Drawing.Size(width, height);
            System.Drawing.Size dg_size = new System.Drawing.Size(DataGridView.Size.Width, DataGridView.PreferredSize.Height);

            DataGridView.Size = dg_size;
            this.Size = form_size;
        }

        private void Поиск_Load(object sender, EventArgs e)
        {
            Font = Параметры.fontDialog1.Font;
            BackColor = Параметры.colorDialog1.Color;
            if (Авторизация.polzov != "Администратор")
            {
                FindRepRadio.Visible = false;
                RepresField.Visible = false;
                RepresValue.Visible = false;
                FindOfficeRadio.Visible = false;
                OfficeField.Visible = false;
                OfficeValue.Visible = false;
                AllOfficeRadio.Visible = false;
                AllRepRadio.Visible = false;
            }

            string sql;
            PsqlData.connection.Open();

            sql = "SELECT kodclient AS \"Код клиента\", (secondname || ' ' || firstname || ' ' || middlename) AS Клиент, gender AS Пол, " +
                    "telephone AS \"Телефон\", address AS \"Адрес\", snils AS \"СНИЛС\", typedocument AS \"Тип документа удост. личн.\", " + 
                    " serianomer \"Серия и номер\", datebirth AS \"Дата рождения\", placebirth AS \"Место рождения\", dataissue AS \"Дата выдачи\", dateend AS \"Дата окончания дейст.\", issuedby AS Выдан " +
                "FROM Client INNER JOIN Document ON Document.koddoc = Client.kodclient " +
                "ORDER BY Клиент";

            PsqlData.Table_Fill("Поиск_клиент", sql);

            DataGridView.DataSource = Tables["Поиск_клиент"];
            Tables["Поиск_клиент"].DefaultView.RowFilter = "";
            //dataGridView1.Columns[0].Visible = false;
            DataGridView.BackgroundColor = SystemColors.Control;
            DataGridView.BorderStyle = BorderStyle.None;
            DataGridView.RowHeadersVisible = false;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.Enabled = true;

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
                ClientField.Items.Add(Tables["Поиск_клиент"].Columns[i].ColumnName);
            }

            for (int i = 0; i < Tables["Поиск_представитель"].Columns.Count; i++)
            {
                RepresField.Items.Add(Tables["Поиск_представитель"].Columns[i].ColumnName);
            }

            for (int i = 0; i < Tables["Поиск_офис"].Columns.Count; i++)
            {
                OfficeField.Items.Add(Tables["Поиск_офис"].Columns[i].ColumnName);
            }
        }

        private void Поиск_Activated(object sender, EventArgs e)
        {
            if (DateClientFirst.Visible)
                DateClientLast.Visible = Параметры_поиска.typeSearchDate;
            else if (RepresDateFirst.Visible)
                RepresDateLast.Visible = Параметры_поиска.typeSearchDate;
            else if (OfficeDateFirst.Visible)
                OfficeDateLast.Visible = Параметры_поиска.typeSearchDate;

            DataGridView.AutoResizeColumns();
            DataGridView.CurrentCell = null;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Excel.Application Excel_ = new Excel.Application();
            Excel_.Visible = true;
            Excel.Workbook WorkBook_ = Excel_.Workbooks.Add();

            Excel.Worksheet Sheet_ = (Excel.Worksheet)WorkBook_.Sheets[1];

            int i, j;

            for (j = 0; j < DataGridView.Columns.Count; j++)
            {
                Sheet_.Cells[1, j + 1].Value = DataGridView.Columns[j].HeaderText;
            }

            for (i = 0; i < DataGridView.Rows.Count; i++)
                for (j = 0; j < DataGridView.Columns.Count; j++)
                    Sheet_.Cells[i + 2, j + 1].Value = DataGridView.Rows[i].Cells[j].Value;

            Sheet_.Range[Sheet_.Cells[1, 1], Sheet_.Cells[i + 1, j]].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            Sheet_.Cells.Columns.EntireColumn.AutoFit();
            Sheet_.Range[Sheet_.Cells[1, 1], Sheet_.Cells[1, j]].HorizontalAlignment = 3;
            Sheet_.Range[Sheet_.Cells[2, 1], Sheet_.Cells[i + 1, j]].HorizontalAlignment = 2;
        }

        private void Поиск_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void AllClientRadio_CheckedChanged(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
            DataGridView.DataSource = Tables["Поиск_клиент"];
            Tables["Поиск_клиент"].DefaultView.RowFilter = "";
            resize();
        }

        private void AllRepRadio_CheckedChanged(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
            DataGridView.DataSource = Tables["Поиск_представитель"];
            Tables["Поиск_представитель"].DefaultView.RowFilter = "";
            resize();
        }

        private void AllOfficeRadio_CheckedChanged(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
            DataGridView.DataSource = Tables["Поиск_офис"];
            Tables["Поиск_офис"].DefaultView.RowFilter = "";
            resize();
        }

        private void FindClientRadio_CheckedChanged(object sender, EventArgs e)
        {
            ElementsChoose el_values = new ElementsChoose(ClientValue, ClientValueCombo, DateClientFirst, DateClientLast, ClientField);
            FindClientRadio.Checked = true;

            if (ClientValue.Text == "" && ClientValue.Visible)
                return;

            if (el_values.OfficeField.Text == "")
            {
                MessageBox.Show("Вы не выбрали поле для поиска клиента!", "Ошибка");
                return;
            }

            for (int i = 0; i < Tables["Поиск_клиент"].Columns.Count; i++)
            {
                if (Tables["Поиск_клиент"].Columns[i].ColumnName == el_values.OfficeField.Text)
                    break;

                if (i == Tables["Поиск_клиент"].Columns.Count - 1)
                {
                    MessageBox.Show("Не изменяйте значения вручную в элементах выбора! Значения необходимо выбирать из списка.", "Ошибка");
                    return;
                }
            }

            DataGridView.DataSource = Tables["Поиск_клиент"];
            el_values.Search(FindClientRadio);
            resize();
        }

        private void ClientField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ElementsChoose elements = new ElementsChoose(ClientValue, ClientValueCombo, DateClientFirst, DateClientLast, ClientField);
            string[] items = new Massives().docItems;

            switch (elements.OfficeField.SelectedItem)
            {
                case "Код клиента":
                    elements.Choose_element(1, 1);
                    break;
                case "Клиент":
                    elements.Choose_element(2, 1);
                    for (int i = 0; i < Tables["Поиск_клиент"].Rows.Count; i++)
                    {
                        elements.OfficeValueCombo.Items.Add(Tables["Поиск_клиент"].Rows[i]["Клиент"].ToString());
                    }
                    break;
                case "Пол":
                    elements.Choose_element(2, 1);
                    elements.OfficeValueCombo.Items.Add("Мужской");
                    elements.OfficeValueCombo.Items.Add("Женский");
                    break;
                case "Телефон":
                    elements.Choose_element(1, 1);
                    elements.OfficeValue.Text = "+7 (777) 777-77-77";
                    break;
                case "Адрес":
                    elements.Choose_element(1, 1);
                    break;
                case "СНИЛС":
                    elements.Choose_element(1, 1);
                    break;
                case "Тип документа удост. личн.":
                    elements.Choose_element(2, 1);
                    elements.OfficeValueCombo.Items.AddRange(items);
                    break;
                case "Серия и номер":
                    elements.Choose_element(1, 1);
                    break;
                case "Дата рождения":
                    elements.Choose_element(3, 1);
                    break;
                case "Место рождения":
                    elements.Choose_element(1, 1);
                    break;
                case "Дата выдачи":
                    elements.Choose_element(3, 1);
                    break;
                case "Дата окончания дейст.":
                    elements.Choose_element(3, 1);
                    break;
                case "Выдан":
                    break;
                default: break;
            }
        }

        private void FindRepRadio_Click(object sender, EventArgs e)
        {
            ElementsChoose el_values = new ElementsChoose(RepresValue, RepresValueCombo, RepresDateFirst, RepresDateLast, RepresField);
            FindRepRadio.Checked = true;

            if (RepresValue.Text == "" && RepresValue.Visible)
                return;

            if (el_values.OfficeField.Text == "")
            {
                MessageBox.Show("Вы не выбрали поле для поиска представителя!", "Ошибка");
                return;
            }

            for (int i = 0; i < Tables["Поиск_представитель"].Columns.Count; i++)
            {
                if (Tables["Поиск_представитель"].Columns[i].ColumnName == el_values.OfficeField.Text)
                    break;

                if (i == Tables["Поиск_представитель"].Columns.Count - 1)
                {
                    MessageBox.Show("Не изменяйте значения вручную в элементах выбора, а выбирайте из списка!", "Ошибка");
                    return;
                }
            }

            DataGridView.DataSource = Tables["Поиск_представитель"];
            el_values.Search(FindRepRadio);
            resize();
        }

        private void FindOfficeRadio_Click(object sender, EventArgs e)
        {
            ElementsChoose el_values = new ElementsChoose(OfficeValue, OfficeValueCombo, OfficeDateFirst, OfficeDateLast, OfficeField);
            FindOfficeRadio.Checked = true;

            if (OfficeValue.Text == "" && OfficeValue.Visible)
                return;

            if (el_values.OfficeField.Text == "")
            {
                MessageBox.Show("Вы не выбрали поле для поиска офиса!", "Ошибка");
                return;
            }

            for (int i = 0; i < Tables["Поиск_офис"].Columns.Count; i++)
            {
                if (Tables["Поиск_офис"].Columns[i].ColumnName == el_values.OfficeField.Text)
                    break;

                if (i == Tables["Поиск_офис"].Columns.Count - 1)
                {
                    MessageBox.Show("Не изменяйте значения вручную в элементах выбора, а выбирайте из списка!", "Ошибка");
                    return;
                }
            }

            DataGridView.DataSource = Tables["Поиск_офис"];
            el_values.Search(FindOfficeRadio);
            resize();
        }

        private void RepresField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ElementsChoose elements = new ElementsChoose(RepresValue, RepresValueCombo, RepresDateFirst, RepresDateLast, RepresField);

            switch (elements.OfficeField.SelectedItem)
            {
                case "Код представителя":
                    elements.Choose_element(1, 2);
                    break;
                case "Представитель":
                    elements.Choose_element(2, 2);
                    for (int i = 0; i < Tables["Поиск_представитель"].Rows.Count; i++)
                    {
                        elements.OfficeValueCombo.Items.Add(Tables["Поиск_представитель"].Rows[i]["Представитель"].ToString());
                    }
                    break;
                case "Пол":
                    elements.Choose_element(2, 2);
                    elements.OfficeValueCombo.Items.Add("Мужской");
                    elements.OfficeValueCombo.Items.Add("Женский");
                    break;
                case "Телефон":
                    elements.Choose_element(1, 2);
                    elements.OfficeValue.Text = "+7 (777) 777-77-77";
                    break;
                case "Адрес":
                    elements.Choose_element(1, 2);
                    break;
                case "Офис":
                    elements.Choose_element(2, 2);
                    for (int i = 0; i < Tables["Поиск_офис"].Rows.Count; i++)
                    {
                        elements.OfficeValueCombo.Items.Add(Tables["Поиск_офис"].Rows[i]["Наименование"]);
                    }
                    break;
                default: break;
            }
        }

        private void OfficeField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ElementsChoose elements = new ElementsChoose(OfficeValue, OfficeValueCombo, OfficeDateFirst, OfficeDateLast, OfficeField);

            switch (elements.OfficeField.SelectedItem)
            {
                case "Код офиса":
                    elements.Choose_element(1, 3);
                    break;
                case "Наименование":
                    elements.Choose_element(2, 3);
                    for (int i = 0; i < Tables["Поиск_офис"].Rows.Count; i++)
                    {
                        elements.OfficeValueCombo.Items.Add(Tables["Поиск_офис"].Rows[i]["Наименование"]);
                    }
                    break;
                case "Телефон":
                    elements.Choose_element(1, 3);
                    elements.OfficeValue.Text = "+7 (777) 777-77-77";
                    break;
                case "Адрес":
                    elements.Choose_element(1, 3);
                    break;
                default: break;
            }
        }

        private void EditField_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(DataGridView.Rows[n].Cells[0].Value); 

            switch (DataGridView.Columns[0].HeaderText)
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

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = DataGridView.CurrentRow.Index;
        }

        private void Поиск_FormClosed(object sender, FormClosedEventArgs e)
        {
            n = -1;
        }

        private void SettingFind_Click(object sender, EventArgs e)
        {
            Параметры_поиска параметры = new Параметры_поиска();
            параметры.Show();
            параметры.Activate();
        }
    }
}
