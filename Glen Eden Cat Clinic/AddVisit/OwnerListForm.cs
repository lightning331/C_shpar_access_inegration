using Glen_Eden_Cat_Clinic.AddCat;
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
        private int formType; //0 - adding visit, 1 - adding cat
        private VisitModel modelVisit = new VisitModel();
        private CatModel modelCat = new CatModel();
        public OwnerListForm(int type)
        {
            formType = type;
            InitializeComponent();
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

            this.Close(); //close current form
            if (formType == 0)
            {
                modelVisit.OwnerId = Convert.ToInt32(item.SubItems[0].Text);
                modelVisit.OwnerLastName = item.SubItems[1].Text;
                modelVisit.OwnerFirstName = item.SubItems[2].Text;
                CatListForm form = new CatListForm(model: modelVisit);
                form.ShowDialog();
            }
            else
            {
                modelCat.OwnerId = Convert.ToInt32(item.SubItems[0].Text);
                modelCat.OwnerLastName = item.SubItems[1].Text;
                modelCat.OwnerFirstName = item.SubItems[2].Text;
                AddCatForm form = new AddCatForm(model: modelCat);
                form.ShowDialog();

            }
        }

    }
}
