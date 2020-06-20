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
    public struct User
    {
        public string login;
        public string password;
        public string type;
    }
    public partial class FormAutorization : Form
    {
        public static User auto = new User();
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void buttonVoity_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool f = false;
                foreach (Autorization user in Program.ADb.Autorization)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        f = true;
                        auto.login = user.Login;
                        auto.password = user.Password;
                        auto.type = user.TypeUser;
                    }
                }
                if (!f)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    FormMenu m = new FormMenu();
                    m.Show();
                    this.Hide();
                }
            }
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxTypeUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
