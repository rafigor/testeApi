using Microsoft.AspNetCore.Mvc;
using System;
using CalculaJurosAPI.Models;

namespace CalculaJurosAPI.Controllers
{
    [ApiController]
    [Route("showmethecode")]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly ShowMeTheCode _showMeTheCode;

        public ShowMeTheCodeController()
        {
            _showMeTheCode = new ShowMeTheCode();
        }

        [HttpGet()]
        public ActionResult<ShowMeTheCode> Get()
        {
            return _showMeTheCode;
        }
    }
}
