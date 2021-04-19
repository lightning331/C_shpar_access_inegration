using Glen_Eden_Cat_Clinic.DBManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glen_Eden_Cat_Clinic.DeleteVisit
{
    public partial class DeleteVisitForm : Form
    {
        private int visitId;
        public DeleteVisitForm(int visit_id)
        {
            visitId = visit_id;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            OleDbConnection connection = DBConnection.Open();

            //read the visit list
            string strSQL = @"SELECT * FROM VISIT WHERE VisitID = @id";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            command.Parameters.AddWithValue("@ownerId", visitId);
            // Execute command    
            OleDbDataReader reader = command.ExecuteReader();
            //int i = 0;
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    labelVisitID.Text = reader["VisitID"].ToString();
                    labelDescription.Text = reader["VisitDescription"].ToString();
                    DateTime dt = DateTime.Parse(reader["VisitDate"].ToString());
                    labelDate.Text = dt.ToString("MM/dd/yyyy");//reader["VisitDate"].ToString();
                    labelVisitFee.Text = reader["Fee"].ToString();
                    labelStatus.Text = reader["Status"].ToString();
                }

            }
        }

        private void DeleteVisitButton_Click(object sender, EventArgs e)
        {//delete a visit
            if (labelStatus.Text.Trim() != "Paid")
            {
                MessageBox.Show("Current visits cannot be deleted");
                return;
            }

            string strSQL = @"DELETE FROM VISIT WHERE VisitID = @visit_id";

            OleDbConnection connection = DBConnection.Open();

            OleDbCommand command = new OleDbCommand(strSQL, connection);

            command.Parameters.AddWithValue("@visit_id", visitId);

            command.ExecuteReader();

            connection.Close();

            MessageBox.Show("Visit deleted successfully");
            this.DialogResult = DialogResult.OK;

        }
    }
}
