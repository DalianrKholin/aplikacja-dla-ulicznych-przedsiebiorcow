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
            SuspendLayout();
            // 
            // enterApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 153);
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "enterApp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login for very usefull aplication";
            FormClosing += enterApp_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}