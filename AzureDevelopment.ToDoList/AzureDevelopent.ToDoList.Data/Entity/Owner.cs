using System.Collections.Generic;

namespace AzureDevelopment.ToDoList.Domain.Entity
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<TaskEntry> Tasks { get; set; }
    }
}
