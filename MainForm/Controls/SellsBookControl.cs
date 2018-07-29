﻿using System;
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
    public partial class SellsBookControl : UserControl
    {
        private DataBaseWrapper dbWrapper;
        private List<OrderControl> orderControls;

        public SellsBookControl()
        {
            InitializeComponent();
            panel.AutoScroll = false;
            panel.HorizontalScroll.Enabled = false;
            panel.HorizontalScroll.Visible = false;
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = true;
            dbWrapper = new DataBaseWrapper();
            orderControls = new List<OrderControl>();

            List<OrderItem> orderItems = dbWrapper.getTodayOrderItems();
            foreach (OrderItem item in orderItems)
            {
                addNewOrder(item);
            }


        }

        private void addNewOrder(OrderItem item)
        {
            OrderControl orderControl = new OrderControl(item, false);
            panel.Controls.Add(orderControl);
            if (orderControls.Count == 0)
            {
                orderControl.Top = 0;
                orderControl.Left = 0;
            }
            else
            {
                OrderControl lastOrder = orderControls.Last();
                orderControl.Top = lastOrder.Bottom + 10;
                orderControl.Left = lastOrder.Left;
            }

            orderControl.changeWidth(gbSellsBook.Width - lbNumberCommon.Left + 15);

            orderControls.Add(orderControl);
        }

        private void SellsBookControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
