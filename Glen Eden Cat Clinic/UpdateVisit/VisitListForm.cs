using Glen_Eden_Cat_Clinic.AssignTreatment;
using Glen_Eden_Cat_Clinic.DBManage;
using Glen_Eden_Cat_Clinic.DeleteVisit;
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


namespace Glen_Eden_Cat_Clinic.UpdateVisit
{
    public partial class VisitListForm : Form
    {
        private int visitToDo;
        public VisitListForm(int status)
        {
            //if status = 0, go to the UpdateVisitForm
            //if status = 1, go to the DeleteVisitForm
            //if status = 2, go to the AssignTreatmentForm
            visitToDo = status;

            InitializeComponent();
            //listView1.Columns[1].Width = 360;
            LoadData();
        }

        private void LoadData()
        {
            OleDbConnection connection = DBConnection.Open();

            //read the owner list
            string strSQL = @"SELECT * FROM VISIT";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            // Execute command    
            OleDbDataReader reader = command.ExecuteReader();
            //int i = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    long visitId = Convert.ToInt32(reader["VisitID"]);

                    string description = reader["VisitDescription"].ToString();

                    ListViewItem lvi = new ListViewItem(visitId.ToString());
                    lvi.SubItems.Add(description);
                    listView1.Items.Add(lvi);
                }

            }

            connection.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            var visit_id = Convert.ToInt32(listView1.SelectedItems[0].Text);
            if (visitToDo == 0)
            {
                UpdateVisitForm form = new UpdateVisitForm(visit_id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //textPhone.Text = new_cl.SelectPhone;
                }
            }
            else if (visitToDo == 1)
            {
                DeleteVisitForm form = new DeleteVisitForm(visit_id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //textPhone.Text = new_cl.SelectPhone;
                    listView1.Items.Clear();
                    LoadData();
                }
            }

            else if (visitToDo == 2)
            {
                this.Close();
                AssignTreatmentForm form = new AssignTreatmentForm(visit_id);
                form.ShowDialog();
            }
        }

    }
}
