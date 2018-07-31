using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Example.Models;

namespace UI_Example.Forms
{

    public delegate void AddNewCostDelegate(CostItem item);

    public partial class AddCostForm : Form
    {
        public AddNewCostDelegate addNewCostCallBack;

        public AddCostForm()
        {
            InitializeComponent();
        }

        private bool checkInput()
        {
            double result;
            if (cbCategory.Text == "")
                return false;
            if (tbName.Text == "")
                return false;
            if (tbCount.Text == "" || !double.TryParse(tbCount.Text, out result))
                return false;
            if (tbCost.Text == "" || !double.TryParse(tbCost.Text, out result))
                return false;
            if (tbDiscount.Text == "" || !double.TryParse(tbDiscount.Text, out result))
                return false;
            return true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!checkInput())
                return;
            addNewCostCallBack(new CostItem(getCostCategory(), tbName.Text, double.Parse(tbCount.Text), double.Parse(tbCost.Text), double.Parse(tbDiscount.Text), rbCash.Checked, rtbComment.Text));
            Hide();
        }

        private CostCategory getCostCategory()
        {
            switch(cbCategory.Text)
            {
                case "Продукты":
                    return CostCategory.PRODUCTS;
                case "Хоз. товары":
                    return CostCategory.HOUSEHOLD;
                case "Зарплата":
                    return CostCategory.SALARY;
                case "Мед. товары":
                    return CostCategory.MEDICAL;
                case "Оборудование":
                    return CostCategory.EQUIPMENT;
                case "Ком. расходы":
                    return CostCategory.COMMERCIAL;
                case "Реклама":
                    return CostCategory.ADVERTISMENT;
                case "Пред. расходы":
                    return CostCategory.PRESENTATIONAL;
                default:
                    return CostCategory.ETC;
            }
        }
    }
}
