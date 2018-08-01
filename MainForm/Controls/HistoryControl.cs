using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using UI_Example.Models;
using UI_Example.Controls;

namespace UI_Example.Controls
{
    public partial class HistoryControl : UserControl
    {
        private DataBaseWrapper dbWrapper;
        private List<HistoryOrderControl> orderControls;

        public HistoryControl()
        {
            InitializeComponent();


            panel.AutoScroll = false;
            panel.HorizontalScroll.Enabled = false;
            panel.HorizontalScroll.Visible = false;
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = true;

            dbWrapper = new DataBaseWrapper();
            orderControls = new List<HistoryOrderControl>();
        }

        private void addNewOrder(OrderItem item)
        {
            HistoryOrderControl orderControl = new HistoryOrderControl(item);
            panel.Controls.Add(orderControl);
            if (orderControls.Count == 0)
            {
                orderControl.Top = 0;
                orderControl.Left = 0;
            }
            else
            {
                HistoryOrderControl lastOrder = orderControls.Last();
                orderControl.Top = lastOrder.Bottom + 10;
                orderControl.Left = lastOrder.Left;
            }

            orderControl.changeWidth(lbComment.Right - lbDate.Left);
            orderControls.Add(orderControl);
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            orderControls.Clear();
            panel.Controls.Clear();

            List<OrderItem> orderItems = dbWrapper.getOrderItemsByDate(dtpFrom.Value, dtpTo.Value);

            if (orderItems.Count != 0)
            {
                orderItems.Reverse();
                foreach (OrderItem item in orderItems)
                    addNewOrder(item);
            }
            else
            {
                Label label = new Label();
                label.Font = new Font(label.Font.FontFamily, 16);
                label.Text = "По вашему запросу заказов не найдено";
                label.Width = panel.Width;
                label.Height = 40;
                label.TextAlign = ContentAlignment.MiddleCenter;

                panel.Controls.Add(label);
            }
        }

        public void changeWidth(int width)
        {
            Width = width;
            gbHistory.Width = width;
            panel.Width = Width - 10;
            lbComment.Width = Width - 745;
            btShow.Left = lbComment.Right - btShow.Width;
            foreach(HistoryOrderControl control in orderControls)
            {
                control.changeWidth(lbComment.Right - lbDate.Left);
            }
        }

        public void changeHeight(int height)
        {
            Height = height;
            gbHistory.Height = height;
            panel.Height = Height - 100;
        }
    }
}
