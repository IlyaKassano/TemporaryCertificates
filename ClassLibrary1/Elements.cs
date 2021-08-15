using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    class Elements
    {
        TextBox textBox;
        ComboBox comboBox;
        ComboBox comboBoxSel;
        DateTimePicker dtp1;
        DateTimePicker dtp2;

        public Elements(TextBox TextBox, ComboBox ComboBox, DateTimePicker DTP1, DateTimePicker DTP2, ComboBox ComboBoxSel)
        {
            textBox = TextBox;
            comboBox = ComboBox;
            comboBoxSel = ComboBoxSel;
            dtp1 = DTP1;
            dtp2 = DTP2;
        }
        public TextBox textBox_el
        {
            get { return textBox; }
            set { textBox = value; }
        }

        public ComboBox comboBox_el
        {
            get { return comboBox; }
            set { comboBox = value; }
        }

        public DateTimePicker dtp1_el
        {
            get { return dtp1; }
            set { dtp1 = value; }
        }

        public DateTimePicker dtp2_el
        {
            get { return dtp2; }
            set { dtp2 = value; }
        }

        public ComboBox comboBoxSel_el
        {
            get { return comboBoxSel; }
            set { comboBoxSel = value; }
        }

        public object choosen_value
        {
            get
            {
                if (textBox.Visible == true)
                {
                    switch (comboBoxSel.Text)
                    {
                        case "Код клиента":
                        case "Код представителя":
                        case "Код офиса":
                            if (textBox.Text != "")
                                return Convert.ToInt32(textBox.Text);
                            break;
                        default: break;
                    }

                    return textBox.Text;
                }
                else if (comboBox.Visible == true)
                {
                    return comboBox.Text;
                }
                else if (dtp1.Visible == true)
                {
                    return dtp1.Value.Date;
                }
                else
                {
                    return null;
                }
            }
        }

        public void search(Elements el_values, int idxTable, RadioButton rb)
        {
            string[] tables = { "Поиск_клиент", "Поиск_представитель", "Поиск_офис" };
            if (el_values.choosen_value.GetType().Name == "Int32")
            {
                PsqlData.ds.Tables[tables[idxTable]].DefaultView.RowFilter = "[" + el_values.comboBoxSel_el.Text + "] = " + el_values.choosen_value.ToString();
            }
            else
            {
                if (el_values.is_dtp() && Параметры_поиска.typeSearchDate)
                {
                    if (el_values.dtp1_el.Value > el_values.dtp2_el.Value)
                    {
                        MessageBox.Show("Второй элемент даты (правый) не может быть меньше первого!", "Ошибка");
                        rb.Checked = false;
                        return;
                    }

                    PsqlData.ds.Tables[tables[idxTable]].DefaultView.RowFilter = "[" + el_values.comboBoxSel_el.Text + "] >= '" + el_values.choosen_value.ToString() + "' AND " + "[" + el_values.comboBoxSel_el.Text + "] <= '" + el_values.dtp2_el.Value.Date.ToString() + "'";
                }
                else if (el_values.is_dtp())
                {
                    PsqlData.ds.Tables[tables[idxTable]].DefaultView.RowFilter = "[" + el_values.comboBoxSel_el.Text + "] = '" + el_values.choosen_value.ToString() + "'";
                }
                else
                {
                    if (!Параметры_поиска.typeSearchString)
                        PsqlData.ds.Tables[tables[idxTable]].DefaultView.RowFilter = "[" + el_values.comboBoxSel_el.Text + "] = '" + el_values.choosen_value.ToString() + "'";
                    else
                        PsqlData.ds.Tables[tables[idxTable]].DefaultView.RowFilter = "[" + el_values.comboBoxSel_el.Text + "] LIKE '*" + el_values.choosen_value.ToString() + "*'";
                }
            }
        }

        public bool is_dtp()
        {
            return dtp1.Visible;
        }

        public void choose_element(int el, int radioNum)
        {
            int dtp2_indent = 127;
            System.Drawing.Point cl_location;

            switch (radioNum)
            {
                case 1: cl_location = new System.Drawing.Point(440, 38); break;
                case 2: cl_location = new System.Drawing.Point(440, 99); break;
                case 3: cl_location = new System.Drawing.Point(440, 157); break;
                default: cl_location = new System.Drawing.Point(440, 38); break;
            }

            System.Drawing.Point cl_cbLocation = new System.Drawing.Point(cl_location.X, cl_location.Y + 25);
            System.Drawing.Point cl_dtp1Location = new System.Drawing.Point(cl_location.X - 254, cl_location.Y + 26);
            System.Drawing.Point cl_dtp2Location = new System.Drawing.Point(cl_dtp1Location.X + dtp2_indent, cl_dtp1Location.Y);
            textBox.Text = "";
            comboBox.Items.Clear();
            comboBox.Text = "";
            dtp1.Value = DateTime.Now;
            dtp2.Value = DateTime.Now;

            switch (el)
            {
                case 1:
                    textBox.Visible = true;
                    textBox.Location = cl_location;
                    comboBox.Visible = false;
                    dtp1.Visible = false;
                    dtp2.Visible = false;

                    if (comboBox.Location == cl_location)
                    {
                        comboBox.Location = cl_cbLocation;
                    }
                    else if (dtp1.Location == cl_location)
                    {
                        dtp1.Location = cl_dtp1Location;
                        dtp2.Location = cl_dtp2Location;
                    }
                    break;
                case 2:
                    comboBox.Visible = true;
                    comboBox.Location = cl_location;
                    textBox.Visible = false;
                    dtp1.Visible = false;
                    dtp2.Visible = false;

                    if (textBox.Location == cl_location)
                    {
                        textBox.Location = cl_cbLocation;
                    }
                    else if (dtp1.Location == cl_location)
                    {
                        dtp1.Location = cl_dtp1Location;
                        dtp2.Location = cl_dtp2Location;
                    }
                    break;
                case 3:
                    dtp1.Visible = true;
                    dtp1.Location = cl_location;

                    cl_dtp2Location = new System.Drawing.Point(dtp1.Location.X + dtp2_indent, dtp1.Location.Y);
                    dtp2.Visible = Параметры_поиска.typeSearchDate;
                    dtp2.Location = cl_dtp2Location;
                    comboBox.Visible = false;
                    textBox.Visible = false;

                    if (comboBox.Location == cl_location)
                    {
                        comboBox.Location = cl_cbLocation;
                    }
                    else if (textBox.Location == cl_location)
                    {
                        textBox.Location = cl_dtp1Location;
                    }
                    break;
                default: break;
            }
        }
    }
}
