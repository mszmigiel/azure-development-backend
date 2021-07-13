using AzureDevelopent.ToDoList.Domain.Owners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDevelopment.ToDoList.Domain.Repository
{
    public interface IOwnerRepository
    {
        Task<Owner> Get(int id);
    }
}
