using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using UI_Example.Models;
using AddOrder;
using SecondForm;
using UI_Example.Controls;
using UI_Example.Forms;

//TODO: fix all namespace
namespace UI_Example
{

    public partial class QueueForm : Form
    {
        public static CashBookItem CurrentCashierInfo { get; set; }

        private AddOrderForm orderForm;
        private SecondForm.SecondForm secondForm;
        private List<OrderControl> orderControls;
        private Control mainGroupBox;
        private HistoryControl historyControl;
        private SellsBookControl sellsBookControl;
        private CashBookControl cashBookControl;
        private CostsControl costsControl;
        private Control currentGroupBox;

        public QueueForm()
        {
            InitializeComponent();

            panel.AutoScroll = false;
            panel.HorizontalScroll.Enabled = false;
            panel.HorizontalScroll.Visible = false;
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = true;

            orderControls = new List<OrderControl>();

            orderForm = new AddOrderForm();
            orderForm.AddOrderCallback = new AddNewOrderDelegate(HandleNewOrder);

            secondForm = new SecondForm.SecondForm();
            secondForm.Show();

            mainGroupBox = gbMain;
            historyControl = new HistoryControl();
            sellsBookControl = new SellsBookControl();
            cashBookControl = new CashBookControl();
            costsControl = new CostsControl();
            currentGroupBox = mainGroupBox;
        }

        private void AddNewOrderButtonClick(object sender, EventArgs e)
        {
            orderForm.Show();
        }

        private void HandleNewOrder(OrderItem item)
        {
            secondForm.AddNewOrder(item);

            OrderControl orderControl = new OrderControl(item, true);
            panel.Controls.Add(orderControl);
            if (orderControls.Count == 0)
            {
                orderControl.Top = 0;
                orderControl.Left = 0;
            }
            else {
                OrderControl lastOrder = orderControls.Last();
                orderControl.Top = lastOrder.Bottom + 10;
                orderControl.Left = lastOrder.Left;
            }
            orderControl.ColorChangedCallBack = new ColorChangedDelegate(secondForm.HandleColorChanged);
            orderControl.OrderRemovedCallBack = new OrderRemovedDelegate(removeOrder);

            orderControl.changeWidth(panel.Width);

            orderControls.Add(orderControl);
        }

        private void removeOrder(int orderID)
        {
            OrderControl orderControl = orderControls.FindLast(order => order.OrderID == orderID);
            panel.Controls.Remove(orderControl);
            orderControls.Remove(orderControl);
            secondForm.removeOrder(orderID);
            moveItems();
        }


        private void moveItems()
        {
            if (orderControls.Count != 0)
                orderControls.First().Top = 0;
            for (int i = 1; i < orderControls.Count; i++)
                orderControls[i].Top = orderControls[i - 1].Bottom + 10;
        }

        private void QueueForm_Resize(object sender, EventArgs e)
        {
            int gbHeight = Height - 50;
            int gbWidth = Width - 180;

            gbNavigation.Height = gbHeight + 3;
            if (currentGroupBox == mainGroupBox)
                resizeMainGB(gbHeight, gbWidth);
            else if (currentGroupBox == historyControl)
            {
                historyControl.changeHeight(gbHeight);
                historyControl.changeWidth(gbWidth);
            }
            else if (currentGroupBox == sellsBookControl)
            {
                sellsBookControl.changeHeight(gbHeight);
                sellsBookControl.changeWidth(gbWidth);
            }
            else if (currentGroupBox == cashBookControl)
            {
                cashBookControl.changeWidth(gbWidth);
                cashBookControl.changeHeight(gbHeight);
            }
            else
            {
                costsControl.changeWidth(gbWidth);
                costsControl.changeHeight(gbHeight);
            }
        }

        private void resizeMainGB(int height, int width)
        {
            mainGroupBox.Height = height;
            mainGroupBox.Width = width;
            panel.Height = mainGroupBox.Height - 100;
            panel.Width = mainGroupBox.Width - 10;
            btAdd.Top = mainGroupBox.Bottom - 40;
            btAdd.Left = (Width - btAdd.Width) / 2 - mainGroupBox.Left;
            lbComment.Width = mainGroupBox.Width - 675;
            foreach (OrderControl orderControl in orderControls)
                orderControl.changeWidth(panel.Width);
        }

        private void QueueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                EndSessionForm endSessionForm = new EndSessionForm();
                endSessionForm.Show();
            }
        }

        private void btSellsBook_Click(object sender, EventArgs e)
        {
            Controls.Remove(currentGroupBox);


            sellsBookControl.update();
            sellsBookControl.changeHeight(Height - 50);
            sellsBookControl.changeWidth(Width - 180);
            currentGroupBox = sellsBookControl;
            currentGroupBox.Top = mainGroupBox.Top;
            currentGroupBox.Left = mainGroupBox.Left;

            Controls.Add(currentGroupBox);
        }

        private void btMain_Click(object sender, EventArgs e)
        {
            Controls.Remove(currentGroupBox);

            resizeMainGB(Height - 50, Width - 180);
            currentGroupBox = mainGroupBox;
          
            Controls.Add(currentGroupBox);
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            Controls.Remove(currentGroupBox);

            historyControl.changeHeight(Height - 50);
            historyControl.changeWidth(Width - 180);
            currentGroupBox = historyControl;
            currentGroupBox.Top = mainGroupBox.Top;
            currentGroupBox.Left = mainGroupBox.Left;

            Controls.Add(currentGroupBox);
        }

        private void btCashBook_Click(object sender, EventArgs e)
        {
            Controls.Remove(currentGroupBox);

            cashBookControl.changeWidth(Width - 180);
            cashBookControl.changeHeight(Height - 50);
            currentGroupBox = cashBookControl;
            currentGroupBox.Top = mainGroupBox.Top;
            currentGroupBox.Left = mainGroupBox.Left;

            Controls.Add(currentGroupBox);
        }

        private void btCosts_Click(object sender, EventArgs e)
        {
            Controls.Remove(currentGroupBox);

            costsControl.changeWidth(Width - 180);
            costsControl.changeHeight(Height - 50);
            costsControl.update();
            currentGroupBox = costsControl;
            currentGroupBox.Top = mainGroupBox.Top;
            currentGroupBox.Left = mainGroupBox.Left;

            Controls.Add(currentGroupBox);
        }
    }
}