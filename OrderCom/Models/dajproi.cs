using SQLite;

namespace OrderCom.Models
{
    [Table("dajproi")]
    public class dajproi
    {
        [Column("nv_brjtin")]
        public int nv_brjtin { get; set; }
        [Column("ab_matgrp")]
        public string ab_matgrp { get; set; }
        [Column("ea_imemat")]
        public string ea_imemat { get; set; }
        [Column("ea_sifean")]
        public string ea_sifean { get; set; }
        [Column("ea_jedmje")]
        public string ea_jedmje { get; set; }
        [Column("ea_rucvlp")]
        public double ea_rucvlp { get; set; }
        [Column("ea_rucmlp")]
        public double ea_rucmlp { get; set; }
    }
}
