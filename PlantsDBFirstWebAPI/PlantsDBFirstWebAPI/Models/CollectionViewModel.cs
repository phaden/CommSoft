using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlantsDBFirstWebAPI.Models
{
    public class CollectionViewModel
    {
        public int CollectionID { get; set; }
        public String CollectionName { get; set; }
        public String CollectionDescription { get; set; }

        public List<int> AllPlantIDs { get; set;}

        public CollectionViewModel(int collectionID, string collectionName, string collectionDescription, List<int> allPlantIDs)
        {
            CollectionID = collectionID;
            CollectionName = collectionName;
            CollectionDescription = collectionDescription;
            AllPlantIDs = allPlantIDs;
        }
    }
}