using AzureDevelopment.ToDoList.Domain.Dto;
using AzureDevelopment.ToDoList.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureDevelopment.ToDoList.Domain.Repository
{
    public interface ITaskRepository
    {
        IAsyncEnumerable<TaskWithOwnerEntryDto> Get();
        Task<TaskWithOwnerEntryDto> Get(int id);
        Task Save(TaskEntryRequest owner);
        Task SetOwner(int id, int ownerId);
    }
}
