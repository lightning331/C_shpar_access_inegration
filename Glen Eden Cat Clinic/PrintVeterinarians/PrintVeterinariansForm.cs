using Glen_Eden_Cat_Clinic.DBManage;
using Glen_Eden_Cat_Clinic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glen_Eden_Cat_Clinic.PrintVeterinarians
{
    public partial class PrintVeterinariansForm : Form
    {
        int totalnumber = 0;
        const int MARGIN_LEFT = 50;
        private PrintPreviewDialog previewDlg = null;
        private List<VeterinarianReportModel> VeterinariansArray = new List<VeterinarianReportModel>();

        public PrintVeterinariansForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            OleDbConnection connection = DBConnection.Open();
            string strSQL = @"SELECT * FROM VETERINARIAN";
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            // Execute command    
            OleDbDataReader veter_reader = command.ExecuteReader();
            while (veter_reader.Read())
            {
                VeterinarianReportModel model = new VeterinarianReportModel();
                model.VeterinarianID = Convert.ToInt32(veter_reader["VeterinarianID"]);
                model.VeterinarianFirstName = veter_reader["FirstName"].ToString();
                model.VeterinarianLastName = veter_reader["LastName"].ToString();
                model.PhoneNumber = veter_reader["PhoneNumber"].ToString();
                model.VeterinarianFee = Convert.ToDouble(veter_reader["Fee"]);

                //read the visit list
                strSQL = @"SELECT * FROM VISIT WHERE VeterinarianID=@id";
                command = new OleDbCommand(strSQL, connection);
                // Execute command    
                command.Parameters.AddWithValue("@id", model.VeterinarianID);
                OleDbDataReader visit_reader = command.ExecuteReader();
                while (visit_reader.Read())
                {
                    VisitReportModel visit = new VisitReportModel();
                    visit.VisitId = Convert.ToInt32(visit_reader["VisitId"]);
                    visit.VisitDescription = visit_reader["VisitDescription"].ToString();
                    DateTime dt = DateTime.Parse(visit_reader["VisitDate"].ToString());
                    visit.VisitDate = dt.ToString("dd/MM/yyyy");
                    visit.VisitFee = Convert.ToDouble(visit_reader["Fee"]);
                    visit.CatId = Convert.ToInt32(visit_reader["CatId"]);
                    visit.VisitStatus = visit_reader["Status"].ToString();

                    strSQL = @"SELECT * FROM CAT WHERE CatID = @id";
                    command = new OleDbCommand(strSQL, connection);
                    command.Parameters.AddWithValue("@id", visit.CatId);
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        //read the cat name
                        visit.CatName = reader["CatName"].ToString();
                        DateTime dt1 = DateTime.Parse(reader["DateOfBirth"].ToString());
                        visit.CatBirthDate = dt1.ToString("dd/MM/yyyy");

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
                        }
                    }

                    //read the Treatment information
                    strSQL = @"SELECT * FROM VISITTREATMENT WHERE VisitID = @id";
                    command = new OleDbCommand(strSQL, connection);
                    command.Parameters.AddWithValue("@id", visit.VisitId);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        VisitTreatmentModel visit_treatment = new VisitTreatmentModel();
                        visit_treatment.TreatmentID = Convert.ToInt32(reader["TreatmentID"]);
                        visit_treatment.Quantity = Convert.ToInt32(reader["Quantity"]);

                        strSQL = @"SELECT * FROM TREATMENT WHERE TreatmentID = @id";
                        command = new OleDbCommand(strSQL, connection);
                        command.Parameters.AddWithValue("@id", visit_treatment.TreatmentID);
                        OleDbDataReader reader2 = command.ExecuteReader();
                        if (reader2.Read())
                        {
                            visit_treatment.TreatmentDescription = reader2["TreatmentDescription"].ToString();
                            visit_treatment.TreatmentCost = Convert.ToDouble(reader2["Cost"]);
                        }
                        visit.VistTreatments.Add(visit_treatment);
                    }
                    model.VisitArray.Add(visit);
                }
                VeterinariansArray.Add(model);

            }
            connection.Close();
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
            e.Graphics.DrawString("Glen Eden Cat Clinic", font, Brushes.Black, width / 2, currentY);
            currentY += 30;
            e.Graphics.DrawString("Veterinarians Report", font, Brushes.Black, width / 2, currentY);
            currentY += 50;
            int total_pages = VeterinariansArray.Count;
            if (totalnumber < total_pages) // check the number of items
            {
                VeterinarianReportModel vr = VeterinariansArray[totalnumber];
                Font f = new Font(SystemFonts.DefaultFont.FontFamily, 12, FontStyle.Regular);
                e.Graphics.DrawString("Veterinarian ID: " + vr.VeterinarianID, f, Brushes.Black, MARGIN_LEFT, currentY);

                currentY += 25;
                e.Graphics.DrawString("Name: " + vr.VeterinarianLastName + ", " + vr.VeterinarianFirstName, f, Brushes.Black, MARGIN_LEFT, currentY);
                e.Graphics.DrawString("Fee: " + "$" + vr.VeterinarianFee.ToString("F"), f, Brushes.Black, MARGIN_LEFT + 550, currentY);

                currentY += 25;
                e.Graphics.DrawString("Phone number: " + vr.PhoneNumber, f, Brushes.Black, MARGIN_LEFT, currentY);
                for (int i = 0; i < vr.VisitArray.Count; i++)
                {
                    currentY += 40;
                    e.Graphics.DrawString("Visit ID: " + vr.VisitArray[i].VisitId, f, Brushes.Black, MARGIN_LEFT, currentY);
                    e.Graphics.DrawString("Date: " + vr.VisitArray[i].VisitDate, f, Brushes.Black, MARGIN_LEFT + 300, currentY);
                    e.Graphics.DrawString("Status: " + vr.VisitArray[i].VisitStatus, f, Brushes.Black, MARGIN_LEFT + 550, currentY);

                    currentY += 25;
                    e.Graphics.DrawString("Description: " + vr.VisitArray[i].VisitDescription, f, Brushes.Black, MARGIN_LEFT, currentY);
                    e.Graphics.DrawString("Fee: " + "$" + vr.VisitArray[i].VisitFee.ToString("F"), f, Brushes.Black, MARGIN_LEFT + 550, currentY);

                    currentY += 40;
                    e.Graphics.DrawString("Cat ID: " + vr.VisitArray[i].CatId, f, Brushes.Black, MARGIN_LEFT, currentY);
                    e.Graphics.DrawString("Cat Name: " + vr.VisitArray[i].CatName, f, Brushes.Black, MARGIN_LEFT + 200, currentY);

                    currentY += 25;
                    e.Graphics.DrawString("Date of birth: ", f, Brushes.Black, MARGIN_LEFT, currentY);
                    e.Graphics.DrawString(vr.VisitArray[i].CatBirthDate, f, Brushes.Black, MARGIN_LEFT + 200, currentY);
                    currentY += 25;
                    e.Graphics.DrawString("Owner ID: " + vr.VisitArray[i].OwnerId, f, Brushes.Black, MARGIN_LEFT, currentY);
                    e.Graphics.DrawString("Name: " + vr.VisitArray[i].OwnerLastName + ", " + vr.VisitArray[i].OwnerFirstName, f, Brushes.Black, MARGIN_LEFT + 200, currentY);

                    currentY += 40;
                    e.Graphics.DrawString("Treatment: ", f, Brushes.Black, MARGIN_LEFT, currentY);
                    for (int j = 0; j < vr.VisitArray[i].VistTreatments.Count; j ++)
                    {
                        VisitTreatmentModel vtm = vr.VisitArray[i].VistTreatments[j];
                        e.Graphics.DrawString(vtm.TreatmentID.ToString(), f, Brushes.Black, MARGIN_LEFT + 200, currentY);
                        e.Graphics.DrawString(vtm.TreatmentDescription, f, Brushes.Black, MARGIN_LEFT + 250, currentY);
                        e.Graphics.DrawString(vtm.Quantity.ToString(), f, Brushes.Black, MARGIN_LEFT + 450, currentY);
                        e.Graphics.DrawString("$" + vtm.TreatmentCost.ToString("F"), f, Brushes.Black, MARGIN_LEFT + 550, currentY);
                        currentY += 25;
                        //double subtotal = vtm.TreatmentCost * vtm.Quantity;
                        //e.Graphics.DrawString("$" + subtotal.ToString("F"), f, Brushes.Black, currentX + 450, currentY);

                    }
                }
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
