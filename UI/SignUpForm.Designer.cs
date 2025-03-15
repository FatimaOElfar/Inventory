namespace InventoryManagementSystem.UI
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            numAge = new NumericUpDown();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            cmbRole = new ComboBox();
            chkShowPassword = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSignUp_Click = new Button();
            btnExit_Click = new Button();
            lblLogin_Click = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label10 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(766, 139);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "User Name";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(317, 43);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(766, 334);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(317, 43);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(766, 440);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(317, 43);
            txtConfirmPassword.TabIndex = 2;
            // 
            // numAge
            // 
            numAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numAge.Location = new Point(766, 643);
            numAge.Name = "numAge";
            numAge.Size = new Size(317, 34);
            numAge.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(766, 542);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Addess";
            txtAddress.Size = new Size(317, 43);
            txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(766, 237);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(317, 43);
            txtEmail.TabIndex = 5;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(766, 730);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(317, 36);
            cmbRole.TabIndex = 6;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.CheckAlign = ContentAlignment.MiddleRight;
            chkShowPassword.Location = new Point(951, 383);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(132, 24);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(3, 68, 136);
            label1.Location = new Point(766, 101);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 8;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(3, 68, 136);
            label2.Location = new Point(766, 297);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(3, 68, 136);
            label3.Location = new Point(766, 402);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 10;
            label3.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(3, 68, 136);
            label4.Location = new Point(766, 604);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 11;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(3, 68, 136);
            label5.Location = new Point(766, 504);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 12;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(3, 68, 136);
            label6.Location = new Point(766, 194);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(3, 68, 136);
            label7.Location = new Point(766, 691);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 14;
            label7.Text = "Role";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(807, 872);
            label8.Name = "label8";
            label8.Size = new Size(205, 25);
            label8.TabIndex = 16;
            label8.Text = "Already have an account";
            // 
            // btnSignUp_Click
            // 
            btnSignUp_Click.BackColor = Color.FromArgb(3, 68, 136);
            btnSignUp_Click.FlatStyle = FlatStyle.Flat;
            btnSignUp_Click.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp_Click.ForeColor = Color.White;
            btnSignUp_Click.Location = new Point(766, 795);
            btnSignUp_Click.Name = "btnSignUp_Click";
            btnSignUp_Click.Size = new Size(317, 50);
            btnSignUp_Click.TabIndex = 17;
            btnSignUp_Click.Text = "SignUp";
            btnSignUp_Click.UseVisualStyleBackColor = false;
            btnSignUp_Click.Click += btnSignUp_Click_Click;
            // 
            // btnExit_Click
            // 
            btnExit_Click.BackColor = Color.White;
            btnExit_Click.FlatStyle = FlatStyle.Flat;
            btnExit_Click.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit_Click.ForeColor = Color.FromArgb(3, 68, 136);
            btnExit_Click.Location = new Point(1465, 901);
            btnExit_Click.Name = "btnExit_Click";
            btnExit_Click.Size = new Size(73, 39);
            btnExit_Click.TabIndex = 18;
            btnExit_Click.Text = "Exit";
            btnExit_Click.UseVisualStyleBackColor = false;
            btnExit_Click.Click += btnExit_Click_Click;
            // 
            // lblLogin_Click
            // 
            lblLogin_Click.AutoSize = true;
            lblLogin_Click.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin_Click.ForeColor = Color.FromArgb(3, 68, 136);
            lblLogin_Click.Location = new Point(1018, 872);
            lblLogin_Click.Name = "lblLogin_Click";
            lblLogin_Click.Size = new Size(52, 23);
            lblLogin_Click.TabIndex = 19;
            lblLogin_Click.Text = "Login";
            lblLogin_Click.Click += lblLogin_Click_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblLogin_Click);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnSignUp_Click);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(numAge);
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbRole);
            panel1.Location = new Point(158, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 911);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Location = new Point(3, 643);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 254);
            panel2.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(3, 68, 136);
            label10.Location = new Point(0, 63);
            label10.Name = "label10";
            label10.Size = new Size(688, 60);
            label10.TabIndex = 0;
            label10.Text = " Our Inventory Management System is a robust and intuitive platform \r\n                          designed to streamline inventory tracking";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(3, 68, 136);
            label9.Location = new Point(742, 27);
            label9.Name = "label9";
            label9.Size = new Size(368, 39);
            label9.TabIndex = 21;
            label9.Text = "Register your account";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(690, 724);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 68, 136);
            ClientSize = new Size(1550, 952);
            Controls.Add(panel1);
            Controls.Add(btnExit_Click);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private NumericUpDown numAge;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private ComboBox cmbRole;
        private CheckBox chkShowPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSignUp_Click;
        private Button btnExit_Click;
        private Label lblLogin_Click;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label9;
        private Panel panel2;
        private Label label10;
    }
}