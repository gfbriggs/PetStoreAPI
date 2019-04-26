using PetStoreAPI.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetStoreAPI.Domain.Repositories
{
    public interface IAnimalRepository : IDisposable
    {
        Task<List<Animal>> GetAllAsync(CancellationToken ct = default);

        Task<Animal> GetByIdAsync(string id, CancellationToken ct = default);

        Task<Animal> AddAsync(Animal animal, CancellationToken ct = default);

        Task<bool> UpdateAsync(Animal animal, CancellationToken ct = default);

        Task<bool> DeleteAsync(string id, CancellationToken ct = default);
    }
}
