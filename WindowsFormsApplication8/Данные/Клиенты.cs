using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication5
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
            string sql;
            Size size = new Size(201, 20);
            maskedTextBox1.Size = size;
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
            textBox1.Text = Tables["Client"].Rows[n]["kodclient"].ToString();
            textBox2.Text = Tables["Client"].Rows[n]["secondname"].ToString();
            textBox3.Text = Tables["Client"].Rows[n]["firstname"].ToString();
            textBox4.Text = Tables["Client"].Rows[n]["middlename"].ToString();
            comboBox1.Text = Tables["Client"].Rows[n]["gender"].ToString();
            textBox10.Text = Tables["Client"].Rows[n]["koddoc"].ToString();
            comboBox2.Text = Tables["Client"].Rows[n]["typedocument"].ToString();
            maskedTextBox1.Text = Tables["Client"].Rows[n]["telephone"].ToString();
            textBox11.Text = Tables["Client"].Rows[n]["address"].ToString();
            textBox8.Text = Tables["Client"].Rows[n]["snils"].ToString();
            textBox10.Text = Tables["Client"].Rows[n]["koddoc"].ToString();
            maskedTextBox2.Text = Tables["Client"].Rows[n]["serianomer"].ToString();
            textBox7.Text = Tables["Client"].Rows[n]["issuedby"].ToString();
            textBox6.Text = Tables["Client"].Rows[n]["placebirth"].ToString();
            if (Tables["Client"].Rows[n]["dataissue"] != DBNull.Value)
                dateTimePicker1.Value = Convert.ToDateTime(Tables["Client"].Rows[n]["dataissue"]);
            if (Tables["Client"].Rows[n]["datebirth"] != DBNull.Value)
                dateTimePicker2.Value = Convert.ToDateTime(Tables["Client"].Rows[n]["datebirth"]);
            if(Tables["Client"].Rows[n]["dateend"] != DBNull.Value)
                dateTimePicker3.Value = Convert.ToDateTime(Tables["Client"].Rows[n]["dateend"]);

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
            textBox10.Text = "";
            maskedTextBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox7.Text = "";
            dateTimePicker2.Value = Convert.ToDateTime("01.01.2000");
            textBox8.Text = "";
            dateTimePicker3.Value = DateTime.Now;
            textBox6.Text = "";
            textBox11.Text = "";
            comboBox2.Text = "";

            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void MaxN() {
            maxN = Convert.ToInt32(Tables["Client"].Compute("Max(kodclient)", string.Empty)) + 1;
        }

        //В начало
        private void button11_Click(object sender, EventArgs e)
        {
            n = 0;
            if (Tables["Client"].Rows.Count > n)
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
            if (n < Tables["Client"].Rows.Count - 1)
            {
                n++;
                FieldsForm_Fill();
            }
            else if ((n == Tables["Client"].Rows.Count - 1) && (Авторизация.polzov == "Администратор" || Авторизация.polzov == "Представитель"))
            {
                n = Tables["Client"].Rows.Count;
                FieldsForm_Clear();
                textBox1.Text = maxN.ToString();
            }
            else if (n != Tables["Client"].Rows.Count)
            {
                n = Tables["Client"].Rows.Count - 1;
                FieldsForm_Fill();
            }
        }

        //В конец
        private void button6_Click(object sender, EventArgs e)
        {
            if (Авторизация.polzov == "Администратор" || Авторизация.polzov == "Представитель")
            {
                n = Tables["Client"].Rows.Count;
                FieldsForm_Clear();
                textBox1.Text = maxN.ToString();
            }
            else if (n != Tables["Client"].Rows.Count)
            {
                n = Tables["Client"].Rows.Count - 1;
                FieldsForm_Fill();
            }
        }

        //Сохранение        
        private void button7_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < dateTimePicker2.Value)
            {
                MessageBox.Show("Дата выдачи документа, удостоверяющего личность не может быть меньше даты рождения", "Ошибка");
                return;
            }

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox8.Text == "" || comboBox2.Text == "" || maskedTextBox2.Text == "" || textBox7.Text == "" || comboBox1.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                return;
            }

            if (n == Tables["Client"].Rows.Count)
            {
                string sql = "INSERT INTO Client (kodclient, secondname, firstname, middlename, telephone, address, snils) values (" + 
                    textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + maskedTextBox1.Text + 
                    "', '" + textBox11.Text + "', '" + textBox8.Text + "');";

                if (!PsqlData.Mod_Execute(sql))
                {
                    return;
                }

                if (dateTimePicker3.Enabled == false)
                    sql = "INSERT INTO Document (koddoc, typedocument, serianomer, gender, dataissue, issuedby, datebirth, placebirth) values (" + 
                        textBox10.Text + ", '" + comboBox2.Text + "', '" + maskedTextBox2.Text + "', '" + comboBox1.Text + "', '" + dateTimePicker1.Value + "', '" + 
                        textBox7.Text + "', '" + dateTimePicker2.Value + "', '" + textBox6.Text + "');";
                else
                    sql = "INSERT INTO Document (koddoc, typedocument, serianomer, gender, dataissue, dateend, issuedby, datebirth, placebirth) values (" +
                        textBox10.Text + ", '" + comboBox2.Text + "', '" + maskedTextBox2.Text + "', '" + comboBox1.Text + "', '" + dateTimePicker1.Value + "', '" +
                        dateTimePicker3.Value + "', '" + textBox7.Text + "', '" + dateTimePicker2.Value + "', '" + textBox6.Text + "');";

                if (!PsqlData.Mod_Execute(sql))
                {
                    sql = "DELETE FROM Client WHERE kodclient = " + textBox1.Text;
                    PsqlData.Mod_Execute(sql);
                    return;
                }

                if (dateTimePicker3.Enabled == false)
                    Tables["Client"].Rows.Add(new object[] { textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text,
                        maskedTextBox1.Text, textBox11.Text, textBox8.Text, textBox10.Text, comboBox2.Text, maskedTextBox2.Text, comboBox1.Text,
                        dateTimePicker1.Value, DBNull.Value, textBox7.Text, dateTimePicker2.Value, textBox6.Text });
                else
                    Tables["Client"].Rows.Add(new object[] { textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text,
                        maskedTextBox1.Text, textBox11.Text, textBox8.Text, textBox10.Text, comboBox2.Text, maskedTextBox2.Text, comboBox1.Text,
                        dateTimePicker1.Value, dateTimePicker3.Value, textBox7.Text, dateTimePicker2.Value, textBox6.Text });

                MaxN();
            }
            else
            {
                string sql = "UPDATE Client SET secondname='" + textBox2.Text + "', firstname='" + textBox3.Text + 
                    "', middlename='" + textBox4.Text + "', snils='" + textBox8.Text + "', telephone='" + maskedTextBox1.Text + 
                    "', address='" + textBox11.Text + "' WHERE kodclient=" + textBox1.Text + ";";

                PsqlData.Mod_Execute(sql);
                if (dateTimePicker3.Enabled == false)
                    sql = "UPDATE Document SET typedocument = '" + comboBox2.Text + "', serianomer = '" + maskedTextBox2.Text + "', gender = '" + comboBox1.Text + 
                        "', dataissue = '" + dateTimePicker1.Value + "', issuedby = '" + textBox7.Text + "', placebirth = '" + 
                        textBox6.Text + "', datebirth = '" + dateTimePicker2.Value + "' WHERE koddoc = " + textBox10.Text + ";";
                else
                    sql = "UPDATE Document SET typedocument = '" + comboBox2.Text + "', serianomer = '" + maskedTextBox2.Text + "', gender = '" + comboBox1.Text +
                        "', dataissue = '" + dateTimePicker1.Value + "', dateend = '" + dateTimePicker3.Value + "', issuedby = '" + textBox7.Text + "', placebirth = '" +
                        textBox6.Text + "', datebirth = '" + dateTimePicker2.Value + "' WHERE koddoc = " + textBox10.Text + ";";

                PsqlData.Mod_Execute(sql);

                if(dateTimePicker3.Enabled == false)
                    Tables["Client"].Rows[n].ItemArray = new object[] { textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text,
                        maskedTextBox1.Text, textBox11.Text, textBox8.Text, textBox10.Text, comboBox2.Text, maskedTextBox2.Text, comboBox1.Text,
                        dateTimePicker1.Value, DBNull.Value, textBox7.Text, dateTimePicker2.Value, textBox6.Text };
                else
                    Tables["Client"].Rows[n].ItemArray = new object[] { textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text,
                        maskedTextBox1.Text, textBox11.Text, textBox8.Text, textBox10.Text, comboBox2.Text, maskedTextBox2.Text, comboBox1.Text,
                        dateTimePicker1.Value, dateTimePicker3.Value, textBox7.Text, dateTimePicker2.Value, textBox6.Text };

               // "SELECT kodclient, firstname, middlename, secondname, telephone, address, snils, " +
                 //   "koddoc, typedocument, serianomer, gender, dataissue, dateend, issuedby, datebirth, placebirth " +
            }
        }

        //Удаление
        private void button9_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите удалить из картотеки клиента с кодом " + textBox1.Text + "?";
            string caption = "Удаление клиента";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult rezult = MessageBox.Show(message, caption, buttons);
            if (rezult == DialogResult.No) { return; }

            string sql = "DELETE FROM Document WHERE koddoc = " + textBox10.Text;
            PsqlData.Mod_Execute(sql);

            sql = "DELETE FROM Client WHERE kodclient = " + textBox1.Text;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox10.Text = textBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Паспорт": 
                    maskedTextBox2.Mask = "00 00 № 000000"; dateTimePicker3.Enabled = false; break;
                case "Свидетельство о рождении": 
                    maskedTextBox2.Mask = "L???-L??? № 000000"; dateTimePicker3.Enabled = false; break;
                case "Удостоверение сотрудника Евразийской экономической комиссии":
                    maskedTextBox2.Mask = "000000"; dateTimePicker3.Enabled = true; break;
                case "Паспорт гражданина СССР":
                    maskedTextBox2.Mask = "L???-LL 000000"; dateTimePicker3.Enabled = false; break;
                default:
                    maskedTextBox2.Mask = ""; dateTimePicker3.Enabled = true; break;
            }
        }
    }
}
