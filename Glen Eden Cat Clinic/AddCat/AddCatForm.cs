using Glen_Eden_Cat_Clinic.DBManage;
using Glen_Eden_Cat_Clinic.Models;
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

namespace Glen_Eden_Cat_Clinic.AddCat
{
    public partial class AddCatForm : Form
    {
        private CatModel model;
        public AddCatForm(CatModel model)
        {
            this.model = model;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            textOwnerId.Text = model.OwnerId.ToString();
            textOwnerLastName.Text = model.OwnerLastName;
            textOwnerFirstName.Text = model.OwnerFirstName;
            comboCatGender.SelectedIndex = 0;
        }

        private void AddCatButton_Click(object sender, EventArgs e)
        {
            if (textCatName.Text.Trim() == string.Empty || 
                comboCatGender.SelectedItem == null || 
                textCatBreed.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill in all fields correctly");
                return;
            }
            
            OleDbConnection connection = DBConnection.Open();

            //Insert a new Visit to the database
            string strSQL = @"INSERT INTO CAT (CatName, Breed, DateOfBirth, Gender, OwnerID) " +
                "VALUES (@name, @breed, @birthdate, @gender, @ownerid)";

            OleDbCommand command = new OleDbCommand(strSQL, connection);
            command.Parameters.AddWithValue("@name", textCatName.Text.Trim());
            command.Parameters.AddWithValue("@breed", textCatBreed.Text.Trim());
            command.Parameters.AddWithValue("@birthdate", BirthDate.Value.ToString("MM/dd/yyyy"));
            command.Parameters.AddWithValue("@gender", comboCatGender.GetItemText(comboCatGender.SelectedItem));
            command.Parameters.AddWithValue("@ownerid", model.OwnerId);
            
            command.ExecuteReader();

            connection.Close();

            MessageBox.Show("Cat added successfully");
            //exit current UI
            this.DialogResult = DialogResult.OK;

        }
    }
}
