using AzureDevelopment.ToDoList.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AzureDevelopment.ToDoList.Infrastructure.EntityConfiguration
{
    class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.ToTable("OWNERS")
                .HasKey(x => x.Id)
                .HasName("PK_OWNER");

            builder
                .HasMany(x => x.Tasks)
                .WithOne(x => x.Owner)
                .HasForeignKey(x => x.OwnerId);
        }
    }
}
