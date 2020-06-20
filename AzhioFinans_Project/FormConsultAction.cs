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
    public partial class FormConsultAction : Form
    {
        public FormConsultAction()
        {
            InitializeComponent();
            ShowSotr();
            ShowAction();
            ShowConsAct();
        }
        public void ShowSotr()
        {
            comboBoxSotr.Items.Clear();
            foreach (ConsultInvest ci in Program.ADb.ConsultInvest)
            {
                string[] item = {ci.Id.ToString() + ".", ci.NamesurnameSotr };
                comboBoxSotr.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowAction()
        {
            comboBoxAction.Items.Clear();
            foreach (SellAction sa in Program.ADb.SellAction)
            {
                string[] item = { sa.Id.ToString() + ".", sa.DateSell};
                comboBoxAction.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowConsAct()
        {
            listViewConsAction.Items.Clear();
            foreach (ConsultAction ca in Program.ADb.ConsultAction)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    ca.IdSotr.ToString(),
                    ca.ConsultInvest.NamesurnameSotr + " ",
                    ca.IdAction.ToString(),
                    ca.SellAction.DateSell + " ",
                    ca.Qwen,
                    ca.Actual.ToString()
                });
                item.Tag = ca;
                listViewConsAction.Items.Add(item);
            }
            listViewConsAction.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxAction.SelectedItem != null && comboBoxSotr.SelectedItem != null)
            {
                ConsultAction ca = new ConsultAction();
                ca.IdSotr = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
                ca.IdAction = Convert.ToInt32(comboBoxAction.SelectedItem.ToString().Split('.')[0]);
                ca.Qwen = Convert.ToString(textBoxQwen.Text);
                ca.Actual = Convert.ToInt32(comboBoxActual.Text);
                Program.ADb.ConsultAction.Add(ca);
                Program.ADb.SaveChanges();
                ShowConsAct();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEditInfo_Click(object sender, EventArgs e)
        {
            if (listViewConsAction.SelectedItems.Count == 1)
            {
                ConsultAction ca = listViewConsAction.SelectedItems[0].Tag as ConsultAction;
                ca.IdSotr = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
                ca.IdAction = Convert.ToInt32(comboBoxAction.SelectedItem.ToString().Split('.')[0]);
                ca.Qwen = Convert.ToString(textBoxQwen.Text);
                ca.Actual = Convert.ToInt32(comboBoxActual.Text);
                Program.ADb.SaveChanges();
                ShowConsAct();
            }
        }

        private void buttonDelInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewConsAction.SelectedItems.Count == 1)
                {
                    ConsultAction ca = listViewConsAction.SelectedItems[0].Tag as ConsultAction;
                    Program.ADb.ConsultAction.Remove(ca);
                    Program.ADb.SaveChanges();
                    ShowConsAct();
                }
                comboBoxAction.SelectedItem = null;
                comboBoxSotr.SelectedItem = null;
                textBoxQwen.Text = "";
                comboBoxActual.Text = "";
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

        private void listViewConsAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewConsAction.SelectedItems.Count == 1)
            {
                ConsultAction ca = listViewConsAction.SelectedItems[0].Tag as ConsultAction;
                comboBoxSotr.SelectedIndex = comboBoxSotr.FindString(ca.IdSotr.ToString());
                comboBoxAction.SelectedIndex = comboBoxAction.FindString(ca.IdAction.ToString());
                textBoxQwen.Text = ca.Qwen.ToString();
                comboBoxActual.Text = ca.Actual.ToString();
            }
            else
            {
                comboBoxAction.SelectedItem = null;
                comboBoxSotr.SelectedItem = null;
                textBoxQwen.Text = "";
                comboBoxActual.Text = "";
            }
        }
    }
}
