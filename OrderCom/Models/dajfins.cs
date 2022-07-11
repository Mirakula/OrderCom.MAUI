using SQLite;

namespace OrderCom.Models
{
    [Table("ba_kupdob")]
    public class dajfins
    {
        [Column("ba_kupdob")]
        public int ba_kupdob { get; set; }
        [Column("ps_ukudug")]
        public double ps_ukudug { get; set; }
        [Column("ps_stadug")]
        public double ps_stadug { get; set; }
        [Column("ps_dandug")]
        public int ps_dandug { get; set; }
        [Column("ps_vriizf")]
        public double ps_vriizf { get; set; }
    }
}
