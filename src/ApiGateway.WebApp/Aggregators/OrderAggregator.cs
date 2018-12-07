using ApiGateway.WebApp.Extensions;
using ApiGateway.WebApp.ViewModels;
using Ocelot.Middleware;
using Ocelot.Middleware.Multiplexer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiGateway.WebApp.Aggregators
{
    public sealed class OrderAggregator : IDefinedAggregator
    {
        private const int IndexCustomerResponse = 0;
        private const int IndexOrdersResponse = 1;

        public async Task<DownstreamResponse> Aggregate(List<DownstreamResponse> responses)
        {
            var customer = await responses[IndexCustomerResponse].Deserialize<CustomerWillBeAggregate>();
            if (customer == null) return responses.EmptyResponse();

            var orders = await responses[IndexOrdersResponse].Deserialize<IEnumerable<OrderWillBeAggregate>>();
            if (orders == null) return responses.EmptyResponse();

            var result = new List<OrderViewModel>();
            foreach (var order in orders)
            {
                var products = new List<ProductViewModel>();
                foreach (var product in order.Products)
                {
                    // buscar cada um dos produtos via servico do catálogo

                    products.Add(ProductViewModel.Create(product.Id, "", decimal.Zero));
                }

                result.Add(OrderViewModel.Create(order.Id, customer.Name, products));
            }

            return await Task.FromResult(responses.Ok(result));
        }
    }
}
