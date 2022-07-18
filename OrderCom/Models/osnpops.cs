using SQLite;

namespace OrderCom.Models
{
    [Table("dajosnp")]
    public class osnpops
    {
        [Column("ba_kupdob")]
        public int ba_kupdob { get; set; }

        [Column("nr_rabkup")]
        public string nr_rabkup { get; set; }
    }
}
