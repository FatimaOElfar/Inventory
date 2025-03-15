namespace InventoryManagementSystem.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txt_userName = new TextBox();
            txt_Pass = new TextBox();
            btn_login = new Button();
            label1 = new Label();
            btnExit_Click = new Button();
            chkShowPassword = new CheckBox();
            lblSignUp_Click = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_userName
            // 
            txt_userName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_userName.Location = new Point(93, 231);
            txt_userName.Multiline = true;
            txt_userName.Name = "txt_userName";
            txt_userName.PlaceholderText = "Your Name";
            txt_userName.Size = new Size(317, 43);
            txt_userName.TabIndex = 0;
            txt_userName.TextChanged += txt_userName_TextChanged;
            // 
            // txt_Pass
            // 
            txt_Pass.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Pass.Location = new Point(93, 308);
            txt_Pass.Multiline = true;
            txt_Pass.Name = "txt_Pass";
            txt_Pass.PlaceholderText = "Your Password";
            txt_Pass.Size = new Size(317, 44);
            txt_Pass.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(3, 68, 136);
            btn_login.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(93, 430);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(317, 48);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(120, 516);
            label1.Name = "label1";
            label1.Size = new Size(201, 23);
            label1.TabIndex = 6;
            label1.Text = "Don't Have an Account ?";
            // 
            // btnExit_Click
            // 
            btnExit_Click.BackColor = Color.DarkRed;
            btnExit_Click.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit_Click.Location = new Point(1482, 943);
            btnExit_Click.Name = "btnExit_Click";
            btnExit_Click.Size = new Size(113, 44);
            btnExit_Click.TabIndex = 19;
            btnExit_Click.Text = "Exit";
            btnExit_Click.UseVisualStyleBackColor = false;
            btnExit_Click.Click += btnExit_Click_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.CheckAlign = ContentAlignment.MiddleRight;
            chkShowPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.FromArgb(3, 68, 136);
            chkShowPassword.Location = new Point(274, 377);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(136, 24);
            chkShowPassword.TabIndex = 20;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblSignUp_Click
            // 
            lblSignUp_Click.AutoSize = true;
            lblSignUp_Click.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUp_Click.ForeColor = SystemColors.HotTrack;
            lblSignUp_Click.Location = new Point(327, 516);
            lblSignUp_Click.Name = "lblSignUp_Click";
            lblSignUp_Click.Size = new Size(65, 23);
            lblSignUp_Click.TabIndex = 21;
            lblSignUp_Click.Text = "SignUp";
            lblSignUp_Click.Click += lblSignUp_Click_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 30.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(3, 68, 136);
            label2.Location = new Point(49, 77);
            label2.Name = "label2";
            label2.Size = new Size(391, 59);
            label2.TabIndex = 23;
            label2.Text = "Welcome Back!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblSignUp_Click);
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(txt_userName);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(txt_Pass);
            panel1.Location = new Point(272, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 686);
            panel1.TabIndex = 24;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(494, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(567, 685);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 68, 136);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1550, 907);
            Controls.Add(panel1);
            Controls.Add(btnExit_Click);
            DoubleBuffered = true;
            ForeColor = Color.White;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_userName;
        private TextBox txt_Pass;
        private Button btn_login;
        private Label label1;
        private Button btnExit_Click;
        private CheckBox chkShowPassword;
        private Label lblSignUp_Click;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}