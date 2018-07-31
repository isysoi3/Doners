using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UI_Example.Models
{
    public class CashBookItem
    {
        public DateTime Date { get; }
        public String CashierName { get; }

        public double CashBegin { get; }
        public double CashEnd { get; set; }

        public double CashIn { get; set; }
        public double CashOut { get; set; }

        public double NonCashIn { get; set; }
        public double NonCashOut { get; set; }

        public CashBookItem(String cashierName, double cashBegin)
        {
            Date = DateTime.Now;
            CashierName = cashierName;
            CashBegin = cashBegin;
            CashIn = 0;
            CashOut = 0;
            NonCashIn = 0;
            NonCashOut = 0;
        }

        public CashBookItem(DataRow row)
        {
            Date = DateTime.Parse(row.Field<String>("date"));
            CashierName = row.Field<String>("cashierName");
            CashBegin = row.Field<double>("cashBegin");
            CashEnd = row.Field<double>("cashEnd");
            CashIn = row.Field<double>("cashIn");
            CashOut = row.Field<double>("cashOut");
            NonCashIn = row.Field<double>("nonCashIn");
            NonCashOut = row.Field<double>("nonCashOut");
        }

        public double getTotalIn()
        {
            return CashIn + NonCashIn;
        }

        public double getTotalOut()
        {
            return CashOut + NonCashOut;
        }

        public double getTotal()
        {
            return getTotalIn() - getTotalOut();
        }

        public double getDifference()
        {
            return CashEnd - (CashBegin + CashIn - CashOut);
        }
    }
}
