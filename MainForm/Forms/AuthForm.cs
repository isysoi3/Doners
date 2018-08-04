using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Example.Models;

namespace UI_Example
{
    public partial class AuthForm : Form
    {

        private DataBaseWrapper dbWrapper;

        public AuthForm()
        {
            InitializeComponent();
            dbWrapper = new DataBaseWrapper();
        }

        private bool checkInput()
        {
            if(tbLogin.Text == "")
            {
                errorProvider.SetError(tbLogin, "Введите логин");
                return false;
            }
            if (tbPassword.Text == "")
            {
                errorProvider.SetError(tbPassword, "Введите пароль");
                return false;
            }
            double cash;
            if (tbCash.Text == "" || !double.TryParse(tbCash.Text, out cash))
            {
                errorProvider.SetError(tbCash, "Введите состояние кассы");
                return false;
            }
            return true;
        }

        private void infoChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (!checkInput())
                return;
            UserInfo info = dbWrapper.login(tbLogin.Text, tbPassword.Text);
            if (info == null)
            {
                errorProvider.SetError(tbLogin, "Неверный логин или пароль");
                return;
            }

            Hide();

            QueueForm.CurrentCashierInfo = new CashBookItem(info.Name, double.Parse(tbCash.Text));

            QueueForm mainForm = new QueueForm();
            mainForm.Show();
        }
    }
}
