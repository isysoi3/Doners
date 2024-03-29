﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Example.Forms;
using UI_Example.Models;

namespace UI_Example.Controls
{
    public partial class CostsControl : UserControl
    {
        DataBaseWrapper dbWrapper;
        AddCostForm addCostForm;
        private List<CostItemControl> costItemControls;

        public CostsControl()
        {
            InitializeComponent();

            panel.AutoScroll = false;
            panel.HorizontalScroll.Enabled = false;
            panel.HorizontalScroll.Visible = false;
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = true;

            dbWrapper = new DataBaseWrapper();
            costItemControls = new List<CostItemControl>();
            addCostForm = new AddCostForm();
            addCostForm.addNewCostCallBack = addNewCostToDB;

            update();
        }

        public void update()
        {
            costItemControls.Clear();
            panel.Controls.Clear();
            List<CostItem> costItems = dbWrapper.getCostItems();
            costItems.Reverse();
            foreach(CostItem item in costItems)
            {
                addCost(item);
            }
        }

        public void addCost(CostItem item)
        {
            CostItemControl costItemControl = new CostItemControl(item);
            panel.Controls.Add(costItemControl);

            if (costItemControls.Count == 0)
            {
                costItemControl.Top = 0;
                costItemControl.Left = 0;
            }
            else
            {
                CostItemControl lastOrder = costItemControls.Last();
                costItemControl.Top = lastOrder.Bottom + 10;
                costItemControl.Left = lastOrder.Left;
            }

            costItemControls.Add(costItemControl);
        }

        public void addNewCostToDB(CostItem item)
        {
            dbWrapper.addCostItem(item);
            update();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            addCostForm.Show();
        }

        public void changeWidth(int width)
        {
            Width = width;
            gbCashBook.Width = width;
            panel.Width = width - 10;
            lbComment.Width = width - 805;
            btAdd.Left = (width - btAdd.Width) / 2;
            foreach (CostItemControl control in costItemControls)
                control.changeWidth(lbComment.Right - lbDate.Left);
        }

        public void changeHeight(int height)
        {
            Height = height;
            gbCashBook.Height = height;
            panel.Height = height - 85;
            btAdd.Top = Height - 30;
        }
    }
}
