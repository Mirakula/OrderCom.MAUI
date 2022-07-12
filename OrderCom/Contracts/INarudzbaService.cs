using OrderCom.Models;

namespace OrderCom.Contracts
{
    public interface INarudzbaService
    {
        Task<List<indkdat>> DajSveNarudzbenice();
        Task<List<instdat>> DajStavkeNarudzbe(string in_brjdok);
        Task<bool> DodajNarudzbenicu(indkdat indkdat);
    }
}
