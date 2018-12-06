using Microsoft.AspNetCore.Mvc;
using Orders.Api.ViewModels;
using Orders.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Api.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository orderRespository;

        public OrdersController(IOrderRepository orderRespository) =>
            this.orderRespository = orderRespository;

        // GET api/orders
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var orders = new List<OrderViewModel>();
            foreach (var order in await orderRespository.GetAll())
                orders.Add(OrderViewModel.Create(order.Id, order.Products.Select(x => x.ProductId)));
            return Ok(orders);
        }
    }
}
