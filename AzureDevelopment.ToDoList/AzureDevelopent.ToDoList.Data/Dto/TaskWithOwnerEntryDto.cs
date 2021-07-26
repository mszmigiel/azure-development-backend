using AzureDevelopment.ToDoList.Domain.Entity;

namespace AzureDevelopment.ToDoList.Domain.Dto
{
    public class TaskWithOwnerEntryDto
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public State State { get; private set; }
        public OwnerDto Owner { get; private set; }

        public TaskWithOwnerEntryDto(TaskEntry taskEntry)
        {
            Id = taskEntry.Id;
            Name = taskEntry.Name;
            State = taskEntry.State;
            Owner = new OwnerDto(taskEntry.Owner);
        }
    }
}
