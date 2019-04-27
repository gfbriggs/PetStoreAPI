using PetStoreAPI.Domain;
using PetStoreAPI.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PetStoreAPI.Data.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        public async Task<Animal> AddAsync(Animal animal, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        
        public async Task<List<Animal>> GetAllAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<Animal> GetByIdAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Animal animal, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
