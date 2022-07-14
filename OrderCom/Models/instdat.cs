using SQLite;

namespace OrderCom.Models
{
    [Table("instdat")]
    public class instdat
    {
        [Column("kn_redbrj")]
        public double kn_redbrj { get; set; }
        [Column("kn_sifmat")]
        public int kn_sifmat { get; set; }
        [Column("kn_kolmat")]
        public double kn_kolmat { get; set; }
        [Column("kn_cijmat")]
        public double kn_cijmat { get; set; }
        [Column("kn_sifpro")]
        public string kn_sifpro { get; set; }
        [Column("kn_brjcij")]
        public double kn_brjcij { get; set; }
        [Column("kn_tipmts ")]
        public double kn_tipmts { get; set; }
        [Column("kn_brjdok")]
        public string kn_brjdok { get; set; }
        [Column("kn_staslg")]
        public string kn_staslg { get; set; }
        [Column("kn_rabsta")]
        public double kn_rabsta { get; set; }
        [Column("kn_siflok")]
        public string kn_siflok { get; set; }
        [Column("kn_rabkup")]
        public double kn_rabkup { get; set; }

        [Ignore]
        // Property koji drzi naziv robe
        public string kn_nazrob { get; set; }
    }
}
