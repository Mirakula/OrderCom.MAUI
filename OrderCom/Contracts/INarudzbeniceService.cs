using OrderCom.Models;

namespace OrderCom.Contracts
{
    public interface INarudzbeniceService
    {
        Task<List<indkdat>> DajSveNarudzbenice();
        Task<bool> DodajNarudzbenicu(indkdat indkdat);
    }
}
