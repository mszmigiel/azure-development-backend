namespace AzureDevelopment.ToDoList.Domain.Entity
{
    public class TaskEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
        public Owner Owner { get; set; }
        public int? OwnerId { get; set; }
    }
}
