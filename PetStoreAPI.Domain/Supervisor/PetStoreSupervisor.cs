using PetStoreAPI.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetStoreAPI.Domain.Supervisor
{
    public partial class PetStoreSupervisor : IPetStoreSupervisor
    {
        private readonly IAnimalRepository _animalRepository;

        public PetStoreSupervisor()
        {

        }

        public PetStoreSupervisor(IAnimalRepository animalRepository) 
                => _animalRepository = animalRepository;
    }
}
