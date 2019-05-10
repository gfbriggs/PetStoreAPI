using Microsoft.EntityFrameworkCore;
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

        private readonly PetStoreContext _context;

        public AnimalRepository(PetStoreContext context)
        {
            _context = context;
        }

        public async Task<bool> AnimalExists(string id, CancellationToken ct = default) => await _context.Animals.FindAsync(id) != null;

        public async Task<Animal> AddAsync(Animal animal, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(string id, CancellationToken ct = default)
        {
            if (await AnimalExists(id, ct))
            {
                _context.Remove(await _context.Animals.FindAsync(id, ct));

                await _context.SaveChangesAsync(ct);

                return true;
            }
            return false;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Animal>> GetAllAsync(CancellationToken ct = default)
        {
            var animals = _context.Animals;

            return await animals.ToListAsync(ct);
        }

        public async Task<Animal> GetByIdAsync(string id, CancellationToken ct = default)
        {
            return await _context.Animals.FindAsync(id, ct);
        }

        public async Task<bool> UpdateAsync(Animal animal, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
