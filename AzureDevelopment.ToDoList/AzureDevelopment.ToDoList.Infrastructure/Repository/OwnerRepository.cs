using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureDevelopment.ToDoList.Domain.Dto;
using AzureDevelopment.ToDoList.Domain.Entity;
using AzureDevelopment.ToDoList.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace AzureDevelopment.ToDoList.Infrastructure.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ToDoListDbContext dbContext;

        public OwnerRepository(ToDoListDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IAsyncEnumerable<OwnerDto> Get()
        {
            return dbContext.Owners
                .Select(x => new OwnerDto(x))
                .AsAsyncEnumerable();
        }

        public async Task<OwnerDto> Get(int id)
        {
            return new OwnerDto(await dbContext
                .Owners.Include(x => x.Tasks)
                .FirstAsync(x => x.Id == id));
        }

        public IAsyncEnumerable<TaskEntryDto> GetTasks(int id)
        {
            return dbContext.Tasks
                .Where(x => x.OwnerId == id)
                .Select(x => new TaskEntryDto(x))
                .AsAsyncEnumerable();
        }

        public async Task Save(OwnerRequest owner)
        {
            await dbContext.AddAsync(owner.ToEntity());
            await dbContext.SaveChangesAsync();
        }
    }
}
