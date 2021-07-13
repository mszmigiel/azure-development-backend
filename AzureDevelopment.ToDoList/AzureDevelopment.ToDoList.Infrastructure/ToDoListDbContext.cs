using AzureDevelopent.ToDoList.Domain.Owners;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AzureDevelopment.ToDoList.Infrastructure
{
    public class ToDoListDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public ToDoListDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<TaskEntry> Tasks { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ToDoList"));
    }
}
