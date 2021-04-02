using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using CalculaJurosAPI.Models;
using Newtonsoft.Json;

namespace CalculaJurosAPI.Controllers
{
    [ApiController]
    [Route("calculajuros")]
    public class CalculaJurosController : ControllerBase
    {
        private CalculaJuros _calculaJuros;
        [HttpGet()]
        public ActionResult<CalculaJuros> Get([FromQuery(Name = "valorinicial")] decimal valorinicial, [FromQuery(Name = "meses")] int meses)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("http://localhost:8080/taxaJuros").Result;
            response.EnsureSuccessStatusCode();
            string conteudo = response.Content.ReadAsStringAsync().Result;

            dynamic result = JsonConvert.DeserializeObject(conteudo);

            decimal _taxaJuros = result.taxaJuros + 1d;
            _calculaJuros = new CalculaJuros();
            _calculaJuros.valorfinal = (decimal.Truncate(valorinicial * Convert.ToDecimal(Math.Pow(Convert.ToDouble(_taxaJuros), meses))*100)/100)
                .ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            return _calculaJuros;
        }    
    }
}
