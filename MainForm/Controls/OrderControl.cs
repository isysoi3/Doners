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
            lbState.Width = btRemove.Left;
            lbState.SendToBack();
            foreach (Control kebab in Controls)
                if (kebab is KebabControl)
                    (kebab as KebabControl).setWidth(btRemove.Left- 5 - lbTime.Right);
        }

        public OrderControl(OrderItem item, bool isEnabled)
        {
            InitializeComponent();
            OrderID = item.orderNumber;
            lbOrderId.Text = item.orderNumber.ToString();
            if (isEnabled)
            {
                foreach (Control control in Controls)
                    control.DoubleClick += changeOrderColor;
            }
            else
                btRemove.Visible = false;
            AddKebabControls(item.kebabs);

            lbTime.Text = item.orderTime.ToString("HH:mm:ss");
        }

        public void changeOrderColor(object sender, EventArgs e)
        {
            if (lbState.BackColor == Color.White)
                lbState.BackColor = Color.Red;
            else if (lbState.BackColor == Color.Red)
                lbState.BackColor = Color.Yellow;
            else if (lbState.BackColor == Color.Yellow)
                lbState.BackColor = Color.Lime;
            else if(lbState.BackColor == Color.Lime)
                lbState.BackColor = Color.Gray;
            else
                lbState.BackColor = Color.White;
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
                orderControl.setDoubleClickListener(changeOrderColor);
                lastControl = orderControl;
                this.Controls.Add(orderControl);
            }
            lbOrderId.Height = lastControl.Bottom - lbOrderId.Top;
            lbTime.Height = lbOrderId.Height;
            lbState.Height = lbTime.Height + 10;
            this.Height = lbState.Height;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if(OrderRemovedCallBack != null)
                OrderRemovedCallBack(OrderID);
        }
    }
}
