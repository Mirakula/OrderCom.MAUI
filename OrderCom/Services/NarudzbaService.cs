using OrderCom.Contracts;
using OrderCom.Models;

namespace OrderCom.Services
{
    public class NarudzbaService : INarudzbaService
    {
        public List<indkdat> Narudzbe;
        public List<instdat> StavkeNarudzbe;
        public List<namadat> Proizvodi;
        public NarudzbaService()
        {
            Narudzbe = new();
        }

        public async Task<namadat> DajProizovd(int ea_sifmat)
        {
            Proizvodi = new()
            {
                new namadat
                {
                    ea_sifmat = 203737,
                    ea_imemat = "CETKICA ZA Z.COL.SLIM SOFT CHARCOAL",
                    ea_imekrt = "CETKICA ZA",
                    ea_jedmje = "KOM",
                    ba_kupdob = 372,
                    ea_kompak = 12.0000,
                    ea_potpak = 1.0000,
                    ea_tipmts = 9,
                    ea_sifean = "8714789954431",
                    ea_sifpro = "CN01068A",
                    ea_brtari = "101",
                    ea_pospor = 1,
                    ea_odnkol = 0.0000,
                    ea_osncij = 4.8500,
                    ea_rucvlp = 4.3600,
                    ea_rucmlp = 4.8500,
                    ab_matgrp = "41030900",
                    ea_staslg = "2",
                    ea_usenam = "ADISA",
                    ea_datdok = DateTime.Parse("2022-02-18 00:00:00.000"),
                    ea_porusl = 0
                },
                new namadat
                {
                    ea_sifmat = 30064,
                    ea_imemat = "PANASONIC BAT.PP GOLD AA LR6 4/1",
                    ea_imekrt = "PANASONIC ",
                    ea_jedmje = "BLI",
                    ba_kupdob = 489,
                    ea_kompak = 1.0000,
                    ea_potpak = 1.0000,
                    ea_tipmts = 9,
                    ea_sifean = "5410853039921",
                    ea_sifpro = " ",
                    ea_brtari = "101",
                    ea_pospor = 1,
                    ea_odnkol = 0.0000,
                    ea_osncij = 3.3000,
                    ea_rucvlp = 3.3000,
                    ea_rucmlp = 3.3000,
                    ab_matgrp = "62020205",
                    ea_staslg = "2",
                    ea_usenam = "ADISA",
                    ea_datdok = DateTime.Parse("2022-02-18 00:00:00.000"),
                    ea_porusl = 0
                },new namadat
                {
                    ea_sifmat = 30080,
                    ea_imemat = "PANASONIC BAT.ZINC CARB.AA R6 4/1",
                    ea_imekrt = "PANASONIC ",
                    ea_jedmje = "BLI",
                    ba_kupdob = 489,
                    ea_kompak = 1.0000,
                    ea_potpak = 1.0000,
                    ea_tipmts = 9,
                    ea_sifean = "5410853032830",
                    ea_sifpro = " ",
                    ea_brtari = "101",
                    ea_pospor = 1,
                    ea_odnkol = 0.0000,
                    ea_osncij = 1.2000,
                    ea_rucvlp = 0.9600,
                    ea_rucmlp = 1.2000,
                    ab_matgrp = "62020205",
                    ea_staslg = "2",
                    ea_usenam = "ADISA",
                    ea_datdok = DateTime.Parse("2022-02-18 00:00:00.000"),
                    ea_porusl = 0
                },new namadat
                {
                    ea_sifmat = 43430,
                    ea_imemat = "PANASONIC BAT.AP BRONZ.AAA LR03 4/1",
                    ea_imekrt = "PANASONIC",
                    ea_jedmje = "BLI",
                    ba_kupdob = 489,
                    ea_kompak = 1.0000,
                    ea_potpak = 1.0000,
                    ea_tipmts = 9,
                    ea_sifean = "5410853039334",
                    ea_sifpro = " ",
                    ea_brtari = "101",
                    ea_pospor = 1,
                    ea_odnkol = 0.0000,
                    ea_osncij = 2.3000,
                    ea_rucvlp = 2.3000,
                    ea_rucmlp = 2.3000,
                    ab_matgrp = "62020205",
                    ea_staslg = "2",
                    ea_usenam = "ADISA",
                    ea_datdok = DateTime.Parse("2022-02-18 00:00:00.000"),
                    ea_porusl = 0
                },new namadat
                {
                    ea_sifmat = 178657,
                    ea_imemat = "CETKICA ZA Z.COL.TRIPLE ACTION 1+1",
                    ea_imekrt = "CETKICA ZA",
                    ea_jedmje = "KOM",
                    ba_kupdob = 372,
                    ea_kompak = 12.0000,
                    ea_potpak = 2.0000,
                    ea_tipmts = 9,
                    ea_sifean = "8718951309609",
                    ea_sifpro = "269954",
                    ea_brtari = "101",
                    ea_pospor = 1,
                    ea_odnkol = 0.0000,
                    ea_osncij = 2.2000,
                    ea_rucvlp = 1.9900,
                    ea_rucmlp = 2.2000,
                    ab_matgrp = "41030900",
                    ea_staslg = "2",
                    ea_usenam = "ADISA",
                    ea_datdok = DateTime.Parse("2022-02-18 00:00:00.000"),
                    ea_porusl = 0
                },new namadat
                {
                    ea_sifmat = 17384,
                    ea_imemat = "CETKICA ZA Z.COL.EXTRA CLEAN 1+1",
                    ea_imekrt = "CETKICA ZA",
                    ea_jedmje = "KOM",
                    ba_kupdob = 372,
                    ea_kompak = 12.0000,
                    ea_potpak = 2.0000,
                    ea_tipmts = 9,
                    ea_sifean = "8714789732244",
                    ea_sifpro = "259439",
                    ea_brtari = "101",
                    ea_pospor = 1,
                    ea_odnkol = 0.0000,
                    ea_osncij = 1.9000,
                    ea_rucvlp = 1.7000,
                    ea_rucmlp = 1.9000,
                    ab_matgrp = "41030900",
                    ea_staslg = "2",
                    ea_usenam = "ADISA",
                    ea_datdok = DateTime.Parse("2022-02-18 00:00:00.000"),
                    ea_porusl = 0
                },new namadat
                {
                    ea_sifmat = 26336,
                    ea_imemat = "CETKICA ZA Z.COL.PREMIER CLEAN",
                    ea_imekrt = "CETKICA ZA",
                    ea_jedmje = "KOM",
                    ba_kupdob = 372,
                    ea_kompak = 12.0000,
                    ea_potpak = 1.0000,
                    ea_tipmts = 9,
                    ea_sifean = "8850006330449",
                    ea_sifpro = "FCN20625",
                    ea_brtari = "101",
                    ea_pospor = 1,
                    ea_odnkol = 0.0000,
                    ea_osncij = 0.8500,
                    ea_rucvlp = 0.7800,
                    ea_rucmlp = 0.8500,
                    ab_matgrp = "41030900",
                    ea_staslg = "2",
                    ea_usenam = "ADISA",
                    ea_datdok = DateTime.Parse("2022-02-18 00:00:00.000"),
                    ea_porusl = 0
                },new namadat
                {
                    ea_sifmat = 26286,
                    ea_imemat = "CETKICA ZA Z.COL.SMILES JUNIOR 2-6",
                    ea_imekrt = "CETKICA ZA",
                    ea_jedmje = "KOM",
                    ba_kupdob = 372,
                    ea_kompak = 12.0000,
                    ea_potpak = 1.0000,
                    ea_tipmts = 9,
                    ea_sifean = "5900273150035",
                    ea_sifpro = "FCN20677",
                    ea_brtari = "101",
                    ea_pospor = 1,
                    ea_odnkol = 0.0000,
                    ea_osncij = 3.8500,
                    ea_rucvlp = 3.4800,
                    ea_rucmlp = 3.8500,
                    ab_matgrp = "41030900",
                    ea_staslg = "2",
                    ea_usenam = "ADISA",
                    ea_datdok = DateTime.Parse("2022-02-18 00:00:00.000"),
                    ea_porusl = 0
                },new namadat
                {
                    ea_sifmat = 17418,
                    ea_imemat = "SAPUN LHS MILK&HONEY PUMP 300ML",
                    ea_imekrt = "SAPUN LHS",
                    ea_jedmje = "KOM",
                    ba_kupdob = 372,
                    ea_kompak = 12.0000,
                    ea_potpak = 1.0000,
                    ea_tipmts = 9,
                    ea_sifean = "8003520013026",
                    ea_sifpro = "207510",
                    ea_brtari = "101",
                    ea_pospor = 1,
                    ea_odnkol = 0.0000,
                    ea_osncij = 3.7000,
                    ea_rucvlp = 3.3300,
                    ea_rucmlp = 3.7000,
                    ab_matgrp = "41010400",
                    ea_staslg = "2",
                    ea_usenam = "ADNA",
                    ea_datdok = DateTime.Parse("2022-02-18 00:00:00.000"),
                    ea_porusl = 0
                },new namadat
                {
                    ea_sifmat = 43422,
                    ea_imemat = "PANASONIC BAT.AP BRONZE AA LR6 4/1",
                    ea_imekrt = "PANASONIC",
                    ea_jedmje = "BLI",
                    ba_kupdob = 489,
                    ea_kompak = 1.0000,
                    ea_potpak = 1.0000,
                    ea_tipmts = 9,
                    ea_sifean = "5410853039273",
                    ea_sifpro = " ",
                    ea_brtari = "101",
                    ea_pospor = 1,
                    ea_odnkol = 0.0000,
                    ea_osncij = 2.3000,
                    ea_rucvlp = 2.3000,
                    ea_rucmlp = 2.3000,
                    ab_matgrp = "41030900",
                    ea_staslg = "2",
                    ea_usenam = "ADISA",
                    ea_datdok = DateTime.Parse("2022-02-18 00:00:00.000"),
                    ea_porusl = 0
                },
            };

            return Proizvodi.Where(s => s.ea_sifmat == ea_sifmat).FirstOrDefault();
        }

