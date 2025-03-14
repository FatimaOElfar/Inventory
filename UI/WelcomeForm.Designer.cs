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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label(); // Add this line to initialize label1


            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLogin_Click
            // 
            btnLogin_Click.BackColor = Color.White;
            btnLogin_Click.FlatStyle = FlatStyle.Flat;
            btnLogin_Click.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            btnLogin_Click.ForeColor = Color.FromArgb(3, 68, 136);
            btnLogin_Click.Location = new Point(89, 457);
            btnLogin_Click.Font = new Font("Lucida Fax", 12F, FontStyle.Bold);
            btnLogin_Click.ForeColor = Color.FromArgb(3, 68, 136);
            btnLogin_Click.Location = new Point(119, 371);
            btnLogin_Click.Name = "btnLogin_Click";
            btnLogin_Click.Size = new Size(170, 61);
            btnLogin_Click.TabIndex = 1;
            btnLogin_Click.Text = "Login";
            btnLogin_Click.UseVisualStyleBackColor = false;
            btnLogin_Click.Click += btnLogin_Click_Click;
            // 
            // btnSignUp_Click
            // 
            btnSignUp_Click.BackColor = Color.White;
            btnSignUp_Click.FlatStyle = FlatStyle.Flat;
            btnSignUp_Click.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            btnSignUp_Click.ForeColor = Color.FromArgb(3, 68, 136);
            btnSignUp_Click.Location = new Point(345, 457);
            btnSignUp_Click.Font = new Font("Lucida Fax", 12F, FontStyle.Bold);
            btnSignUp_Click.ForeColor = Color.FromArgb(3, 68, 136);
            btnSignUp_Click.Location = new Point(350, 371);
            btnSignUp_Click.Name = "btnSignUp_Click";
            btnSignUp_Click.Size = new Size(174, 61);
            btnSignUp_Click.TabIndex = 2;
            btnSignUp_Click.Text = "SignUp";
            btnSignUp_Click.UseVisualStyleBackColor = false;
            btnSignUp_Click.Click += btnSignUp_Click_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1508, 27);
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
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 145);
            label3.Name = "label3";
            label3.Size = new Size(511, 39);
            label3.TabIndex = 6;
            label3.Text = "Welcome to our Inventory App!";
            label3.Click += label3_Click;

            label3.Font = new Font("Century Schoolbook", 29F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 78);
            label3.Name = "label3";
            label3.Size = new Size(686, 58);
            label3.TabIndex = 6;
            label3.Text = "Welcome to our Inventory";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Location = new Point(669, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(881, 907);

            pictureBox2.Location = new Point(695, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(912, 999);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 264);
            label2.Name = "label2";
            label2.Size = new Size(639, 58);
            label2.TabIndex = 9;
            label2.Text = "Get ready for smarter and more efficient management.\r\nGreater Profits!";

            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 221);
            label1.Name = "label1";
            label1.Size = new Size(501, 40);
            label1.TabIndex = 8;
            label1.Text = "With our intuitive platform";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 68, 136);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1550, 907);
            Controls.Add(label2);

            ClientSize = new Size(1607, 999);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignUp_Click);
            Controls.Add(btnLogin_Click);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(3, 68, 136);
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin_Click;
        private Button btnSignUp_Click;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
    }
}
