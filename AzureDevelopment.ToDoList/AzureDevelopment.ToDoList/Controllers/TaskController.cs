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
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IAsyncEnumerable<TaskWithOwnerEntryDto> Get([FromServices] ITaskRepository taskRepository) => taskRepository.Get();

        [HttpGet("{id}")]
        public async Task<TaskWithOwnerEntryDto> GetById(int id, [FromServices] ITaskRepository taskRepository) => await taskRepository.Get(id);

        [HttpPost]
        public async Task Save([FromBody] TaskEntryRequest task, [FromServices] ITaskRepository taskRepository) => await taskRepository.Save(task);

        [HttpPost("{id}/setOwner/{ownerId}")]
        public async Task SetOwner(int id, int ownerId, [FromServices] ITaskRepository taskRepository) => await taskRepository.SetOwner(id, ownerId);
    }
}
