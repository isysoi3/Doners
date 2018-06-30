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

        public QueueForm()
        {
            InitializeComponent();

            orderControls = new List<OrderControl>();

            orderForm = new AddOrderForm();
            orderForm.AddOrderCallback = new AddNewOrderDelegate(HandleNewOrder);

            secondForm = new SecondForm.SecondForm();
            secondForm.Show();
        }

        private void AddNewOrderButtonClick(object sender, EventArgs e)
        {
            orderForm.Show();
        }

        private void HandleNewOrder(OrderItem item)
        {
            OrderControl orderControl = new OrderControl(item);
            Controls.Add(orderControl);
            if (orderControls.Count == 0)
            {
                orderControl.Top = lbNumberCommon.Bottom + 10;
                orderControl.Left = lbNumberCommon.Left;
            }
            else {
                OrderControl lastOrder = orderControls.Last();
                orderControl.Top = lastOrder.Bottom + 10;
                orderControl.Left = lastOrder.Left;
            }
            orderControls.Add(orderControl);
        }
    }
}