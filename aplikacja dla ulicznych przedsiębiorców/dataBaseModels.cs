using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace aplikacja_dla_ulicznych_przedsiębiorców
{

    public class myDataContexUsers : DbContext
    {
        public myDataContexUsers(string connecionString) : base(connecionString)
        { }
        public myDataContexUsers() : base(@"server=DESKTOP-AI71G3Q;database=userData;integrated security=true") 
        { }
        public DbSet<Bissnesman> persons { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Place> places { get; set; }
        public DbSet<ToDoTask> toDoTasks { get; set; }
        public DbSet<PlaceBissnesma> tasks { get; set; }
    }
    public class ToDoTask
    {
        public int ID { get; set; }
        public string toDo { get; set; }
        public DateTime date { get; set; }
        public Bissnesman execiutioner { get; set; }
    }
    public class Bissnesman
    {
        public int ID { get; set; }
        [MaxLength(20)]
        public string name { get; set; }
        [StringLength(64)]
        public string pass { get; set; }
        public bool adminPass { get; set; }
        public int messageCounter { get; set; }
        public List<PlaceBissnesma>? joiner { get; set; } = new List<PlaceBissnesma>();
        public List<Place>? places { get; set; } = new List<Place> { };
    }
    public class Message
    {
        public int ID { get; set; }
        [MaxLength(500)]
        public string item { get; set; }
        public DateTime date { get; set; }
        public Bissnesman sender { get; set; }
        public Bissnesman recipient { get; set; }

    }
    public class Place
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
        public List<Bissnesman> protectors { get; set; } = new List<Bissnesman>();
    }
    public class PlaceBissnesma
    {
        public int ID { get; set; }
        public int PlaceID { get; set; }
        public int BissnesmanID { get; set; }
        public Place place { get; set; }
        public Bissnesman bissnesman { get; set; }
    }
}
