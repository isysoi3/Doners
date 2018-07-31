using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Example.Models
{
    public enum CostCategory { PRODUCTS, HOUSEHOLD, SALARY, MEDICAL, EQUIPMENT, COMMERCIAL, PRESENTATIONAL };

    public class CostItem
    {
        public CostCategory category;
        public String name;
        public double count;
        public double costPerUnit;
        public double discount;
        public bool isCash;
        public String comment;

        public CostItem(CostCategory category,
            String name,
            double count,
            double costPerUnit,
            double discount,
            bool isCash,
            String comment)
        {
            this.category = category;
            this.name = name;
            this.count = count;
            this.costPerUnit = costPerUnit;
            this.discount = discount;
            this.isCash = isCash;
            this.comment = comment;
        }
    }
}
