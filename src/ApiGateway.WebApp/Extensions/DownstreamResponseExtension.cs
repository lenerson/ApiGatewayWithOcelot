using Ocelot.Middleware;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using static Newtonsoft.Json.JsonConvert;

namespace ApiGateway.WebApp.Extensions
{
    public static class DownstreamResponseExtension
    {
        public static async Task<T> Deserialize<T>(this DownstreamResponse response) =>
            await response.Content.ReadAsAsync<T>();

        public static DownstreamResponse EmptyResponse(this List<DownstreamResponse> responses) =>
            new DownstreamResponse(
                new StringContent(string.Empty),
                HttpStatusCode.OK,
                responses.SelectMany(x => x.Headers).ToList(),
                string.Empty);

        public static DownstreamResponse Ok(this List<DownstreamResponse> responses, object result) =>
            new DownstreamResponse(
                new StringContent(SerializeObject(result)),
                HttpStatusCode.OK,
                responses.SelectMany(x => x.Headers).ToList(),
                string.Empty
            );
    }
}
