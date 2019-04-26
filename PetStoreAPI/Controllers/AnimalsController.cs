using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetStoreAPI.Domain;

namespace PetStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        // GET api/animals
        [HttpGet]
        [Produces(typeof(List<Animal>))]
        public async Task<ActionResult<IEnumerable<Animal>>> Get()
        {
            try
            {
                // TODO : Replace with real repository call

                return new ObjectResult(new List<Animal>() { new Animal() { AnimalId = 1, Breed = "Tabby", Type = AnimalType.Cat } });
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        // GET api/animals/5
        [HttpGet("{id}")]
        [Produces(typeof(Animal))]
        public async Task<ActionResult<Animal>> Get(int id)
        {
            // TODO : Replace with real repository call
            return new ObjectResult(new Animal() { AnimalId = 2, Breed = "Rex", Type = AnimalType.Cat });
        }

        // POST api/animals
        [HttpPost]
        public void Post([FromBody] Animal value)
        {
        }

        // PUT api/animals/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal value)
        {
        }

        // DELETE api/animals/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
