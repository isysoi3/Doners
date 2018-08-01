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

namespace UI_Example.Controls
{
    public partial class CashBookControl : UserControl
    {
        private DataBaseWrapper dbWrapper;
        private List<CashBookItemControl> cashBookControls;

        public CashBookControl()
        {
            InitializeComponent();

            panel.AutoScroll = false;
            panel.HorizontalScroll.Enabled = false;
            panel.HorizontalScroll.Visible = false;
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = true;

            dbWrapper = new DataBaseWrapper();
            cashBookControls = new List<CashBookItemControl>();

            List<CashBookItem> orderItems = dbWrapper.getCashBookItems();
            orderItems.Reverse();
            foreach (CashBookItem item in orderItems)
            {
                addNewItem(item);
            }
        }

        private void addNewItem(CashBookItem item)
        {
            CashBookItemControl orderControl = new CashBookItemControl(item);
            panel.Controls.Add(orderControl);
            if (cashBookControls.Count == 0)
            {
                orderControl.Top = 0;
                orderControl.Left = 0;
            }
            else
            {
                CashBookItemControl lastOrder = cashBookControls.Last();
                orderControl.Top = lastOrder.Bottom + 10;
                orderControl.Left = lastOrder.Left;
            }


            cashBookControls.Add(orderControl);
        }

        public void changeHeight(int height)
        {
            Height = height;
            gbCashBook.Height = height;
            panel.Height = height - 55;
        }

        public void changeWidth(int width)
        {
            Width = width;
            gbCashBook.Width = width;
            lbDiff.Width = width - 990;
            panel.Width = width - 10;
            foreach (CashBookItemControl control in cashBookControls)
                control.changeWidth(lbDiff.Right - lbDate.Left);
        }
    }
}
