using Glen_Eden_Cat_Clinic.DBManage;
using Glen_Eden_Cat_Clinic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Glen_Eden_Cat_Clinic.PrintInvoices
{
    public partial class PrintInvoicesForm : Form
    {
        int totalnumber = 0;
        const int MARGIN_LEFT = 50;
        private PrintPreviewDialog previewDlg = null;
        private List<VisitModel> visitList = new List<VisitModel>();

        public PrintInvoicesForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            OleDbConnection connection = DBConnection.Open();

            //read the visit list
            string strSQL = @"SELECT * FROM VISIT";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            // Execute command    
            OleDbDataReader visit_reader = command.ExecuteReader();
            //int i = 0;
            while (visit_reader.Read())
            {
                VisitModel visit = new VisitModel();
                visit.VisitId = Convert.ToInt32(visit_reader["VisitId"]);
                visit.VisitDescription = visit_reader["VisitDescription"].ToString();
                DateTime dt = DateTime.Parse(visit_reader["VisitDate"].ToString());
                visit.VisitDate = dt.ToString("dd/MM/yyyy");
                visit.VisitFee = Convert.ToDouble(visit_reader["Fee"]);
                visit.CatId = Convert.ToInt32(visit_reader["CatId"]);
                visit.VeterinarianID = Convert.ToInt32(visit_reader["VeterinarianID"]);

                strSQL = @"SELECT * FROM CAT WHERE CatID = @id";
                command = new OleDbCommand(strSQL, connection);
                command.Parameters.AddWithValue("@id", visit.CatId);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    //read the cat name
                    visit.CatName = reader["CatName"].ToString();

                    visit.OwnerId = Convert.ToInt32(reader["OwnerID"]);
                    strSQL = @"SELECT * FROM OWNER WHERE OwnerID = @id";
                    command = new OleDbCommand(strSQL, connection);
                    command.Parameters.AddWithValue("@id", visit.OwnerId);
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        //read the owner information
                        visit.OwnerLastName = reader["LastName"].ToString();
                        visit.OwnerFirstName = reader["FirstName"].ToString();
                        visit.OwnerStreetAddress = reader["StreetAddress"].ToString();
                        visit.OwnerSuburb = reader["Suburb"].ToString();
                    }
                }

                //read the Veterinarian information
                strSQL = @"SELECT * FROM VETERINARIAN WHERE VeterinarianID = @id";
                command = new OleDbCommand(strSQL, connection);
                command.Parameters.AddWithValue("@id", visit.VeterinarianID);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    visit.VeterinarianLastName = reader["LastName"].ToString();
                    visit.VeterinarianFirstName = reader["FirstName"].ToString();
                    visit.VeterinarianFee = Convert.ToDouble(reader["Fee"]);
                }

                //read the Treatment information
                strSQL = @"SELECT * FROM VISITTREATMENT WHERE VisitID = @id";
                command = new OleDbCommand(strSQL, connection);
                command.Parameters.AddWithValue("@id", visit.VisitId);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    VisitTreatmentModel model = new VisitTreatmentModel();
                    model.TreatmentID = Convert.ToInt32(reader["TreatmentID"]);
                    model.Quantity = Convert.ToInt32(reader["Quantity"]);

                    strSQL = @"SELECT * FROM TREATMENT WHERE TreatmentID = @id";
                    command = new OleDbCommand(strSQL, connection);
                    command.Parameters.AddWithValue("@id", model.TreatmentID);
                    OleDbDataReader reader2 = command.ExecuteReader();
                    if (reader2.Read())
                    {
                        model.TreatmentDescription = reader2["TreatmentDescription"].ToString();
                        model.TreatmentCost = Convert.ToDouble(reader2["Cost"]);
                    }
                    visit.VistTreatments.Add(model);
                }

                visitList.Add(visit);
            }


        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //Create a PrintPreviewDialog object  
            previewDlg = new PrintPreviewDialog();
            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();
            //Add print-page event handler  
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            //Set Document property of PrintPreviewDialog  
            previewDlg.Document = pd;
            //Display dialog  
            previewDlg.ShowDialog();

            this.Close();
        }

        public void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            float currentY = 20;// declare  one variable for height measurement
            Font font = new Font(SystemFonts.DefaultFont.FontFamily, 18, FontStyle.Regular);
            float width = ((float)this.ClientRectangle.Width);
            //SizeF size = e.Graphics.MeasureString(letter.ToString(), font);
            e.Graphics.DrawString("Glen Eden Cat Clinic", font, Brushes.Black, width/2, currentY);
            currentY += 30;
            e.Graphics.DrawString("Invoice", font, Brushes.Black, width / 2 + 60, currentY);
            currentY += 50;
            int total_pages = visitList.Count;
            if (totalnumber < total_pages) // check the number of items
            {
                VisitModel vm = visitList[totalnumber];
                Font f = new Font(SystemFonts.DefaultFont.FontFamily, 12, FontStyle.Regular);
                e.Graphics.DrawString(vm.OwnerFirstName + " " + vm.OwnerLastName, f, Brushes.Black, MARGIN_LEFT, currentY);//print each item
                currentY += 25;
                e.Graphics.DrawString(vm.OwnerStreetAddress, f, Brushes.Black, MARGIN_LEFT, currentY);
                currentY += 25;
                e.Graphics.DrawString(vm.OwnerSuburb, f, Brushes.Black, MARGIN_LEFT, currentY);

                currentY += 45;
                e.Graphics.DrawString("Owner ID: " + vm.OwnerId.ToString(), f, Brushes.Black, MARGIN_LEFT, currentY);
                currentY += 45;
                e.Graphics.DrawString("Visit ID: " + vm.VisitId.ToString(), f, Brushes.Black, MARGIN_LEFT, currentY);
                e.Graphics.DrawString("Date: " + vm.VisitDate.ToString(), f, Brushes.Black, MARGIN_LEFT + 550, currentY);
                currentY += 45;
                e.Graphics.DrawString("Cat ID: " + vm.CatId.ToString(), f, Brushes.Black, MARGIN_LEFT, currentY);
                e.Graphics.DrawString("Cat Name: " + vm.CatName.ToString(), f, Brushes.Black, MARGIN_LEFT + 200, currentY);

                currentY += 45;
                e.Graphics.DrawString("Veterinarian: " + vm.VeterinarianFirstName + "" + vm.VeterinarianLastName, f, Brushes.Black, MARGIN_LEFT, currentY);
                e.Graphics.DrawString("$" + vm.VeterinarianFee.ToString("F"), f, Brushes.Black, MARGIN_LEFT + 600, currentY);
                currentY += 25;
                e.Graphics.DrawString("Description: " + vm.VisitDescription, f, Brushes.Black, MARGIN_LEFT, currentY);
                e.Graphics.DrawString("$" + vm.VisitFee.ToString("F"), f, Brushes.Black, MARGIN_LEFT + 600, currentY);

                currentY += 45;
                e.Graphics.DrawString("Treatment", f, Brushes.Black, MARGIN_LEFT, currentY);

                currentY += 45;
                double totalTreatment = 0.0;
                for (int i = 0; i < vm.VistTreatments.Count; i ++)
                {
                    int currentX = MARGIN_LEFT;
                    e.Graphics.DrawString(vm.VistTreatments[i].TreatmentID.ToString(), f, Brushes.Black, currentX, currentY);
                    e.Graphics.DrawString(vm.VistTreatments[i].TreatmentDescription, f, Brushes.Black, currentX + 50, currentY);
                    e.Graphics.DrawString(vm.VistTreatments[i].Quantity.ToString(), f, Brushes.Black, currentX + 250, currentY);
                    e.Graphics.DrawString("$" + vm.VistTreatments[i].TreatmentCost.ToString("F"), f, Brushes.Black, currentX + 320, currentY);
                    double subtotal = vm.VistTreatments[i].TreatmentCost * vm.VistTreatments[i].Quantity;
                    e.Graphics.DrawString("$" + subtotal.ToString("F"), f, Brushes.Black, currentX + 450, currentY);

                    totalTreatment += subtotal;
                    currentY += 25;
                }

                currentY += 20;
                e.Graphics.DrawString("Total Treatment: ", f, Brushes.Black, MARGIN_LEFT, currentY);
                e.Graphics.DrawString("$" + totalTreatment.ToString("F"), f, Brushes.Black, MARGIN_LEFT + 450, currentY);

                currentY += 60;
                double totalVisit = vm.VeterinarianFee + vm.VisitFee + totalTreatment;
                e.Graphics.DrawString("Visit Total:", f, Brushes.Black, MARGIN_LEFT + 450, currentY);
                e.Graphics.DrawString("$" + totalVisit.ToString("F"), f, Brushes.Black, MARGIN_LEFT + 600, currentY);

                totalnumber += 1;
                if (totalnumber >= total_pages)
                    e.HasMorePages = false;
                else
                {
                    e.HasMorePages = true; //e.HasMorePages raised the PrintPage event once per page .
                }
            }
        }
    }
}
