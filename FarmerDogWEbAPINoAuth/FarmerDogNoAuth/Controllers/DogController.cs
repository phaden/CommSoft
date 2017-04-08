using FarmDogWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FarmDogWebAPI.Controllers
{
    public class DogController : ApiController
    {
        DbStub mockDb;
        public DogController()
        {
            mockDb = new DbStub();
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            List<String> dogStrings = new List<string>();
            foreach (Dog d in mockDb.Dogs)
            {
                dogStrings.Add(d.ToString());
            }
            return dogStrings;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            Dog selectedDog = mockDb.Dogs[id - 1];  //List is 0-indexed; IDs are not

            String kv1 = "DogID: " + selectedDog.DogID.ToString();
            String kv2 = "Name: " + selectedDog.Name;
            String kv3 = "Breed: " + selectedDog.Breed;

            String farmerName = "No farmer name";
            if (selectedDog.FarmerID != -1)
            {
                Farmer myFarmer = mockDb.Farmers[selectedDog.FarmerID - 1];
                farmerName = myFarmer.LastName + ", " + myFarmer.FirstName;
            }
            String kv4 = "Farmer: " + farmerName;

            String fakeJSON = "{" + kv1 + ", " + kv2 + ", " + kv3 + ", " + kv4 + "}";

            return fakeJSON;

        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}