using SQLite;

namespace OrderCom.Models
{
    [Table("dajgrpp")]
    public class dajgrpp
    {
        [Column("tg_matgrp")]
        public string tg_matgrp { get; set; }
        [Column("tg_imegrp")]
        public string tg_imegrp { get; set; }
        [Column("tg_brjtip")]
        public int tg_brjtip { get; set; }
    }
}
