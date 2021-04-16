using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glen_Eden_Cat_Clinic.DBManage
{
    class DBConnection
    {
        public static OleDbConnection Open()
        {
            // Connection string and SQL query    
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\GlenEdenCatClinic.accdb";

            // Create a connection    
            OleDbConnection connection = new OleDbConnection(connectionString);

            // Open connecton    
            connection.Open();

            return connection;
        }
    }
}
