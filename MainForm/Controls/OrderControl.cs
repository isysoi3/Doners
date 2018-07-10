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
    public delegate void ColorChangedDelegate(int orderID);
    public delegate void OrderRemovedDelegate(int orderID);

    public partial class OrderControl : UserControl
    {
        public ColorChangedDelegate ColorChangedCallBack;
        public OrderRemovedDelegate OrderRemovedCallBack;
        public int OrderID { get; set; }

        public void changeWidth(int width)
        {
            Width = width;
            btRemove.Left = width - btRemove.Width - 20;
            foreach (Control kebab in Controls)
                if (kebab is KebabControl)
                    (kebab as KebabControl).setWidth(btRemove.Left - lbTime.Right);
        }

        public OrderControl(OrderItem item, bool isEnabled)
        {
            InitializeComponent();
            OrderID = item.orderNumber;
            lbOrderId.Text = item.orderNumber.ToString();
            if (isEnabled)
                lbOrderId.DoubleClick += changeOrderColor;
            else
                btRemove.Visible = false;
            AddKebabControls(item.kebabs);

            lbTime.Text = item.orderTime.ToString("HH:mm:ss");
        }

        public void changeOrderColor(object sender, EventArgs e)
        {
            if (lbOrderId.BackColor == Color.White)
                lbOrderId.BackColor = Color.Red;
            else if (lbOrderId.BackColor == Color.Red)
                lbOrderId.BackColor = Color.Yellow;
            else if (lbOrderId.BackColor == Color.Yellow)
                lbOrderId.BackColor = Color.Lime;
            else if(lbOrderId.BackColor == Color.Lime)
                lbOrderId.BackColor = Color.Gray;
            else
                lbOrderId.BackColor = Color.White;
            if (ColorChangedCallBack != null)
                ColorChangedCallBack(OrderID);
        }

        private void AddKebabControls(List<KebabItem> kebabs)
        {
            KebabControl lastControl = null;
            foreach(KebabItem kebab in kebabs)
            {
                KebabControl orderControl = new KebabControl(kebab);
                orderControl.Left = lbTime.Right;
                if (lastControl == null)
                    orderControl.Top = lbOrderId.Top;
                else
                    orderControl.Top = lastControl.Bottom;
                lastControl = orderControl;
                this.Controls.Add(orderControl);
            }
            lbOrderId.Height = lastControl.Bottom - lbOrderId.Top;
            lbTime.Height = lbOrderId.Height;
            this.Height = lbOrderId.Height;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if(OrderRemovedCallBack != null)
                OrderRemovedCallBack(OrderID);
        }
    }
}
