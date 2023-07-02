using System.Data.Entity;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Xml.Serialization;

namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    public partial class enterApp : Form
    {
        private mainApp myMainApp;
        private bool passFocus;
        private string user { get; set; }
        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }



        public enterApp(mainApp apka)
        {
            InitializeComponent();
            textPass.KeyDown += new KeyEventHandler(keyCheck);
            myMainApp = apka;
        }
        public enterApp()
        {
            InitializeComponent();
            textPass.KeyDown += new KeyEventHandler(keyCheck);
        }
        public string coder(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2")); // formatowanie jako szesnastkowe
                }
                return stringBuilder.ToString();
            }
        }


        private void passwordCheck()//dajemy nazwe użytkownika do bazy a ona zwraca hasło i porównujemy to ze sobą, wiem że trzymanie raw hasła to idiotyzm ale coż, na razie to jest wersja pre pre
        {
            // nasza baza DESKTOP-AI71G3Q

            using (var connect = new myDataContex(@"server=DESKTOP-AI71G3Q;database=userData;integrated security=true"))
            {

                password = coder(password);
                if (!connect.usersData.Any(e => (e.name.Trim() == user && e.pass == password)))
                {
                    MessageBox.Show(user);//"chłopaki już jadą ;)"
                    Application.Exit();
                }
            }
            passFocus = true;
            myMainApp.Show();
            this.Close();

        }

        private void keyCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordCheck();
            }
        }
        public async Task pog()
        {
            while (true)
            {
                if (passFocus)
                {
                    return;
                }
                Random random = new Random();
                fakeBox.Text = new string('a', random.Next(0, 12));
                await Task.Delay(30);
            }
        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user = textUser.Text;
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            passFocus = false;
            fakeBox.Visible = true;
            textPass.Visible = false;
            new Thread(() => { pog(); }).Start();
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {
            password = textPass.Text;
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            textPass.Text = "";
            passFocus = true;
            fakeBox.Visible = false;
            textPass.Visible = true;
        }

        public class myDataContex : DbContext
        {
            public myDataContex(string connecionString) : base(connecionString)
            { }
            public myDataContex() { }
            public DbSet<data> usersData { get; set; }
        }
        public class data
        {
            public int ID { get; set; }
            public string name { get; set; }
            public string pass { get; set; }
        }

        private void enterApp_Deactivate(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}