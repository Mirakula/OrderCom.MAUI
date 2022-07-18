using OrderCom.Contracts;
using OrderCom.Models;
using OrderCom.Models.DTOs;

namespace OrderCom.Services
{
    public class HttpService : IHttpService
    {
        public Task<dajfins> DajFinansije(int nv_brjtin, string ca_imekrt)
        {
            throw new NotImplementedException();
        }

        public Task<dajgrpp> DajGrupe(dajgrppDTO dajgrppDTO)
        {
            throw new NotImplementedException();
        }

        public Task<dajkupc> DajKupce(int nv_brjtin, string ca_imekrt)
        {
            throw new NotImplementedException();
        }

        public Task<dajlokc> DajLokacije(int nv_brjtin, string ca_imekrt)
        {
            throw new NotImplementedException();
        }

        public Task<dajosnp> DajOsnovnePopuste(int nv_brjtin, string ca_imekrt)
        {
            throw new NotImplementedException();
        }

        public Task<dajtipn> DajPrograme(string ca_imekrt)
        {
            throw new NotImplementedException();
        }

        public Task<rokplac> DajRokovePlacanja(int nv_brjtin, string ca_imekrt)
        {
            throw new NotImplementedException();
        }

        public Task<indkdat> DodajNarudzbu(indkdatDTO indkdatDTO)
        {
            throw new NotImplementedException();
        }

        public Task<instdat> DodajStavkeNarudzbe(instdatDTO instdatDTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> ObrisiNarudzbu(string brjdok)
        {
            throw new NotImplementedException();
        }


    }
}
