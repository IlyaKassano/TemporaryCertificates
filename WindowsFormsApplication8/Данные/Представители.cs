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
                Office.Items.Add(Tables["Offices"].Rows[i]["name"].ToString());
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
            KodRep.Text = Tables["Representative"].Rows[n]["kodrep"].ToString();
            LastName.Text = Tables["Representative"].Rows[n]["secondname"].ToString();
            FirstName.Text = Tables["Representative"].Rows[n]["firstname"].ToString();
            SecondName.Text = Tables["Representative"].Rows[n]["middlename"].ToString();
            Gener.Text = Tables["Representative"].Rows[n]["gender"].ToString();
            Telephone.Text = Tables["Representative"].Rows[n]["telephone"].ToString();
            Address.Text = Tables["Representative"].Rows[n]["address"].ToString();
            Office.Text = Tables["Representative"].Rows[n]["name"].ToString();

            KodRep.Enabled = false;
        }

        /// <summary>  
        ///  Очистка значений формы
        /// </summary> 
        private void FieldsForm_Clear()
        {
            KodRep.Text = "";
            LastName.Text = "";
            FirstName.Text = "";
            SecondName.Text = "";
            Gener.Text = "";
            Telephone.Text = "";
            Address.Text = "";
            Office.Text = "";
            KodRep.Enabled = true;
            KodRep.Focus();
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
                KodRep.Text = maxN.ToString();
            }
        }

        //В конец
        private void button6_Click(object sender, EventArgs e)
        {
            n = Tables["Representative"].Rows.Count;
            FieldsForm_Clear();
            KodRep.Text = maxN.ToString();
        }

        //Сохранение        
        private void button7_Click(object sender, EventArgs e)
        {
            if (KodRep.Text == "" || LastName.Text == "" || FirstName.Text == "" || Gener.Text == "" || Office.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                return;
            }

            int kod_off = -1;
            for (int i = 0; i < Tables["Offices"].Rows.Count; i++)
            {
                if (Office.Text == Tables["Offices"].Rows[i]["name"].ToString())
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
                    KodRep.Text + ", '" + LastName.Text + "', '" + FirstName.Text + "', '" + SecondName.Text + "', '" + Gener.Text + "', '" + Telephone.Text + 
                    "', '" + Address.Text + "', " + kod_off + ");";

                PsqlData.Mod_Execute(sql);
                KodRep.Enabled = false;
                Tables["Representative"].Rows.Add(new object[] { KodRep.Text, FirstName.Text, SecondName.Text, LastName.Text,
                    Gener.Text, Telephone.Text, Address.Text, Office.Text });

            }
            else
            {
                string sql = "UPDATE Representative SET secondname='" + LastName.Text + "', firstname='" + FirstName.Text + 
                    "', middlename='" + SecondName.Text + "', gender='" + Gener.Text + "', telephone='" + Telephone.Text + 
                    "', address='" + Address.Text + "', office = " + kod_off + " WHERE kodrep=" + KodRep.Text + ";";

                PsqlData.Mod_Execute(sql);
                Tables["Representative"].Rows[n].ItemArray = new object[] { KodRep.Text, FirstName.Text, SecondName.Text, LastName.Text,
                    Gener.Text, Telephone.Text, Address.Text, Office.Text };
            }
        }

        //Удаление
        private void button9_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите удалить из картотеки представителя с кодом " + KodRep.Text + "?";
            string caption = "Удаление представителя";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult rezult = MessageBox.Show(message, caption, buttons);
            if (rezult == DialogResult.No) { return; }

            string sql = "DELETE FROM Representative WHERE kodrep = " + KodRep.Text;
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
    }
}
