using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlantsDBFirstWebAPI.Controllers
{
    public class BadController : ApiController
    {
        BotanicGardenDbDataContext BotanicGardenDB;


        public BadController()
        {
            BotanicGardenDB = new PlantsDBFirstWebAPI.BotanicGardenDbDataContext();
        }

        //GET: api/Plants
        public IEnumerable<string> Get()
        {
            return new string[] { "data", "data" };
        }

        // GET: api/Plants/5
        public string Get(int searchID)
        {
            var allPlants = BotanicGardenDB.tblPlants;
            var allSpecies = BotanicGardenDB.tblSpecies;
            var allCollections = BotanicGardenDB.tblCollections;

            var firstPlant = allPlants.Where(p => p.plantID == searchID).First();

            int plantSpeciesFK = (int)firstPlant.speciesID;
            var currentPlantSpecies = allSpecies.Where(s => s.speciesID == plantSpeciesFK).First();

            int plantID = firstPlant.plantID;
            string plantDescription = firstPlant.plantDescription;
            string speciesCommonName = currentPlantSpecies.commonName;
            string speciesScientificName = currentPlantSpecies.scientificName;

            string[] returnValues = new string[] {  plantID.ToString(),
                                                    plantDescription,
                                                    speciesCommonName,
                                                    speciesScientificName};

            return plantID.ToString() + "," + plantDescription + ", " + speciesCommonName + ", " + speciesScientificName;
        }

        // POST: api/Plants
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Plants/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Plants/5
        public void Delete(int id)
        {
        }
    }
}
