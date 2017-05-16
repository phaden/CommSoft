using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication1.Models
{
    public class Dog
    {
        public int DogID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        public int FarmerId { get; set; }
        public virtual Farmer Farmer { get; set; }
    }
}
