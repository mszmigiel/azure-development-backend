using AzureDevelopment.ToDoList.Domain.Dto;
using AzureDevelopment.ToDoList.Domain.Entity;
using AzureDevelopment.ToDoList.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDevelopment.ToDoList.Infrastructure.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ToDoListDbContext dbContext;

        public TaskRepository(ToDoListDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IAsyncEnumerable<TaskWithOwnerEntryDto> Get()
        {
            return dbContext.Tasks
                .Include(x => x.Owner)
                .Select(x => new TaskWithOwnerEntryDto(x))
                .AsAsyncEnumerable();
        }

        public async Task<TaskWithOwnerEntryDto> Get(int id)
        {
            return new TaskWithOwnerEntryDto(await dbContext
                .Tasks
                .Include(x => x.Owner)
                .FirstAsync(x => x.Id == id));
        }

        public async Task Save(TaskEntryRequest owner)
        {
            await dbContext.AddAsync(owner.ToEntity());
            await dbContext.SaveChangesAsync();
        }

        public async Task SetOwner(int taskId, int ownerId)
        {
            var taskEntry = await dbContext.FindAsync<TaskEntry>(taskId);
            var owner = await dbContext.FindAsync<Owner>(ownerId);
            taskEntry.Owner = owner;
            await dbContext.SaveChangesAsync();
        }
    }
}
