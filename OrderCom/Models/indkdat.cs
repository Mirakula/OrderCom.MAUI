using SQLite;

namespace OrderCom.Models
{
    [Table("indkdat")]
    public class indkdat
    {
        [Column("in_brjdok")]
        public string in_brjdok { get; set; }
        [Column("in_brjori")]
        public string in_brjori { get; set; }
        [Column("in_brjotp")]
        public string in_brjotp { get; set; }
        [Column("in_posmat")]
        public string in_posmat { get; set; }
        [Column("in_primat")]
        public double in_primat { get; set; }
        [Column("in_primis")]
        public double in_primis { get; set; }
        [Column("in_rabkup")]
        public double in_rabkup { get; set; }
        [Column("in_datrea")]
        public DateTime in_datrea { get; set; }
        [Column("in_nacpla")]
        public double in_nacpla { get; set; }
        [Column("in_valpla")]
        public string in_valpla { get; set; }
        [Column("in_rokpla")]
        public double in_rokpla { get; set; }
        [Column("in_tiprac")]
        public double in_tiprac { get; set; }
        [Column("in_tipnar")]
        public double in_tipnar { get; set; }
        [Column("in_demdin")]
        public double in_demdin { get; set; }
        [Column("in_vriskl")]
        public double in_vriskl { get; set; }
        [Column("in_indskl")]
        public double in_indskl { get; set; }
        [Column("in_staslg")]
        public string in_staslg { get; set; }
        [Column("in_datdok")]
        public DateTime in_datdok { get; set; }
        [Column("in_usenam")]
        public string in_usenam { get; set; }
        [Column("in_radmod")]
        public string in_radmod { get; set; }
        [Column("in_izvdok")]
        public double in_izvdok { get; set; }
        [Column("in_siflok")]
        public string in_siflok { get; set; }
        [Column("in_narkup")]
        public string in_narkup { get; set; }
        [Ignore]
        public string in_poszak { get; set; }
    }
}
