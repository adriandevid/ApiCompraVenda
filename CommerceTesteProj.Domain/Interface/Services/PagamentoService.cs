using CommerceTesteProj.Domain.Models;

namespace CommerceTesteProj.Domain.Interface
{
    public interface PagamentoService
    {
        bool AutorizePayment(Pagamento EntityGeneric);
    }
}