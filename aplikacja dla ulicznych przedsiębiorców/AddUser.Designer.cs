namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    partial class AddUser
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
            adminButton = new RadioButton();
            SuspendLayout();
            // 
            // rejectButton
            // 
            rejectButton.Location = new Point(12, 142);
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(12, 113);
            // 
            // passwordInfo
            // 
            passwordInfo.Location = new Point(12, 84);
            passwordInfo.Size = new Size(472, 23);
            passwordInfo.Visible = true;
            // 
            // fakeBox
            // 
            fakeBox.Location = new Point(77, 36);
            // 
            // adminButton
            // 
            adminButton.AutoSize = true;
            adminButton.Location = new Point(77, 65);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(143, 19);
            adminButton.TabIndex = 8;
            adminButton.TabStop = true;
            adminButton.Text = "is new user an Admin?";
            adminButton.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 177);
            Controls.Add(adminButton);
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "add new User";
            Controls.SetChildIndex(rejectButton, 0);
            Controls.SetChildIndex(textUser, 0);
            Controls.SetChildIndex(textPass, 0);
            Controls.SetChildIndex(acceptButton, 0);
            Controls.SetChildIndex(passwordInfo, 0);
            Controls.SetChildIndex(fakeBox, 0);
            Controls.SetChildIndex(adminButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton adminButton;
    }
}