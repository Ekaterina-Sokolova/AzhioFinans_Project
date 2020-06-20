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
    public partial class FormSellsAction : Form
    {
        public FormSellsAction()
        {
            InitializeComponent();
            ShowSell();
            ShowSellsAction();
        }
        public void ShowSell()
        {
            comboBoxNameAction.Items.Clear();
            foreach (SellAction sa in Program.ADb.SellAction)
            {
                string[] item = {sa.Id.ToString() + ".", sa.DateSell};
                comboBoxNameAction.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowSellsAction()
        {
            listViewSell.Items.Clear();
            foreach (SellsAction ssa in Program.ADb.SellsAction)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    ssa.IdAction.ToString(),
                    ssa.SellAction.DateSell + " ",
                    ssa.DateSells,
                    ssa.PriceSells
                });
                item.Tag = ssa;
                listViewSell.Items.Add(item);
            }
            listViewSell.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxNameAction.SelectedItem != null)
            {
                SellsAction ssa = new SellsAction();
                ssa.IdAction = Convert.ToInt32(comboBoxNameAction.SelectedItem.ToString().Split('.')[0]);
                ssa.DateSells = Convert.ToString(textBoxDateSells.Text);
                ssa.PriceSells = Convert.ToString(textBoxPriceSells.Text);
                Program.ADb.SellsAction.Add(ssa);
                Program.ADb.SaveChanges();
                ShowSellsAction();
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
                SellsAction ssa = listViewSell.SelectedItems[0].Tag as SellsAction;
                ssa.IdAction = Convert.ToInt32(comboBoxNameAction.SelectedItem.ToString().Split('.')[0]);
                ssa.DateSells = Convert.ToString(textBoxDateSells.Text);
                ssa.PriceSells = Convert.ToString(textBoxPriceSells.Text);
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
                    SellsAction ssa = listViewSell.SelectedItems[0].Tag as SellsAction;
                    Program.ADb.SellsAction.Remove(ssa);
                    Program.ADb.SaveChanges();
                    ShowSell();
                }
                comboBoxNameAction.SelectedItem = null;
                textBoxDateSells.Text = "";
                textBoxPriceSells.Text = "";
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

        private void listViewSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSell.SelectedItems.Count == 1)
            {
                SellsAction ssa = listViewSell.SelectedItems[0].Tag as SellsAction;
                comboBoxNameAction.SelectedIndex = comboBoxNameAction.FindString(ssa.IdAction.ToString());
                textBoxDateSells.Text = ssa.DateSells.ToString();
                textBoxPriceSells.Text = ssa.PriceSells.ToString();
            }
            else
            {
                comboBoxNameAction.SelectedItem = null;
                textBoxDateSells.Text = "";
                textBoxPriceSells.Text = "";
            }
        }
    }
}
