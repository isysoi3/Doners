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
    public partial class CashBookItemControl : UserControl
    {
        public CashBookItemControl(CashBookItem item)
        {
            InitializeComponent();
            lbDate.Text = item.Date.ToString("dd.MM.yyyy");
            lbCashier.Text = item.CashierName;
            lbBegin.Text = item.CashBegin.ToString();
            lbEnd.Text = item.CashEnd.ToString();
            lbIn.Text = item.getTotalIn().ToString();
            lbOut.Text = item.getTotalOut().ToString();
            lbTotal.Text = item.getTotal().ToString();
            lbDiff.Text = item.getDifference().ToString();

            toolTip.SetToolTip(lbIn, "Наличный приход: " + item.CashIn + "\nБезниличный приход: " + item.NonCashIn);
            toolTip.SetToolTip(lbOut, "Наличный расход: " + item.CashOut + "\nБезниличный расход: " + item.NonCashOut);
        }

        public void changeWidth(int width)
        {
            Width = width;
            lbDiff.Width = width - 944;
        }
    }
}
