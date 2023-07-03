using System.Data.Entity;
using System.Security.Cryptography;
using System.Text;

namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    public partial class enterApp : VirtualForm
    {
        private mainApp myMainApp;
        private bool validPass;
        private short badPassCounter = 0;

        public enterApp(mainApp apka)
        {
            InitializeComponent();
            myMainApp = apka;
            textPass.KeyDown += new KeyEventHandler(keyCheck);
            acceptButton.Text = "zaloguj";
            RejectButton.Text = "wyjdź";
        }
        public enterApp()
        {
            InitializeComponent();
        }

        private void passwordCheck()
        {
            using (var connect = new myDataContexUsers(@"server=DESKTOP-AI71G3Q;database=userData;integrated security=true"))
            {
                password = coder(password);
                
                if (!connect.usersData.Any(e => (e.name.Trim() == user && e.pass == password)))
                {
                    textPass.Text= "";
                    if (badPassCounter++ < 5)
                    {
                        passwordInfo.Text = "błędne hasło proszimy o podaniie go jeszcze raz, zostało {placeholder}".Replace("{placeholder}",(6-badPassCounter).ToString());
                        passwordInfo.Visible = true;
                        return;
                    }
                    else
                    {
                        Application.Exit();
                    }
                    return;
                }

                myMainApp.isAdmin = connect.usersData.Single(e => (e.name == user)).adminPass;
            }
            passFocus = true;
            validPass = true;
            myMainApp.Show();
            myMainApp.username = user;
            this.Close();
        }
        protected override void AcceptButton_Click(object sender, EventArgs e)
        {
            passwordCheck();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user = textUser.Text;
        }

        private void enterApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!validPass)
            {
                Application.Exit();
            }

        }
        protected void textPass_Leave(object sender, EventArgs e)
        {
            base.textPass_Leave(sender, e);
        }
        protected void textPass_Enter(object sender, EventArgs e)
        {
            base.textPass_Enter(sender, e);
        }

        override protected void RejectButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            base.RejectButton_Click(sender, e);
        }

        private void passReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tak jak na ulicy, czasu nie cofniesz, powodzenia w zgadywaniu :)");
        }
        override protected void makeAcction()
        {
            passwordCheck();
        }
    }
}
