using System;
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
        }

        public void update()
        {

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
    }
}
