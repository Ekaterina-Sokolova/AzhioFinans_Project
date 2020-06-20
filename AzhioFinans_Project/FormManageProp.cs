using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzhioFinans_Project
{
    public partial class FormManageProp : Form
    {
        public FormManageProp()
        {
            InitializeComponent();
            comboBoxTypeProp.SelectedIndex = 0;
            ShowManageProper();
        }
        public void ShowManageProper()
        {
            listViewRentHouse.Items.Clear();
            listViewRentFloor.Items.Clear();
            listViewMyHouse.Items.Clear();
            listViewMyFloor.Items.Clear();
            foreach (ManageProperty mp in Program.ADb.ManageProperty)
            {
                if (mp.TypeProp == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {

                    mp.Id.ToString(), mp.Name, mp.Surname,
                    mp.Patronymic, mp.DateOfHouse, mp.DedlineHouse

                    });
                    item.Tag = mp;
                    listViewRentHouse.Items.Add(item);
                }
                else if (mp.TypeProp == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {

                    mp.Id.ToString(), mp.Name, mp.Surname,
                    mp.Patronymic, mp.DateOfFloor, mp.DedlineFloor

                    });
                    item.Tag = mp;
                    listViewRentFloor.Items.Add(item);
                }
                else if (mp.TypeProp == 2)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {

                    mp.Id.ToString(), mp.Name, mp.Surname,
                    mp.Patronymic, mp.DateSellHouse

                    });
                    item.Tag = mp;
                    listViewMyHouse.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {

                    mp.Id.ToString(), mp.Name, mp.Surname,
                    mp.Patronymic, mp.DateSellFloor

                    });
                    item.Tag = mp;
                    listViewMyFloor.Items.Add(item);
                }
            }

            listViewRentHouse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRentFloor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewMyHouse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewMyFloor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewRentHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRentHouse.SelectedItems.Count == 1)
            {
                ManageProperty mp = listViewRentHouse.SelectedItems[0].Tag as ManageProperty;
                textBoxName.Text = mp.Name;
                textBoxSurname.Text = mp.Surname;
                textBoxPatronymic.Text = mp.Patronymic;
                textBoxDateRentHouse.Text = mp.DateOfHouse;
                textBoxDedlineHouse.Text = mp.DedlineHouse;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronymic.Text = "";
                textBoxDateRentHouse.Text = "";
                textBoxDedlineHouse.Text = "";
            }
        }

        private void listViewRentFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRentFloor.SelectedItems.Count == 1)
            {
                ManageProperty mp = listViewRentFloor.SelectedItems[0].Tag as ManageProperty;
                textBoxName.Text = mp.Name;
                textBoxSurname.Text = mp.Surname;
                textBoxPatronymic.Text = mp.Patronymic;
                textBoxDateRentFloor.Text = mp.DateOfFloor;
                textBoxDedlineFloor.Text = mp.DedlineFloor;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronymic.Text = "";
                textBoxDateRentFloor.Text = "";
                textBoxDedlineFloor.Text = "";
            }
        }

        private void listViewMyHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMyHouse.SelectedItems.Count == 1)
            {
                ManageProperty mp = listViewMyHouse.SelectedItems[0].Tag as ManageProperty;
                textBoxName.Text = mp.Name;
                textBoxSurname.Text = mp.Surname;
                textBoxPatronymic.Text = mp.Patronymic;
                textBoxDateOfHouse.Text = mp.DateSellHouse;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronymic.Text = "";
                textBoxDateOfHouse.Text = "";
            }
        }

        private void listViewMyFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMyFloor.SelectedItems.Count == 1)
            {
                ManageProperty mp = listViewMyFloor.SelectedItems[0].Tag as ManageProperty;
                textBoxName.Text = mp.Name;
                textBoxSurname.Text = mp.Surname;
                textBoxPatronymic.Text = mp.Patronymic;
                textBoxDateOfFloor.Text = mp.DateSellFloor;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronymic.Text = "";
                textBoxDateOfFloor.Text = "";
            }
        }

        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            ManageProperty mp = new ManageProperty();
            mp.Name = textBoxName.Text;
            mp.Surname = textBoxSurname.Text;
            mp.Patronymic = textBoxPatronymic.Text;
            if (comboBoxTypeProp.SelectedIndex == 0)
            {
                mp.TypeProp = 0;
                mp.DateOfHouse = textBoxDateRentHouse.Text;
                mp.DedlineHouse = textBoxDedlineHouse.Text;
            }
            else if (comboBoxTypeProp.SelectedIndex == 1)
            {
                mp.TypeProp = 1;
                mp.DateOfFloor = textBoxDateRentFloor.Text;
                mp.DedlineFloor = textBoxDedlineFloor.Text;
            }
            else if (comboBoxTypeProp.SelectedIndex == 2)
            {
                mp.TypeProp = 2;
                mp.DateSellHouse = textBoxDateOfHouse.Text;
            }
            else
            {
                mp.TypeProp = 3;
                mp.DateSellFloor = textBoxDateOfFloor.Text;
            }
            Program.ADb.ManageProperty.Add(mp);
            Program.ADb.SaveChanges();
            ShowManageProper();
        }

        private void buttonEditInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeProp.SelectedIndex == 0)
            {
                if (listViewRentHouse.SelectedItems.Count == 1)
                {
                    ManageProperty mp = listViewRentHouse.SelectedItems[0].Tag as ManageProperty;
                    mp.Name = textBoxName.Text;
                    mp.Surname = textBoxSurname.Text;
                    mp.Patronymic = textBoxPatronymic.Text;
                    mp.DateOfHouse = textBoxDateRentHouse.Text;
                    mp.DedlineHouse = textBoxDedlineHouse.Text;
                    Program.ADb.SaveChanges();
                    ShowManageProper();
                }
            }
            else if (comboBoxTypeProp.SelectedIndex == 1)
            {
                if (listViewRentFloor.SelectedItems.Count == 1)
                {
                    ManageProperty mp = listViewRentFloor.SelectedItems[0].Tag as ManageProperty;
                    mp.Name = textBoxName.Text;
                    mp.Surname = textBoxSurname.Text;
                    mp.Patronymic = textBoxPatronymic.Text;
                    mp.DateOfFloor = textBoxDateRentFloor.Text;
                    mp.DedlineFloor = textBoxDedlineFloor.Text;
                    Program.ADb.SaveChanges();
                    ShowManageProper();
                }
            }
            if (comboBoxTypeProp.SelectedIndex == 2)
            {
                if (listViewMyHouse.SelectedItems.Count == 1)
                {
                    ManageProperty mp = listViewMyHouse.SelectedItems[0].Tag as ManageProperty;
                    mp.Name = textBoxName.Text;
                    mp.Surname = textBoxSurname.Text;
                    mp.Patronymic = textBoxPatronymic.Text;
                    mp.DateSellHouse = textBoxDateOfHouse.Text;
                    Program.ADb.SaveChanges();
                    ShowManageProper();
                }
            }
            else 
            {
                if (listViewMyFloor.SelectedItems.Count == 1)
                {
                    ManageProperty mp = listViewMyFloor.SelectedItems[0].Tag as ManageProperty;
                    mp.Name = textBoxName.Text;
                    mp.Surname = textBoxSurname.Text;
                    mp.Patronymic = textBoxPatronymic.Text;
                    mp.DateSellFloor = textBoxDateOfFloor.Text;
                    Program.ADb.SaveChanges();
                    ShowManageProper();
                }
            }
        }

        private void buttonDelInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTypeProp.SelectedIndex == 0)
                {
                    if (listViewRentHouse.SelectedItems.Count == 1)
                    {
                        ManageProperty mp = listViewRentHouse.SelectedItems[0].Tag as ManageProperty;
                        Program.ADb.ManageProperty.Remove(mp);
                        Program.ADb.SaveChanges();
                        ShowManageProper();
                    }
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxPatronymic.Text = "";
                    textBoxDateOfHouse.Text = "";
                    textBoxDedlineHouse.Text = "";
                }
                else if (comboBoxTypeProp.SelectedIndex == 1)
                {
                    if (listViewRentFloor.SelectedItems.Count == 1)
                    {
                        ManageProperty mp = listViewRentFloor.SelectedItems[0].Tag as ManageProperty;
                        Program.ADb.ManageProperty.Remove(mp);
                        Program.ADb.SaveChanges();
                        ShowManageProper();
                    }
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxPatronymic.Text = "";
                    textBoxDateRentFloor.Text = "";
                    textBoxDedlineFloor.Text = "";
                }
                else if (comboBoxTypeProp.SelectedIndex == 2)
                {
                    if (listViewMyHouse.SelectedItems.Count == 1)
                    {
                        ManageProperty mp = listViewMyHouse.SelectedItems[0].Tag as ManageProperty;
                        Program.ADb.ManageProperty.Remove(mp);
                        Program.ADb.SaveChanges();
                        ShowManageProper();
                    }
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxPatronymic.Text = "";
                    textBoxDateOfHouse.Text = "";
                }
                else
                {
                    if (listViewMyFloor.SelectedItems.Count == 1)
                    {
                        ManageProperty mp = listViewMyFloor.SelectedItems[0].Tag as ManageProperty;
                        Program.ADb.ManageProperty.Remove(mp);
                        Program.ADb.SaveChanges();
                        ShowManageProper();
                    }
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxPatronymic.Text = "";
                    textBoxDateOfFloor.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxTypeProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeProp.SelectedIndex == 0)
            {
                listViewRentHouse.Visible = true;
                labelName.Visible = true;
                textBoxName.Visible = true;
                labelSurname.Visible = true;
                textBoxSurname.Visible = true;
                labelPatronymic.Visible = true;
                textBoxPatronymic.Visible = true;
                labelDateRentHouse.Visible = true;
                textBoxDateRentHouse.Visible = true;
                labelDedlineHouse.Visible = true;
                textBoxDedlineHouse.Visible = true;

                listViewRentFloor.Visible = false;
                listViewMyHouse.Visible = false;
                listViewMyFloor.Visible = false;
                labelDateRentFloor.Visible = false;
                textBoxDateRentFloor.Visible = false;
                labelDedlineFloor.Visible = false;
                textBoxDedlineFloor.Visible = false;
                labelDateOfHouse.Visible = false;
                textBoxDateOfHouse.Visible = false;
                labelDateOfFloor.Visible = false;
                textBoxDateOfFloor.Visible = false;

                textBoxDateRentHouse.Text = "";
                textBoxDedlineHouse.Text = "";
            }
            if (comboBoxTypeProp.SelectedIndex == 1)
            {
                listViewRentFloor.Visible = true;
                labelName.Visible = true;
                textBoxName.Visible = true;
                labelSurname.Visible = true;
                textBoxSurname.Visible = true;
                labelPatronymic.Visible = true;
                textBoxPatronymic.Visible = true;
                labelDateRentFloor.Visible = true;
                textBoxDateRentFloor.Visible = true;
                labelDedlineFloor.Visible = true;
                textBoxDedlineFloor.Visible = true;

                listViewRentHouse.Visible = false;
                listViewMyHouse.Visible = false;
                listViewMyFloor.Visible = false;
                labelDateRentHouse.Visible = false;
                textBoxDateRentHouse.Visible = false;
                labelDedlineHouse.Visible = false;
                textBoxDedlineHouse.Visible = false;
                labelDateOfHouse.Visible = false;
                textBoxDateOfHouse.Visible = false;
                labelDateOfFloor.Visible = false;
                textBoxDateOfFloor.Visible = false;

                textBoxDateRentFloor.Text = "";
                textBoxDedlineFloor.Text = "";
            }
            if (comboBoxTypeProp.SelectedIndex == 2)
            {
                listViewMyHouse.Visible = true;
                labelName.Visible = true;
                textBoxName.Visible = true;
                labelSurname.Visible = true;
                textBoxSurname.Visible = true;
                labelPatronymic.Visible = true;
                textBoxPatronymic.Visible = true;
                labelDateOfHouse.Visible = true;
                textBoxDateOfHouse.Visible = true;

                listViewRentFloor.Visible = false;
                listViewRentHouse.Visible = false;
                listViewMyFloor.Visible = false;
                labelDateRentFloor.Visible = false;
                textBoxDateRentFloor.Visible = false;
                labelDedlineFloor.Visible = false;
                textBoxDedlineFloor.Visible = false;
                labelDateRentHouse.Visible = false;
                textBoxDateRentHouse.Visible = false;
                labelDedlineHouse.Visible = false;
                textBoxDedlineHouse.Visible = false;
                labelDateOfFloor.Visible = false;
                textBoxDateOfFloor.Visible = false;

                textBoxDateOfHouse.Text = "";
            }
            if (comboBoxTypeProp.SelectedIndex == 3)
            {
                listViewMyFloor.Visible = true;
                labelName.Visible = true;
                textBoxName.Visible = true;
                labelSurname.Visible = true;
                textBoxSurname.Visible = true;
                labelPatronymic.Visible = true;
                textBoxPatronymic.Visible = true;
                labelDateOfFloor.Visible = true;
                textBoxDateOfFloor.Visible = true;

                listViewRentFloor.Visible = false;
                listViewRentHouse.Visible = false;
                listViewMyHouse.Visible = false;
                labelDateRentFloor.Visible = false;
                textBoxDateRentFloor.Visible = false;
                labelDedlineFloor.Visible = false;
                textBoxDedlineFloor.Visible = false;
                labelDateRentHouse.Visible = false;
                textBoxDateRentHouse.Visible = false;
                labelDedlineHouse.Visible = false;
                textBoxDedlineHouse.Visible = false;
                labelDateOfHouse.Visible = false;
                textBoxDateOfHouse.Visible = false;

                textBoxDateOfFloor.Text = "";
            }
        }
    }
}
