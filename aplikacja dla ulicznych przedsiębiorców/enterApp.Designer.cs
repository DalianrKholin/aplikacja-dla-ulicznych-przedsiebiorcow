namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    partial class enterApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textUser = new TextBox();
            fakeBox = new TextBox();
            textPass = new TextBox();
            userLabel = new Label();
            passLabel = new Label();
            addUser = new Button();
            passReset = new Button();
            SuspendLayout();
            // 
            // textUser
            // 
            textUser.Location = new Point(75, 16);
            textUser.Name = "textUser";
            textUser.Size = new Size(100, 23);
            textUser.TabIndex = 0;
            textUser.TextChanged += textBox1_TextChanged;
            // 
            // fakeBox
            // 
            fakeBox.Location = new Point(75, 52);
            fakeBox.Name = "fakeBox";
            fakeBox.PasswordChar = '*';
            fakeBox.Size = new Size(100, 23);
            fakeBox.TabIndex = 1;
            // 
            // textPass
            // 
            textPass.Location = new Point(75, 52);
            textPass.Name = "textPass";
            textPass.Size = new Size(100, 23);
            textPass.TabIndex = 2;
            textPass.TextChanged += textPass_TextChanged;
            textPass.Enter += textPass_Enter;
            textPass.Leave += textPass_Leave;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(9, 19);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(60, 15);
            userLabel.TabIndex = 3;
            userLabel.Text = "Username";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(12, 52);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(57, 15);
            passLabel.TabIndex = 4;
            passLabel.Text = "Password";
            passLabel.Click += passLabel_Click;
            // 
            // addUser
            // 
            addUser.Location = new Point(12, 102);
            addUser.Name = "addUser";
            addUser.Size = new Size(163, 23);
            addUser.TabIndex = 5;
            addUser.Text = "add User";
            addUser.UseVisualStyleBackColor = true;
            // 
            // passReset
            // 
            passReset.Location = new Point(12, 131);
            passReset.Name = "passReset";
            passReset.Size = new Size(163, 23);
            passReset.TabIndex = 6;
            passReset.Text = "restet Password";
            passReset.UseVisualStyleBackColor = true;
            // 
            // enterApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(193, 166);
            Controls.Add(passReset);
            Controls.Add(addUser);
            Controls.Add(passLabel);
            Controls.Add(userLabel);
            Controls.Add(textPass);
            Controls.Add(fakeBox);
            Controls.Add(textUser);
            Name = "enterApp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUser;
        private TextBox fakeBox;
        private TextBox textPass;
        private Label userLabel;
        private Label passLabel;
        private Button addUser;
        private Button passReset;
    }
}