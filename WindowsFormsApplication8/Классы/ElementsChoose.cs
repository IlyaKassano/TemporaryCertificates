using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemporaryCertificates
{
    class ElementsChoose
    {
        TextBox officeValue;
        ComboBox officeValueCombo;
        ComboBox officeField;
        DateTimePicker officeDateFirst;
        DateTimePicker officeDateLast;

        public ElementsChoose(TextBox OfficeValue, ComboBox OfficeValueCombo, DateTimePicker OfficeDateFirst, DateTimePicker OfficeDateLast, ComboBox OfficeField)
        {
            officeValue = OfficeValue;
            officeValueCombo = OfficeValueCombo;
            officeDateFirst = OfficeDateFirst;
            officeDateLast = OfficeDateLast;
            officeField = OfficeField;
        }
        public TextBox OfficeValue
        {
            get { return officeValue; }
            set { officeValue = value; }
        }

        public ComboBox OfficeValueCombo
        {
            get { return officeValueCombo; }
            set { officeValueCombo = value; }
        }

        public DateTimePicker OfficeDateFirst
        {
            get { return officeDateFirst; }
            set { officeDateFirst = value; }
        }

        public DateTimePicker OfficeDateLast
        {
            get { return officeDateLast; }
            set { officeDateLast = value; }
        }

        public ComboBox OfficeField
        {
            get { return officeField; }
            set { officeField = value; }
        }

        public object SelectedValue
        {
            get
            {
                if (officeValue.Visible == true)
                {
                    switch (officeField.Text)
                    {
                        case "Код клиента":
                        case "Код представителя":
                        case "Код офиса":
                            if (officeValue.Text != "")
                                return Convert.ToInt32(officeValue.Text);
                            break;
                        default: break;
                    }

                    return officeValue.Text;
                }
                else if (officeValueCombo.Visible == true)
                {
                    return officeValueCombo.Text;
                }
                else if (officeDateFirst.Visible == true)
                {
                    return officeDateFirst.Value.Date;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        ///  Определяет где нужно изменить элементы (клиенты, представители, офисы).
        /// </summary>
        /// <param name="idxTable">Индекс таблицы.<br/>0 - Клиент<br/>1 - Представитель<br/>2 - Оффис</param> 
        /// <param name="findRadio"></param>
        public void Search( RadioButton findRadio)
        {
            string table = null;
            string[] tables = { "Поиск_клиент", "Поиск_представитель", "Поиск_офис" };

            switch (findRadio.Name)
            { 
                case "FindClientRadio":
                    table = tables[0];
                    break;
                case "FindRepRadio":
                    table = tables[1];
                    break;
                case "FindOfficeRadio":
                    table = tables[2];
                    break;
            }

            if (SelectedValue.GetType().Name == "Int32")
            {
                PsqlData.ds.Tables[table].DefaultView.RowFilter = "[" + OfficeField.Text + "] = " + SelectedValue.ToString();
            }
            else
            {
                if (officeDateFirst.Visible && Параметры_поиска.typeSearchDate)
                {
                    if (OfficeDateFirst.Value > OfficeDateLast.Value)
                    {
                        MessageBox.Show("Второй элемент даты (правый) не может быть меньше первого!", "Ошибка");
                        findRadio.Checked = false;
                        return;
                    }

                    PsqlData.ds.Tables[table].DefaultView.RowFilter = "[" + OfficeField.Text + "] >= '" + SelectedValue.ToString() + "' AND " + "[" + OfficeField.Text + "] <= '" + OfficeDateLast.Value.Date.ToString() + "'";
                }
                else if (officeDateFirst.Visible)
                {
                    PsqlData.ds.Tables[table].DefaultView.RowFilter = "[" + OfficeField.Text + "] = '" + SelectedValue.ToString() + "'";
                }
                else
                {
                    if (!Параметры_поиска.typeSearchString)
                        PsqlData.ds.Tables[table].DefaultView.RowFilter = "[" + OfficeField.Text + "] = '" + SelectedValue.ToString() + "'";
                    else
                        PsqlData.ds.Tables[table].DefaultView.RowFilter = "[" + OfficeField.Text + "] LIKE '*" + SelectedValue.ToString() + "*'";
                }
            }
        }

        public void Choose_element(int el, int radioNum)
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
            officeValue.Text = "";
            officeValueCombo.Items.Clear();
            officeValueCombo.Text = "";
            officeDateFirst.Value = DateTime.Now;
            officeDateLast.Value = DateTime.Now;

            switch (el)
            {
                case 1:
                    officeValue.Visible = true;
                    officeValue.Location = cl_location;
                    officeValueCombo.Visible = false;
                    officeDateFirst.Visible = false;
                    officeDateLast.Visible = false;

                    if (officeValueCombo.Location == cl_location)
                    {
                        officeValueCombo.Location = cl_cbLocation;
                    }
                    else if (officeDateFirst.Location == cl_location)
                    {
                        officeDateFirst.Location = cl_dtp1Location;
                        officeDateLast.Location = cl_dtp2Location;
                    }
                    break;
                case 2:
                    officeValueCombo.Visible = true;
                    officeValueCombo.Location = cl_location;
                    officeValue.Visible = false;
                    officeDateFirst.Visible = false;
                    officeDateLast.Visible = false;

                    if (officeValue.Location == cl_location)
                    {
                        officeValue.Location = cl_cbLocation;
                    }
                    else if (officeDateFirst.Location == cl_location)
                    {
                        officeDateFirst.Location = cl_dtp1Location;
                        officeDateLast.Location = cl_dtp2Location;
                    }
                    break;
                case 3:
                    officeDateFirst.Visible = true;
                    officeDateFirst.Location = cl_location;

                    cl_dtp2Location = new System.Drawing.Point(officeDateFirst.Location.X + dtp2_indent, officeDateFirst.Location.Y);
                    officeDateLast.Visible = Параметры_поиска.typeSearchDate;
                    officeDateLast.Location = cl_dtp2Location;
                    officeValueCombo.Visible = false;
                    officeValue.Visible = false;

                    if (officeValueCombo.Location == cl_location)
                    {
                        officeValueCombo.Location = cl_cbLocation;
                    }
                    else if (officeValue.Location == cl_location)
                    {
                        officeValue.Location = cl_dtp1Location;
                    }
                    break;
                default: break;
            }
        }
    }
}
