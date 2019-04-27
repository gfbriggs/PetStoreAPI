using Microsoft.EntityFrameworkCore;
using PetStoreAPI.Data.Configurations;
using PetStoreAPI.Domain;
using System;
using System.Threading;

namespace PetStoreAPI.Data
{
    public class PetStoreContext : DbContext
    {
        public virtual DbSet<Animal> Animals { get; set; }

        public static long InstanceCount;

        public PetStoreContext(DbContextOptions<PetStoreContext> options) : base(options)
            => Interlocked.Increment(ref InstanceCount);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AnimalConfiguration(modelBuilder.Entity<Animal>());
        }
    }