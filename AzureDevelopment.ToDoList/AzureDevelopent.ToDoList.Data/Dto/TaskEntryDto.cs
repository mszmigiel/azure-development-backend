using AzureDevelopment.ToDoList.Domain.Entity;

namespace AzureDevelopment.ToDoList.Domain.Dto
{
    public class TaskEntryDto
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public State State { get; private set; }

        public TaskEntryDto(TaskEntry taskEntry)
        {
            Id = taskEntry.Id;
            Name = taskEntry.Name;
            State = taskEntry.State;
        }
    }
}
