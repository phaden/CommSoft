using FarmDogWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FarmDogWebAPI.Controllers
{
    public class FarmerController : ApiController
    {
        DbStub mockDb;
        public FarmerController()
        {
            mockDb = new DbStub();
        }



        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            List<String> farmerStrings = new List<string>();
            foreach (Farmer f in mockDb.Farmers)
            {
                farmerStrings.Add(f.ToString());
            }
            return farmerStrings;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return mockDb.Farmers[id - 1].ToString(); // List is 0-indexed, IDs are not
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