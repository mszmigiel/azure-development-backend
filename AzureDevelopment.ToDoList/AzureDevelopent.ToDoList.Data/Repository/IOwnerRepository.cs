using AzureDevelopment.ToDoList.Domain.Dto;
using AzureDevelopment.ToDoList.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureDevelopment.ToDoList.Domain.Repository
{
    public interface IOwnerRepository
    {
        IAsyncEnumerable<OwnerDto> Get();
        Task<OwnerDto> Get(int id);
        Task Save(OwnerRequest owner);
        IAsyncEnumerable<TaskEntryDto> GetTasks(int ownerId);
    }
}
