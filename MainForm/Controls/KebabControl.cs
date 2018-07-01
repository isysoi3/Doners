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

            setInfo(item);
            int saucesCount = lbSauces.Text.Split('\n').Length - 1;
            int cellsHeight = saucesCount * lbSauces.Height;

            setHeigth(cellsHeight);
        }

        private void setInfo(KebabItem item)
        {
            lbComment.Text = item.comment;
            lbQuantity.Text = item.quantity.ToString();
            lbSauces.Text = item.GetSaucesString();
            lbPitaType.Text = item.GetPitaTypeString();
            lbSize.Text = item.GetSizeString();
        }

        private void setHeigth(int height)
        {
            Height = height;
            lbComment.Height = height;
            lbQuantity.Height = height;
            lbSauces.Height = height;
            lbPitaType.Height = height;
            lbSize.Height = height;
        }

        public void setWidth(int width)
        {
            Width = width;
            lbComment.Width = width - lbQuantity.Right;
        }
    }
}
