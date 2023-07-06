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

        public enterApp(mainApp apka, myDataContexUsers call)
        {
            InitializeComponent();
            myMainApp = apka;
            userConnection = call;
            acceptButton.Text = "zaloguj";
            rejectButton.Text = "wyjdź";
        }
        public enterApp()
        {
            InitializeComponent();
        }

        private void passwordCheck()
        {

                password = coder(password);
                if (!userConnection.persons.Any(e => (e.name.Trim() == user && e.pass == password)))
                {
                    textPass.Text = "";
                    if (badPassCounter++ < 5)
                    {
                        passwordInfo.Text = "błędne hasło proszimy o podaniie go jeszcze raz, zostało {placeholder}".Replace("{placeholder}", (6 - badPassCounter).ToString());
                        passwordInfo.Visible = true;
                        return;
                    }
                    else
                    {
                        Application.Exit();
                    }
                    return;
                }
                myMainApp.usersData = userConnection.persons.Single(e => (e.name == user));
                myMainApp.isAdmin = myMainApp.usersData.adminPass;
            
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

        private void enterApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!validPass)
            {
                Application.Exit();
            }
        }
        override protected void RejectButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            base.RejectButton_Click(sender, e);
        }
        override protected void makeAcction()
        {
            passwordCheck();
        }
    }
}
