using AzureDevelopment.ToDoList.Domain.Dto;
using AzureDevelopment.ToDoList.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureDevelopment.ToDoList.Domain.Repository
{
    public interface ITaskRepository
    {
        IAsyncEnumerable<TaskEntry> Get();
        Task<TaskEntry> Get(int id);
        Task Save(TaskDto owner);
    }
}
