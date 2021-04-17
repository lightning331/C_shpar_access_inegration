using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glen_Eden_Cat_Clinic.Models
{
    public class VisitModel
    {
        public int     OwnerId;
        public string   OwnerLastName;
        public string   OwnerFirstName;
        public int      CatId;
        public string   CatName;
        public int      VeterinarianId;
        public string   VeterinarianLastName;
        public string   VeterinarianFirstName;

        public VisitModel()
        {
            OwnerId = -1;
            OwnerLastName = "";
            OwnerFirstName = "";
        }
    }
}
