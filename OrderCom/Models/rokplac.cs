using SQLite;

namespace OrderCom.Models
{
    [Table("rokplac")]
    public class rokplac
    {
        [Column("nv_brjtin")]
        public int nv_brjtin { get; set; }
        [Column("ba_kupdob")]
        public int ba_kupdob { get; set; }
        [Column("nr_rabkup")]
        public double nr_rabkup { get; set; }
        [Column("nr_rokpla")]
        public int nr_rokpla { get; set; }
    }
}
