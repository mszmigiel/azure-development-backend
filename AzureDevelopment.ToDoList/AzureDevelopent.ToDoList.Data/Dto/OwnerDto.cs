using AzureDevelopment.ToDoList.Domain.Entity;

namespace AzureDevelopment.ToDoList.Domain.Dto
{
    public record OwnerDto
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public OwnerDto(Owner owner)
        {
            Id = owner.Id;
            Name = owner.Name;
            Surname = owner.Surname;
        }
    }
}
