using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculaJuros.Api.Controllers
{
    [ApiController]
    // [Route("calculaJuros")]
    public class CalculaJurosController : ControllerBase
    {
        public CalculaJurosController()
        {
        }

        [HttpGet("calculaJuros")]
        public string CalcularJuros()
        {
            return "calculaJuros";
        }

        [HttpGet("showmethecode")]
        public string ShowMeTheCode()
        {
            return "showmethecode ";
        }
    }
}
