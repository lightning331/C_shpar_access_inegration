using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.OleDb;
using Glen_Eden_Cat_Clinic.DBManage;

namespace Glen_Eden_Cat_Clinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

/*            string strDSN = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = E:\\Database1.accdb";
            string strSQL = "SELECT * FROM Foods";
            // create Objects of ADOConnection and ADOCommand    
            OleDbConnection myConn = new OleDbConnection(strDSN);
            OleDbDataAdapter myCmd = new OleDbDataAdapter(strSQL, myConn);
            myConn.Open();
            DataSet dtSet = new DataSet();
            myCmd.Fill(dtSet, "Developer");
            DataTable dTable = dtSet.Tables[0];
            //dataGridView1.DataSource = dtSet.Tables["Developer"].DefaultView;
            myConn.Close();
*/        }

        private void AddVisitButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = DBConnection.Open();
            string strSQL = "SELECT * FROM CAT";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            
            // Execute command    
            OleDbDataReader reader = command.ExecuteReader();

            Console.WriteLine("------------Original data----------------");
            while (reader.Read())
            {
                Console.WriteLine("{0}, {1}", reader["CatName"].ToString(), reader["Breed"].ToString());
            }

            connection.Close();

//            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\GlenEdenCatClinic.accdb";
//            string strSQL = "SELECT * FROM CAT";
// Create a connection    
            /*            using (OleDbConnection connection = new OleDbConnection(connectionString))
                        {
                            // Create a command and set its connection    
                            // Open connecton    
                            connection.Open();

                            OleDbCommand command = new OleDbCommand(strSQL, connection);
                            // Open the connection and execute the select command.    
                            try
                            {
                                // Execute command    
                                using (OleDbDataReader reader = command.ExecuteReader())
                                {
                                    Console.WriteLine("------------Original data----------------");
                                    while (reader.Read())
                                    {
                                        Console.WriteLine("{0}, {1}", reader["CatName"].ToString(), reader["Breed"].ToString());
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                             }
                            // The connection is automatically closed becasuse of using block.    
                        }
            */            //Console.ReadKey();
        }

        private void UpdateVisitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
