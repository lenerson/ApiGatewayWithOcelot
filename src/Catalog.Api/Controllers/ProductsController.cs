using Catalog.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Catalog.Api.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IEnumerable<ProductViewModel> products;

        public ProductsController()
        {
            products = new List<ProductViewModel>
            {
                ProductViewModel.Create(Guid.NewGuid(), "Notebook Avell G1513 FOX-5 BS", 4799.70m),
                ProductViewModel.Create(Guid.NewGuid(), "Smartphone ASUS ZenFone 5Z 8GB/256GB Preto",  3509.10m),
                ProductViewModel.Create(Guid.NewGuid(), "Console Xbox One X 1TB 4K+ Controle sem Fio", 2540.19m),
                ProductViewModel.Create(Guid.NewGuid(), "Console Playstation 4 Pro 1tb - Ps4", 2640.00m)
            };
        }

        // GET api/products
        [HttpGet]
        public IActionResult Get() => Ok(products);
    }
}
