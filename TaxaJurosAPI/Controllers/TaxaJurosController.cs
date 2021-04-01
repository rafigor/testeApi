using Microsoft.AspNetCore.Mvc;
using TaxaJurosAPI.Models;

namespace TaxaJurosAPI.Controllers
{
    [ApiController]
    [Route("taxaJuros")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly TaxaJuros _taxaJuros;

        public TaxaJurosController()
        {
            _taxaJuros = new TaxaJuros();
        }

        [HttpGet]
        public ActionResult<TaxaJuros> Get()
        {
            return _taxaJuros;
        }
    }
}