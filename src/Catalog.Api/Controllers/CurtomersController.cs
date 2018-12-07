using Catalog.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Catalog.Api.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CurtomersController : ControllerBase
    {
        private readonly ICustomerRepository customerRepository;

        public CurtomersController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        // GET api/customers/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id) => Ok(await customerRepository.GetById(id));
    }
}