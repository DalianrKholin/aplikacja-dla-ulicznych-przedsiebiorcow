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
        public bool isAdmin { get; set; }
        private string connectS = string.Empty;
        private Thread acctive;
        private string _name;
        internal myDataContexData connect;
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
            enterApp login = new enterApp(this);

            InitializeComponent();
            login.ShowDialog();
            connectS = @"server=DESKTOP-AI71G3Q;database=placeholder;integrated security=true".Replace("placeholder", (username + "Data"));
            connect = new myDataContexData(connectS);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             TODO 
            zamknąc połaczenie z bazą, pozapisywać wszystko
            wyzerować wszystkie zmienne a potem otworzyć ponownie okno logowania
             */
            this.Hide();
            new enterApp(this).ShowDialog();
            connectS = @"server=DESKTOP-AI71G3Q;database=placeholder;integrated security=true".Replace("placeholder", (username + "Data"));
            connect = new myDataContexData(connectS);
        }

        private void date_Validated(object sender, EventArgs e)
        {

        }

        private void mainApp_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString().ToString();
        }



        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                MessageBox.Show("");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        internal async Task addToDataBase()
        {
            try
            {
                if (connect.locals.Any(e => (e.name == textNewLocalName.Text && e.street == textNewLocalStreet.Text && e.number.ToString() == textNewLocaNr.Text)))
                {
                    MessageBox.Show("ten lokal aktualnie istnieje w bazie");
                    return;
                }
                connect.locals.Add(new lokale
                {

                    name = textNewLocalName.Text,
                    street = textNewLocalStreet.Text,
                    number = textNewLocaNr.Text == "" ? null : Convert.ToInt32(textNewLocaNr.Text),
                    panishment = textNewLocalPanishment.Text == "" ? null : textNewLocalPanishment.Text,
                    tribiute = Convert.ToInt32(textNewLocalTribiute.Text)
                });
                connect.SaveChanges();

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
            }
            else
            {
                MessageBox.Show("uzupełnij dane nowego lokalu");
            }
        }
    }
}
