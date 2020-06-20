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
    public partial class FormSellAction : Form
    {
        public FormSellAction()
        {
            InitializeComponent();
            ShowManagePropers();
            ShowSell();
        }
        public void ShowManagePropers()
        {
            comboBoxNameUser.Items.Clear();
            foreach (ManageProperty mp in Program.ADb.ManageProperty)
            {
                string[] item = { mp.Id.ToString() + ".", mp.Name, mp.Patronymic };
                comboBoxNameUser.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowSell()
        {
            listViewSell.Items.Clear();
            foreach (SellAction sa in Program.ADb.SellAction)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    sa.IdUser.ToString(),
                    sa.ManageProperty.Name + " " + sa.ManageProperty.Patronymic + " ",
                    sa.DateSell,
                    sa.PriceSell
                });
                item.Tag = sa;
                listViewSell.Items.Add(item);
            }
            listViewSell.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxNameUser.SelectedItem != null)
            {
                SellAction sa = new SellAction();
                sa.IdUser = Convert.ToInt32(comboBoxNameUser.SelectedItem.ToString().Split('.')[0]);
                sa.DateSell = Convert.ToString(textBoxDateSell.Text);
                sa.PriceSell = Convert.ToString(textBoxPriceSell.Text);
                Program.ADb.SellAction.Add(sa);
                Program.ADb.SaveChanges();
                ShowSell();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEditInfo_Click(object sender, EventArgs e)
        {
            if (listViewSell.SelectedItems.Count == 1)
            {
                SellAction sa = listViewSell.SelectedItems[0].Tag as SellAction;
                sa.IdUser = Convert.ToInt32(comboBoxNameUser.SelectedItem.ToString().Split('.')[0]);
                sa.DateSell = Convert.ToString(textBoxDateSell.Text);
                sa.PriceSell = Convert.ToString(textBoxPriceSell.Text);
                Program.ADb.SaveChanges();
                ShowSell();
            }
        }

        private void buttonDelInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSell.SelectedItems.Count == 1)
                {
                    SellAction sa = listViewSell.SelectedItems[0].Tag as SellAction;
                    Program.ADb.SellAction.Remove(sa);
                    Program.ADb.SaveChanges();
                    ShowSell();
                }
                comboBoxNameUser.SelectedItem = null;
                textBoxDateSell.Text = "";
                textBoxPriceSell.Text = "";
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSell.SelectedItems.Count == 1)
            {
                SellAction sa = listViewSell.SelectedItems[0].Tag as SellAction;
                comboBoxNameUser.SelectedIndex = comboBoxNameUser.FindString(sa.IdUser.ToString());
                textBoxDateSell.Text = sa.DateSell.ToString();
                textBoxPriceSell.Text = sa.PriceSell.ToString();
            }
            else
            {
                comboBoxNameUser.SelectedItem = null;
                textBoxDateSell.Text = "";
                textBoxPriceSell.Text = "";
            }
        }
    }
}
