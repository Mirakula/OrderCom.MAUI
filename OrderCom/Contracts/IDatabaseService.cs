using OrderCom.Models;
using OrderCom.Models.DTOs;

namespace OrderCom.Contracts
{
    public interface IDatabaseService
    {
        bool IsDbCreated();
        Task DeployLocalDatabase();
        Task DeleteLocalDatabase();
        Task<IEnumerable<akcpops>> OsvjeziAkcijskePopuste();
        Task<IEnumerable<namadat>> OsvjeziProizvode(dajproiDTO dajproiDTO);
        /// <summary>
        /// (Osvjezi tipove narudzbi)
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<dajtipn>> OsvjeziPrograme(dajtipnDTO dajtipnDTO);

        Task<IEnumerable<dajkupc>> OsvjeziKupce(dajkupcDTO dajkupcDTO);
    }
}
