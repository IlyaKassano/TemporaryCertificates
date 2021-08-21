using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TemporaryCertificates
{
    public partial class Клиенты : Form
    {
        public Клиенты(int kod = -1)
        {
            InitializeComponent();
            Font = Параметры.fontDialog1.Font;
            BackColor = Параметры.colorDialog1.Color;

            string sql = "SELECT kodclient, firstname, middlename, secondname, telephone, address, snils, " +
                    "koddoc, typedocument, serianomer, gender, dataissue, dateend, issuedby, datebirth, placebirth " +
                "FROM Client LEFT OUTER JOIN Document ON Document.koddoc = Client.kodclient " +
                "ORDER BY kodclient";
            PsqlData.Table_Fill("Client", sql);

            if (kod != -1)
            {
                n = Tables["Client"].Rows.IndexOf(Tables["Client"].Select("kodclient = " + kod).First());
                FieldsForm_Fill();
            }
        }   
        /// <summary>  
        ///  Номер записи
        /// </summary> 
        int n = 0;
        int maxN = 0;
        DataTableCollection Tables = PsqlData.ds.Tables;

        private void Клиенты_Load(object sender, EventArgs e)
        {
            Size size = new Size(201, 20);
            Telephone.Size = size;
            MaxN();

            PsqlData.connection.Close();

            if (Tables["Client"].Rows.Count > n)
            {
                FieldsForm_Fill();
            }
        }

        /// <summary>  
        ///  Заполнение формы значениями из таблицы БД
        /// </summary> 
        private void FieldsForm_Fill()
        {
            KodClient.Text = Tables["Client"].Rows[n]["kodclient"].ToString();
            LastName.Text = Tables["Client"].Rows[n]["secondname"].ToString();
            FirstName.Text = Tables["Client"].Rows[n]["firstname"].ToString();
            SecondName.Text = Tables["Client"].Rows[n]["middlename"].ToString();
            Gender.Text = Tables["Client"].Rows[n]["gender"].ToString();
            KodDoc.Text = Tables["Client"].Rows[n]["koddoc"].ToString();
            DocName.Text = Tables["Client"].Rows[n]["typedocument"].ToString();
            Telephone.Text = Tables["Client"].Rows[n]["telephone"].ToString();
            Address.Text = Tables["Client"].Rows[n]["address"].ToString();
            Snils.Text = Tables["Client"].Rows[n]["snils"].ToString();
            KodDoc.Text = Tables["Client"].Rows[n]["koddoc"].ToString();
            SeriaNomer.Text = Tables["Client"].Rows[n]["serianomer"].ToString();
            IssuedBy.Text = Tables["Client"].Rows[n]["issuedby"].ToString();
            PlaceBirth.Text = Tables["Client"].Rows[n]["placebirth"].ToString();
            if (Tables["Client"].Rows[n]["dataissue"] != DBNull.Value)
                DateIssue.Value = Convert.ToDateTime(Tables["Client"].Rows[n]["dataissue"]);
            if (Tables["Client"].Rows[n]["datebirth"] != DBNull.Value)
                DateBirth.Value = Convert.ToDateTime(Tables["Client"].Rows[n]["datebirth"]);
            if(Tables["Client"].Rows[n]["dateend"] != DBNull.Value)
                DateEnd.Value = Convert.ToDateTime(Tables["Client"].Rows[n]["dateend"]);

            KodClient.Enabled = false;
        }

        /// <summary>  
        ///  Очистка значений формы
        /// </summary> 
        private void FieldsForm_Clear()
        {
            KodClient.Text = "";
            LastName.Text = "";
            FirstName.Text = "";
            SecondName.Text = "";
            Gender.Text = "";
            Telephone.Text = "";
            KodDoc.Text = "";
            SeriaNomer.Text = "";
            DateIssue.Value = DateTime.Now;
            IssuedBy.Text = "";
            DateBirth.Value = Convert.ToDateTime("01.01.2000");
            Snils.Text = "";
            DateEnd.Value = DateTime.Now;
            PlaceBirth.Text = "";
            Address.Text = "";
            DocName.Text = "";

            KodClient.Enabled = true;
            KodClient.Focus();
        }

        private void MaxN() {
            maxN = Convert.ToInt32(Tables["Client"].Compute("Max(kodclient)", string.Empty)) + 1;
        }

        private void KodClient_TextChanged(object sender, EventArgs e)
        {
            KodDoc.Text = KodClient.Text;
        }

        private void FirstRecord_Click(object sender, EventArgs e)
        {
            n = 0;
            if (Tables["Client"].Rows.Count > n)
                FieldsForm_Fill();
        }

        private void PrevRecord_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                n--;
                FieldsForm_Fill();
            }
        }

        private void NextRecord_Click(object sender, EventArgs e)
        {
            if (n < Tables["Client"].Rows.Count - 1)
            {
                n++;
                FieldsForm_Fill();
            }
            else if ((n == Tables["Client"].Rows.Count - 1) && (Авторизация.polzov == "Администратор" || Авторизация.polzov == "Представитель"))
            {
                n = Tables["Client"].Rows.Count;
                FieldsForm_Clear();
                KodClient.Text = maxN.ToString();
            }
            else if (n != Tables["Client"].Rows.Count)
            {
                n = Tables["Client"].Rows.Count - 1;
                FieldsForm_Fill();
            }
        }

        private void LastRecord_Click(object sender, EventArgs e)
        {
            if (Авторизация.polzov == "Администратор" || Авторизация.polzov == "Представитель")
            {
                n = Tables["Client"].Rows.Count;
                FieldsForm_Clear();
                KodClient.Text = maxN.ToString();
            }
            else if (n != Tables["Client"].Rows.Count)
            {
                n = Tables["Client"].Rows.Count - 1;
                FieldsForm_Fill();
            }
        }

        private void SaveRecord_Click(object sender, EventArgs e)
        {
            if (DateIssue.Value < DateBirth.Value)
            {
                MessageBox.Show("Дата выдачи документа, удостоверяющего личность не может быть меньше даты рождения", "Ошибка");
                return;
            }

            if (KodClient.Text == "" || LastName.Text == "" || FirstName.Text == "" || Snils.Text == "" || DocName.Text == "" || SeriaNomer.Text == "" || IssuedBy.Text == "" || Gender.Text == "" || PlaceBirth.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                return;
            }

            if (n == Tables["Client"].Rows.Count)
            {
                string sql = "INSERT INTO Client (kodclient, secondname, firstname, middlename, telephone, address, snils) values (" +
                    KodClient.Text + ", '" + LastName.Text + "', '" + FirstName.Text + "', '" + SecondName.Text + "', '" + Telephone.Text +
                    "', '" + Address.Text + "', '" + Snils.Text + "');";

                if (!PsqlData.Mod_Execute(sql))
                {
                    return;
                }

                if (DateEnd.Enabled == false)
                    sql = "INSERT INTO Document (koddoc, typedocument, serianomer, gender, dataissue, issuedby, datebirth, placebirth) values (" +
                        KodDoc.Text + ", '" + DocName.Text + "', '" + SeriaNomer.Text + "', '" + Gender.Text + "', '" + DateIssue.Value + "', '" +
                        IssuedBy.Text + "', '" + DateBirth.Value + "', '" + PlaceBirth.Text + "');";
                else
                    sql = "INSERT INTO Document (koddoc, typedocument, serianomer, gender, dataissue, dateend, issuedby, datebirth, placebirth) values (" +
                        KodDoc.Text + ", '" + DocName.Text + "', '" + SeriaNomer.Text + "', '" + Gender.Text + "', '" + DateIssue.Value + "', '" +
                        DateEnd.Value + "', '" + IssuedBy.Text + "', '" + DateBirth.Value + "', '" + PlaceBirth.Text + "');";

                if (!PsqlData.Mod_Execute(sql))
                {
                    sql = "DELETE FROM Client WHERE kodclient = " + KodClient.Text;
                    PsqlData.Mod_Execute(sql);
                    return;
                }

                if (DateEnd.Enabled == false)
                    Tables["Client"].Rows.Add(new object[] { KodClient.Text, FirstName.Text, SecondName.Text, LastName.Text,
                        Telephone.Text, Address.Text, Snils.Text, KodDoc.Text, DocName.Text, SeriaNomer.Text, Gender.Text,
                        DateIssue.Value, DBNull.Value, IssuedBy.Text, DateBirth.Value, PlaceBirth.Text });
                else
                    Tables["Client"].Rows.Add(new object[] { KodClient.Text, FirstName.Text, SecondName.Text, LastName.Text,
                        Telephone.Text, Address.Text, Snils.Text, KodDoc.Text, DocName.Text, SeriaNomer.Text, Gender.Text,
                        DateIssue.Value, DateEnd.Value, IssuedBy.Text, DateBirth.Value, PlaceBirth.Text });

                MaxN();
            }
            else
            {
                string sql = "UPDATE Client SET secondname='" + LastName.Text + "', firstname='" + FirstName.Text +
                    "', middlename='" + SecondName.Text + "', snils='" + Snils.Text + "', telephone='" + Telephone.Text +
                    "', address='" + Address.Text + "' WHERE kodclient=" + KodClient.Text + ";";

                PsqlData.Mod_Execute(sql);
                if (DateEnd.Enabled == false)
                    sql = "UPDATE Document SET typedocument = '" + DocName.Text + "', serianomer = '" + SeriaNomer.Text + "', gender = '" + Gender.Text +
                        "', dataissue = '" + DateIssue.Value + "', issuedby = '" + IssuedBy.Text + "', placebirth = '" +
                        PlaceBirth.Text + "', datebirth = '" + DateBirth.Value + "' WHERE koddoc = " + KodDoc.Text + ";";
                else
                    sql = "UPDATE Document SET typedocument = '" + DocName.Text + "', serianomer = '" + SeriaNomer.Text + "', gender = '" + Gender.Text +
                        "', dataissue = '" + DateIssue.Value + "', dateend = '" + DateEnd.Value + "', issuedby = '" + IssuedBy.Text + "', placebirth = '" +
                        PlaceBirth.Text + "', datebirth = '" + DateBirth.Value + "' WHERE koddoc = " + KodDoc.Text + ";";

                PsqlData.Mod_Execute(sql);

                if (DateEnd.Enabled == false)
                    Tables["Client"].Rows[n].ItemArray = new object[] { KodClient.Text, FirstName.Text, SecondName.Text, LastName.Text,
                        Telephone.Text, Address.Text, Snils.Text, KodDoc.Text, DocName.Text, SeriaNomer.Text, Gender.Text,
                        DateIssue.Value, DBNull.Value, IssuedBy.Text, DateBirth.Value, PlaceBirth.Text };
                else
                    Tables["Client"].Rows[n].ItemArray = new object[] { KodClient.Text, FirstName.Text, SecondName.Text, LastName.Text,
                        Telephone.Text, Address.Text, Snils.Text, KodDoc.Text, DocName.Text, SeriaNomer.Text, Gender.Text,
                        DateIssue.Value, DateEnd.Value, IssuedBy.Text, DateBirth.Value, PlaceBirth.Text };

                // "SELECT kodclient, firstname, middlename, secondname, telephone, address, snils, " +
                //   "koddoc, typedocument, serianomer, gender, dataissue, dateend, issuedby, datebirth, placebirth " +
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите удалить из картотеки клиента с кодом " + KodClient.Text + "?";
            string caption = "Удаление клиента";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult rezult = MessageBox.Show(message, caption, buttons);
            if (rezult == DialogResult.No) { return; }

            string sql = "DELETE FROM Document WHERE koddoc = " + KodDoc.Text;
            PsqlData.Mod_Execute(sql);

            sql = "DELETE FROM Client WHERE kodclient = " + KodClient.Text;
            PsqlData.Mod_Execute(sql);

            try
            {
                Tables["Client"].Rows.RemoveAt(n);
                MaxN();
            }
            catch (IndexOutOfRangeException)
            {
            }

            if (Tables["Client"].Rows.Count > n)
            {
                FieldsForm_Fill();
            }
            else
            {
                FieldsForm_Clear();
            }
        }

        private void DocName_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DocName.Text)
            {
                case "Паспорт":
                    SeriaNomer.Mask = "00 00 № 000000"; DateEnd.Enabled = false; break;
                case "Свидетельство о рождении":
                    SeriaNomer.Mask = "L???-L??? № 000000"; DateEnd.Enabled = false; break;
                case "Удостоверение сотрудника Евразийской экономической комиссии":
                    SeriaNomer.Mask = "000000"; DateEnd.Enabled = true; break;
                case "Паспорт гражданина СССР":
                    SeriaNomer.Mask = "L???-LL 000000"; DateEnd.Enabled = false; break;
                default:
                    SeriaNomer.Mask = ""; DateEnd.Enabled = true; break;
            }
        }
    }
}