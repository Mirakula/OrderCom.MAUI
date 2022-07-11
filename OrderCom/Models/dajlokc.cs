using SQLite;

namespace OrderCom.Models
{
    [Table("dajlokc")]
    public class dajlokc
    {
        [Column("ba_kupdob")]
        public int ba_kupdob { get; set; }
        [Column("da_imemis")]
        public string da_imemis { get; set; }
        [Column("da_adresa")]
        public string da_adresa { get; set; }
        [Column("da_mjemis")]
        public string da_mjemis { get; set; }
        [Column("da_tlfcen")]
        public string da_tlfcen { get; set; }
    }
}
