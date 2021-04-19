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

namespace Glen_Eden_Cat_Clinic.RemoveTreatment
{
    public partial class RemoveTreatmentForm : Form
    {
        private int visitId;
        public RemoveTreatmentForm(int visit_id)
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
                labelDescription.Text = reader["VisitDescription"].ToString();
                BirthDate.Text = reader["VisitDate"].ToString();


                strSQL = @"SELECT * FROM CAT WHERE CatID = @id";
                command = new OleDbCommand(strSQL, connection);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(reader["CatID"]));
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    labelCatName.Text = reader["CatName"].ToString();

                    int owner_id = Convert.ToInt32(reader["OwnerID"]);
                    strSQL = @"SELECT * FROM OWNER WHERE OwnerID = @id";
                    command = new OleDbCommand(strSQL, connection);
                    command.Parameters.AddWithValue("@id", owner_id);
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        labelOwnerLastName.Text = reader["LastName"].ToString();
                        labelOwnerFirstName.Text = reader["FirstName"].ToString();
                    }
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

            connection.Close();

        }

        private void AssignTreatmentButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please selecte a treatment to remove");
                return;
            }
            ListViewItem item = listView1.SelectedItems[0];
            int treatmentid =  Convert.ToInt32(item.SubItems[0].Text);
            int quantity = Convert.ToInt32(item.SubItems[2].Text);

            string strSQL = @"DELETE FROM VISITTREATMENT WHERE VisitID = @visit_id AND TreatmentID=@treatment_id AND Quantity=@quantity";

            OleDbConnection connection = DBConnection.Open();

            OleDbCommand command = new OleDbCommand(strSQL, connection);
            command.Parameters.AddWithValue("@visit_id", this.visitId);
            command.Parameters.AddWithValue("@treatment_id", treatmentid);
            command.Parameters.AddWithValue("@quantity", quantity);

            command.ExecuteReader();

            MessageBox.Show("Treatment removed successfully");
            this.DialogResult = DialogResult.OK;

        }
    }
}
