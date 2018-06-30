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
    public partial class KebabControl : UserControl
    {
        public KebabControl(KebabItem item)
        {
            InitializeComponent();

            lbComment.Text = item.comment;
            lbQuantity.Text = item.quantity.ToString();
            lbSauces.Text = item.GetSaucesString();
            lbPitaType.Text = item.GetPitaTypeString();
            lbSize.Text = item.GetSizeString();
        }
    }
}
