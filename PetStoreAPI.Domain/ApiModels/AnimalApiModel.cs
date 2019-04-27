using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreAPI.Domain.ApiModels
{
    public class AnimalApiModel
    {
        public int AnimalId { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }

        public double Price { get; set; }

        public string Breed { get; set; }

        public byte[] Picture { get; set; }

        public AnimalType Type { get; set; }

        public Animal Convert => new Animal()
        {
            AnimalId = AnimalId,
            DateOfBirth = DateOfBirth,
            Price = Price,
            Breed = Breed,
            Picture = Picture,
        };
    }
}
