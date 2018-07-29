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
    public partial class HistoryOrderControl : UserControl
    {

        public HistoryOrderControl(OrderItem item)
        {
            InitializeComponent();
            AddKebabControls(item.kebabs);
            lbDate.Text = item.orderTime.ToString("dd.MM.yyyy");
            lbTime.Text = item.orderTime.ToString("HH:mm:ss");

        }

        private void AddKebabControls(List<KebabItem> kebabs)
        {
            KebabControl lastControl = null;
            foreach (KebabItem kebab in kebabs)
            {
                KebabControl orderControl = new KebabControl(kebab);
                orderControl.Left = lbTime.Right;
                if (lastControl == null)
                    orderControl.Top = lbDate.Top;
                else
                    orderControl.Top = lastControl.Bottom;
                lastControl = orderControl;
                this.Controls.Add(orderControl);
            }
            lbDate.Height = lastControl.Bottom - lbDate.Top;
            lbTime.Height = lbDate.Height;
            this.Height = lbDate.Height;
        }
    }
}
