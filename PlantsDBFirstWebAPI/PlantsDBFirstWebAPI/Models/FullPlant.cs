using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlantsDBFirstWebAPI.Models
{
    // PH: Can eventually add all the other fields in here....
    public class FullPlant
    {
        public int PlantID { get; set; }
        public String PlantDescription { get; set; }
        public String SpeciesCommonName { get; set; }
        public String SpeciesScientificName { get; set; }
      
    }
}