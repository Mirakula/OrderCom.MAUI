using OrderCom.Models;

namespace OrderCom.Contracts
{
    public interface INarudzbeniceService
    {
        Task<List<indkdat>> DajSveNarudzbenice();
    }
}
