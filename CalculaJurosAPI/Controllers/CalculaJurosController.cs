using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculaJurosAPI.Models;

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
            var _taxaJuros = 0.01d;
            _calculaJuros = new CalculaJuros();
            _calculaJuros.valorfinal = (decimal.Truncate(valorinicial * Convert.ToDecimal(Math.Pow((1d + _taxaJuros), meses))*100)/100)
                .ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            return _calculaJuros;
        }    
    }
}
