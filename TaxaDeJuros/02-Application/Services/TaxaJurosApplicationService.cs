using TaxaDeJuros.Application.Services.Contracts;
using TaxaDeJuros.Domain.Entities;
using TaxaDeJuros.Domain.Services.Contracts;

namespace TaxaDeJuros.Application.Services
{
    public class TaxaJurosApplicationService : ITaxaJurosApplicationService
    {
        private readonly ITaxaJurosService _service;
        public TaxaJurosApplicationService(ITaxaJurosService service)
        {
            _service = service;
        }

        public TaxaJuros GetTaxaDeJuros()
        {
            return _service.GetTaxaJuros();
        }
    }
}
