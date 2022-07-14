using OrderCom.Models;

namespace OrderCom.Contracts
{
    public interface INarudzbaService
    {
        Task<List<indkdat>> DajSveNarudzbenice();
        List<instdat> DajStavkeNarudzbe(string in_brjdok);
        Task<namadat> DajProizovd(int ea_sifmat);
        Task<bool> DodajNarudzbenicu(indkdat indkdat);
    }
}
