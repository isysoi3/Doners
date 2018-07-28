﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using UI_Example.Models;
using System.Globalization;

namespace UI_Example
{
    class DataBaseWrapper
    {
        private DataBaseConnection dbConnection;
        private SQLiteCommand command;
        private static CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

        public DataBaseWrapper()
        {
            dbConnection = DataBaseConnection.getInstance();
            command = new SQLiteCommand();
            command.Connection = dbConnection.getConnection();
        }

        public List<OrderItem> getTodayOrderItems()
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            DataTable table = new DataTable();
            String query = "SELECT * FROM history WHERE date ='" + DateTime.Now.ToString("MM/dd/yyyy") + "'";
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, dbConnection.getConnection());
                adapter.Fill(table);
            }
            catch (SQLiteException ex)
            {
                String v = ex.Message;
                return orderItems;
            }

            OrderItem currentOrder = new OrderItem();

            foreach(DataRow row in table.Rows)
            {
                if (currentOrder.kebabs.Count != 0)
                {
                    int orderNumber = (int)row.Field<Int64>("orderNumber");
                    DateTime orderTime = DateTime.Parse(row.Field<String>("date") + " " + row.Field<String>("time"), culture);

                    if (currentOrder.orderNumber == orderNumber && currentOrder.orderTime == orderTime)
                    {
                        currentOrder.AddNewKebabToOrder(new KebabItem(row));
                    }
                    else
                    {
                        orderItems.Add(currentOrder);

                        currentOrder = new OrderItem();
                        currentOrder.orderNumber = (int)row.Field<Int64>("orderNumber");
                        currentOrder.orderTime = DateTime.Parse(row.Field<String>("date") + " " + row.Field<String>("time"), culture);

                        currentOrder.AddNewKebabToOrder(new KebabItem(row));
                    }
                }
                else
                {
                    currentOrder.orderNumber = (int)row.Field<Int64>("orderNumber");
                    currentOrder.orderTime = DateTime.Parse(row.Field<String>("date") + " " + row.Field<String>("time"), culture);

                    currentOrder.AddNewKebabToOrder(new KebabItem(row));
                }
            }
            if(currentOrder.kebabs.Count != 0)
                orderItems.Add(currentOrder);
            return orderItems;
        }

        public void addOrder(OrderItem item)
        {
            foreach(KebabItem kebab in item.kebabs)
            {
                String query = "INSERT INTO history ('orderNumber', 'date', 'time', 'isGarlic', 'isSalsa', 'isCheesy', 'isCaesar', 'isMustard', 'isBigMac', 'isBigTasty', 'size', 'pita', 'quantity', 'cost') VALUES ('" +
                item.orderNumber + "','" +
                item.orderTime.ToString("MM/dd/yyyy") + "','" +
                item.orderTime.ToString("HH:mm:ss") + "','" +
                kebab.sauces.Exists((SauceTypeEnum sauce) => sauce == SauceTypeEnum.garlic) + "','" +
                kebab.sauces.Exists((SauceTypeEnum sauce) => sauce == SauceTypeEnum.salsa) + "','" +
                kebab.sauces.Exists((SauceTypeEnum sauce) => sauce == SauceTypeEnum.cheesy) + "','" +
                kebab.sauces.Exists((SauceTypeEnum sauce) => sauce == SauceTypeEnum.caesar) + "','" +
                kebab.sauces.Exists((SauceTypeEnum sauce) => sauce == SauceTypeEnum.mustard) + "','" +
                kebab.sauces.Exists((SauceTypeEnum sauce) => sauce == SauceTypeEnum.bigMac) + "','" +
                kebab.sauces.Exists((SauceTypeEnum sauce) => sauce == SauceTypeEnum.bigTasty) + "','" +
                kebab.sizeType + "','" +
                kebab.pitaType + "','" +
                kebab.quantity + "','" +
                kebab.CountCost() + "')";
                try
                {
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                }
            }
        }

        public bool login(String username, String password)
        {
            DataTable table = new DataTable();
            String query = "SELECT * FROM users WHERE username=" + username + " AND password=" + password;
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, dbConnection.getConnection());
                adapter.Fill(table);
            }
            catch(SQLiteException ex)
            {
                return false;
            }
            if(table.Rows.Count > 0)
                return true;
            return false;
        }
    }
}