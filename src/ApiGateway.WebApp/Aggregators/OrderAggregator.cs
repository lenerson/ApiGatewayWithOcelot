using Ocelot.Middleware;
using Ocelot.Middleware.Multiplexer;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiGateway.WebApp.Aggregators
{
    public sealed class OrderAggregator : IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<DownstreamResponse> responses)
        {
            var one = await responses[0].Content.ReadAsStringAsync();
            var two = await responses[1].Content.ReadAsStringAsync();

            return await Task.FromResult(new DownstreamResponse(
                new StringContent(two),
                HttpStatusCode.OK,
                responses.SelectMany(x => x.Headers).ToList(),
                string.Empty));
        }
    }
}
