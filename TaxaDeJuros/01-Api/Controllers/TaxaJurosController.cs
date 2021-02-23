using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaxaDeJuros.Application.Services.Contracts;
using TaxaDeJuros.Domain.Entities;

namespace TaxaDeJuros.Api.Controllers
{
    [ApiController]
    [Route("taxaJuros")]
    public class TaxaJurosController : ControllerBase
    {
        public TaxaJurosController()
        {
        }

        [HttpGet]
        public TaxaJuros Get([FromServices] ITaxaJurosApplicationService service)
        {
            return service.GetTaxaDeJuros();
        }
    }
}
