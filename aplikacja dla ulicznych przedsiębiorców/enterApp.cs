using System.Data.Entity;
using System.Security.Cryptography;
using System.Text;

namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    public partial class enterApp : Form
    {
        private mainApp myMainApp;
        private bool passFocus;
        private string user { get; set; }
        private string _password;
        private bool validPass;
        private short badPassCounter = 0;
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


        private void passwordCheck()
        {
            using (var connect = new myDataContex(@"server=DESKTOP-AI71G3Q;database=userData;integrated security=true"))
            {
                password = coder(password);
                if (!connect.usersData.Any(e => (e.name.Trim() == user && e.pass == password)))
                {
                    if (badPassCounter++ < 5)
                    {
                        passwordInfo.Text = "błędne hasło proszimy o podaniie go jeszcze raz";
                        passwordInfo.Visible = true;
                    }
                    else
                    {
                        Application.Exit();
                    }
                    return;
                }
                
            }
            validPass = true;
            passFocus = true;
            myMainApp.Show();
            myMainApp.username = user;
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
            char[] signs = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '}', '{', '"', ':', '?', '>', '<', '|', '\\', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            while (true)
            {
                fakeBox.Text = "";
                if (passFocus)
                {
                    return;
                }
                Random random = new Random();
                for (int i = 0; i < random.Next(0, 60); i++)
                {
                    fakeBox.Text += signs[random.Next(0, 31)];
                }
                await Task.Delay(50);
            }
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
        internal class myDataContex : DbContext
        {
            public myDataContex(string connecionString) : base(connecionString)
            { }
            public myDataContex() { }
            public DbSet<data> usersData { get; set; }
        }
        internal class data
        {
            public int ID { get; set; }
            public string name { get; set; }
            public string pass { get; set; }
        }

        private void enterApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!validPass)
            {
                Application.Exit();
            }

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("proszę skontaktowac sie z administratorem :)");
        }

        private void passReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tak jak na ulicy, czasu nie cofniesz, powodzenia w zgadywaniu :)");
        }

        private void passwordInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
