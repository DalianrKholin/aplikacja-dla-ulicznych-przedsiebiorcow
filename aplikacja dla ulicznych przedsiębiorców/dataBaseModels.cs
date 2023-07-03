using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    public class myDataContexData : DbContext
    {
        public myDataContexData(string connecionString) : base(connecionString)
        { }
        public myDataContexData() { }
        public DbSet<lokale> locals { get; set; }

    }

    public class lokale
    {
        public int ID { get; set; }
        [MaxLength(20)]
        public string name { get; set; }
        [MaxLength(20)]
        public string street { get; set; }
        public int? number { get; set; }
        [Range(0, 10000)]
        public int tribiute { get; set; }
        [MaxLength(100)]
        public string? panishment { get; set; }
    }
    public class myDataContexUsers : DbContext
    {
        public myDataContexUsers(string connecionString) : base(connecionString)
        { }
        public myDataContexUsers() { }
        public DbSet<data> usersData { get; set; }
    }
    public class data
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public bool adminPass { get; set; }
    }
}
