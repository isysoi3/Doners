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
    public partial class CostItemControl : UserControl
    {
        public CostItemControl(CostItem item)
        {
            InitializeComponent();
            lbDate.Text = item.date.ToString("dd.MM.yyyy");
            lbCategory.Text = getStringCategory(item.category);
            lbName.Text = item.name;
            lbCount.Text = item.count.ToString();
            lbCost.Text = item.costPerUnit.ToString();
            lbDiscount.Text = item.discount.ToString();
            lbToPay.Text = (item.count * item.costPerUnit - item.discount).ToString();
            if (item.isCash)
                lbPaymentType.Text = "Нал";
            else
                lbPaymentType.Text = "Безнал";
            lbComment.Text = item.comment;
        }

        public void changeWidth(int width)
        {
            Width = width;
            lbComment.Width = width - 764;
        }

        private String getStringCategory(CostCategory category)
        {
            switch(category)
            {
                case CostCategory.ADVERTISMENT:
                    return "Реклама";
                case CostCategory.COMMERCIAL:
                    return "Ком.расходы";
                case CostCategory.EQUIPMENT:
                    return "Оборудование";
                case CostCategory.HOUSEHOLD:
                    return "Хоз.товары";
                case CostCategory.MEDICAL:
                    return "Мед. товары";
                case CostCategory.PRESENTATIONAL:
                    return "Пред.расходы";
                case CostCategory.PRODUCTS:
                    return "Продукты";
                case CostCategory.SALARY:
                    return "Зарплата";
                default:
                    return "Другое";
            }
        }  
    }
}
