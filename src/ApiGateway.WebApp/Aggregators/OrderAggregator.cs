using ApiGateway.WebApp.Extensions;
using ApiGateway.WebApp.ViewModels;
using Microsoft.Extensions.Configuration;
using Ocelot.Configuration.File;
using Ocelot.Middleware;
using Ocelot.Middleware.Multiplexer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGateway.WebApp.Aggregators
{
    public sealed class OrderAggregator : IDefinedAggregator
    {
        private const int IndexCustomerResponse = 0;
        private const int IndexOrdersResponse = 1;

        private readonly FileConfiguration fileConfiguration;

        public OrderAggregator(IConfiguration configuration) =>
            fileConfiguration = configuration.Get<FileConfiguration>();

        public async Task<DownstreamResponse> Aggregate(List<DownstreamResponse> responses)
        {
            var customer = await responses[IndexCustomerResponse].Deserialize<CustomerWillBeAggregate>();
            if (customer == null) return responses.Empty();

            var orders = await responses[IndexOrdersResponse].Deserialize<IEnumerable<OrderWillBeAggregate>>();
            if (orders == null) return responses.Empty();

            var result = new List<OrderViewModel>();
            foreach (var order in orders)
            {
                var products = new List<ProductViewModel>();
                foreach (var product in order.Products)
                {
                    // buscar cada um dos produtos via servico do catálogo

                    var productWillBeAggregate = await GetProductById(product.Id);

                    products.Add(ProductViewModel.Create(
                            product.Id,
                            productWillBeAggregate.Name,
                            productWillBeAggregate.Price));
                }

                result.Add(OrderViewModel.Create(order.Id, customer.Name, products));
            }

            return await Task.FromResult(responses.Ok(result));
        }

        private Task<ProductWillBeAggregate> GetProductById(Guid productId)
        {
            var client = new RestClient(GetBaseUrlProductById());
            var request = new RestRequest(GetResourceProductById(productId), Method.GET);

            var taskCompletionSource = new TaskCompletionSource<ProductWillBeAggregate>();

            client.ExecuteAsync<ProductWillBeAggregate>(request, response =>
            {
                if (response.ErrorException != null)
                {
                    taskCompletionSource.TrySetException(response.ErrorException);
                    return;
                }
                taskCompletionSource.TrySetResult(response.Data);
            });

            return taskCompletionSource.Task;
        }

        private string GetBaseUrlProductById()
        {
            var reRoute = fileConfiguration.ReRoutes.Single(x => string.Equals(x.Key, "ProductById"));
            return $"{reRoute.DownstreamScheme}://{reRoute.DownstreamHostAndPorts[0].Host}:{reRoute.DownstreamHostAndPorts[0].Port}";
        }

        private string GetResourceProductById(Guid productId) =>
            fileConfiguration.ReRoutes.Single(x =>
                string.Equals(x.Key, "ProductById")).DownstreamPathTemplate.Replace("{id:Guid}", productId.ToString());
    }
}
