using AzureDevelopment.ToDoList.Domain.Dto;
using AzureDevelopment.ToDoList.Domain.Entity;
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
        Task Save(OwnerDto owner);
        IAsyncEnumerable<Owner> All();
    }
}