        public List<instdat> DajStavkeNarudzbe(string in_brjdok)
        {
            List<instdat> stavkeNarudzbe = new()
            {
                new instdat
                {
                    kn_redbrj = 1,
                    kn_sifmat = 20373,
                    kn_kolmat = 12.000,
                    kn_cijmat = 4.360,
                    kn_sifpro = " ",
                    kn_brjcij = 0,
                    kn_tipmts = 0,
                    kn_brjdok = "219C6005",
                    kn_staslg = "3",
                    kn_rabsta = 0,
                    kn_siflok = null,
                    kn_rabkup = 8.000
                },
                 new instdat
                {
                    kn_redbrj = 2,
                    kn_sifmat = 43422,
                    kn_kolmat = 2.300,
                    kn_cijmat = 4.360,
                    kn_sifpro = " ",
                    kn_brjcij = 0,
                    kn_tipmts = 0,
                    kn_brjdok = "219C6005",
                    kn_staslg = "3",
                    kn_rabsta = 0,
                    kn_siflok = null,
                    kn_rabkup = 8.000
                },
                  new instdat
                {
                    kn_redbrj = 3,
                    kn_sifmat = 30064,
                    kn_kolmat = 12.000,
                    kn_cijmat = 3.300,
                    kn_sifpro = " ",
                    kn_brjcij = 0,
                    kn_tipmts = 0,
                    kn_brjdok = "219C6005",
                    kn_staslg = "3",
                    kn_rabsta = 0,
                    kn_siflok = null,
                    kn_rabkup = 8.000
                },
                   new instdat
                {
                    kn_redbrj = 4,
                    kn_sifmat = 30080,
                    kn_kolmat = 12.000,
                    kn_cijmat = 0.960,
                    kn_sifpro = " ",
                    kn_brjcij = 0,
                    kn_tipmts = 0,
                    kn_brjdok = "219C6005",
                    kn_staslg = "3",
                    kn_rabsta = 0,
                    kn_siflok = null,
                    kn_rabkup = 8.000
                },
                 new instdat
                {
                    kn_redbrj = 6,
                    kn_sifmat = 178657,
                    kn_kolmat = 12.000,
                    kn_cijmat = 1.990,
                    kn_sifpro = " ",
                    kn_brjcij = 0,
                    kn_tipmts = 0,
                    kn_brjdok = "219C6005",
                    kn_staslg = "3",
                    kn_rabsta = 0,
                    kn_siflok = null,
                    kn_rabkup = 8.000
                },
                 new instdat
                {
                    kn_redbrj = 7,
                    kn_sifmat = 17384,
                    kn_kolmat = 12.000,
                    kn_cijmat = 1.700,
                    kn_sifpro = " ",
                    kn_brjcij = 0,
                    kn_tipmts = 0,
                    kn_brjdok = "219C6005",
                    kn_staslg = "3",
                    kn_rabsta = 0,
                    kn_siflok = null,
                    kn_rabkup = 8.000
                },
                 new instdat
                {
                    kn_redbrj = 8,
                    kn_sifmat = 26336,
                    kn_kolmat = 12.000,
                    kn_cijmat = 0.780,
                    kn_sifpro = " ",
                    kn_brjcij = 0,
                    kn_tipmts = 0,
                    kn_brjdok = "219C6005",
                    kn_staslg = "3",
                    kn_rabsta = 0,
                    kn_siflok = null,
                    kn_rabkup = 8.000
                },
                 new instdat
                {
                    kn_redbrj = 9,
                    kn_sifmat = 26286,
                    kn_kolmat = 6.000,
                    kn_cijmat = 3.480,
                    kn_sifpro = " ",
                    kn_brjcij = 0,
                    kn_tipmts = 0,
                    kn_brjdok = "219C6005",
                    kn_staslg = "3",
                    kn_rabsta = 0,
                    kn_siflok = null,
                    kn_rabkup = 8.000
                },
                 new instdat
                {
                    kn_redbrj = 10,
                    kn_sifmat = 17418,
                    kn_kolmat = 3.000,
                    kn_cijmat = 3.330,
                    kn_sifpro = " ",
                    kn_brjcij = 0,
                    kn_tipmts = 0,
                    kn_brjdok = "219C6005",
                    kn_staslg = "3",
                    kn_rabsta = 0,
                    kn_siflok = null,
                    kn_rabkup = 8.000
                },
            };

            return stavkeNarudzbe.Where(s => s.kn_brjdok == in_brjdok).ToList();
        }

