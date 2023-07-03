using System.Text;

using System.Security.Cryptography;
using Microsoft.VisualBasic.ApplicationServices;

namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    public partial class VirtualForm : Form
    {
        protected string user { get; set; }
        protected string _password;
        protected string password
        {
            get { return _password; }
            set { _password = value; }
        }
        protected bool passFocus;
        protected string coder(string input)
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
        public VirtualForm()
        {
            this.InitializeComponent();
        }

        virtual protected void AcceptButton_Click(object sender, EventArgs e)
        {

        }
        virtual protected void makeAcction()
        {
        }
        virtual protected void RejectButton_Click(object sender, EventArgs e)
        {

        }
        protected void keyCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                makeAcction();
            }
        }
        protected async Task passHider()
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
        protected void textPass_Leave(object sender, EventArgs e)
        {
            textPass.Text = "";
            passFocus = true;
            fakeBox.Visible = false;
            textPass.Visible = true;
        }
        protected void textPass_Enter(object sender, EventArgs e)
        {
            passFocus = false;
            fakeBox.Visible = true;
            textPass.Visible = false;
            new Thread(() => { passHider(); }).Start();
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            user = textUser.Text;
        }
        private void textPass_TextChanged(object sender, EventArgs e)
        {
            password = textPass.Text;
        }
    }
}
