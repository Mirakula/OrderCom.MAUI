using SQLite;

namespace OrderCom.Models
{
    [Table("dajtipn")]
    public class dajtipn
    {
        [Column("nv_brjtin")]
        public int nv_brjtin { get; set; }
        [Column("nv_imetin")]
        public string nv_imetin { get; set; }
    }
}
