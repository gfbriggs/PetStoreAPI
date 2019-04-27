using PetStoreAPI.Domain.ApiModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PetStoreAPI.Domain.Supervisor
{
    public interface IPetStoreSupervisor
    {
        Task<List<AnimalApiModel>> GetAllAnimalAsync(CancellationToken ct = default);

        Task<AnimalApiModel> GetAnimalByIdAsync(string id, CancellationToken ct = default);

        Task<AnimalApiModel> AddAnimalAsync(AnimalApiModel animal, CancellationToken ct = default);

        Task<bool> UpdateAnimalAsync(AnimalApiModel animal, CancellationToken ct = default);

        Task<bool> DeleteAnimalAsync(string id, CancellationToken ct = default);
    }
}
