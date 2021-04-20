using Glen_Eden_Cat_Clinic.DBManage;
using Glen_Eden_Cat_Clinic.Models;
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
        private VisitModel model;
        public AddVisitForm(VisitModel model)
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
            textCatId.Text = model.CatId.ToString();
            textCatName.Text = model.CatName;
            textVeterId.Text = model.VeterinarianID.ToString();
            textVeterLastName.Text = model.VeterinarianLastName;
            textVeterFirstName.Text = model.VeterinarianFirstName;
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
            if (textFee.Text.Trim() == string.Empty || textDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill in all fields correctly");
                return;
            }

            OleDbConnection connection = DBConnection.Open();

            //Insert a new Visit to the database
            string strSQL = @"INSERT INTO VISIT (VisitDescription, VisitDate, Status, Fee, CatID, VeterinarianID) " + 
                "VALUES (@description, @date, @status, @fee, @catid, @verterinarianid) ";

            OleDbCommand command = new OleDbCommand(strSQL, connection);
            command.Parameters.AddWithValue("@description", textDescription.Text.Trim());
            command.Parameters.AddWithValue("@date", VisitDate.Value.ToString("MM/dd/yyyy"));
            command.Parameters.AddWithValue("@status", "Current");
            command.Parameters.AddWithValue("@fee", Convert.ToDecimal(textFee.Text.Trim()));
            command.Parameters.AddWithValue("@catid", model.CatId);
            command.Parameters.AddWithValue("@verterinarianid", model.VeterinarianID);
            
            command.ExecuteReader();

            connection.Close();

            MessageBox.Show("Visit added successfully");
            //exit current UI
            this.DialogResult = DialogResult.OK;
        }

    }
}
