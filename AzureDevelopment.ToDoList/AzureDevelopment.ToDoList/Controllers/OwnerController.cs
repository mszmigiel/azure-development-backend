using AzureDevelopent.ToDoList.Domain.Owners;
using AzureDevelopment.ToDoList.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDevelopment.ToDoList.Api.Controllers
{
    public class OwnerController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<Owner> Get(int id, [FromServices] IOwnerRepository orderRepository) => await orderRepository.Get(id);
    }
}
