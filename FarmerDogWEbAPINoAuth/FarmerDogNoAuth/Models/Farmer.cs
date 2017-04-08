using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmDogWebAPI.Models
{
    public class Farmer
    {
        public int FarmerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public virtual List<Dog> Dogs { get; set; }

        public override string ToString()
        {
            return FarmerID.ToString() + ": " + LastName.ToString() + ", " + FirstName.ToString();
        }
    }
}