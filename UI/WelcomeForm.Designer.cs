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
            btnLogin_Click.Location = new Point(12, 298);
            btnLogin_Click.Margin = new Padding(3, 2, 3, 2);
            btnLogin_Click.Name = "btnLogin_Click";
            btnLogin_Click.Size = new Size(149, 46);
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
            btnSignUp_Click.Location = new Point(233, 298);
            btnSignUp_Click.Margin = new Padding(3, 2, 3, 2);
            btnSignUp_Click.Name = "btnSignUp_Click";
            btnSignUp_Click.Size = new Size(152, 46);
            btnSignUp_Click.TabIndex = 2;
            btnSignUp_Click.Text = "SignUp";
            btnSignUp_Click.UseVisualStyleBackColor = false;
            btnSignUp_Click.Click += btnSignUp_Click_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1320, 20);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 109);
            label3.Name = "label3";
            label3.Size = new Size(414, 31);
            label3.TabIndex = 6;
            label3.Text = "Welcome to our Inventory App!";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Location = new Point(428, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(771, 562);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 198);
            label2.Name = "label2";
            label2.Size = new Size(300, 48);
            label2.TabIndex = 9;
            label2.Text = "Get ready for smarter and more efficient management.\r\nGreater Profits!";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 68, 136);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1199, 562);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignUp_Click);
            Controls.Add(btnLogin_Click);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(3, 68, 136);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
