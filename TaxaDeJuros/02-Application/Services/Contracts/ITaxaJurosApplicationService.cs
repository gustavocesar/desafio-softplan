using TaxaDeJuros.Domain.Entities;

namespace TaxaDeJuros.Application.Services.Contracts
{
    public interface ITaxaJurosApplicationService
    {
        TaxaJuros GetTaxaDeJuros();
    }
}