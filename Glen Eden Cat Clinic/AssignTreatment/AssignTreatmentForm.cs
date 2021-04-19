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

namespace Glen_Eden_Cat_Clinic.AssignTreatment
{
    public partial class AssignTreatmentForm : Form
    {
        private int visitId;
        private List<int> treatmentIds = new List<int>();
        public AssignTreatmentForm(int visit_id)
        {
            this.visitId = visit_id;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            OleDbConnection connection = DBConnection.Open();

            string strSQL = @"SELECT * FROM VISIT WHERE VisitID = @id";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            command.Parameters.AddWithValue("@ownerId", visitId);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                labelVisitID.Text = reader["VisitID"].ToString();
                //DateTime dt = DateTime.Parse(reader["VisitDate"].ToString());
                labelDescription.Text = reader["VisitDescription"].ToString();
                BirthDate.Text = reader["VisitDate"].ToString();

                strSQL = @"SELECT * FROM CAT WHERE CatID = @id";
                command = new OleDbCommand(strSQL, connection);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(reader["CatID"]));
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    labelCatID.Text = reader["CatID"].ToString();
                    labelCatName.Text = reader["CatName"].ToString();
                }

                strSQL = @"SELECT * FROM CAT WHERE CatID = @id";
                command = new OleDbCommand(strSQL, connection);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(reader["CatID"]));
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    labelCatID.Text = reader["CatID"].ToString();
                    labelCatName.Text = reader["CatName"].ToString();
                }

                strSQL = @"SELECT * FROM VISITTREATMENT WHERE VisitID = @id";
                command = new OleDbCommand(strSQL, connection);
                command.Parameters.AddWithValue("@id", visitId);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    long treatmentId = Convert.ToInt32(reader["TreatmentID"]);
                    
                    strSQL = @"SELECT * FROM TREATMENT WHERE TreatmentID = @id";
                    command = new OleDbCommand(strSQL, connection);
                    command.Parameters.AddWithValue("@id", treatmentId);
                    OleDbDataReader reader2 = command.ExecuteReader();

                    ListViewItem lvi = new ListViewItem(treatmentId.ToString());
                    if (reader2.Read())
                        lvi.SubItems.Add(reader2["TreatmentDescription"].ToString());
                    else
                        lvi.SubItems.Add("");
                    lvi.SubItems.Add(reader["Quantity"].ToString());
                    listView1.Items.Add(lvi);

                }
            }

            strSQL = @"SELECT * FROM TREATMENT";
            command = new OleDbCommand(strSQL, connection);
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                comboTreatments.Items.Insert(i, reader["TreatmentDescription"].ToString());
                treatmentIds.Add(Convert.ToInt32(reader["TreatmentID"]));
                i++;
            }
            connection.Close();

        }
        private void textQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AssignTreatmentButton_Click(object sender, EventArgs e)
        {
            if (comboTreatments.SelectedIndex < 0 || textQuantity.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please fill in all fields correctly");
                return;
            }

            OleDbConnection connection = DBConnection.Open();

            //Insert a new Visit to the database
            string strSQL = @"INSERT INTO VISITTREATMENT (VisitID, TreatmentID, Quantity) " +
                "VALUES (@visit_id, @treatment_id, @quantity)";

            OleDbCommand command = new OleDbCommand(strSQL, connection);
            command.Parameters.AddWithValue("@visit_id", visitId);
            command.Parameters.AddWithValue("@treatment_id", treatmentIds[comboTreatments.SelectedIndex]);
            command.Parameters.AddWithValue("@quantity", Convert.ToInt32(textQuantity.Text.Trim()));

            command.ExecuteReader();

            MessageBox.Show("Treatment assigned successfully");

            connection.Close();

        }

    }
}
