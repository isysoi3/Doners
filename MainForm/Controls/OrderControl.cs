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
    public partial class OrderControl : UserControl
    {
        public OrderControl(OrderItem item)
        {
            InitializeComponent();
            lbOrderId.Text = item.orderNumber.ToString();
            lbOrderId.DoubleClick += changeOrderColor;
            AddKebabControls(item.kebabs);
        }

        private void changeOrderColor(object sender, EventArgs e)
        {
            if (lbOrderId.BackColor == Color.White)
                lbOrderId.BackColor = Color.Red;
            else if (lbOrderId.BackColor == Color.Red)
                lbOrderId.BackColor = Color.Yellow;
            else if (lbOrderId.BackColor == Color.Yellow)
                lbOrderId.BackColor = Color.Lime;
            else
                lbOrderId.BackColor = Color.White;
        }

        private void AddKebabControls(List<KebabItem> kebabs)
        {
            KebabControl lastControl = null;
            int height = 0;
            foreach(KebabItem kebab in kebabs)
            {
                KebabControl orderControl = new KebabControl(kebab);
                orderControl.Left = lbOrderId.Right;
                if (lastControl == null)
                    orderControl.Top = lbOrderId.Top;
                else
                    orderControl.Top = lastControl.Bottom;
                height += orderControl.Height;
                lastControl = orderControl;
                this.Controls.Add(orderControl);
            }
            lbOrderId.Height = lastControl.Bottom - lbOrderId.Top;
            this.Height = height + lbOrderId.Height;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
