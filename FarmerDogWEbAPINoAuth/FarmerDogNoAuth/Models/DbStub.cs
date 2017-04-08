using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmDogWebAPI.Models
{
    public class DbStub
    {
        public List<Farmer> Farmers { get; set; }
        public List<Dog> Dogs { get; set; }

        public DbStub()
        {
            Dogs = new List<Dog>
            {
                new Dog {DogID = 1, Name = "Peg" , Breed="Border Collie", FarmerID=1},
                new Dog {DogID = 2, Name = "Sam",  Breed="Border Collie", FarmerID=2},
                new Dog {DogID = 3, Name = "Kip", Breed="Huntaway", FarmerID=2},
                new Dog {DogID = 4, Name = "Max", Breed="Border Collie", FarmerID=3},
            };

            Farmers = new List<Farmer>
            {
                new Farmer {FarmerID = 1, LastName = "Mackensie" , FirstName="Bob", Phone="1111111"},
                new Farmer {FarmerID = 2, LastName = "Clark", FirstName="Sally", Phone="2222222"},
                new Farmer {FarmerID = 3, LastName = "Fincher", FirstName="Kim", Phone="3333333"},
            };

        }
    }
}