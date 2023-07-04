﻿using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    public partial class mainApp : Form
    {
        private int lastMove;
        private Thread session;
        public bool isAdmin { get; set; }
        private string connectS = string.Empty;
        private string _name;
        internal myDataContexData dataConnect;
        public myDataContexUsers userConnect;
        public List<TextBox> toZero = new List<TextBox>();
        public data usersData;
        public string username
        {
            get { return _name; }
            set
            {
                _name = value;
                labelUser.Text = value;
            }
        }
        public mainApp()
        {
            userConnect = new myDataContexUsers(@"server=DESKTOP-AI71G3Q;database=userData;integrated security=true");
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<myDataContexUsers, aplikacja_dla_ulicznych_przedsiębiorców.Migrations.Configuration>());
            enterApp login = new enterApp(this, userConnect);
            InitializeComponent();
            login.ShowDialog();
            connectS = @"server=DESKTOP-AI71G3Q;database=placeholder;integrated security=true".Replace("placeholder", (username + "Data"));
            toZero.Add(textNewLocalName);
            toZero.Add(textNewLocalPanishment);
            toZero.Add(textNewLocalStreet);
            toZero.Add(textNewLocalTribiute);
            toZero.Add(textNewLocalNr);
            dataConnect = new myDataContexData(connectS);
            lastMove = 120;
            session = new Thread(() => focusSession());
            new Thread(() => { inicjalizeCombo(); }).Start();
            session.Start();
        }
        private async Task inicjalizeCombo()
        {
            foreach (var item in userConnect.usersData)
            {
                usersList.Items.Add(item.name);
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             TODO 
            zamknąc połaczenie z bazą, pozapisywać wszystko
            wyzerować wszystkie zmienne a potem otworzyć ponownie okno logowania
             */
            session.Interrupt();
            foreach (var z in toZero)
            {
                z.Text = "";
            }
            messageToUser.Text = "";
            this.Hide();
            new enterApp(this, userConnect).ShowDialog();
            lastMove = 120;
            session = new Thread(() => focusSession());
            session.Start();

        }

        private void mainApp_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString().ToString();
        }



        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                new AddUser(userConnect).ShowDialog();
            }
        }
        internal async Task addToDataBase()
        {
            try
            {
                if (dataConnect.locals.Any(e => (e.name == textNewLocalName.Text && e.street == textNewLocalStreet.Text && e.number.ToString() == textNewLocalNr.Text)))
                {
                    MessageBox.Show("ten lokal aktualnie istnieje w bazie");
                    return;
                }
                dataConnect.locals.Add(new lokale
                {

                    name = textNewLocalName.Text,
                    street = textNewLocalStreet.Text,
                    number = textNewLocalNr.Text == "" ? null : Convert.ToInt32(textNewLocalNr.Text),
                    panishment = textNewLocalPanishment.Text == "" ? null : textNewLocalPanishment.Text,
                    tribiute = Convert.ToInt32(textNewLocalTribiute.Text)
                });

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (textNewLocalName.Text != null && textNewLocalStreet.Text != null && textNewLocalTribiute.Text != null)
            {
                new Thread(() => addToDataBase()).Start();
                textNewLocalName.Text = "";
                textNewLocalPanishment.Text = "";
                textNewLocalStreet.Text = "";
                textNewLocalTribiute.Text = "";
                textNewLocalNr.Text = "";
            }
            else
            {
                MessageBox.Show("uzupełnij dane nowego lokalu");
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            dataConnect.SaveChangesAsync();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            dataConnect.Dispose();
        }

        private async Task focusSession()
        {
            while (lastMove-- > 0)
            {
                logoutTimew.Text = lastMove.ToString();
                await Task.Delay(1000);
            }
            logoutToolStripMenuItem_Click(this, new EventArgs());

        }
        private void mainApp_MouseMove(object sender, MouseEventArgs e)
        {
            lastMove = 120;
        }

        private void mainApp_mouseMove(object sender, EventArgs e)
        {
            lastMove = 120;
        }

        private async Task sendMessageAcction()
        {
            MessageBox.Show((usersList.Text == usersList.Items[0].ToString()).ToString());
            var member = userConnect.usersData.Single(e => e.name ==  usersList.SelectedItem);
            MessageBox.Show("pogger");
            userConnect.messages.Add(new Message
            {
                sender = usersData,
                item = messageToUser.Text,
                recipient = member
            });
            userConnect.SaveChanges();
            MessageBox.Show("udało się");

        }
        private void sendMessage_Click(object sender, EventArgs e)
        {
            new Thread(() => { sendMessageAcction(); }).Start();
        }
    }
}
