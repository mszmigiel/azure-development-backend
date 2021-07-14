using System.Collections.Generic;
using System.Threading.Tasks;
using AzureDevelopment.ToDoList.Domain.Dto;
using AzureDevelopment.ToDoList.Domain.Entity;
using AzureDevelopment.ToDoList.Domain.Repository;

namespace AzureDevelopment.ToDoList.Infrastructure.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ToDoListDbContext dbContext;

        public OwnerRepository(ToDoListDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async IAsyncEnumerable<Owner> All()
        {
            var owners = dbContext.Owners.AsAsyncEnumerable();

            await foreach (var owner in owners)
            {
                yield return owner;
            }
        }

        public async Task<Owner> Get(int id)
        {
            return await dbContext.FindAsync<Owner>(id);
        }

        public async Task Save(OwnerDto owner)
        {
            await dbContext.AddAsync(owner.ToEntity());
            await dbContext.SaveChangesAsync();
        }
    }
}
