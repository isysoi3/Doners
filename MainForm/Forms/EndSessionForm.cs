using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Example.Forms
{
    public partial class EndSessionForm : Form
    {
        public EndSessionForm()
        {
            InitializeComponent();
        }

        private void btEndSession_Click(object sender, EventArgs e)
        {
            double cash;
            if (tbCash.Text == "" || !double.TryParse(tbCash.Text, out cash))
            {
                errorProvider.SetError(tbCash, "Введите состояние кассы");
                return;
            }
            QueueForm.CurrentCashierInfo.CashEnd = cash;
            new DataBaseWrapper().addCashBookItem(QueueForm.CurrentCashierInfo);
            Application.Exit();
        }
    }
}
