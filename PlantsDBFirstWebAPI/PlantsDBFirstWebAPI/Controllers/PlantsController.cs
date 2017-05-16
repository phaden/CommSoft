using PlantsDBFirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlantsDBFirstWebAPI.Controllers
{
    public class PlantsController : ApiController
    {

        BotanicGardenDbDataContext BotanicGardenDB;


        public PlantsController()
        {
            BotanicGardenDB = new PlantsDBFirstWebAPI.BotanicGardenDbDataContext();
        }

        // GET: api/Plants
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET: api/Plants/5
        public FullPlant Get(int id)
        {
            var allPlants = BotanicGardenDB.tblPlants;
            var allSpecies = BotanicGardenDB.tblSpecies;
            var allCollections = BotanicGardenDB.tblCollections;

            var selectedPlant = allPlants.Where(p => p.plantID == id).First();

            int plantSpeciesFK = (int)selectedPlant.speciesID;
            var currentPlantSpecies = allSpecies.Where(s => s.speciesID == plantSpeciesFK).First();

            int plantID = selectedPlant.plantID;
            string plantDescription = selectedPlant.plantDescription;
            string speciesCommonName = currentPlantSpecies.commonName;
            string speciesScientificName = currentPlantSpecies.scientificName;

            FullPlant outputPlantData = new FullPlant { PlantID = plantID,
                PlantDescription = plantDescription,
                SpeciesCommonName = speciesCommonName,
                SpeciesScientificName = speciesScientificName };

            return outputPlantData;
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
