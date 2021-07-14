using AzureDevelopment.ToDoList.Domain.Dto;
using AzureDevelopment.ToDoList.Domain.Entity;
using AzureDevelopment.ToDoList.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureDevelopment.ToDoList.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        [HttpGet]
        public IAsyncEnumerable<Owner> Get([FromServices] IOwnerRepository ownerRepository) => ownerRepository.All();

        [HttpGet("{id}")]
        public async Task<Owner> GetById(int id, [FromServices] IOwnerRepository ownerRepository) => await ownerRepository.Get(id);

        [HttpPost]
        public async Task Owner([FromBody] OwnerDto owner, [FromServices] IOwnerRepository ownerRepository) => await ownerRepository.Save(owner);
    }
}
