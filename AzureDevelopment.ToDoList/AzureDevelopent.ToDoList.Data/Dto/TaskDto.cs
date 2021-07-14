using AzureDevelopment.ToDoList.Domain.Entity;

namespace AzureDevelopment.ToDoList.Domain.Dto
{
    public class TaskDto
    {
        public string Name { get; set; }

        public TaskEntry ToEntity()
        {
            return new TaskEntry
            {
                Name = Name,
                State = State.ToDo
            };
        }
    }
}
