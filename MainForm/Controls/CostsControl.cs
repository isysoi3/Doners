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
        AddCostForm addCostForm;

        public CostsControl()
        {
            InitializeComponent();
            addCostForm = new AddCostForm();
            addCostForm.addNewCostCallBack = addNewCost;
        }

        public void addNewCost(CostItem item)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            addCostForm.Show();
        }
    }
}
