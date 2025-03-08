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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            btnLogin_Click = new Button();
            btnSignUp_Click = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin_Click
            // 
            btnLogin_Click.BackColor = Color.FromArgb(212, 232, 231);
            btnLogin_Click.FlatStyle = FlatStyle.Flat;
            btnLogin_Click.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin_Click.ForeColor = Color.FromArgb(9, 111, 187);
            btnLogin_Click.Location = new Point(166, 387);
            btnLogin_Click.Name = "btnLogin_Click";
            btnLogin_Click.Size = new Size(170, 61);
            btnLogin_Click.TabIndex = 1;
            btnLogin_Click.Text = "Login";
            btnLogin_Click.UseVisualStyleBackColor = false;
            btnLogin_Click.Click += btnLogin_Click_Click;
            // 
            // btnSignUp_Click
            // 
            btnSignUp_Click.BackColor = Color.FromArgb(212, 232, 231);
            btnSignUp_Click.FlatStyle = FlatStyle.Flat;
            btnSignUp_Click.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp_Click.ForeColor = Color.FromArgb(9, 111, 187);
            btnSignUp_Click.Location = new Point(428, 387);
            btnSignUp_Click.Name = "btnSignUp_Click";
            btnSignUp_Click.Size = new Size(174, 61);
            btnSignUp_Click.TabIndex = 2;
            btnSignUp_Click.Text = "SignUp";
            btnSignUp_Click.UseVisualStyleBackColor = false;
            btnSignUp_Click.Click += btnSignUp_Click_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(9, 111, 187);
            label2.Location = new Point(89, 271);
            label2.Name = "label2";
            label2.Size = new Size(635, 76);
            label2.TabIndex = 4;
            label2.Text = "Effortless tracking, optimized stock, and smarter\r\nbusiness decisions\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1433, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(9, 111, 187);
            label3.Location = new Point(89, 70);
            label3.Name = "label3";
            label3.Size = new Size(595, 156);
            label3.TabIndex = 6;
            label3.Text = "Smart Inventory \r\nManagement System";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1484, 752);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnSignUp_Click);
            Controls.Add(btnLogin_Click);
            DoubleBuffered = true;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin_Click;
        private Button btnSignUp_Click;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
