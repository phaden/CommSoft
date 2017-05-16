using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlantsDBFirstWebAPI.Controllers
{
   
    public class ValuesController : ApiController
    {
        BotanicGardenDbDataContext BotanicGardenDB;


        public ValuesController()
        {
            BotanicGardenDB = new PlantsDBFirstWebAPI.BotanicGardenDbDataContext();
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            var allPlants = BotanicGardenDB.tblPlants;
            var allSpecies = BotanicGardenDB.tblSpecies;
            var allCollections = BotanicGardenDB.tblCollections;

            var firstPlant = allPlants.Where(p => p.plantID == id).First();

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

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
