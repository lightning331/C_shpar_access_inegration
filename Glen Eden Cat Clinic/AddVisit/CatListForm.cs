using Glen_Eden_Cat_Clinic.AddCat;
using Glen_Eden_Cat_Clinic.DBManage;
using Glen_Eden_Cat_Clinic.Models;
using Glen_Eden_Cat_Clinic.UpdateCat;
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
        private VisitModel  model;
        private int isDelete;
        public CatListForm(VisitModel model, int is_delete = 0)
        {
            this.model = model;
            this.isDelete = is_delete;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            OleDbConnection connection = DBConnection.Open();

            //read the cat list
            string strSQL;
            OleDbCommand command;
            if (model != null)
            {
                strSQL = @"SELECT * FROM CAT WHERE OwnerID = @ownerId";
                command = new OleDbCommand(strSQL, connection);
                command.Parameters.AddWithValue("@ownerId", model.OwnerId); //selOwnerId
            }
            else
            {
                strSQL = @"SELECT * FROM CAT";
                command = new OleDbCommand(strSQL, connection);
            }
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

            if (model != null)
            {
                model.CatId = Convert.ToInt32(item.SubItems[0].Text);
                model.CatName = item.SubItems[1].Text;

                this.Close();
                VeterinarianListForm form = new VeterinarianListForm(model: model);
                form.ShowDialog();
            }
            else
            {
                this.Close();
                UpdateCatForm form = new UpdateCatForm(Convert.ToInt32(item.SubItems[0].Text), isDelete);
                form.ShowDialog();
            }
        }
    }
}
