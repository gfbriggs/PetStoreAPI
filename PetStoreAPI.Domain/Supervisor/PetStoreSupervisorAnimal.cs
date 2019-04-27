using PetStoreAPI.Domain.ApiModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetStoreAPI.Domain.Supervisor
{
    public partial class PetStoreSupervisor
    {
        public Task<AnimalApiModel> AddAnimalAsync(AnimalApiModel animal, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAnimalAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<AnimalApiModel>> GetAllAnimalAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<AnimalApiModel> GetAnimalByIdAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAnimalAsync(AnimalApiModel animal, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
