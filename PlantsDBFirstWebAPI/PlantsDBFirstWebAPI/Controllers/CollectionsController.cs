using PlantsDBFirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlantsDBFirstWebAPI.Controllers
{
    
    public class CollectionsController : ApiController
    {
        BotanicGardenDbDataContext BotanicGardenDB;


        public CollectionsController()
        {
            BotanicGardenDB = new PlantsDBFirstWebAPI.BotanicGardenDbDataContext();
        }


        // GET: api/Collections
        public IEnumerable<CollectionViewModel> Get()
        {
            List<CollectionViewModel> collectionViews = new List<CollectionViewModel>();
            foreach(var collection in BotanicGardenDB.tblCollections)
            {
                int id = collection.collectionID;
                string name = collection.collectionName;
                string description = collection.collectionDescription;
                List < tblPlant > collectionPlants = collection.tblPlants.ToList();

                List<int> plantIDs = new List<int>();
                foreach (tblPlant p in collectionPlants)
                    plantIDs.Add(p.plantID);

                CollectionViewModel cvm = new CollectionViewModel(id, name, description, plantIDs);
                collectionViews.Add(cvm);
            }
            return collectionViews;
        }

        // GET: api/Collections/5
        public string Get(int id)
        {
            var chosenCollection = BotanicGardenDB.tblCollections.Where(c => c.collectionID == id);
            var collection = chosenCollection.First();
            String collectionDisplayString = collection.collectionName + ", " + collection.collectionDescription;

            return collectionDisplayString;
        }

        // POST: api/Collections
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Collections/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Collections/5
        public void Delete(int id)
        {
        }
    }
}