        public async Task<List<indkdat>> DajSveNarudzbenice()
        {
            Narudzbe.Add(new indkdat
            {
                in_brjdok = "219C6005",
                in_brjori = " ",
                in_brjotp = " ",
                in_posmat = "050201",
                in_primat = 600031,
                in_primis = 10,
                in_rabkup = 0.00,
                in_datrea = DateTime.Parse("2022-02-19 07:43:46.000"),
                in_nacpla = 1,
                in_valpla = "KM",
                in_rokpla = 60,
                in_tiprac = 0,
                in_tipnar = 35,
                in_demdin = 1.000000,
                in_vriskl = 573.78,
                in_indskl = 0,
                in_staslg = "3",
                in_datdok = DateTime.Parse("2022-02-19 07:43:46.000"),
                in_usenam = "C6",
                in_radmod = "RUR",
                in_izvdok = 0,
                in_siflok = null,
                in_narkup = " "
            });
            Narudzbe.Add(new indkdat
            {
                in_brjdok = "309E2002",
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
                in_vriskl = 165.74,
                in_indskl = 0,
                in_staslg = "2",
                in_datdok = DateTime.Parse("2017-03-09 15:27:25.000"),
                in_usenam = "E2",
                in_radmod = "RUR",
                in_izvdok = 0,
                in_siflok = null,
                in_narkup = " "
            });
            Narudzbe.Add(new indkdat
            {
                in_brjdok = "309E2003",
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
                in_vriskl = 275.0,
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

            foreach (var narudzba in Narudzbe)
            {
                if (narudzba.in_staslg == "1")
                    narudzba.in_poszak = "nezakljucena_light.png";
                else if (narudzba.in_staslg == "2")
                    narudzba.in_poszak = "zakljucena_light.png";
                else
                    narudzba.in_poszak = "poslana_light.png";
            }

            return Narudzbe;
        }

        public Task<bool> DodajNarudzbenicu(indkdat indkdat)
        {
            throw new NotImplementedException();
        }
    }
}
