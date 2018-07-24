using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace UI_Example
{
    class DataBaseConnection
    {
        private const String dbName = "doners.db";
        private SQLiteConnection connection;
        private static DataBaseConnection instance;

        public SQLiteConnection getConnection()
        {
            return connection;
        }

        private DataBaseConnection()
        {
            connection = new SQLiteConnection("Data Source=" + dbName + ";Version=3;");
            connection.Open();
        }

        public static DataBaseConnection getInstance()
        {
            if (instance == null)
                instance = new DataBaseConnection();
            return instance;
        }
    }
}
