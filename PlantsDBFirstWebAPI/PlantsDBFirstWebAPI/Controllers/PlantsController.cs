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
        public IEnumerable<FullPlant> Get()
        {
            List<FullPlant> fullPlantList = new List<Models.FullPlant>();

            var joinRecords = from p in BotanicGardenDB.tblPlants
                              join s in BotanicGardenDB.tblSpecies
                              on p.speciesID equals s.speciesID
                              select new { plantID = p.plantID, plantDescription = p.plantDescription, commonName = s.commonName, scientificName = s.scientificName };
            foreach(var r in joinRecords)
            {
                FullPlant fp = new FullPlant(r.plantID, r.plantDescription, r.commonName, r.scientificName);
                fullPlantList.Add(fp); 
            }

            return fullPlantList;
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

            FullPlant outputPlantData = new FullPlant(plantID,plantDescription,speciesCommonName,speciesScientificName);

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
