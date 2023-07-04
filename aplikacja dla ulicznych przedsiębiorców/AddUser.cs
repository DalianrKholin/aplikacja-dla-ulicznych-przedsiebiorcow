﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    public partial class AddUser : VirtualForm
    {

        private async Task addUserAcction()
        {
            try
            {
                var hasz = coder(password);
                passwordInfo.Visible = true;
                if (userConnection.usersData.Any(e => e.name == user))
                {
                    passwordInfo.Text = "w bazie wystepuje użytkownik o takiej nazwie, proszę o wybranie innej";
                    return;
                }
                userConnection.usersData.Add(new data
                {
                    name = user,
                    pass = hasz,
                    adminPass = adminButton.Checked
                });
                userConnection.SaveChanges();
                var id = userConnection.usersData.Single(e => e.name == user);
                userConnection.messages.Add(new Message
                {
                    item = "hello new user welcome on our application for street bisnesman",
                    recipient = id,
                    sender = id
                });
                id.messageCounter =0;
                userConnection.SaveChanges();
                passwordInfo.Text = "udało się dodać uzytkownika";
            }
            catch(Exception e) {
                MessageBox.Show(e.ToString()); 
            }

        }

        public AddUser(myDataContexUsers call)
        {
            InitializeComponent();
            acceptButton.Text = "dodaj użytkownika";
            rejectButton.Text = "anuluj akcje";
            userConnection = call;
        }


        protected override void RejectButton_Click(object sender, EventArgs e)
        {
            this.Close();
            base.RejectButton_Click(sender, e);
        }
        protected override void makeAcction()
        {
            new Thread(() => addUserAcction()).Start();
            base.makeAcction();
        }
        protected override void AcceptButton_Click(object sender, EventArgs e)
        {
            makeAcction();
            base.AcceptButton_Click(sender, e);
        }
    }
}
