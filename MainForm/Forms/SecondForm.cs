using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Example.Controls;
using UI_Example.Models;

//TODO: fix all namespace
namespace SecondForm
{
    public partial class SecondForm : Form
    {
        private List<OrderControl> orderControls;

        public SecondForm()
        {
            InitializeComponent();

            orderControls = new List<OrderControl>();
        }

        public void AddNewOrder(OrderItem item)
        {
            OrderControl orderControl = new OrderControl(item);
            Controls.Add(orderControl);
            if (orderControls.Count == 0)
            {
                orderControl.Top = lbNumberCommon.Bottom + 10;
                orderControl.Left = lbNumberCommon.Left;
            }
            else
            {
                OrderControl lastOrder = orderControls.Last();
                orderControl.Top = lastOrder.Bottom + 10;
                orderControl.Left = lastOrder.Left;
            }
            orderControls.Add(orderControl);
        }

        public void HandleColorChanged(int orderID)
        {
            OrderControl orderControl = orderControls.Find(control => control.OrderID == orderID);
            orderControl.changeOrderColor(orderControl, null);
        }
    }
}
