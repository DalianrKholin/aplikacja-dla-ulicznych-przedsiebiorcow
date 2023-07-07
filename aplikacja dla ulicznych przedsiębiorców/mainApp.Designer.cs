namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    partial class mainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelUser = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            buttonToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            userThingsToolStripMenuItem = new ToolStripMenuItem();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            date = new Label();
            newLokal = new GroupBox();
            button3 = new Button();
            acceptButton = new Button();
            rejectButton = new Button();
            textNewLocalStreet = new TextBox();
            textNewLocalNr = new TextBox();
            textNewLocalTribiute = new TextBox();
            textNewLocalPanishment = new TextBox();
            textNewLocalName = new TextBox();
            newLocalPanishment = new Label();
            newLocalTribute = new Label();
            newLocalAdressNumber = new Label();
            newLocalStreet = new Label();
            newLocalName = new Label();
            groupBox1 = new GroupBox();
            actionStatus = new Label();
            incidenthMonth = new ComboBox();
            label15 = new Label();
            incidentDay = new ComboBox();
            listPlaces = new ComboBox();
            label14 = new Label();
            weightOfAction = new ComboBox();
            addAction = new Button();
            label13 = new Label();
            incidentIncome = new TextBox();
            helpers = new ListView();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            whatToDo = new TextBox();
            groupBox2 = new GroupBox();
            statusMessage = new Label();
            label8 = new Label();
            sendMessage = new Button();
            label6 = new Label();
            label4 = new Label();
            usersList = new ComboBox();
            messageToUser = new RichTextBox();
            businessmanBindingSource = new BindingSource(components);
            messageTaken = new GroupBox();
            user1 = new Label();
            mess1 = new TextBox();
            user5 = new Label();
            user4 = new Label();
            user3 = new Label();
            user2 = new Label();
            mess5 = new TextBox();
            mess4 = new TextBox();
            mess3 = new TextBox();
            mess2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            logoutTimew = new Label();
            label5 = new Label();
            monthlyIncome = new Label();
            label7 = new Label();
            mes1 = new Label();
            refreshMessages = new System.Windows.Forms.Timer(components);
            treeToDo = new TreeView();
            label16 = new Label();
            label17 = new Label();
            dailyIncome = new Label();
            menuStrip1.SuspendLayout();
            newLokal.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)businessmanBindingSource).BeginInit();
            messageTaken.SuspendLayout();
            SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(99, 24);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(81, 15);
            labelUser.TabIndex = 0;
            labelUser.Text = "Velcome dear ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Velcome dear ";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { buttonToolStripMenuItem, userThingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1299, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // buttonToolStripMenuItem
            // 
            buttonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, logoutToolStripMenuItem });
            buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
            buttonToolStripMenuItem.Size = new Size(131, 20);
            buttonToolStripMenuItem.Text = "session management";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(163, 22);
            toolStripMenuItem1.Text = "close application";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(163, 22);
            logoutToolStripMenuItem.Text = "logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // userThingsToolStripMenuItem
            // 
            userThingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewUserToolStripMenuItem });
            userThingsToolStripMenuItem.Name = "userThingsToolStripMenuItem";
            userThingsToolStripMenuItem.Size = new Size(76, 20);
            userThingsToolStripMenuItem.Text = "userThings";
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(141, 22);
            addNewUserToolStripMenuItem.Text = "addNewUser";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 24);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "todays date is";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(271, 24);
            date.Name = "date";
            date.Size = new Size(30, 15);
            date.TabIndex = 5;
            date.Text = "data";
            // 
            // newLokal
            // 
            newLokal.Controls.Add(button3);
            newLokal.Controls.Add(acceptButton);
            newLokal.Controls.Add(rejectButton);
            newLokal.Controls.Add(textNewLocalStreet);
            newLokal.Controls.Add(textNewLocalNr);
            newLokal.Controls.Add(textNewLocalTribiute);
            newLokal.Controls.Add(textNewLocalPanishment);
            newLokal.Controls.Add(textNewLocalName);
            newLokal.Controls.Add(newLocalPanishment);
            newLokal.Controls.Add(newLocalTribute);
            newLokal.Controls.Add(newLocalAdressNumber);
            newLokal.Controls.Add(newLocalStreet);
            newLokal.Controls.Add(newLocalName);
            newLokal.Location = new Point(12, 50);
            newLokal.Name = "newLokal";
            newLokal.Size = new Size(469, 302);
            newLokal.TabIndex = 6;
            newLokal.TabStop = false;
            newLokal.Text = "dodaj nowy lokal przedsiębiorco";
            // 
            // button3
            // 
            button3.Location = new Point(6, 244);
            button3.Name = "button3";
            button3.Size = new Size(109, 50);
            button3.TabIndex = 7;
            button3.Text = "wczytaj zmiany do bazy danych";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(174, 244);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(109, 50);
            acceptButton.TabIndex = 14;
            acceptButton.Text = "zaakceptuj zmiany";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // rejectButton
            // 
            rejectButton.Location = new Point(343, 244);
            rejectButton.Name = "rejectButton";
            rejectButton.Size = new Size(109, 50);
            rejectButton.TabIndex = 13;
            rejectButton.Text = "porzuć zmiany";
            rejectButton.UseVisualStyleBackColor = true;
            rejectButton.Click += rejectButton_Click;
            // 
            // textNewLocalStreet
            // 
            textNewLocalStreet.Location = new Point(100, 70);
            textNewLocalStreet.Name = "textNewLocalStreet";
            textNewLocalStreet.Size = new Size(352, 23);
            textNewLocalStreet.TabIndex = 9;
            // 
            // textNewLocalNr
            // 
            textNewLocalNr.Location = new Point(100, 123);
            textNewLocalNr.Name = "textNewLocalNr";
            textNewLocalNr.Size = new Size(352, 23);
            textNewLocalNr.TabIndex = 8;
            // 
            // textNewLocalTribiute
            // 
            textNewLocalTribiute.Location = new Point(100, 170);
            textNewLocalTribiute.Name = "textNewLocalTribiute";
            textNewLocalTribiute.Size = new Size(352, 23);
            textNewLocalTribiute.TabIndex = 7;
            // 
            // textNewLocalPanishment
            // 
            textNewLocalPanishment.Location = new Point(100, 215);
            textNewLocalPanishment.Name = "textNewLocalPanishment";
            textNewLocalPanishment.Size = new Size(352, 23);
            textNewLocalPanishment.TabIndex = 6;
            // 
            // textNewLocalName
            // 
            textNewLocalName.Location = new Point(100, 24);
            textNewLocalName.Name = "textNewLocalName";
            textNewLocalName.Size = new Size(352, 23);
            textNewLocalName.TabIndex = 5;
            // 
            // newLocalPanishment
            // 
            newLocalPanishment.AutoSize = true;
            newLocalPanishment.Location = new Point(6, 218);
            newLocalPanishment.Name = "newLocalPanishment";
            newLocalPanishment.Size = new Size(29, 15);
            newLocalPanishment.TabIndex = 4;
            newLocalPanishment.Text = "kara";
            // 
            // newLocalTribute
            // 
            newLocalTribute.AutoSize = true;
            newLocalTribute.Location = new Point(6, 173);
            newLocalTribute.Name = "newLocalTribute";
            newLocalTribute.Size = new Size(41, 15);
            newLocalTribute.TabIndex = 3;
            newLocalTribute.Text = "czynsz";
            // 
            // newLocalAdressNumber
            // 
            newLocalAdressNumber.AutoSize = true;
            newLocalAdressNumber.Location = new Point(6, 126);
            newLocalAdressNumber.Name = "newLocalAdressNumber";
            newLocalAdressNumber.Size = new Size(79, 15);
            newLocalAdressNumber.TabIndex = 2;
            newLocalAdressNumber.Text = "nr Mieszkania";
            // 
            // newLocalStreet
            // 
            newLocalStreet.AutoSize = true;
            newLocalStreet.Location = new Point(6, 70);
            newLocalStreet.Name = "newLocalStreet";
            newLocalStreet.Size = new Size(33, 15);
            newLocalStreet.TabIndex = 1;
            newLocalStreet.Text = "Ulica";
            // 
            // newLocalName
            // 
            newLocalName.AutoSize = true;
            newLocalName.Location = new Point(6, 27);
            newLocalName.Name = "newLocalName";
            newLocalName.Size = new Size(75, 15);
            newLocalName.TabIndex = 0;
            newLocalName.Text = "nazwa lokalu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(actionStatus);
            groupBox1.Controls.Add(incidenthMonth);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(incidentDay);
            groupBox1.Controls.Add(listPlaces);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(weightOfAction);
            groupBox1.Controls.Add(addAction);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(incidentIncome);
            groupBox1.Controls.Add(helpers);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(whatToDo);
            groupBox1.Location = new Point(487, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 302);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "zaplanuj akcję";
            // 
            // actionStatus
            // 
            actionStatus.AutoSize = true;
            actionStatus.Location = new Point(98, 274);
            actionStatus.Name = "actionStatus";
            actionStatus.Size = new Size(0, 15);
            actionStatus.TabIndex = 18;
            // 
            // incidenthMonth
            // 
            incidenthMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            incidenthMonth.FormattingEnabled = true;
            incidenthMonth.Location = new Point(174, 24);
            incidenthMonth.Name = "incidenthMonth";
            incidenthMonth.Size = new Size(103, 23);
            incidenthMonth.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(121, 27);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 16;
            label15.Text = "miesiac";
            // 
            // incidentDay
            // 
            incidentDay.DropDownStyle = ComboBoxStyle.DropDownList;
            incidentDay.FormattingEnabled = true;
            incidentDay.Location = new Point(48, 24);
            incidentDay.Name = "incidentDay";
            incidentDay.Size = new Size(67, 23);
            incidentDay.TabIndex = 15;
            // 
            // listPlaces
            // 
            listPlaces.DisplayMember = "name";
            listPlaces.DropDownStyle = ComboBoxStyle.DropDownList;
            listPlaces.FormattingEnabled = true;
            listPlaces.Location = new Point(47, 58);
            listPlaces.Name = "listPlaces";
            listPlaces.Size = new Size(533, 23);
            listPlaces.TabIndex = 14;
            listPlaces.ValueMember = "name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(267, 275);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 13;
            label14.Text = "waga akcji";
            // 
            // weightOfAction
            // 
            weightOfAction.DropDownStyle = ComboBoxStyle.DropDownList;
            weightOfAction.Location = new Point(335, 271);
            weightOfAction.Name = "weightOfAction";
            weightOfAction.Size = new Size(246, 23);
            weightOfAction.TabIndex = 12;
            weightOfAction.Tag = "";
            // 
            // addAction
            // 
            addAction.Location = new Point(6, 271);
            addAction.Name = "addAction";
            addAction.Size = new Size(86, 23);
            addAction.TabIndex = 11;
            addAction.Text = "dodaj Akcje";
            addAction.UseVisualStyleBackColor = true;
            addAction.Click += addAction_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 62);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 10;
            label13.Text = "lokal";
            // 
            // incidentIncome
            // 
            incidentIncome.Location = new Point(473, 22);
            incidentIncome.Name = "incidentIncome";
            incidentIncome.Size = new Size(108, 23);
            incidentIncome.TabIndex = 9;
            // 
            // helpers
            // 
            helpers.Location = new Point(6, 136);
            helpers.Name = "helpers";
            helpers.Size = new Size(575, 123);
            helpers.TabIndex = 8;
            helpers.UseCompatibleStateImageBehavior = false;
            helpers.View = View.SmallIcon;
            helpers.ItemActivate += helpers_ItemActivate;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 118);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 7;
            label12.Text = "pomocnicy";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 90);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 5;
            label11.Text = "Akcja";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(283, 27);
            label10.Name = "label10";
            label10.Size = new Size(184, 15);
            label10.TabIndex = 4;
            label10.Text = "planowany przychód(opcjonalne)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 27);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 3;
            label9.Text = "dzień";
            // 
            // whatToDo
            // 
            whatToDo.Location = new Point(47, 87);
            whatToDo.Name = "whatToDo";
            whatToDo.Size = new Size(534, 23);
            whatToDo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(statusMessage);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(sendMessage);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(usersList);
            groupBox2.Controls.Add(messageToUser);
            groupBox2.Location = new Point(12, 358);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 297);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "wyślij wiadomość do użytkownika - w combo dodać contextMenu dla ręcznego wpisywania";
            // 
            // statusMessage
            // 
            statusMessage.AutoSize = true;
            statusMessage.Location = new Point(123, 274);
            statusMessage.Name = "statusMessage";
            statusMessage.Size = new Size(0, 15);
            statusMessage.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 274);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 5;
            label8.Text = "status wiadomości :";
            // 
            // sendMessage
            // 
            sendMessage.Location = new Point(332, 270);
            sendMessage.Name = "sendMessage";
            sendMessage.Size = new Size(75, 23);
            sendMessage.TabIndex = 4;
            sendMessage.Text = "wyślij";
            sendMessage.UseVisualStyleBackColor = true;
            sendMessage.Click += sendMessage_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 85);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 3;
            label6.Text = "wiadomość";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 31);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 2;
            label4.Text = "wybierz użytkownika";
            // 
            // usersList
            // 
            usersList.DropDownStyle = ComboBoxStyle.DropDownList;
            usersList.FormattingEnabled = true;
            usersList.Location = new Point(6, 49);
            usersList.Name = "usersList";
            usersList.Size = new Size(401, 23);
            usersList.TabIndex = 1;
            // 
            // messageToUser
            // 
            messageToUser.Location = new Point(6, 102);
            messageToUser.Name = "messageToUser";
            messageToUser.Size = new Size(401, 162);
            messageToUser.TabIndex = 0;
            messageToUser.Text = "";
            messageToUser.Enter += messageToUser_Enter;
            messageToUser.Leave += messageToUser_Leave;
            // 
            // businessmanBindingSource
            // 
            businessmanBindingSource.DataSource = typeof(Businessman);
            // 
            // messageTaken
            // 
            messageTaken.Controls.Add(user1);
            messageTaken.Controls.Add(mess1);
            messageTaken.Controls.Add(user5);
            messageTaken.Controls.Add(user4);
            messageTaken.Controls.Add(user3);
            messageTaken.Controls.Add(user2);
            messageTaken.Controls.Add(mess5);
            messageTaken.Controls.Add(mess4);
            messageTaken.Controls.Add(mess3);
            messageTaken.Controls.Add(mess2);
            messageTaken.Location = new Point(431, 358);
            messageTaken.Name = "messageTaken";
            messageTaken.Size = new Size(643, 297);
            messageTaken.TabIndex = 9;
            messageTaken.TabStop = false;
            messageTaken.Text = "new message - zmienić na treeView od danego użytkownika";
            // 
            // user1
            // 
            user1.AutoSize = true;
            user1.Location = new Point(6, 24);
            user1.Name = "user1";
            user1.Size = new Size(44, 15);
            user1.TabIndex = 18;
            user1.Text = "label13";
            // 
            // mess1
            // 
            mess1.Location = new Point(6, 44);
            mess1.Name = "mess1";
            mess1.ReadOnly = true;
            mess1.Size = new Size(631, 23);
            mess1.TabIndex = 16;
            // 
            // user5
            // 
            user5.AutoSize = true;
            user5.Location = new Point(6, 241);
            user5.Name = "user5";
            user5.Size = new Size(44, 15);
            user5.TabIndex = 15;
            user5.Text = "label16";
            // 
            // user4
            // 
            user4.AutoSize = true;
            user4.Location = new Point(6, 186);
            user4.Name = "user4";
            user4.Size = new Size(44, 15);
            user4.TabIndex = 14;
            user4.Text = "label15";
            // 
            // user3
            // 
            user3.AutoSize = true;
            user3.Location = new Point(6, 132);
            user3.Name = "user3";
            user3.Size = new Size(44, 15);
            user3.TabIndex = 13;
            user3.Text = "label14";
            // 
            // user2
            // 
            user2.AutoSize = true;
            user2.Location = new Point(6, 77);
            user2.Name = "user2";
            user2.Size = new Size(44, 15);
            user2.TabIndex = 12;
            user2.Text = "label13";
            // 
            // mess5
            // 
            mess5.Location = new Point(6, 259);
            mess5.Name = "mess5";
            mess5.ReadOnly = true;
            mess5.Size = new Size(631, 23);
            mess5.TabIndex = 9;
            // 
            // mess4
            // 
            mess4.Location = new Point(6, 205);
            mess4.Name = "mess4";
            mess4.ReadOnly = true;
            mess4.Size = new Size(631, 23);
            mess4.TabIndex = 7;
            // 
            // mess3
            // 
            mess3.Location = new Point(6, 150);
            mess3.Name = "mess3";
            mess3.ReadOnly = true;
            mess3.Size = new Size(631, 23);
            mess3.TabIndex = 5;
            // 
            // mess2
            // 
            mess2.Location = new Point(6, 97);
            mess2.Name = "mess2";
            mess2.ReadOnly = true;
            mess2.Size = new Size(631, 23);
            mess2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(631, 23);
            textBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 24);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 10;
            label3.Text = "wylogowanie nastapi za";
            // 
            // logoutTimew
            // 
            logoutTimew.AutoSize = true;
            logoutTimew.Location = new Point(493, 24);
            logoutTimew.Name = "logoutTimew";
            logoutTimew.Size = new Size(38, 15);
            logoutTimew.TabIndex = 11;
            logoutTimew.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 24);
            label5.Name = "label5";
            label5.Size = new Size(208, 15);
            label5.TabIndex = 12;
            label5.Text = "mieisęczny przychód z tytułu protekcji";
            // 
            // monthlyIncome
            // 
            monthlyIncome.AutoSize = true;
            monthlyIncome.Location = new Point(799, 24);
            monthlyIncome.Name = "monthlyIncome";
            monthlyIncome.Size = new Size(38, 15);
            monthlyIncome.TabIndex = 13;
            monthlyIncome.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 28);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 2;
            label7.Text = "from";
            // 
            // mes1
            // 
            mes1.AutoSize = true;
            mes1.Location = new Point(65, 28);
            mes1.Name = "mes1";
            mes1.Size = new Size(44, 15);
            mes1.TabIndex = 11;
            mes1.Text = "label12";
            // 
            // refreshMessages
            // 
            refreshMessages.Enabled = true;
            refreshMessages.Interval = 5000;
            refreshMessages.Tick += refreshMessages_Tick;
            // 
            // treeToDo
            // 
            treeToDo.Location = new Point(1080, 72);
            treeToDo.Name = "treeToDo";
            treeToDo.Size = new Size(207, 583);
            treeToDo.TabIndex = 14;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1080, 54);
            label16.Name = "label16";
            label16.Size = new Size(147, 15);
            label16.TabIndex = 15;
            label16.Text = "zadania bojowe na dzisiajh";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(861, 24);
            label17.Name = "label17";
            label17.Size = new Size(189, 15);
            label17.TabIndex = 16;
            label17.Text = "przychód dnia dzisiejszego z zadań";
            // 
            // dailyIncome
            // 
            dailyIncome.AutoSize = true;
            dailyIncome.Location = new Point(1080, 24);
            dailyIncome.Name = "dailyIncome";
            dailyIncome.Size = new Size(44, 15);
            dailyIncome.TabIndex = 17;
            dailyIncome.Text = "label18";
            // 
            // mainApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 665);
            Controls.Add(dailyIncome);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(treeToDo);
            Controls.Add(monthlyIncome);
            Controls.Add(label5);
            Controls.Add(logoutTimew);
            Controls.Add(label3);
            Controls.Add(messageTaken);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(newLokal);
            Controls.Add(date);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(labelUser);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainApp";
            Text = "Aplication for street bisnesman";
            Load += mainApp_Load;
            TextChanged += mainApp_mouseMove;
            MouseMove += mainApp_MouseMove;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            newLokal.ResumeLayout(false);
            newLokal.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)businessmanBindingSource).EndInit();
            messageTaken.ResumeLayout(false);
            messageTaken.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUser;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem buttonToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Label label1;
        private Label date;
        private ToolStripMenuItem userThingsToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private GroupBox newLokal;
        private TextBox textNewLocalStreet;
        private TextBox textNewLocalNr;
        private TextBox textNewLocalTribiute;
        private TextBox textNewLocalPanishment;
        private TextBox textNewLocalName;
        private Label newLocalPanishment;
        private Label newLocalTribute;
        private Label newLocalAdressNumber;
        private Label newLocalStreet;
        private Label newLocalName;
        private Button button2;
        private Button addAction;
        private Button rejectButton;
        private Button acceptButton;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox messageTaken;
        private Label label3;
        private Label logoutTimew;
        private Label label5;
        private Label monthlyIncome;
        private Button sendMessage;
        private Label label6;
        private Label label4;
        private ComboBox usersList;
        private RichTextBox messageToUser;
        private Label user5;
        private Label user4;
        private Label user3;
        private Label user2;
        private TextBox mess5;
        private TextBox mess4;
        private TextBox mess3;
        private TextBox mess2;
        private TextBox textBox1;
        private Label label7;
        private Label mes1;
        private Label user1;
        private TextBox mess1;
        private System.Windows.Forms.Timer refreshMessages;
        private Label statusMessage;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox whatToDo;
        private Label label12;
        private ListView helpers;
        private Label label13;
        private TextBox incidentIncome;
        private ComboBox weightOfAction;
        private Label label14;
        private BindingSource businessmanBindingSource;
        private ComboBox listPlaces;
        private ComboBox incidentDay;
        private Label label15;
        private ComboBox incidenthMonth;
        private Label actionStatus;
        private TreeView treeToDo;
        private Label label16;
        private Label label17;
        private Label dailyIncome;
    }
}