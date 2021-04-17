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

namespace Glen_Eden_Cat_Clinic.UpdateVisit
{
    public partial class UpdateVisitForm : Form
    {
        private int visitId;
        public UpdateVisitForm(int visit_id)
        {
            visitId = visit_id;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            OleDbConnection connection = DBConnection.Open();

            //read the owner list
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
                    textVisitID.Text = reader["VisitID"].ToString();
                    textDescription.Text = reader["VisitDescription"].ToString();
                    VisitDate.Text = reader["VisitDate"].ToString();
                    textFee.Text = reader["Fee"].ToString();
                    comboBoxStatus.Text = reader["Status"].ToString();
                    
                    //Read cat information
                    int cat_id = Convert.ToInt32(reader["CatID"]);
                    strSQL = @"SELECT * FROM CAT WHERE CatID = @catId";
                    command = new OleDbCommand(strSQL, connection);
                    command.Parameters.AddWithValue("@catId", cat_id);
                    // Execute command    
                    OleDbDataReader reader2 = command.ExecuteReader();
                    if (reader2.Read())
                    {
                        textCat.Text = reader2["CatName"].ToString();

                        //read owner information
                        int owner_id = Convert.ToInt32(reader2["OwnerID"]);
                        strSQL = @"SELECT * FROM OWNER WHERE OwnerID = @ownerId";
                        command = new OleDbCommand(strSQL, connection);
                        command.Parameters.AddWithValue("@ownerId", owner_id);
                        OleDbDataReader reader3 = command.ExecuteReader();
                        if (reader3.Read())
                        {
                            textLastName.Text = reader3["LastName"].ToString();
                            textFirstName.Text = reader3["FirstName"].ToString();
                        }
                    }
                }

            }
        }
        private void UpdateVisitButton_Click(object sender, EventArgs e)
        {
            if (textFee.Text.Trim() == string.Empty || textDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill in all fields correctly");
                return;
            }
            if (comboBoxStatus.SelectedIndex != 1)
            {
                MessageBox.Show("Status must only be updated to paid");
                return;
            }

            OleDbConnection connection = DBConnection.Open();

            string strSQL = @"UPDATE VISIT SET VisitDescription=@description, VisitDate=@date, Status=@status, Fee=@fee " +
                "WHERE VisitID = @visit_id";


            OleDbCommand command = new OleDbCommand(strSQL, connection);

            command.Parameters.AddWithValue("@description", textDescription.Text.Trim());
            command.Parameters.AddWithValue("@date", VisitDate.Value.ToString("MM/dd/yyyy"));
            command.Parameters.AddWithValue("@status", comboBoxStatus.Text.Trim());
            command.Parameters.AddWithValue("@fee", Convert.ToDecimal(textFee.Text.Trim()));
            command.Parameters.AddWithValue("@visit_id", visitId);

            command.ExecuteReader();
            
            connection.Close();

            MessageBox.Show("Visit updated successfully");
            this.DialogResult = DialogResult.OK;
        }
    }
}
