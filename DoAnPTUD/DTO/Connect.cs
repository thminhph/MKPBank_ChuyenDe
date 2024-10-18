using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Connect
    {
        private string dataSource, database, userName, passWord;
        public Connect()
        {

        }

        public string DataSource { get => dataSource; set => dataSource = value; }
        public string Database { get => database; set => database = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        public string SqlconnectionSQLSeverAuthentication()
        {
            string connString =
                @"Data Source=" + DataSource +
                ";Initial Catalog=" + Database +
                ";User ID=" + UserName +
                ";Password=" + PassWord;
            return connString;
        }
        public string SqlConnectionWindowsAuthentication()
        {
            string connString = @"Data Source=" + DataSource + ";Initial Catalog="
                        + Database + ";Integrated Security=True";
            return connString;
        }
        public string SqlConnectionWindows()
        {
            string connString = @"Data Source=" + DataSource + ";Initial Catalog="
                        + Database + ";Integrated Security=True";
            return connString;
        }
        public Connect(string datasource, string database, string username, string password)
        {
            DataSource = datasource;
            Database = database;
            UserName = username;
            PassWord = password;
        }
        public Connect(string datasource, string database)
        {
            DataSource = datasource;
            Database = database;
        }
    }
}
