using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmDogWebAPI.Models
{
    public class Dog
    {
        public int DogID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        public int FarmerID { get; set; }
        public virtual Farmer Farmer { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}