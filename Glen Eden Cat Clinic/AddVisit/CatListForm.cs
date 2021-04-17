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
    public partial class CatListForm : Form
    {
        private VisitModel model;
        public CatListForm(VisitModel model)
        {
            this.model = model;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            OleDbConnection connection = DBConnection.Open();

            //read the cat list
            string strSQL = @"SELECT * FROM CAT WHERE OwnerID = @ownerId";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            command.Parameters.AddWithValue("@ownerId", model.OwnerId); //selOwnerId
            // Execute command    
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader["CatId"].ToString());
                lvi.SubItems.Add(reader["CatName"].ToString());
                listView1.Items.Add(lvi);
            }

            connection.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            model.CatId = Convert.ToInt32(item.SubItems[0].Text);
            model.CatName = item.SubItems[1].Text;

            this.Close();
            VeterinarianListForm form = new VeterinarianListForm(model: model);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //textPhone.Text = new_cl.SelectPhone;
            }

        }
    }
}
