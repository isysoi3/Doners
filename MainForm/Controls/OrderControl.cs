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
            AddKebabControls(item.kebabs);
        }

        private void AddKebabControls(List<KebabItem> kebabs)
        {
            foreach(KebabItem kebab in kebabs)
            {
                KebabControl orderControl = new KebabControl(kebab);
                this.Controls.Add(orderControl);
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
