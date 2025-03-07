namespace InventoryManagementSystem
{
    partial class WelcomeForm
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
            label1 = new Label();
            btnLogin_Click = new Button();
            btnSignUp_Click = new Button();
            btnExit_Click = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 87);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our App";
            // 
            // btnLogin_Click
            // 
            btnLogin_Click.Location = new Point(266, 213);
            btnLogin_Click.Name = "btnLogin_Click";
            btnLogin_Click.Size = new Size(94, 29);
            btnLogin_Click.TabIndex = 1;
            btnLogin_Click.Text = "Login";
            btnLogin_Click.UseVisualStyleBackColor = true;
            btnLogin_Click.Click += btnLogin_Click_Click;
            // 
            // btnSignUp_Click
            // 
            btnSignUp_Click.Location = new Point(477, 213);
            btnSignUp_Click.Name = "btnSignUp_Click";
            btnSignUp_Click.Size = new Size(94, 29);
            btnSignUp_Click.TabIndex = 2;
            btnSignUp_Click.Text = "SignUp";
            btnSignUp_Click.UseVisualStyleBackColor = true;
            btnSignUp_Click.Click += btnSignUp_Click_Click;
            // 
            // btnExit_Click
            // 
            btnExit_Click.Location = new Point(12, 644);
            btnExit_Click.Name = "btnExit_Click";
            btnExit_Click.RightToLeft = RightToLeft.Yes;
            btnExit_Click.Size = new Size(94, 29);
            btnExit_Click.TabIndex = 3;
            btnExit_Click.Text = "Exit";
            btnExit_Click.UseVisualStyleBackColor = true;
            btnExit_Click.Click += btnExit_Click_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 685);
            Controls.Add(btnExit_Click);
            Controls.Add(btnSignUp_Click);
            Controls.Add(btnLogin_Click);
            Controls.Add(label1);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin_Click;
        private Button btnSignUp_Click;
        private Button btnExit_Click;
    }
}
