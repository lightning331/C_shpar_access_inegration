using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.OleDb;
using Glen_Eden_Cat_Clinic.DBManage;
using Glen_Eden_Cat_Clinic.AddVisit;
using Glen_Eden_Cat_Clinic.UpdateVisit;

namespace Glen_Eden_Cat_Clinic
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

/*            string strDSN = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = E:\\Database1.accdb";
            string strSQL = "SELECT * FROM Foods";
            // create Objects of ADOConnection and ADOCommand    
            OleDbConnection myConn = new OleDbConnection(strDSN);
            OleDbDataAdapter myCmd = new OleDbDataAdapter(strSQL, myConn);
            myConn.Open();
            DataSet dtSet = new DataSet();
            myCmd.Fill(dtSet, "Developer");
            DataTable dTable = dtSet.Tables[0];
            //dataGridView1.DataSource = dtSet.Tables["Developer"].DefaultView;
            myConn.Close();
*/        }

        private void AddVisitButton_Click(object sender, EventArgs e)
        {
            OwnerListForm new_cl = new OwnerListForm();
            if (new_cl.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void UpdateVisitButton_Click(object sender, EventArgs e)
        {
            VisitListForm new_cl = new VisitListForm(0);
            if (new_cl.ShowDialog() == DialogResult.OK)
            {
            }

        }

        private void DeleteVisitButton_Click(object sender, EventArgs e)
        {
            VisitListForm new_cl = new VisitListForm(1);
            if (new_cl.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
