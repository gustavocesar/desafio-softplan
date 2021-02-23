using TaxaDeJuros.Domain.Entities;
using TaxaDeJuros.Domain.Services.Contracts;

namespace TaxaDeJuros.Domain.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        public TaxaJuros GetTaxaJuros()
        {
            return new TaxaJuros
            {
                Taxa = 0.01M
            };
        }
    }
}
