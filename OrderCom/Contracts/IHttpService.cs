using OrderCom.Models;
using OrderCom.Models.DTOs;

namespace OrderCom.Contracts
{
    public interface IHttpService
    {
        /// <summary>
        /// Web metoda koja daje tipove narudzbi po ca_imekrt.
        /// Tipovi narudzbi su prodajni programi.
        /// </summary>
        /// <param name="ca_imekrt"></param>
        /// <returns></returns>
        Task<dajtipn> DajPrograme(string ca_imekrt);

        /// <summary>
        /// Web Metoda koja vraca osnovne popuste po nv_brjtin i ca_imekrt.
        /// </summary>
        /// <param name="nv_brjtin"></param>
        /// <param name="ca_imekrt"></param>
        /// <returns></returns>
        Task<dajosnp> DajOsnovnePopuste(int nv_brjtin, string ca_imekrt);

        /// <summary>
        /// Web metoda koja daje sve kupce po nv_brjtin i ca_imekrt.
        /// </summary>
        /// <param name="nv_brjtin"></param>
        /// <param name="ca_imekrt"></param>
        /// <returns></returns>
        Task<dajkupc> DajKupce(int nv_brjtin, string ca_imekrt);

        /// <summary>
        /// Web metoda koja vraca stanja kupaca (dug, status duga, dan dugovanja...),
        /// po nv_brjtin i ca_imekrt.
        /// </summary>
        /// <param name="nv_brjtin"></param>
        /// <param name="ca_imekrt"></param>
        /// <returns></returns>
        Task<dajfins> DajFinansije(int nv_brjtin, string ca_imekrt);

        /// <summary>
        /// Web metoda koja vraca lokaciju kupaca i informacije kupca tipa
        /// naziv kupca, adresu, mjesto...
        /// </summary>
        /// <param name="nv_brjtin"></param>
        /// <param name="ca_imekrt"></param>
        /// <returns></returns>
        Task<dajlokc> DajLokacije(int nv_brjtin, string ca_imekrt);

        /// <summary>
        /// Web metoda koja vraca rokove placanja .
        /// </summary>
        /// <param name="nv_brjtin"></param>
        /// <param name="ca_imekrt"></param>
        /// <returns></returns>
        Task<rokplac> DajRokovePlacanja(int nv_brjtin, string ca_imekrt);

        /// <summary>
        /// Web metoda koja je zaduzena za slanje narudzbe u web servis.
        /// </summary>
        /// <param name="indkdatDTO"></param>
        /// <returns></returns>
        Task<indkdat> DodajNarudzbu(indkdatDTO indkdatDTO);

        /// <summary>
        /// Web metoda koja je zaduzena za slanje stavki narudzbe.
        /// </summary>
        /// <param name="instdatDTO"></param>
        /// <returns></returns>
        Task<instdat> DodajStavkeNarudzbe(instdatDTO instdatDTO);

        /// <summary>
        /// Web metoda koja je zaduzena za dobavljanje grupa za proizvod po
        /// nv_brjtin. 
        /// </summary>
        /// <param name="dajgrppDTO"></param>
        /// <returns></returns>
        Task<dajgrpp> DajGrupe(dajgrppDTO dajgrppDTO);

        /// <summary>
        /// Web metoda koja je zaduzena za brisanje narudzbe i stavki narudzbe iz SQL Baze.
        /// Proslijedi se broj dokumenta brjdok a web servis obrise narudzbu zajedno sa stavkama narudzbe.
        /// </summary>
        /// <param name="brjdok"></param>
        /// <returns></returns>
        Task<int> ObrisiNarudzbu(string brjdok);

    }
}
