using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glen_Eden_Cat_Clinic.Models
{
    public class VisitModel
    {
        public int      VisitId;
        public string   VisitDescription;
        public string   VisitDate;
        public double   VisitFee;
        public int      OwnerId;
        public string   OwnerLastName;
        public string   OwnerFirstName;
        public string   OwnerStreetAddress;
        public string   OwnerSuburb;
        public int      CatId;
        public string   CatName;
        public int      VeterinarianID;
        public string   VeterinarianLastName;
        public string   VeterinarianFirstName;
        public double    VeterinarianFee;
        public List<VisitTreatmentModel> VistTreatments;

        public VisitModel()
        {
            OwnerId = -1;
            OwnerLastName = "";
            OwnerFirstName = "";
            CatId = -1;
            CatName = "";
            VeterinarianID = -1;
            VeterinarianLastName = "";
            VeterinarianFirstName = "";
            VistTreatments = new List<VisitTreatmentModel>();
        }
    }
}
