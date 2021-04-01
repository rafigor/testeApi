using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;

namespace TaxaJurosAPI.Tests
{
    public class TaxaJurosAPITest
    {
        private readonly HttpClient _client;

        public TaxaJurosAPITest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());

            _client = server.CreateClient();
        }

        [Theory]
        [InlineData("Get")]
        public async Task TaxaJurosGetAsync(string method)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), "/taxaJuros");

            var response = await _client.SendAsync(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
