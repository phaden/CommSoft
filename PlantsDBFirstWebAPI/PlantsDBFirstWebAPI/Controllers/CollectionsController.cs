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
        public IEnumerable<string> Get()
        {
            List<String> collectionNames = new List<string>();
            foreach(var collection in BotanicGardenDB.tblCollections)
            {
                collectionNames.Add(collection.collectionName);
            }
            return collectionNames;
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
