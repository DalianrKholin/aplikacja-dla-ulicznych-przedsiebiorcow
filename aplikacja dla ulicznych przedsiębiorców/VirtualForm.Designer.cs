namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    partial class VirtualForm
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
            rejectButton = new Button();
            label1 = new Label();
            label2 = new Label();
            textUser = new TextBox();
            textPass = new TextBox();
            acceptButton = new Button();
            passwordInfo = new TextBox();
            fakeBox = new TextBox();
            SuspendLayout();
            // 
            // RejectButton
            // 
            rejectButton.Location = new Point(12, 122);
            rejectButton.Name = "RejectButton";
            rejectButton.Size = new Size(476, 23);
            rejectButton.TabIndex = 0;
            rejectButton.UseVisualStyleBackColor = true;
            rejectButton.Click += RejectButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "password";
            // 
            // textUser
            // 
            textUser.Location = new Point(77, 6);
            textUser.Name = "textUser";
            textUser.Size = new Size(411, 23);
            textUser.TabIndex = 3;
            textUser.TextChanged += textUser_TextChanged;
            // 
            // textPass
            // 
            textPass.Location = new Point(77, 36);
            textPass.Name = "textPass";
            textPass.Size = new Size(411, 23);
            textPass.TabIndex = 4;
            textPass.Enter += textPass_Enter;
            textPass.Leave += textPass_Leave;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(12, 93);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(476, 23);
            acceptButton.TabIndex = 5;
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += AcceptButton_Click;
            // 
            // passwordInfo
            // 
            passwordInfo.ForeColor = Color.Red;
            passwordInfo.Location = new Point(12, 64);
            passwordInfo.Name = "passwordInfo";
            passwordInfo.ReadOnly = true;
            passwordInfo.Size = new Size(476, 23);
            passwordInfo.TabIndex = 6;
            passwordInfo.TextAlign = HorizontalAlignment.Center;
            passwordInfo.Visible = false;
            // 
            // fakeBox
            // 
            fakeBox.Location = new Point(77, 35);
            fakeBox.Name = "fakeBox";
            fakeBox.Size = new Size(411, 23);
            fakeBox.TabIndex = 7;
            fakeBox.Visible = false;
            fakeBox.TextChanged += textPass_TextChanged;
            // 
            // VirtualForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 154);
            Controls.Add(fakeBox);
            Controls.Add(passwordInfo);
            Controls.Add(acceptButton);
            Controls.Add(textPass);
            Controls.Add(textUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rejectButton);
            Name = "VirtualForm";
            Text = "VirtualForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        protected Button rejectButton;
        protected TextBox textUser;
        protected Button acceptButton;
        protected TextBox passwordInfo;
        protected TextBox fakeBox;
        protected TextBox textPass;
    }
}