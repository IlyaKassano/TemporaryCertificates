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
using Word = Microsoft.Office.Interop.Word;

namespace TemporaryCertificates
{
    public partial class Оформление_сертификата : Form
    {
        public Оформление_сертификата()
        {
            InitializeComponent();
        }

        DataTableCollection Tables = PsqlData.ds.Tables;

        private void Оформление_сертификата_Load(object sender, EventArgs e)
        {
            Font = Параметры.fontDialog1.Font;
            BackColor = Параметры.colorDialog1.Color;
            if (Авторизация.polzov != "Администратор")
            {
                AddRepres.Visible = false;
                AddOffice.Visible = false;
                OfficeCombo.Enabled = false;
            }

            try
            {
                KodSert.Text = Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Код"].ToString();
                if (Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Дата начала дейст. свидет."] != DBNull.Value)
                    DateStart.Value = Convert.ToDateTime(Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Дата начала дейст. свидет."]);
                else
                    DateStart.Value = DateTime.Now;

                if (Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Дата окончания дейст. свидет."] != DBNull.Value)
                {
                    try
                    {
                        DateEnd.Value = Convert.ToDateTime(Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Дата окончания дейст. свидет."]);
                    }
                    catch (FormatException)
                    {
                        DateTime date = DateTime.Now.AddDays(30);
                        DateEnd.Value = date;
                    }
                }
                else
                {
                    DateEnd.Value = DateTime.Now.AddDays(30);
                }

                if (Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Действителен"] != DBNull.Value)
                    checkBox1.Checked = Convert.ToBoolean(Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Действителен"]);
                
                RepresCombo.Text = Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Представитель"].ToString();
                OfficeCombo.Text = Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Наименование филиала"].ToString();
                ClientCombo.Text = Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Клиент"].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Не указана редактируемая запись таблицы", "Ошибка");
                this.Close();
                return;
            }
            KodSert.Enabled = false;
        }

        public static object kod = null;

        private void Оформление_сертификата_Activated(object sender, EventArgs e)
        {
            RepresCombo.Items.Clear();
            for (int i = 0; i < Tables["Представитель"].Rows.Count; i++)
            {
                RepresCombo.Items.Add(Tables["Представитель"].Rows[i]["secondname"].ToString() + " " +
                    Tables["Представитель"].Rows[i]["firstname"].ToString() + " " +
                    Tables["Представитель"].Rows[i]["middlename"].ToString());
            }

            OfficeCombo.Items.Clear();
            for (int i = 0; i < Tables["Офис"].Rows.Count; i++)
            {
                OfficeCombo.Items.Add(Tables["Офис"].Rows[i]["name"].ToString());
            }

            ClientCombo.Items.Clear();
            for (int i = 0; i < Tables["Клиенты"].Rows.Count; i++)
            {
                ClientCombo.Items.Add(Tables["Клиенты"].Rows[i]["secondname"].ToString() + " " +
                    Tables["Клиенты"].Rows[i]["firstname"].ToString() + " " +
                    Tables["Клиенты"].Rows[i]["middlename"].ToString());
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int kod_rep = 0;
            int kod_office = 0;
            int kod_client = 0;
            int kod_doc = 0;
            int idx_doc = 0;
            int idx_office = 0;
            string sql;

            if (DateEnd.Value <= DateStart.Value)
            {
                MessageBox.Show("Дата окончания действия не может быть меньше или равна дате начала!", "Ошибка");
                return;
            }

            if (ClientCombo.Text == "")
            {
                MessageBox.Show("Вы не выбрали клиента!", "Ошибка");
                return;
            }

            if (RepresCombo.Text == "")
            {
                MessageBox.Show("Вы не выбрали представителя!", "Ошибка");
                return;
            }

            if (OfficeCombo.Text == "")
            {
                MessageBox.Show("Офис не заполнен. Откройте представителей и назначте ему офис!", "Ошибка");
                return;
            }

            for (int i = 0; i < Tables["Представитель"].Rows.Count; i++)
            {
                if (
                    (Tables["Представитель"].Rows[i]["secondname"].ToString() + " " +
                    Tables["Представитель"].Rows[i]["firstname"].ToString() + " " +
                    Tables["Представитель"].Rows[i]["middlename"].ToString()).Equals(RepresCombo.Text)
                )
                {
                    kod_rep = (int)Tables["Представитель"].Rows[i]["kodrep"];
                }
            }

            for (int i = 0; i < Tables["Офис"].Rows.Count; i++)
            {
                if (Tables["Офис"].Rows[i]["name"].ToString().Equals(OfficeCombo.Text))
                {
                    kod_office = (int)Tables["Офис"].Rows[i]["kodoffice"];
                    idx_office = i;
                    break;
                }
            }

            for (int i = 0; i < Tables["Клиенты"].Rows.Count; i++)
            {
                string fioclient = Tables["Клиенты"].Rows[i]["secondname"].ToString() + " " +
                    Tables["Клиенты"].Rows[i]["firstname"].ToString() + " " +
                    Tables["Клиенты"].Rows[i]["middlename"].ToString();

                if (fioclient.Equals(ClientCombo.Text))
                {
                    kod_client = Convert.ToInt32(Tables["Клиенты"].Rows[i]["kodclient"]);
                    idx_doc = i;

                    if (Convert.ToInt32(Tables["Документ"].Rows[i]["koddoc"]) != kod_client)
                    {
                        for (int k = 0; k < Tables["Документ"].Rows.Count; k++)
                        {
                            if (Convert.ToInt32(Tables["Документ"].Rows[k]["koddoc"]) == kod_client)
                            {
                                idx_doc = k;
                                break;
                            }
                        }
                    }
                }

                kod_doc = kod_client;
            }

            sql = "UPDATE tempcertificate SET datestart='" + DateStart.Value + "', dateend= '" + DateEnd.Value.ToString() + "', valid = " +  checkBox1.Checked +
                ", kodclient=" + kod_client + ", kodrep=" + kod_rep + ", kodoffice=" + kod_office + " WHERE kodtempcert=" + KodSert.Text;
            PsqlData.Mod_Execute(sql);

            //DateTime? date = null;

            Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n].ItemArray = new object[]
                { KodSert.Text, ClientCombo.Text, checkBox1.Checked, DateStart.Value, DateEnd.Value, Tables["Документ"].Rows[idx_doc]["gender"], 
                    Tables["Документ"].Rows[idx_doc]["datebirth"], Tables["Документ"].Rows[idx_doc]["typedocument"], Tables["Документ"].Rows[idx_doc]["serianomer"],
                    Tables["Документ"].Rows[idx_doc]["dataissue"], Tables["Документ"].Rows[idx_doc]["dateend"], Tables["Документ"].Rows[idx_doc]["issuedby"], Tables["Документ"].Rows[idx_doc]["placebirth"], 
                    RepresCombo.Text, OfficeCombo.Text, Tables["Офис"].Rows[idx_office]["address"], Tables["Офис"].Rows[idx_office]["telephone"] };

            // Сортировка таблицы
            Tables["Временный сертификат"].DefaultView.Sort = " Код Asc";
            DataSet second = new DataSet();
            second.Tables.Add(Tables["Временный сертификат"].DefaultView.ToTable());
            Tables.Remove(Tables["Временный сертификат"]);
            Tables.Add(second.Tables["Временный сертификат"].DefaultView.ToTable());

            this.Close();
        }

        private void AddRepres_Click(object sender, EventArgs e)
        {
            Представители представители = new Представители();
            представители.Show();
        }

        private void AddOffice_Click(object sender, EventArgs e)
        {
            Офисы офисы = new Офисы();
            офисы.Show();
        }

        private void Оформление_сертификата_FormClosed(object sender, FormClosedEventArgs e)
        {
            Журнал_временного_сертификата.n = -1;
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            Клиенты клиенты = new Клиенты();
            клиенты.Show();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                DialogResult resValid = MessageBox.Show("Данное временное свидетельство недействительно. Вы действительно хотите вывести его на печать?", "Подтверждение", MessageBoxButtons.YesNo);
                if (resValid == DialogResult.No)
                    return;
            }

            string name = "TepmCert" + KodSert.Text + ".doc";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + name;
            DialogResult resPrint = MessageBox.Show("Сохранить файл \"" + name + "\" на рабочем столе?", "Подтверждение", MessageBoxButtons.YesNo);

            if (resPrint == DialogResult.No)
            {
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    path = folderBrowser.SelectedPath + "\\" + name;
                }
            }

            Word.Document doc = null;
            Word.Application app = null;
            try
            { 
                app = new Word.Application();
                string source = Environment.CurrentDirectory + "\\TempCert_template.dotx";
                doc = app.Documents.Open(source);
                //app.Visible = true;
                doc.Activate();

                Word.Bookmarks wBookmarks = doc.Bookmarks;
                Word.Range wRange;

                string addressNTel = null;
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("ru-RU");
                string dateEnd = Convert.ToDateTime(Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Дата окончания дейст. свидет."]).ToString("dd MMMMMMMM yy", culture);
                string dateStart = Convert.ToDateTime(Tables["Временный сертификат"].Rows[Журнал_временного_сертификата.n]["Дата начала дейст. свидет."]).ToString("dd MMMMMMMM yy", culture);
                string[] splDateEnd = dateEnd.Split(' ');
                string[] splDateStart = dateStart.Split(' ');
                string FIOClient = ClientCombo.Text;
                string FIORepresentative = RepresCombo.Text;
                string genderFemale = "";
                string genderMale = "";
                string info = "";
                string kodTempCert = KodSert.Text;
                string nameOrg = "АО \"МАКС-М\"";
                string placeBirth = "";


                for (int i = 0; i < Tables["Клиенты"].Rows.Count; i++)
                {
                    string fiocl = Tables["Клиенты"].Rows[i]["secondname"].ToString() + " " +
                        Tables["Клиенты"].Rows[i]["firstname"].ToString() + " " +
                        Tables["Клиенты"].Rows[i]["middlename"].ToString();

                    if (fiocl.Equals(FIOClient))
                    {
                        int kod_cl = Convert.ToInt32(Tables["Клиенты"].Rows[i]["kodclient"]);
                        int idx_doc = Convert.ToInt32(Tables["Документ"].Rows[i]["koddoc"]);
                        
                        if (idx_doc != kod_cl)
                        {
                            for (int k = 0; k < Tables["Документ"].Rows.Count; k++)
                            {
                                if (Convert.ToInt32(Tables["Документ"].Rows[k]["koddoc"]) == kod_cl)
                                {
                                    idx_doc = k;
                                }
                            }
                        }

                        info = Tables["Документ"].Rows[idx_doc]["datebirth"].ToString().Split(' ')[0] + "    " +
                            Tables["Документ"].Rows[idx_doc]["typedocument"].ToString() + "    " +
                            Tables["Документ"].Rows[idx_doc]["serianomer"].ToString() + "    " +
                            Tables["Документ"].Rows[idx_doc]["dataissue"].ToString().Split(' ')[0] + "    " +
                            Tables["Документ"].Rows[idx_doc]["issuedby"].ToString();

                        if (Tables["Документ"].Rows[kod_cl]["gender"].ToString().Equals("Мужской"))
                        {
                            genderMale = "V";
                        }
                        else if (Tables["Документ"].Rows[kod_cl]["gender"].ToString().Equals("Женский"))
                        {
                            genderFemale = "V";
                        }

                        placeBirth = Tables["Документ"].Rows[idx_doc]["placeBirth"].ToString();

                        break;
                    }
                }

                if (FIOClient == null)
                {
                    MessageBox.Show("Не удалось заполнить ФИО клиента.\nПопробуйте еще раз или введите данные вручную", "Ошибка");
                }

                for (int i = 0; i < Tables["Офис"].Rows.Count; i++)
                {
                    if (Tables["Офис"].Rows[i]["name"].ToString().Equals(OfficeCombo.Text))
                    {
                        addressNTel = Tables["Офис"].Rows[i]["address"].ToString() +
                            '\t' + Tables["Офис"].Rows[i]["telephone"].ToString();
                    }
                }

                if (addressNTel == null)
                {
                    MessageBox.Show("Неудалось заполнить данные офиса.\nПопробуйте еще раз или введите данные вручную", "Ошибка");
                }

                int j = 0;
                string[] data = new string[15] { addressNTel, splDateEnd[0], splDateEnd[1], splDateEnd[2],
                    splDateStart[0], splDateStart[1], splDateStart[2], FIOClient, FIORepresentative, 
                    genderFemale, genderMale, info, kodTempCert, nameOrg, placeBirth };

                foreach (Word.Bookmark mark in wBookmarks)
                {
                    wRange = mark.Range;
                    wRange.Text = data[j];
                    j++;
                }

                doc.SaveAs2(path);
                doc.Close();
                app.Quit();
                //doc = null;
            }
            catch (Exception error)
            {
                if (doc != null)
                    doc.Close();
                app.Quit();
                doc = null;
                app = null;
            }
        }

        private void RepresCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tables["Представитель"].Rows.Count; i++)
            {
                if (
                    (Tables["Представитель"].Rows[i]["secondname"].ToString() + " " +
                    Tables["Представитель"].Rows[i]["firstname"].ToString() + " " +
                    Tables["Представитель"].Rows[i]["middlename"].ToString()).Equals(RepresCombo.Text)
                )
                {
                    OfficeCombo.Text = Tables["Представитель"].Rows[i]["office"].ToString();
                    break;
                }
            }
        }
    }
}
