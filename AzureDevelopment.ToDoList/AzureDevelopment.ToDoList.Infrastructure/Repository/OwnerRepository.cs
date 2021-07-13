using System.Threading.Tasks;
using AzureDevelopent.ToDoList.Domain.Owners;
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

        public async Task<Owner> Get(int id)
        {
            return await dbContext.FindAsync<Owner>(id);
        }

        public async Task Save(Owner owner)
        {
            await dbContext.AddAsync(owner);
        }
    }
}
