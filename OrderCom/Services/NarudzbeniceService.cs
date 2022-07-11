using OrderCom.Contracts;
using OrderCom.Models;
using System.Globalization;

namespace OrderCom.Services
{
    public class NarudzbeniceService : INarudzbeniceService
    {
        public List<indkdat> Narudzbenice;
        public NarudzbeniceService()
        {
            Narudzbenice = new();
        }
        public async Task<List<indkdat>> DajSveNarudzbenice()
        {
            Narudzbenice.Add(new indkdat
            {
                in_brjdok = "309E2001",
                in_brjori = " ",
                in_brjotp = " ",
                in_posmat = "123456",
                in_primat = 63388,
                in_primis = 60,
                in_rabkup = 0.00,
                in_datrea = DateTime.Parse("2017-03-09 15:27:25.000"),
                in_nacpla = 2,
                in_valpla = "KM",
                in_rokpla = 20,
                in_tiprac = 0,
                in_tipnar = 49,
                in_demdin = 1.000000,
                in_vriskl = 165.0,
                in_indskl = 0,
                in_staslg = "1",
                in_datdok = DateTime.Parse("2017-03-09 15:27:25.000"),
                in_usenam = "E2",
                in_radmod = "RUR",
                in_izvdok = 0,
                in_siflok = null,
                in_narkup = " "
            });
            Narudzbenice.Add(new indkdat
            {
                in_brjdok = "309E2001",
                in_brjori = " ",
                in_brjotp = " ",
                in_posmat = "123456",
                in_primat = 63388,
                in_primis = 60,
                in_rabkup = 0.00,
                in_datrea = DateTime.Parse("2017-03-09 15:27:25.000"),
                in_nacpla = 2,
                in_valpla = "KM",
                in_rokpla = 20,
                in_tiprac = 0,
                in_tipnar = 49,
                in_demdin = 1.000000,
                in_vriskl = 165.0,
                in_indskl = 0,
                in_staslg = "1",
                in_datdok = DateTime.Parse("2017-03-09 15:27:25.000"),
                in_usenam = "E2",
                in_radmod = "RUR",
                in_izvdok = 0,
                in_siflok = null,
                in_narkup = " "
            });
            Narudzbenice.Add(new indkdat
            {
                in_brjdok = "309E2001",
                in_brjori = " ",
                in_brjotp = " ",
                in_posmat = "123456",
                in_primat = 63388,
                in_primis = 60,
                in_rabkup = 0.00,
                in_datrea = DateTime.Parse("2017-03-09 15:27:25.000"),
                in_nacpla = 2,
                in_valpla = "KM",
                in_rokpla = 20,
                in_tiprac = 0,
                in_tipnar = 49,
                in_demdin = 1.000000,
                in_vriskl = 165.0,
                in_indskl = 0,
                in_staslg = "1",
                in_datdok = DateTime.Parse("2017-03-09 15:27:25.000"),
                in_usenam = "E2",
                in_radmod = "RUR",
                in_izvdok = 0,
                in_siflok = null,
                in_narkup = " "
            }); ;

            await Task.Delay(3000);

            return Narudzbenice;
        }
    }
}
