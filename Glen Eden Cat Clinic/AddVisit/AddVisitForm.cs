using Glen_Eden_Cat_Clinic.DBManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glen_Eden_Cat_Clinic.AddVisit
{
    public partial class AddVisitForm : Form
    {
        private List<int> ownerIdArray = new List<int>{};
        private List<int> catIdArray = new List<int> { };
        private List<int> veterinarianIdArray = new List<int> { };
        private int ownerIndex = -1;
        private int catIndex = -1;
        private int veterinarianIndex = -1;
        public AddVisitForm()
        {
            InitializeComponent();
            LoadData();
/*            comboBoxOwner.Items.Insert(0, "select1");
            comboBoxOwner.Items.Insert(1, "select2");
*/        }

        private void LoadData()
        {
            
            OleDbConnection connection = DBConnection.Open();

            //read the owner list
            string strSQL = @"SELECT * FROM OWNER WHERE CreditStatus ='Valid'";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            // Execute command    
            OleDbDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                ownerIdArray.Add(Convert.ToInt32(reader["OwnerID"]));
                comboBoxOwner.Items.Insert(i, reader["LastName"].ToString() + " " + reader["FirstName"].ToString());
                i++;
            }

            //read veterinarian
            strSQL = @"SELECT * FROM VETERINARIAN";
            command = new OleDbCommand(strSQL, connection);
            // Execute command    
            reader = command.ExecuteReader();
            i = 0;
            while (reader.Read())
            {
                veterinarianIdArray.Add(Convert.ToInt32(reader["VeterinarianID"]));
                comboBoxVeterinarian.Items.Insert(i, reader["LastName"].ToString() + " " + reader["FirstName"].ToString());
                i++;
            }


            connection.Close();
        }

        private void comboBoxOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ownerIndex = comboBoxOwner.SelectedIndex;

            OleDbConnection connection = DBConnection.Open();

            //read the cat list
            string strSQL = @"SELECT * FROM CAT WHERE OwnerID = @ownerId";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            command.Parameters.AddWithValue("@ownerId", ownerIdArray[ownerIndex]); //selOwnerId
            // Execute command    
            OleDbDataReader reader = command.ExecuteReader();

            int i = 0;
            comboBoxCat.Items.Clear();
            catIdArray.Clear();
            catIndex = -1;
            while (reader.Read())
            {
                catIdArray.Add(Convert.ToInt32(reader["CatId"]));
                comboBoxCat.Items.Insert(i, reader["CatName"].ToString());
                i++;
            }

            connection.Close();
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            catIndex = comboBoxCat.SelectedIndex;
        }
        private void comboBoxVeterinarian_SelectedIndexChanged(object sender, EventArgs e)
        {
            veterinarianIndex = comboBoxVeterinarian.SelectedIndex;
        }

        private void textFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddVisitButton_Click(object sender, EventArgs e)
        {
            if (ownerIndex == -1 || catIndex == -1 || veterinarianIndex == -1 || 
                textFee.Text.Trim() == string.Empty || textDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill all the fields", "Error!");
                return;
            }

            OleDbConnection connection = DBConnection.Open();

            //Insert a new Visit to the database
            string strSQL = @"INSERT INTO VISIT (VisitDescription, VisitDate, Status, Fee, CatID, VeterinarianID) " + 
                "VALUES (@description, @date, @status, @fee, @catid, @verterinarianid) ";

            //string strSQL = @"INSERT INTO VISIT (VisitDescription, VisitDate, Status, Fee, CatID, VeterinarianID) VALUES ('test descri', '1/23/2022', 'Current', 23, 15, 2 )";

            OleDbCommand command = new OleDbCommand(strSQL, connection);
            command.Parameters.AddWithValue("@description", textDescription.Text.Trim());
            command.Parameters.AddWithValue("@date", VisitDate.Value.ToString("MM/dd/yyyy"));
            command.Parameters.AddWithValue("@status", "Current");
            command.Parameters.AddWithValue("@fee", Convert.ToDecimal(textFee.Text.Trim()));
            command.Parameters.AddWithValue("@catid", catIdArray[catIndex]);
            command.Parameters.AddWithValue("@verterinarianid", veterinarianIdArray[veterinarianIndex]);
            
            command.ExecuteReader();

            connection.Close();

            MessageBox.Show("Visit added successfully", "Success!");
            this.DialogResult = DialogResult.OK;
        }

    }
}
