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
        public IAsyncEnumerable<OwnerDto> Get([FromServices] IOwnerRepository ownerRepository) => ownerRepository.Get();

        [HttpGet("{id}")]
        public async Task<OwnerDto> GetById(int id, [FromServices] IOwnerRepository ownerRepository) => await ownerRepository.Get(id);

        [HttpGet("{id}/tasks")]
        public IAsyncEnumerable<TaskEntryDto> OwnerTasks(int id, [FromServices] IOwnerRepository ownerRepository) => ownerRepository.GetTasks(id);

        [HttpPost]
        public async Task Owner([FromBody] OwnerRequest owner, [FromServices] IOwnerRepository ownerRepository) => await ownerRepository.Save(owner);
    }
}
