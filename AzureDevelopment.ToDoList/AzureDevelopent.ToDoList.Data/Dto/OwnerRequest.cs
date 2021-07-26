using AzureDevelopment.ToDoList.Domain.Entity;

namespace AzureDevelopment.ToDoList.Domain.Dto
{
    public class OwnerRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Owner ToEntity()
        {
            return new Owner
            {
                Name = Name,
                Surname = Surname
            };
        }
    }
}