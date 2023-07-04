using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    


    public class myDataContexData : DbContext
    {
        public myDataContexData(string connecionString) : base(connecionString)
        { }
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

    public class Message
    {
        public int ID { get; set; }
        [MaxLength(500)]
        public string item { get; set; }
        public data sender { get; set; }
        public data recipient { get; set; }
       
    }
    public class myDataContexUsers : DbContext
    {
        public myDataContexUsers(string connecionString) : base(connecionString)
        { }
        public myDataContexUsers() : base(@"server=DESKTOP-AI71G3Q;database=userData;integrated security=true") 
        { }
        public DbSet<data> usersData { get; set; }
        public DbSet<Message> messages { get; set; }
    }
    public class data
    {
        public int ID { get; set; }
        [MaxLength(20)]
        public string name { get; set; }
        [StringLength(64)]
        public string pass { get; set; }
        public bool adminPass { get; set; }
        public Message Message { get; set; }
        virtual public ICollection<Message> mess { get; set; }
    }
}
