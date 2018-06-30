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
using UI_Example.Controls;

//TODO: fix all namespace
namespace UI_Example
{

    public partial class QueueForm : Form
    {
        private AddOrderForm orderForm;

        public QueueForm()
        {
            InitializeComponent();
            orderForm = new AddOrderForm();
            orderForm.AddOrderCallback = new AddNewOrderDelegate(HandleNewOrder);
        }

        private void AddNewOrderButtonClick(object sender, EventArgs e)
        {
            orderForm.Show();
        }

        private void HandleNewOrder(OrderItem item)
        {
            double tmp = item.summary;
            OrderControl orderControl = new OrderControl(item);
            Controls.Add(orderControl);
            orderControl.Top = label14.Bottom + 10;
        }
    }
}