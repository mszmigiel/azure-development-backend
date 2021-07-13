using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDevelopent.ToDoList.Domain.Owners
{
    public class TaskEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
    }
}
