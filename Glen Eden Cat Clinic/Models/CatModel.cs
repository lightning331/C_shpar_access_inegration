using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glen_Eden_Cat_Clinic.Models
{
    public class CatModel
    {
        public int OwnerId;
        public string OwnerLastName;
        public string OwnerFirstName;

        public CatModel()
        {
            OwnerId = -1;
            OwnerLastName = "";
            OwnerFirstName = "";
        }
    }
}
