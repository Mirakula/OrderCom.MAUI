using SQLite;

namespace OrderCom.Models
{
    [Table("dajkupc")]
    public class dajkupc
    {
        [Column("ba_kupdob")]
        public int ba_kupdob { get; set; }
        [Column("ba_imepre")]
        public string ba_imepre { get; set; }
        [Column("ba_adresa")]
        public string ba_adresa { get; set; }
        [Column("ba_mjepre")]
        public string ba_mjepre { get; set; }
        [Column("ba_tlfcen")]
        public string ba_tlfcen { get; set; }
        [Column("ba_porbrj")]
        public long ba_porbrj { get; set; }
        [Column("ba_porpdv")]
        public string ba_porpdv { get; set; }
        [Column("ps_ukudug")]
        public double ps_ukudug { get; set; }
        [Column("ps_stadug")]
        public double ps_stadug { get; set; }
        [Column("ps_dandug")]
        public int ps_dandug { get; set; }
        [Column("ps_vriizf")]
        public double ps_vriizf { get; set; }
        [Column("ba_matbrj")]
        public string ba_matbrj { get; set; }
        [Column("nr_rabkup")]
        public double nr_rabkup { get; set; }
    }
}
