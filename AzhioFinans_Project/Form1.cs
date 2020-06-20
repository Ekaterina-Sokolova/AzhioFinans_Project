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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRentProper_Click(object sender, EventArgs e)
        {
            Form formRentprop = new FormRentProp();
            formRentprop.Show();
        }

        private void buttonPropManage_Click(object sender, EventArgs e)
        {
            Form formManageprop = new FormManageProp();
            formManageprop.Show();
        }

        private void buttonConsultInvest_Click(object sender, EventArgs e)
        {
            Form formConsInv = new FormConsultInvest();
            formConsInv.Show();
        }

        private void buttonBuyBussinesOrAction_Click(object sender, EventArgs e)
        {
            Form formsell = new FormSellAction();
            formsell.Show();
        }

        private void buttonSellBussinesOrAction_Click(object sender, EventArgs e)
        {
            Form formsells = new FormSellsAction();
            formsells.Show();
        }
    }
}
