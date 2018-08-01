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

        private void gbHistory_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void lbSizeCommon_Click(object sender, EventArgs e)
        {

        }

        private void lbComment_Click(object sender, EventArgs e)
        {

        }
    }
}
