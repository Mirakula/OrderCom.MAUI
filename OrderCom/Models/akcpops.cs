using SQLite;

namespace OrderCom.Models
{
    [Table("akcpops")]
    public class akcpops
    {
        [Column("ea_sifmat ")]
        public int ea_sifmat { get; set; }
        [Column("ba_kupdob")]
        public int ba_kupdob { get; set; }
        [Column("rv_sifpre")]
        public int rv_sifpre { get; set; }
        [Column("rv_primis")]
        public int rv_primis { get; set; }
        [Column("rv_datcij")]
        public string rv_datcij { get; set; }
        [Column("rv_datpre")]
        public string rv_datpre { get; set; }
        [Column("rv_rabsta")]
        public double rv_rabsta { get; set; }
    }
}
