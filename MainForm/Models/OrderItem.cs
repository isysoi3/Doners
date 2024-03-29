﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: fix all namespace
namespace UI_Example.Models
{
    public class OrderItem
    {
        public int orderNumber;
        public DateTime orderTime;
        public double summary { get; private set; }
        public List<KebabItem> kebabs { get; private set; }

        public OrderItem()
        {
            summary = 0;
            kebabs = new List<KebabItem>();
        }

        public bool IsOrderEmpty()
        {
            if (kebabs.Count == 0)
                return true;
            else
                return false;
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
