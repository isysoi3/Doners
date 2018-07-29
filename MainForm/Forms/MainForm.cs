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

//TODO: fix all namespace
namespace UI_Example
{

    public partial class QueueForm : Form
    {
        private AddOrderForm orderForm;
        private SecondForm.SecondForm secondForm;
        private List<OrderControl> orderControls;
        private Control mainGroupBox;
        private HistoryControl historyControl;
        private SellsBookControl sellsBookControl;
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

            orderControl.changeWidth(gbMain.Width - lbNumberCommon.Left);

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
            btAdd.Top = Height - btAdd.Height- 50;
            btAdd.Left = (Width - btAdd.Width) / 2;
            lbComment.Width = Width - lbComment.Left - 45;
            foreach (OrderControl orderControl in orderControls)
                orderControl.changeWidth(Width - lbNumberCommon.Left);
        }

        private void QueueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btSellsBook_Click(object sender, EventArgs e)
        {
            Controls.Remove(currentGroupBox);

            sellsBookControl.update();
            currentGroupBox = sellsBookControl;
            currentGroupBox.Top = mainGroupBox.Top;
            currentGroupBox.Left = mainGroupBox.Left;

            Controls.Add(currentGroupBox);
        }

        private void btMain_Click(object sender, EventArgs e)
        {
            Controls.Remove(currentGroupBox);

            currentGroupBox = mainGroupBox;
          
            Controls.Add(currentGroupBox);
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            Controls.Remove(currentGroupBox);

            currentGroupBox = historyControl;
            currentGroupBox.Top = mainGroupBox.Top;
            currentGroupBox.Left = mainGroupBox.Left;

            Controls.Add(currentGroupBox);
        }
    }
}