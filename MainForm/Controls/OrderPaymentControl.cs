using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Example.Models;
using AddOrder;

namespace UI_Example.Controls
{
    public partial class OrderPaymentControl : UserControl
    {
        private OrderItem currentOrder;
        public AddNewOrderDelegate AddOrderCallback;
        private DataBaseWrapper dbWrapper;

        public void setCurrentOrder(OrderItem order)
        {
            currentOrder = order;
        }

        public OrderItem getCurrentOrder()
        {
            return currentOrder;
        }

        public OrderPaymentControl()
        {
            dbWrapper = new DataBaseWrapper();
            InitializeComponent();
        }

        private void paymentChanged(object sender, EventArgs e)
        {
            if (rbCard.Checked)
            {
                tbGiven.Enabled = false;
                tbGiven.Text = "";
                lbChange.Text = "Сдача: ";
            }
            else
                tbGiven.Enabled = true;
            recountTotalAndChange(sender, e);
        }

        public void clearOrderInput()
        {
            tbDiscount.Clear();
            tbGiven.Clear();
            rbCash.Checked = true;

            lbTotal.Text = "Итого:";
            lbChange.Text = "Сдача:";
        }

        private double countTotal()
        {
            double total = currentOrder.summary;
            double discount;
            if (double.TryParse(tbDiscount.Text, out discount) && discount >= 0)
                total *= (100 - discount) / 100;
            total = Math.Round(total, 2);

            return total;
        }

        private void recountTotalAndChange(object sender, EventArgs e)
        {
            double given;
            double total = countTotal();
            lbTotal.Text = "Итого: " + total;

            if (double.TryParse(tbGiven.Text, out given) && given >= total)
                lbChange.Text = "Сдача: " + (given - total);
        }

        public bool endOrderButtonClick()
        {
            int orderNumber;
            if (!int.TryParse(tbNumber.Text, out orderNumber) || orderNumber < 0)
            {
                errProvider.SetError(tbNumber, "Не указан номер заказа");
                return false;
            }
            DateTime currentTime = DateTime.Now;

            currentOrder.orderNumber = orderNumber;
            currentOrder.orderTime = currentTime;
            
            if (rbCash.Checked)
                QueueForm.CurrentCashierInfo.CashIn += countTotal();
            else
                QueueForm.CurrentCashierInfo.NonCashIn += countTotal();

            return true;
        }

        private void ClearForm()
        {
            currentOrder.ClearOrder();
            clearOrderInput();
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            int idStart;
            errProvider.Clear();

            if (tbId.Text.Equals("") || tbId.Text.Equals(cbId.Text))
            {
                cbId.DroppedDown = false;
                return;
            }

            cbId.Text = "";
            if (!int.TryParse(tbId.Text, out idStart))
            {
                errProvider.SetError(cbId, "Введено не число");
                cbId.DroppedDown = false;
                return;
            }

            List<int> ids = dbWrapper.getCustomersIdStartedWith(idStart, 5);
            if(ids.Count == 0)
            {
                cbId.DroppedDown = false;
                return;
            }
            cbId.Items.Clear();
            Cursor.Current = Cursors.Default;

            foreach (int id in ids)
            {
                cbId.Items.Add(id);
            }

            cbId.DroppedDown = false;
            cbId.DroppedDown = true;
        }

        private void cbId_SelectedValueChanged(object sender, EventArgs e)
        {
            tbId.Text = cbId.Text;
            cbId.DroppedDown = false;
        }
    }
}
