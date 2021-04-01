using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;

namespace CalculaJurosAPI.Tests
{
    public class CalculoJurosAPITest
    {
        private readonly HttpClient _client;

        public CalculoJurosAPITest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());

            _client = server.CreateClient();            
        }

        [Theory]
        [InlineData("Get", 100, 5)]
        public async Task CalculaJurosGetAsync(string method, decimal valorinicial, int meses)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), $"/calculajuros?valorinicial={valorinicial}&meses={meses}");

            var response = await _client.SendAsync(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }
    }
}
