using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetStoreAPI.Domain.Supervisor
{
    public interface IPetStoreSupervisor
    {
        Task<List<Animal>> GetAllAnimalAsync(CancellationToken ct = default);

        Task<Animal> GetAnimalByIdAsync(string id, CancellationToken ct = default);

        Task<Animal> AddAnimalAsync(Animal animal, CancellationToken ct = default);

        Task<bool> UpdateAnimalAsync(Animal animal, CancellationToken ct = default);

        Task<bool> DeleteAnimalAsync(string id, CancellationToken ct = default);
    }
}
