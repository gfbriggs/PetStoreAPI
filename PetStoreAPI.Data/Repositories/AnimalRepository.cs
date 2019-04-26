using PetStoreAPI.Domain;
using PetStoreAPI.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetStoreAPI.Data.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        public Task<Animal> AddAsync(Animal animal, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<Animal>> GetAllAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<Animal> GetByIdAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Animal animal, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
