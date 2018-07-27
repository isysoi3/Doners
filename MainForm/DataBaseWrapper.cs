using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using UI_Example.Models;

namespace UI_Example
{
    class DataBaseWrapper
    {
        private DataBaseConnection dbConnection;
        private SQLiteCommand command;

        public DataBaseWrapper()
        {
            dbConnection = DataBaseConnection.getInstance();
            command = new SQLiteCommand();
            command.Connection = dbConnection.getConnection();
        }

        public void addOrder(OrderItem item)
        {
            foreach(KebabItem kebab in item.kebabs)
            {
                String query = "INSERT INTO history ('orderNumber', 'date', 'time', 'isGarlic', 'isSalsa', 'isCheesy', 'isCaesar', 'isMustard', 'isBigMac', 'isBigTasty', 'size', 'pita', 'quantity', 'cost') VALUES ('" +
                item.orderNumber + "','" +
                item.orderTime.Date.Month + "." + item.orderTime.Date.Day + "','" +
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
