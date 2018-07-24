using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace UI_Example
{
    class DataBaseWrapper
    {
        private DataBaseConnection dbConnection;
        private SQLiteCommand command;

        public DataBaseWrapper()
        {
            dbConnection = DataBaseConnection.getInstance(); 
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
