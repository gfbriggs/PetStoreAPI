using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetStoreAPI.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreAPI.Data.Configurations
{
    public class AnimalConfiguration
    {
        public AnimalConfiguration(EntityTypeBuilder<Animal> entity)
        {
            entity.HasIndex(i => i.AnimalId)
                  .IsUnique();

            entity.Property(p => p.Type)
                  .IsRequired();

            entity.Property(p => p.Price)
                  .IsRequired();
        }
    }
}
