using AzureDevelopment.ToDoList.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AzureDevelopment.ToDoList.Infrastructure.EntityConfiguration
{
    class TaskEntryConfiguration : IEntityTypeConfiguration<TaskEntry>
    {
        public void Configure(EntityTypeBuilder<TaskEntry> builder)
        {
        }
    }
}
