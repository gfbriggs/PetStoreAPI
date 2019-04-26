using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreAPI.Domain
{
    public class Animal
    {
        public int AnimalId { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }

        public double Price { get; set; }

        public string Breed { get; set; }

        public byte[] Picture { get; set; }

        public AnimalType Type { get; set; }
    }
}
