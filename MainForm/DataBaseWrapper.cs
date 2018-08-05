using System;
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

        public List<CostItem> getCostItems()
        {
            List<CostItem> costItems = new List<CostItem>();

            DataTable table = new DataTable();
            String query = "SELECT * FROM costs";

            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, dbConnection.getConnection());
                adapter.Fill(table);
            }
            catch (SQLiteException ex)
            {
                return costItems;
            }

            foreach (DataRow row in table.Rows)
            {
                costItems.Add(new CostItem(row));
            }

            return costItems;
        }

        public List<CashBookItem> getCashBookItems()
        {
            List<CashBookItem> cashBookItems = new List<CashBookItem>();

            DataTable table = new DataTable();
            String query = "SELECT * FROM cashBook";

            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, dbConnection.getConnection());
                adapter.Fill(table);
            }
            catch (SQLiteException ex)
            {
                return cashBookItems;
            }

            foreach(DataRow row in table.Rows)
            {
                cashBookItems.Add(new CashBookItem(row));
            }

            return cashBookItems;
        }

        public List<OrderItem> getOrderItemsByDate(DateTime from, DateTime to)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            DataTable table = new DataTable();
            String query = "SELECT * FROM history WHERE date >='" + from.ToString("MM/dd/yyyy") + "' AND date <='" + to.ToString("MM/dd/yyyy") + "'";
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, dbConnection.getConnection());
                adapter.Fill(table);
            }
            catch (SQLiteException ex)
            {
                return orderItems;
            }

            OrderItem currentOrder = new OrderItem();

            foreach (DataRow row in table.Rows)
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
            if (currentOrder.kebabs.Count != 0)
                orderItems.Add(currentOrder);
            return orderItems;
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
                String query = "INSERT INTO history ('orderNumber', 'date', 'time', 'type', 'size', 'pita', 'quantity', 'cost') VALUES ('" +
                item.orderNumber + "','" +
                item.orderTime.ToString("MM/dd/yyyy") + "','" +
                item.orderTime.ToString("HH:mm:ss") + "','" +
                kebab.GetSaucesString() + "','" +
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

        public void addCostItem(CostItem item)
        {
            String query = "INSERT INTO costs ('date', 'category', 'name', 'count', 'costPerUnit', 'discount', 'isCash', 'comment') VALUES ('" +
                item.date.ToString("dd.MM.yyyy") + "','" +
                item.category.ToString() + "','" +
                item.name + "','" +
                item.count.ToString(CultureInfo.InvariantCulture) + "','" +
                item.costPerUnit.ToString(CultureInfo.InvariantCulture) + "','" +
                item.discount.ToString(CultureInfo.InvariantCulture) + "','" +
                item.isCash.ToString() + "','" +
                item.comment + "')";
            try
            {
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
            }
        }

        public void addCashBookItem(CashBookItem item)
        {
            String query = "INSERT INTO cashBook ('date','cashierName','cashBegin','cashEnd','cashIn','cashOut','nonCashIn','nonCashOut') VALUES ('" +
                item.Date.ToString("dd.MM.yyyy") + "','" +
                item.CashierName.ToString(CultureInfo.InvariantCulture) + "','" +
                item.CashBegin.ToString(CultureInfo.InvariantCulture) + "','" +
                item.CashEnd.ToString(CultureInfo.InvariantCulture) + "','" +
                item.CashIn.ToString(CultureInfo.InvariantCulture) + "','" +
                item.CashOut.ToString(CultureInfo.InvariantCulture) + "','" +
                item.NonCashIn.ToString(CultureInfo.InvariantCulture) + "','" +
                item.NonCashOut.ToString(CultureInfo.InvariantCulture) + "')";
            try
            {
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
            }
        }

        public UserInfo login(String username, String password)
        {
            DataTable table = new DataTable();
            String query = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'";
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, dbConnection.getConnection());
                adapter.Fill(table);
            }
            catch(SQLiteException ex)
            {
                return null;
            }
            if(table.Rows.Count > 0)
                return new UserInfo(table.Rows[0]);
            return null;
        }
    }
}
