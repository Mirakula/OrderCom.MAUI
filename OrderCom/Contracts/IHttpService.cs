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
        /// <param name="dajtipnDTO"></param>
        /// <returns></returns>
        Task<IEnumerable<dajtipn>> DajPrograme(dajtipnDTO dajtipnDTO);

        /// <summary>
        /// Web etoda koja vraca osnovne popuste po nv_brjtin i ca_imekrt.
        /// </summary>
        /// <param name="osnpopsDTO"></param>
        /// <returns></returns>
        Task<IEnumerable<osnpops>> DajOsnovnePopuste(osnpopsDTO osnpopsDTO);

        /// <summary>
        /// Web metoda koja vraca akcijske popuste. 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<akcpops>> DajAkcijskePopuste();

        /// <summary>
        /// Web metoda koja daje sve kupce po nv_brjtin i ca_imekrt.
        /// </summary>
        /// <param name="dajkupcDTO"></param>
        /// <returns></returns>
        Task<IEnumerable<dajkupc>> DajKupce(dajkupcDTO dajkupcDTO);

        /// <summary>
        /// Web metoda koja vraca stanja kupaca (dug, status duga, dan dugovanja...),
        /// po nv_brjtin i ca_imekrt.
        /// </summary>
        /// <param name="dajfinsDTO"></param>
        /// <returns></returns>
        Task<IEnumerable<dajfins>> DajFinansije(dajfinsDTO dajfinsDTO);

        /// <summary>
        /// Web metoda koja vraca lokaciju kupaca i informacije kupca tipa
        /// naziv kupca, adresu, mjesto...
        /// </summary>
        /// <param name="dajlokcDTO"></param>
        /// <returns></returns>
        Task<IEnumerable<dajlokc>> DajLokacije(dajlokcDTO dajlokcDTO);

        /// <summary>
        /// Web metoda koja vraca rokove placanja .
        /// </summary>
        /// <param name="rokplacDTO"></param>
        /// <returns></returns>
        Task<IEnumerable<rokplac>> DajRokovePlacanja(rokplacDTO rokplacDTO);

        /// <summary>
        /// Web metoda koja je zaduzena za slanje narudzbe u web servis.
        /// </summary>
        /// <param name="indkdatDTO"></param>
        /// <returns></returns>
        Task<int> DodajNarudzbu(indkdatDTO indkdatDTO);

        /// <summary>
        /// Web metoda koja je zaduzena za slanje stavki narudzbe.
        /// </summary>
        /// <param name="instdatDTO"></param>
        /// <returns></returns>
        Task<int> DodajStavkeNarudzbe(instdatDTO instdatDTO);

        /// <summary>
        /// Web metoda koja je zaduzena za dobavljanje grupa za proizvod po
        /// nv_brjtin. 
        /// </summary>
        /// <param name="dajgrppDTO"></param>
        /// <returns></returns>
        Task<IEnumerable<dajgrpp>> DajGrupe(dajgrppDTO dajgrppDTO);

        /// <summary>
        /// Web metoda koja je zaduzena za brisanje narudzbe i stavki narudzbe iz SQL Baze.
        /// Proslijedi se broj dokumenta brjdok a web servis obrise narudzbu zajedno sa stavkama narudzbe.
        /// </summary>
        /// <param name="brjdokDTO"></param>
        /// <returns></returns>
        Task<int> ObrisiNarudzbu(brjdokDTO brjdokDTO);

        /// <summary>
        /// Web metoda koja je zaduzena za dobavljanje proizvoda iz SQL Baze.
        /// Proslijedi se broj dokumenta brjdok a web servis obrise narudzbu zajedno sa stavkama narudzbe.
        /// </summary>
        /// <param name="dajproiDTO"></param>
        /// <returns></returns>

        Task<IEnumerable<namadat>> DajProizvode(dajproiDTO dajproiDTO);
    }
}
