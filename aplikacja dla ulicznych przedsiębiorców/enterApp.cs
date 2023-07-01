using System.Security.Permissions;
using System.Xml.Serialization;

namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    public partial class enterApp : Form
    {
        private mainApp myMainApp;
        private bool passFocus;
        private string user;
        private string _password;

        public enterApp(mainApp apka)
        {
            InitializeComponent();
            textPass.KeyDown += new KeyEventHandler(keyCheck);
            myMainApp = apka;
        }

        private string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private void checkerPass(object sender)
        {
            if (sender != textPass)
            {
                MessageBox.Show("chłopaki już jadą :))");
                this.Close();
            }

        }
        public enterApp()
        {
            InitializeComponent();
            textPass.KeyDown += new KeyEventHandler(keyCheck);
        }
        private void passwordCheck()
        {
            if (password != "chuj")
            {
                MessageBox.Show("chłopaki już jadą ;)");
                Application.Exit();
            }
            else
            {
                passFocus = true;
                myMainApp.Show();
                this.Close();
            }
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

        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            fakeBox.Visible = true;
            textPass.Visible = false;
            new Thread(() => { pog(); }).Start();
            fakeBox.Text = "chuj  oaiusdhf po;ajshdf";
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {
            password = textPass.Text;
        }

        private void textPass_Leave(object sender, EventArgs e)
        {

        }
    }
}