using AzureDevelopment.ToDoList.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AzureDevelopment.ToDoList.Infrastructure.EntityConfiguration
{
    class TaskEntryConfiguration : IEntityTypeConfiguration<TaskEntry>
    {
        public void Configure(EntityTypeBuilder<TaskEntry> builder)
        {
            builder
                .ToTable("TASKS")
                .HasKey(x => x.Id)
                .HasName("PK_TASKS");

            builder
                .HasOne(x => x.Owner)
                .WithMany(x => x.Tasks)
                .HasForeignKey(x => x.OwnerId);
        }
    }
}
