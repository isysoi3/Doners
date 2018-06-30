using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: fix all namespace
namespace UI_Example.Models
{
    class OrderItem
    {
        public double summary { get; private set; }
        private List<KebabItem> kebabs;

        public OrderItem()
        {
            summary = 0;
            kebabs = new List<KebabItem>();
        }

        public void AddNewKebabToOrder(KebabItem item)
        {
            kebabs.Add(item);
            summary += item.CountCost();
        }

        public void ClearOrder()
        {
            summary = 0;
            kebabs = new List<KebabItem>();
        }

    }
}
