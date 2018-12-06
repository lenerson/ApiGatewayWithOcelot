using Microsoft.AspNetCore.Mvc;
using Orders.Api.ViewModels;
using System;
using System.Collections.Generic;

namespace Orders.Api.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IEnumerable<OrderViewModel> orders;

        public OrdersController() =>
            orders = new List<OrderViewModel>
            {
                OrderViewModel.Create(new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() }),
                OrderViewModel.Create(new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() }),
                OrderViewModel.Create(new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() }),
                OrderViewModel.Create(new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() })
            };

        // GET api/values
        [HttpGet]
        public IActionResult Get() => Ok(orders);
    }
}
