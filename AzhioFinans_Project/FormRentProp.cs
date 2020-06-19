using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzhioFinans_Project
{
    public partial class FormRentProp : Form
    {
        public FormRentProp()
        {
            InitializeComponent();
            comboBoxTypeProp.SelectedIndex = 0;
            ShowRentProper();
        }
        void ShowRentProper()
        {
            listViewHouse.Items.Clear();
            listViewFloor.Items.Clear();
            foreach (RentProperty rp in Program.ADb.RentProperty)
            {
                if (rp.TypeProp == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {

                    rp.id.ToString(), rp.Name, rp.Surname,
                    rp.Patronymic, rp.AddressHouse, rp.PriceHouse

                    });
                    item.Tag = rp;
                    listViewHouse.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {

                    rp.id.ToString(), rp.Name, rp.Surname,
                    rp.Patronymic, rp.AddressFloor, rp.PriceFloor

                    });
                    item.Tag = rp;
                    listViewFloor.Items.Add(item);
                }
            }

            listViewHouse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewFloor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            RentProperty rp = new RentProperty();
            rp.Name = textBoxName.Text;
            rp.Surname = textBoxSurname.Text;
            rp.Patronymic = textBoxPatronymic.Text;
            if (comboBoxTypeProp.SelectedIndex == 0)
            {
                rp.TypeProp = 0;
                rp.AddressHouse = textBoxAdHouse.Text;
                rp.PriceHouse = textBoxPriceHouse.Text;
            }
            else
            {
                rp.TypeProp = 1;
                rp.AddressFloor = textBoxAdFloor.Text;
                rp.PriceFloor = textBoxPriceFloor.Text;
            }
            Program.ADb.RentProperty.Add(rp);
            Program.ADb.SaveChanges();
            ShowRentProper();
        }

        private void buttonEditInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeProp.SelectedIndex == 0)
            {
                if (listViewHouse.SelectedItems.Count == 1)
                {
                    RentProperty rp = listViewHouse.SelectedItems[0].Tag as RentProperty;
                    rp.Name = textBoxName.Text;
                    rp.Surname = textBoxSurname.Text;
                    rp.Patronymic = textBoxPatronymic.Text;
                    rp.AddressHouse = textBoxAdHouse.Text;
                    rp.PriceHouse = textBoxPriceHouse.Text;
                    Program.ADb.SaveChanges();
                    ShowRentProper();
                }
            }
            else
            {
                if (listViewFloor.SelectedItems.Count == 1)
                {
                    RentProperty rp = listViewFloor.SelectedItems[0].Tag as RentProperty;
                    rp.Name = textBoxName.Text;
                    rp.Surname = textBoxSurname.Text;
                    rp.Patronymic = textBoxPatronymic.Text;
                    rp.AddressFloor = textBoxAdFloor.Text;
                    rp.PriceFloor = textBoxPriceFloor.Text;
                    Program.ADb.SaveChanges();
                    ShowRentProper();
                }
            }
        }

        private void buttonDelInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTypeProp.SelectedIndex == 0)
                {
                    if (listViewHouse.SelectedItems.Count == 1)
                    {
                        RentProperty rp = listViewHouse.SelectedItems[0].Tag as RentProperty;
                        Program.ADb.RentProperty.Remove(rp);
                        Program.ADb.SaveChanges();
                        ShowRentProper();
                    }
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxPatronymic.Text = "";
                    textBoxAdHouse.Text = "";
                    textBoxPriceHouse.Text = "";
                }
                else
                {
                    if (listViewFloor.SelectedItems.Count == 1)
                    {
                        RentProperty rp = listViewFloor.SelectedItems[0].Tag as RentProperty;
                        Program.ADb.RentProperty.Remove(rp);
                        Program.ADb.SaveChanges();
                        ShowRentProper();
                    }
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxPatronymic.Text = "";
                    textBoxAdFloor.Text = "";
                    textBoxPriceFloor.Text = "";
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

        private void listViewHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHouse.SelectedItems.Count == 1)
            {
                RentProperty rp = listViewHouse.SelectedItems[0].Tag as RentProperty;
                textBoxName.Text = rp.Name;
                textBoxSurname.Text = rp.Surname;
                textBoxPatronymic.Text = rp.Patronymic;
                textBoxAdHouse.Text = rp.AddressHouse;
                textBoxPriceFloor.Text = rp.PriceHouse;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronymic.Text = "";
                textBoxAdHouse.Text = "";
                textBoxPriceHouse.Text = "";
            }
        }

        private void listViewFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFloor.SelectedItems.Count == 1)
            {
                RentProperty rp = listViewFloor.SelectedItems[0].Tag as RentProperty;
                textBoxName.Text = rp.Name;
                textBoxSurname.Text = rp.Surname;
                textBoxPatronymic.Text = rp.Patronymic;
                textBoxAdFloor.Text = rp.AddressFloor;
                textBoxPriceFloor.Text = rp.PriceFloor;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronymic.Text = "";
                textBoxAdFloor.Text = "";
                textBoxPriceFloor.Text = "";
            }
        }

        private void comboBoxTypeProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTypeProp.SelectedIndex == 0)
            {
                listViewHouse.Visible = true;
                labelName.Visible = true;
                textBoxName.Visible = true;
                labelSurname.Visible = true;
                textBoxSurname.Visible = true;
                labelPatronymic.Visible = true;
                textBoxPatronymic.Visible = true;
                labelAdHouse.Visible = true;
                textBoxAdHouse.Visible = true;
                labelPriceHouse.Visible = true;
                textBoxPriceHouse.Visible = true;

                listViewFloor.Visible = false;
                labelAdFloor.Visible = false;
                textBoxAdFloor.Visible = false;
                labelPriceFloor.Visible = false;
                textBoxPriceFloor.Visible = false;

                textBoxAdHouse.Text = "";
                textBoxPriceHouse.Text = "";
            }
            if (comboBoxTypeProp.SelectedIndex == 1)
            {
                listViewFloor.Visible = true;
                labelName.Visible = true;
                textBoxName.Visible = true;
                labelSurname.Visible = true;
                textBoxSurname.Visible = true;
                labelPatronymic.Visible = true;
                textBoxPatronymic.Visible = true;
                labelAdFloor.Visible = true;
                textBoxAdFloor.Visible = true;
                labelPriceFloor.Visible = true;
                textBoxPriceFloor.Visible = true;

                listViewHouse.Visible = false;
                labelAdHouse.Visible = false;
                textBoxAdHouse.Visible = false;
                labelPriceHouse.Visible = false;
                textBoxPriceHouse.Visible = false;

                textBoxAdFloor.Text = "";
                textBoxPriceFloor.Text = "";
            }
        }
    }
}
