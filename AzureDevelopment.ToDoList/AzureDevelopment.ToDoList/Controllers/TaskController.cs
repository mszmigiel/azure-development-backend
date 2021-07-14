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
        public IAsyncEnumerable<TaskEntry> Get([FromServices] ITaskRepository taskRepository) => taskRepository.Get();

        [HttpGet("{id}")]
        public async Task<TaskEntry> GetById(int id, [FromServices] ITaskRepository taskRepository) => await taskRepository.Get(id);

        [HttpPost]
        public async Task Owner([FromBody] TaskDto task, [FromServices] ITaskRepository taskRepository) => await taskRepository.Save(task);
    }
}
