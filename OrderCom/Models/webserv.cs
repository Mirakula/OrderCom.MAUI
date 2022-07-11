using SQLite;

namespace OrderCom.Models
{
    [Table("webserv")]
    public class webserv
    {
        [Column("we_ipadre")]
        public string we_ipadre { get; set; }
    }
}
