using SQLite;

namespace IFashion.Models
{
    [Table("user")]
    public class user
    {
        [PrimaryKey, AutoIncrement, NotNull, Column("_id")]
        public int id { get; set; }

        [MaxLength(100), NotNull]
        public string email { get; set; }

        [MaxLength(50), NotNull]
        public string username { get; set; }

        [MaxLength(10), NotNull]
        public string gender { get; set; }

        [MaxLength(20), NotNull]
        public string password { get; set; }

    }
}
