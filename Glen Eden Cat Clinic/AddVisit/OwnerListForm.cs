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
    public partial class OwnerListForm : Form
    {
        private VisitModel model = new VisitModel();
        public OwnerListForm()
        {
            InitializeComponent();
            //listOwner.Columns[1].Width = 360;
            LoadData();
        }

        private void LoadData()
        {
            OleDbConnection connection = DBConnection.Open();

            //read the owner list
            string strSQL = @"SELECT * FROM OWNER WHERE CreditStatus ='Valid'";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            // Execute command    
            OleDbDataReader reader = command.ExecuteReader();
            //int i = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader["OwnerId"].ToString());
                    lvi.SubItems.Add(reader["LastName"].ToString());
                    lvi.SubItems.Add(reader["FirstName"].ToString());
                    listOwner.Items.Add(lvi);
                }

            }

            connection.Close();
        }

        private void listOwner_DoubleClick(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            ListViewItem item = listOwner.SelectedItems[0];
            model.OwnerId = Convert.ToInt32(item.SubItems[0].Text);
            model.OwnerLastName = item.SubItems[1].Text;
            model.OwnerFirstName = item.SubItems[2].Text;


            this.Close(); //close current form
            CatListForm form = new CatListForm(model: model);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //textPhone.Text = new_cl.SelectPhone;
            }
        }

    }
}
