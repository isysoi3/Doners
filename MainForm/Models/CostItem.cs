using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UI_Example.Models
{
    public enum CostCategory { PRODUCTS, ADVERTISMENT, HOUSEHOLD, SALARY, MEDICAL, EQUIPMENT, COMMERCIAL, PRESENTATIONAL, ETC };

    public class CostItem
    {
        public DateTime date;
        public CostCategory category;
        public String name;
        public double count;
        public double costPerUnit;
        public double discount;
        public bool isCash;
        public String comment;

        public CostItem(DateTime date,
            CostCategory category,
            String name,
            double count,
            double costPerUnit,
            double discount,
            bool isCash,
            String comment)
        {
            this.date = date;
            this.category = category;
            this.name = name;
            this.count = count;
            this.costPerUnit = costPerUnit;
            this.discount = discount;
            this.isCash = isCash;
            this.comment = comment;
        }

        public CostItem(DataRow row)
        {
            date = DateTime.Parse(row.Field<String>("date"));
            category = (CostCategory)Enum.Parse(typeof(CostCategory), row.Field<String>("category"));
            name = row.Field<String>("name");
            count = row.Field<double>("count");
            costPerUnit = row.Field<double>("costPerUnit");
            discount = row.Field<double>("discount");
            isCash = bool.Parse(row.Field<String>("isCash"));
            comment = row.Field<String>("comment");
        }
    }
}
