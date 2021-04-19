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

namespace Glen_Eden_Cat_Clinic.UpdateCat
{
    public partial class UpdateCatForm : Form
    {
        private int isDelete; //0 - update a cat, 1 - delete a cat
        private int catId;
        public UpdateCatForm(int cat_id, int is_delete)
        {
            catId = cat_id;
            this.isDelete = is_delete;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            OleDbConnection connection = DBConnection.Open();

            //Read cat information
            string strSQL = @"SELECT * FROM CAT WHERE CatID = @catId";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            command.Parameters.AddWithValue("@catId", catId);
            // Execute command    
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textCatID.Text = reader["CatID"].ToString();
                textCatName.Text = reader["CatName"].ToString();
                textCatBreed.Text = reader["Breed"].ToString();
                comboCatGender.SelectedItem = reader["Gender"].ToString();
                BirthDate.Text = reader["DateOfBirth"].ToString();

                //read owner information
                int owner_id = Convert.ToInt32(reader["OwnerID"]);
                strSQL = @"SELECT * FROM OWNER WHERE OwnerID = @ownerId";
                command = new OleDbCommand(strSQL, connection);
                command.Parameters.AddWithValue("@ownerId", owner_id);
                OleDbDataReader reader2 = command.ExecuteReader();
                if (reader2.Read())
                {
                    textOwnerLastName.Text = reader2["LastName"].ToString();
                    textOwnerFirstName.Text = reader2["FirstName"].ToString();
                }
            }
            connection.Close();

            if (isDelete == 1)
            {
                textCatName.ReadOnly = true;
                textCatBreed.ReadOnly = true;
                BirthDate.Enabled = false;
                comboCatGender.Enabled = false;
                UpdateCatButton.Text = "Delete Cat";
                this.Text = "Delete Cat";
            }
        }

        private void UpdateCatButton_Click(object sender, EventArgs e)
        {
            if (textCatName.Text.Trim() == string.Empty ||
                comboCatGender.SelectedItem == null ||
                textCatBreed.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill in all fields correctly");
                return;
            }

            OleDbConnection connection = DBConnection.Open();

            if (isDelete == 0)
            {
                //update a cat
                string strSQL = @"UPDATE CAT SET CatName=@name, Breed=@breed, DateOfBirth=@birthdate, Gender=@gender WHERE CatID = @cat_id";

                OleDbCommand command = new OleDbCommand(strSQL, connection);
                command.Parameters.AddWithValue("@name", textCatName.Text.Trim());
                command.Parameters.AddWithValue("@breed", textCatBreed.Text.Trim());
                command.Parameters.AddWithValue("@birthdate", BirthDate.Value.ToString("MM/dd/yyyy"));
                command.Parameters.AddWithValue("@gender", comboCatGender.GetItemText(comboCatGender.SelectedItem));
                command.Parameters.AddWithValue("@cat_id", catId);

                command.ExecuteReader();

                MessageBox.Show("Cat updated successfully");
            } 
            else
            {
                //delete a cat
                string strSQL = @"DELETE FROM CAT WHERE CatID = @cat_id";

                OleDbCommand command = new OleDbCommand(strSQL, connection);
                command.Parameters.AddWithValue("@cat_id", catId);

                command.ExecuteReader();

                MessageBox.Show("Cat deleted successfully");
                this.DialogResult = DialogResult.OK;

            }

            connection.Close();
            //exit current UI
            this.DialogResult = DialogResult.OK;

        }

    }
}
