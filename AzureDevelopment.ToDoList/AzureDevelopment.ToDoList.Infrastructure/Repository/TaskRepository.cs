using AzureDevelopment.ToDoList.Domain.Dto;
using AzureDevelopment.ToDoList.Domain.Entity;
using AzureDevelopment.ToDoList.Domain.Repository;
using System.Collections.Generic;
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

        public IAsyncEnumerable<TaskEntry> Get()
        {
            return dbContext.Tasks.AsAsyncEnumerable();
        }

        public async Task<TaskEntry> Get(int id)
        {
            return await dbContext.FindAsync<TaskEntry>(id);
        }

        public async Task Save(TaskDto owner)
        {
            await dbContext.AddAsync(owner.ToEntity());
            await dbContext.SaveChangesAsync();
        }
    }
}
