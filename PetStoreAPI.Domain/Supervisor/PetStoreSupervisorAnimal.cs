using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetStoreAPI.Domain.Supervisor
{
    public partial class PetStoreSupervisor
    {
        public Task<Animal> AddAnimalAsync(Animal animal, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAnimalAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<Animal>> GetAllAnimalAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<Animal> GetAnimalByIdAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAnimalAsync(Animal animal, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
