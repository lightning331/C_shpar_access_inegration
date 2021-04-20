using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glen_Eden_Cat_Clinic.Models
{
    public class VisitReportModel
    {
        public int VisitId;
        public string VisitDescription;
        public string VisitDate;
        public double VisitFee;
        public string VisitStatus;
        public int  CatId;
        public string CatName;
        public string CatBirthDate;
        public int OwnerId;
        public string OwnerLastName;
        public string OwnerFirstName;
        public List<VisitTreatmentModel> VistTreatments;

        public VisitReportModel()
        {
            VistTreatments = new List<VisitTreatmentModel>();
        }
    }
    public class VeterinarianReportModel
    {
        public int  VeterinarianID;
        public string VeterinarianLastName;
        public string VeterinarianFirstName;
        public string PhoneNumber;
        public double VeterinarianFee;
        public List<VisitReportModel> VisitArray;

        public VeterinarianReportModel()
        {
            VisitArray = new List<VisitReportModel>();
        }
    }
}
