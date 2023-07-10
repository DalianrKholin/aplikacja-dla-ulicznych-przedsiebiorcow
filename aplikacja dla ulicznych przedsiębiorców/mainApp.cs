using System.Data.Entity;
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
using System.Diagnostics;
using System.Collections;
using Microsoft.VisualBasic;

namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    public partial class mainApp : Form
    {
        private int lastMove; //last mause move
        private Thread session; // thraed protecting time of use aplicatio
        private bool sessionStoper; // synchonizer for session thread
        public bool isAdmin { get; set; } // says that, can user add user
        private string _name;
        public myDataContexUsers userConnect; //connection to data Base
        public List<TextBox> toZero = new List<TextBox>(); // list of textbox that have to be cleared after logout
        public Businessman usersData; // self-descriptive
        private Queue<Message> qMessage = new Queue<Message>(); //new message taken from DB
        private List<TextBox> messagesTextBoxList = new List<TextBox>();// facilitating the handling of the messaging mechanism and resmoothing of code
        private List<Label> messagesLabelList = new List<Label>();//facilitating the handling of the messaging mechanism and resmoothing of code
        private List<string> helperList { get; set; } = new List<string>(); // list of user that will help us in new task
        public string username //user nick
        {
            get { return _name; }
            set
            {
                _name = value.ToLower();
                labelUser.Text = value;
            }
        }
        private int _mIncome;
        private int mIncome
        {
            get
            {
                return _mIncome;
            }
            set
            {
                monthlyIncome.Text = value.ToString();
                _mIncome = value;
            }
        }
        private int _dIncome;
        private int dIncome
        {
            get
            {
                return _dIncome;
            }
            set
            {
                dailyIncome.Text = value.ToString();
                _dIncome = value;
            }
        }
        public mainApp()
        {
            userConnect = new myDataContexUsers(@"server=DESKTOP-AI71G3Q;database=userData;integrated security=true;multipleactiveresultsets=true");// setting connection to dataBase
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<myDataContexUsers, aplikacja_dla_ulicznych_przedsiębiorców.Migrations.Configuration>());//migration of database mechanism
            if (!userConnect.persons.Any())
            {
                seeding();    
            }
            enterApp login = new enterApp(this, userConnect); //logging to mainApp window
            InitializeComponent();
            login.ShowDialog();
            //obrzydliwy kod alert
            toZero.Add(textNewLocalName);
            toZero.Add(textNewLocalPanishment);
            toZero.Add(textNewLocalStreet);
            toZero.Add(textNewLocalTribiute);
            toZero.Add(textNewLocalNr);
            messagesLabelList.Add(user1);
            messagesLabelList.Add(user2);
            messagesLabelList.Add(user3);
            messagesLabelList.Add(user4);
            messagesLabelList.Add(user5);
            messagesTextBoxList.Add(mess1);
            messagesTextBoxList.Add(mess2);
            messagesTextBoxList.Add(mess3);
            messagesTextBoxList.Add(mess4);
            messagesTextBoxList.Add(mess5);
            lastMove = 120;
            usersData = userConnect.persons.Single(e => e.name == username);
            session = new Thread(() => focusSession());
            new Thread(() => { reinicjacjaDanychIWiadomosci(); }).Start();
            session.Start();
            for (int i = 1; i < 32; i++)
            {
                if (i <= 12)
                {
                    incidenthMonth.Items.Add(i.ToString());
                }
                incidentDay.Items.Add(i.ToString());
            }
            string[] nazwy = { "zwykłe", "ciekawe", "legendarne", "międzygwiezdne", "międzygalaktyczne", "o podbój wszechświata" };
            try
            {
                foreach (var item in nazwy)
                {
                    weightOfAction.Items.Add(item);
                    treeToDo.Nodes.Add(item);
                }
                foreach (var item in userConnect.toDoTasks //eking of TaskToDO treeView 
                    .Where(e => e.date.Month == DateTime.Now.Month && e.date.Day == DateTime.Now.Day)
                    .Where(p => p.executioners
                    .Any(a => a.ID == usersData.ID) ||
                    p.headOfAcction.ID == usersData.ID))
                {
                    dIncome += item.income == null ? 0 : (int)(item.income);
                    treeToDo.Nodes[item.weightOfTask].Nodes.Add(item.toDo);
                    
                    
                }
            }
            catch (Exception e)
            {
                treeToDo.Nodes.Add("coś poszło nie tak :(");
            }
        }
        private void seeding()
        {
    userConnect.persons.Add(new Businessman
{
    name = "dalinarKholin",
    pass = "2309acb4a88359a4ba3c164006ca607da331dec15468f9f2645bb21436b44d90",
    adminPass = true,
    messageCounter = 0
});
            userConnect.SaveChanges();
var persona = userConnect.persons.Single(e => e.name == "dalinarKholin");
int personId = persona.ID;
            userConnect.messages.Add(new Message
{
    item = "fajnie co nie? ",
    date = DateTime.Now,
    sender = persona,
    recipient = persona
});
            userConnect.places.Add(new Place
{
    name = "nwm",
    street = "lozl",
    number = 1,
    tribiute = 1,
    protectors = new List<Businessman>() { persona }
});
            userConnect.SaveChanges();


return;

        }
        private async Task reinicjacjaDanychIWiadomosci()
        {
            int[] indexTab = new int[2] { usersList.SelectedIndex, listPlaces.SelectedIndex };

            listPlaces.Items.Clear();
            usersList.Items.Clear();

            helpers.Items.Clear();
            foreach (var item in userConnect.persons)
            {
                if (item.name.ToLower() != username) // user cant send message to himself and help himself into tasks
                {
                    usersList.Items.Add(item.name);
                    helpers.Items.Add(item.name);
                }
            }
            usersList.SelectedIndex = indexTab[0];
            foreach (var x in helperList)
            {
                helpers.Items[helpers.FindItemWithText(x.Replace("\u2714", "")).Index].Text = x;
            }

            listPlaces.SelectedIndex = indexTab[1];

            if (userConnect.messages.Any((e => e.recipient.name == usersData.name && e.ID > usersData.messageCounter)))
            {
                foreach (var item in userConnect.messages.Where(e => e.recipient.name == usersData.name && e.ID > usersData.messageCounter).OrderBy(e => -e.ID))
                {
                    qMessage.Enqueue(item);
                }
                usersData.messageCounter = qMessage.Peek().ID;
                userConnect.SaveChanges();
            }

            messageTaken.Text = "new messages = " + qMessage.Count.ToString();
            if (qMessage.Count != 0 || messagesLabelList[0].Text == "label13") //if there is no new message, we leave old alone 
            {
                for (int i = 0; i < 5; i++)
                {
                    if (qMessage.Count == 0)
                    {
                        messagesTextBoxList[i].Visible = false;
                        messagesLabelList[i].Visible = false;
                        continue;
                    }
                    messagesTextBoxList[i].Visible = true;
                    messagesLabelList[i].Visible = true;
                    Message message = qMessage.Dequeue();
                    messagesLabelList[i].Text = ("user: " + message.sender.name.ToString()).PadRight(30) + message.date;
                    messagesTextBoxList[i].Text = message.item;
                }
            }
            mIncome = 0;
            foreach (var item in userConnect.places.
                Where(e => e.protectors
                    .Any(p => p.ID == usersData.ID)))
            {
                listPlaces.Items.Add(item);
                mIncome += item.tribiute;
            }


        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sessionStoper = true;
            foreach (var z in toZero)
            {
                z.Text = "";
            }
            messageToUser.Text = "";
            refreshMessages.Stop();
            this.Hide();
            new enterApp(this, userConnect).ShowDialog();
            treeToDo.Visible = false;
            lastMove = 120;
            sessionStoper = false;
            session = new Thread(() => focusSession());
            new Thread(() => { reinicjacjaDanychIWiadomosci(); }).Start();
            session.Start();
            refreshMessages.Start();

        }

        private void mainApp_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString().ToString();
        }



        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                sessionStoper = true;
                refreshMessages.Stop();
                new AddUser(userConnect).ShowDialog();
                lastMove = 120;

                sessionStoper = false;
                new Thread(() => { reinicjacjaDanychIWiadomosci(); }).Start();
                session = new Thread(() => focusSession());
                session.Start();
                refreshMessages.Start();
            }
        }
        internal async Task addToDataBase()
        {
            try
            {

                if (userConnect.places.Any(e => (e.name == textNewLocalName.Text && e.street == textNewLocalStreet.Text && e.number.ToString() == textNewLocalNr.Text)))
                {//local exist in data base
                    if (userConnect.places.Any(e => (e.name == textNewLocalName.Text && e.street == textNewLocalStreet.Text && e.number.ToString() == textNewLocalNr.Text && (e.protectors.Any(u => e.ID == usersData.ID)))))
                    {//user already owned this local
                        MessageBox.Show("ten lokal aktualnie istnieje w bazie");
                        return;
                    }
                    else
                    {//if local exist we just add user to list of protectors
                        var place = userConnect.places.Single(e => (e.name == textNewLocalName.Text && e.street == textNewLocalStreet.Text && e.number.ToString() == textNewLocalNr.Text));
                        place.protectors.Add(usersData);
                    }
                }
                else
                {//if local didnt exist we add it to database 
                    Place place = new Place
                    {
                        protectors = new List<Businessman>(),
                        name = textNewLocalName.Text,
                        street = textNewLocalStreet.Text,
                        number = textNewLocalNr.Text == "" ? null : Convert.ToInt32(textNewLocalNr.Text),
                        panishment = textNewLocalPanishment.Text == "" ? "" : textNewLocalPanishment.Text,
                        tribiute = Convert.ToInt32(textNewLocalTribiute.Text)
                    };
                    place.protectors.Add(usersData);
                    userConnect.places.Add(place);


                }
                await userConnect.SaveChangesAsync();
                textNewLocalName.Text = "";
                textNewLocalPanishment.Text = "";
                textNewLocalStreet.Text = "";
                textNewLocalTribiute.Text = "";
                textNewLocalNr.Text = "";
                newLokal.Text += " - udało się zapisać zmiany"; // cleaning after message
            }
            catch (Exception e)
            {
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (textNewLocalName.Text != null && textNewLocalStreet.Text != null && textNewLocalTribiute.Text != null) // if any of it is not set database will blow up
            {
                new Thread(() => addToDataBase()).Start();
            }
            else
            {
                MessageBox.Show("uzupełnij dane nowego lokalu");
            }
        }

        private async Task save()
        {

            await userConnect.SaveChangesAsync();
            newLokal.Text = newLokal.Text.Replace(" - sa zmiany do zapisu", " - udało się dodać użytkownika");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new Thread(() => { save(); }).Start();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            userConnect.Dispose();
        }

        private async Task focusSession()
        {
            while (lastMove-- > 0) //every one second it decreasing number of second to logout, and when it hit 0 logout user
            {
                if (sessionStoper) return;
                logoutTimew.Text = lastMove.ToString();
                await Task.Delay(1000);
            }
            logoutToolStripMenuItem_Click(this, new EventArgs());

        }
        private void mainApp_MouseMove(object sender, MouseEventArgs e)
        {
            lastMove = 120;//set time to auttomatic logout to 2 min
        }

        private void mainApp_mouseMove(object sender, EventArgs e)
        {
            lastMove = 120;//set time to auttomatic logout to 2 min
        }

        private async Task sendMessageAcction()
        {
            statusMessage.Text = "wysyłanie wiadomości...";
            if (usersList.SelectedIndex == -1)
            {
                int index = usersList.Items.IndexOf(usersList.Text);
                if (index == -1)
                {
                    statusMessage.Text = "nieporawny użytkownik";
                    return;
                }
                usersList.SelectedItem = index;
            }
            var member = userConnect.persons.Single(e => e.name == usersList.SelectedItem);
            userConnect.messages.Add(new Message
            {
                sender = usersData,
                item = messageToUser.Text,
                recipient = member,
                date = DateTime.Now
            });

            await userConnect.SaveChangesAsync();
            messageToUser.Text = "";
            statusMessage.Text = "udało się wysłać wiadomość";
        }
        private void sendMessage_Click(object sender, EventArgs e)
        {
            new Thread(() => { sendMessageAcction(); }).Start();

        }
        private void refreshMessages_Tick(object sender, EventArgs e)
        {
            new Thread(() => { reinicjacjaDanychIWiadomosci(); }).Start();
        }

        private void messageToUser_Enter(object sender, EventArgs e)
        {
            statusMessage.Text = "pisanie...";
        }

        private void messageToUser_Leave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }


        private void helpers_ItemActivate(object sender, EventArgs e)
        {
            int index = helpers.SelectedItems[0].Index;
            var x = helpers.Items[helpers.SelectedItems[0].Index];
            string y = x.Text; //c# pointers mechanism suck :(
            if (helperList.Any(e => e == x.Text))
            {
                helpers.Items[index].Text = helpers.Items[index].Text.Replace("\u2714", "");
                helperList.Remove(y);
            }
            else
            {
                helperList.Add(x.Text + "\u2714");
                helpers.Items[index].Text += "\u2714";
            }
            helpers.Refresh();
        }
        private async Task addActionTask()
        {
            try
            {
                actionStatus.Text = "wysyłanie";
                List<Businessman> tsotsi = new List<Businessman>();
                foreach (var items in helperList)
                {
                    tsotsi.Add(userConnect.persons.Single(e => e.name == items.Replace("\u2714", ""))); // why we replace "\u2714", its checkmark utf char that we add if user is chcecked
                }
                string myPlace = ((Place)listPlaces.Items[listPlaces.SelectedIndex]).name;
                ToDoTask newTask = new ToDoTask()
                {
                    toDo = whatToDo.Text,
                    weightOfTask = weightOfAction.SelectedIndex,
                    income = incidentIncome.Text == "" ? null : Convert.ToInt32(incidentIncome.Text),
                    date = new DateTime(2023, Convert.ToInt32(incidenthMonth.Text), Convert.ToInt32(incidentDay.Text)),
                    headOfAcction = usersData,
                    unluckyIncidentSite = userConnect.places.Single(e => e.name == myPlace),//(Place)listPlaces.Items[listPlaces.SelectedIndex],
                    executioners = tsotsi.Count == 0 ? null : tsotsi
                };
                userConnect.toDoTasks.Add(newTask);
                await userConnect.SaveChangesAsync();
                incidentDay.SelectedIndex = -1;
                incidenthMonth.SelectedIndex = -1;
                listPlaces.SelectedIndex = -1;
                weightOfAction.SelectedIndex = -1;
                whatToDo.Text = "";
                incidentIncome.Text = "";
                actionStatus.Text = "udało się ustawić zadanie";

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void addAction_Click(object sender, EventArgs e)
        {
            if (incidenthMonth.SelectedIndex == -1 || incidentDay.SelectedIndex == -1 || listPlaces.SelectedIndex == -1 || whatToDo.Text == string.Empty || weightOfAction.SelectedIndex == -1)
            {
                actionStatus.Text = "proszę uzupełnić dane ok?";
            }
            else
            {
                new Thread(() => { addActionTask(); }).Start();
            }
        }
    }
}
