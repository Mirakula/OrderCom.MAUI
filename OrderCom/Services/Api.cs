namespace OrderCom.Services
{
    public static class Api
    {
        /// <summary>
        /// Base Url of web server
        /// </summary>
        public static string BaseUrl = "http://www.ordercom.truthmath.com/api/";

        public static string DajOsnovnePopuste = "popusti/DajOsnovnePopuste";
        public static string DajAkcijskePopuste = "Popusti/DajAkcijskePopuste";
        public static string DajKupce = "Kupci/DajKupce";
        public static string DajFinasije = "finansije/dajfinansije";
        public static string DajLokacije = "lokacije/DajLokacije";
        public static string DajPrograme = "narudzbe/dajtipovenarudzbi";
        public static string DajRokovePlacanja = "finansije/DajRokovePlacanja";
        public static string DajProizvode = "Proizvodi/DajProizvode";
        public static string DajGrupe = "Proizvodi/DajGrupe";
        public static string DodajNarudzbu = "Narudzbe/DodajNarudzbu";
        public static string DodajStavkeNarudzbe = "Narudzbe/DodajStavkeNarudzbe";
        public static string BrisiNarudzbu = "Narudzbe/BrisiNarudzbu";

        public static string Login = "auth/login";
    }
}
