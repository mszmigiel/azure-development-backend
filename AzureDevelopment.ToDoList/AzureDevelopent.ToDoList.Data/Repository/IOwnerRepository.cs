﻿using AzureDevelopment.ToDoList.Domain.Dto;
using AzureDevelopment.ToDoList.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureDevelopment.ToDoList.Domain.Repository
{
    public interface IOwnerRepository
    {
        IAsyncEnumerable<Owner> Get();
        Task<Owner> Get(int id);
        Task Save(OwnerDto owner);
    }
}
