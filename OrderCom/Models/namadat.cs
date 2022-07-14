using SQLite;

namespace OrderCom.Models
{
    [Table("namadat")]
    public class namadat
    {
        [PrimaryKey, Column("ea_sifmat")]
        public int ea_sifmat { get; set; }

        [Column("ea_imemat")]
        public string ea_imemat { get; set; }

        [Column("ea_imekrt")]
        public string ea_imekrt { get; set; }

        [Column("ea_jedmje")]
        public string ea_jedmje { get; set; }

        [Column("ba_kupdob")]
        public int ba_kupdob { get; set; }

        [Column("ea_kompak")]
        public double ea_kompak { get; set; }

        [Column("ea_potpak")]
        public double ea_potpak { get; set; }

        [Column("ea_tipmts")]
        public double ea_tipmts { get; set; }

        [Column("ea_sifean")]
        public string ea_sifean { get; set; }

        [Column("ea_sifpro")]
        public string ea_sifpro { get; set; }

        [Column("ea_brtari")]
        public string ea_brtari { get; set; }

        [Column("ea_pospor")]
        public double ea_pospor { get; set; }

        [Column("ea_odnkol")]
        public double ea_odnkol { get; set; }

        [Column("ea_osncij")]
        public double ea_osncij { get; set; }

        [Column("ea_rucvlp")]
        public double ea_rucvlp { get; set; }

        [Column("ea_rucmlp")]
        public double ea_rucmlp { get; set; }

        [Column("ab_matgrp")]
        public string ab_matgrp { get; set; }

        [Column("ea_staslg")]
        public string ea_staslg { get; set; }

        [Column("ea_usenam")]
        public string ea_usenam { get; set; }

        [Column("ea_datdok")]
        public DateTime ea_datdok { get; set; }

        [Column("ea_porusl")]
        public double ea_porusl { get; set; }
    }
}
