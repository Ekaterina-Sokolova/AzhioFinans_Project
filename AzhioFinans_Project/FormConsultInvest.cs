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
    public partial class FormConsultInvest : Form
    {
        public FormConsultInvest()
        {
            InitializeComponent();
            ShowManagePropers();
            ShowInvest();
        }
        public void ShowManagePropers()
        {
            comboBoxNameUser.Items.Clear();
            foreach (ManageProperty mp in Program.ADb.ManageProperty)
            {
                string[] item = {mp.Id.ToString() + ".", mp.Name, mp.Patronymic};
                comboBoxNameUser.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowInvest()
        {
            listViewConsultInvest.Items.Clear();
            foreach (ConsultInvest ci in Program.ADb.ConsultInvest)
            {
                 ListViewItem item = new ListViewItem(new string[]
                 {
                    ci.Id.ToString(),
                    ci.NamesurnameSotr,
                    ci.IdUser.ToString(),
                    ci.ManageProperty.Name + " " + ci.ManageProperty.Patronymic + " ",
                    ci.PlaceInvest,
                    ci.ActualInvest.ToString(),
                    ci.ColInvest
                 });
                    item.Tag = ci;
                    listViewConsultInvest.Items.Add(item);            
            }
            listViewConsultInvest.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxNameUser.SelectedItem != null && comboBoxActualInvest.SelectedItem != null)
            {
                ConsultInvest ci = new ConsultInvest();
                ci.NamesurnameSotr = Convert.ToString(textBoxNameSotr.Text);
                ci.IdUser = Convert.ToInt32(comboBoxNameUser.SelectedItem.ToString().Split('.')[0]);
                ci.PlaceInvest = Convert.ToString(textBoxPlaceInvest.Text);
                ci.ActualInvest = Convert.ToInt32(comboBoxActualInvest.Text);
                ci.ColInvest = Convert.ToString(textBoxColInvest.Text);
                Program.ADb.ConsultInvest.Add(ci);
                Program.ADb.SaveChanges();
                ShowInvest();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEditInfo_Click(object sender, EventArgs e)
        {
            if (listViewConsultInvest.SelectedItems.Count == 1)
            {
                ConsultInvest ci = listViewConsultInvest.SelectedItems[0].Tag as ConsultInvest;
                ci.NamesurnameSotr = Convert.ToString(textBoxNameSotr.Text);
                ci.IdUser = Convert.ToInt32(comboBoxNameUser.SelectedItem.ToString().Split('.')[0]);
                ci.PlaceInvest = Convert.ToString(textBoxPlaceInvest.Text);
                ci.ActualInvest = Convert.ToInt32(comboBoxActualInvest.Text);
                ci.ColInvest = Convert.ToString(textBoxColInvest.Text);
                Program.ADb.SaveChanges();
                ShowInvest();
            }
        }

        private void buttonDelInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewConsultInvest.SelectedItems.Count == 1)
                {
                    ConsultInvest ci = listViewConsultInvest.SelectedItems[0].Tag as ConsultInvest;
                    Program.ADb.ConsultInvest.Remove(ci);
                    Program.ADb.SaveChanges();
                    ShowInvest();
                }
                textBoxNameSotr.Text = "";
                comboBoxNameUser.SelectedItem = null;
                textBoxPlaceInvest.Text = "";
                textBoxColInvest.Text = "";
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

        private void listViewConsultInvest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewConsultInvest.SelectedItems.Count == 1)
            {
                ConsultInvest ci = listViewConsultInvest.SelectedItems[0].Tag as ConsultInvest;
                textBoxNameSotr.Text = ci.NamesurnameSotr.ToString();
                comboBoxNameUser.SelectedIndex = comboBoxNameUser.FindString(ci.IdUser.ToString());
                comboBoxActualInvest.Text = ci.ActualInvest.ToString();
                textBoxPlaceInvest.Text = ci.PlaceInvest.ToString();
                textBoxColInvest.Text = ci.ColInvest.ToString();
            }
            else
            {
                textBoxNameSotr.Text = "";
                comboBoxNameUser.SelectedItem = null;
                textBoxPlaceInvest.Text = "";
                textBoxColInvest.Text = "";
            }
        }
    }
}
