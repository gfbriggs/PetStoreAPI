using Microsoft.EntityFrameworkCore;
using System;

namespace PetStoreAPI.Data
{
    public class PetStoreContext : DbContext
    {
        public PetStoreContext(DbContextOptions<PetStoreContext> options)
             : base(options)
        {
        }

    }
}
