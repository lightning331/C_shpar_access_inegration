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

namespace Glen_Eden_Cat_Clinic.AddVisit
{
    public partial class VeterinarianListForm : Form
    {
        private VisitModel model;
        public VeterinarianListForm(VisitModel model)
        {
            this.model = model;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            OleDbConnection connection = DBConnection.Open();

            //read veterinarian
            string strSQL = @"SELECT * FROM VETERINARIAN";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            // Execute command    
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader["VeterinarianID"].ToString());
                lvi.SubItems.Add(reader["LastName"].ToString());
                lvi.SubItems.Add(reader["FirstName"].ToString());
                listview1.Items.Add(lvi);
            }
            connection.Close();
        }

        private void listview1_DoubleClick(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            ListViewItem item = listview1.SelectedItems[0];
            model.VeterinarianId = Convert.ToInt32(item.SubItems[0].Text);
            model.VeterinarianLastName = item.SubItems[1].Text;
            model.VeterinarianFirstName = item.SubItems[2].Text;


            this.Close();

            AddVisitForm form = new AddVisitForm(model: model);
            this.DialogResult = DialogResult.OK;
            if (form.ShowDialog() == DialogResult.OK)
            {
                //textPhone.Text = new_cl.SelectPhone;
            }
        }

    }
}
