namespace InventoryManagementSystem.UI
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            panel1 = new Panel();
            but_newSale = new Button();
            btn_StockTransaction = new Button();
            Home = new Button();
            label1 = new Label();
            btn_Suppliers = new Button();
            btn_Sale = new Button();
            btn_ProductManagment = new Button();
            btn_UserManagment = new Button();
            pnlNavbar = new Panel();
            button1 = new Button();
            lbl_role = new Label();
            lblUsername = new Label();
            pictureBox1 = new PictureBox();
            lblDateTime = new Label();
            Admin_pannel = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            button2 = new Button();
            pictureBox9 = new PictureBox();
            panel1.SuspendLayout();
            pnlNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 68, 136);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(but_newSale);
            panel1.Controls.Add(btn_StockTransaction);
            panel1.Controls.Add(Home);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Suppliers);
            panel1.Controls.Add(btn_Sale);
            panel1.Controls.Add(btn_ProductManagment);
            panel1.Controls.Add(btn_UserManagment);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 999);
            panel1.TabIndex = 0;
            // 
            // but_newSale
            // 
            but_newSale.BackColor = Color.White;
            but_newSale.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but_newSale.ForeColor = Color.FromArgb(3, 68, 136);
            but_newSale.Location = new Point(40, 526);
            but_newSale.Name = "but_newSale";
            but_newSale.Size = new Size(297, 81);
            but_newSale.TabIndex = 8;
            but_newSale.Text = "New Sales";
            but_newSale.UseVisualStyleBackColor = false;
            but_newSale.Click += but_newSale_Click;
            // 
            // btn_StockTransaction
            // 
            btn_StockTransaction.BackColor = Color.White;
            btn_StockTransaction.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_StockTransaction.ForeColor = Color.FromArgb(3, 68, 136);
            btn_StockTransaction.Location = new Point(40, 750);
            btn_StockTransaction.Name = "btn_StockTransaction";
            btn_StockTransaction.Size = new Size(297, 81);
            btn_StockTransaction.TabIndex = 4;
            btn_StockTransaction.Text = "Stock Transaction";
            btn_StockTransaction.UseVisualStyleBackColor = false;
            btn_StockTransaction.Click += btn_StockTransaction_Click;
            // 
            // Home
            // 
            Home.BackColor = Color.White;
            Home.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Home.ForeColor = Color.FromArgb(3, 68, 136);
            Home.Location = new Point(0, 91);
            Home.Name = "Home";
            Home.Size = new Size(381, 84);
            Home.TabIndex = 7;
            Home.Text = "       Dashboard";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.FromArgb(3, 68, 136);
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -4);
            label1.Name = "label1";
            label1.Size = new Size(381, 95);
            label1.TabIndex = 6;
            label1.Text = "Welcome to Inventory Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Suppliers
            // 
            btn_Suppliers.BackColor = Color.White;
            btn_Suppliers.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Suppliers.ForeColor = Color.FromArgb(3, 68, 136);
            btn_Suppliers.Location = new Point(40, 425);
            btn_Suppliers.Name = "btn_Suppliers";
            btn_Suppliers.Size = new Size(297, 81);
            btn_Suppliers.TabIndex = 5;
            btn_Suppliers.Text = "Suppliers ";
            btn_Suppliers.UseVisualStyleBackColor = false;
            btn_Suppliers.Click += btn_Suppliers_Click;
            // 
            // btn_Sale
            // 
            btn_Sale.BackColor = Color.White;
            btn_Sale.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Sale.ForeColor = Color.FromArgb(3, 68, 136);
            btn_Sale.Location = new Point(40, 637);
            btn_Sale.Name = "btn_Sale";
            btn_Sale.Size = new Size(297, 81);
            btn_Sale.TabIndex = 3;
            btn_Sale.Text = "Sales History";
            btn_Sale.UseVisualStyleBackColor = false;
            btn_Sale.Click += btn_Sale_Click;
            // 
            // btn_ProductManagment
            // 
            btn_ProductManagment.BackColor = Color.White;
            btn_ProductManagment.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_ProductManagment.ForeColor = Color.FromArgb(3, 68, 136);
            btn_ProductManagment.Location = new Point(40, 312);
            btn_ProductManagment.Name = "btn_ProductManagment";
            btn_ProductManagment.Size = new Size(297, 81);
            btn_ProductManagment.TabIndex = 2;
            btn_ProductManagment.Text = "Products";
            btn_ProductManagment.UseVisualStyleBackColor = false;
            btn_ProductManagment.Click += btn_ProductManagment_Click;
            // 
            // btn_UserManagment
            // 
            btn_UserManagment.BackColor = Color.White;
            btn_UserManagment.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_UserManagment.ForeColor = Color.FromArgb(3, 68, 136);
            btn_UserManagment.Location = new Point(40, 197);
            btn_UserManagment.Name = "btn_UserManagment";
            btn_UserManagment.Size = new Size(297, 81);
            btn_UserManagment.TabIndex = 1;
            btn_UserManagment.Text = "Customers";
            btn_UserManagment.UseVisualStyleBackColor = false;
            btn_UserManagment.Click += btn_UserManagment_Click;
            // 
            // pnlNavbar
            // 
            pnlNavbar.BackColor = Color.FromArgb(3, 68, 136);
            pnlNavbar.Controls.Add(button1);
            pnlNavbar.Controls.Add(lbl_role);
            pnlNavbar.Controls.Add(lblUsername);
            pnlNavbar.Controls.Add(pictureBox1);
            pnlNavbar.Controls.Add(lblDateTime);
            pnlNavbar.Dock = DockStyle.Top;
            pnlNavbar.Location = new Point(381, 0);
            pnlNavbar.Name = "pnlNavbar";
            pnlNavbar.Size = new Size(1226, 91);
            pnlNavbar.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(3, 68, 136);
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1120, 23);
            button1.Name = "button1";
            button1.Size = new Size(106, 49);
            button1.TabIndex = 4;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbl_role.ForeColor = Color.White;
            lbl_role.Location = new Point(534, 22);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(66, 35);
            lbl_role.TabIndex = 3;
            lbl_role.Text = "Role";
            lbl_role.Click += lbl_role_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(962, 34);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(53, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(854, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.White;
            lblDateTime.Location = new Point(114, 33);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(50, 25);
            lblDateTime.TabIndex = 0;
            lblDateTime.Text = "time";
            lblDateTime.Click += lblDateTime_Click;
            // 
            // Admin_pannel
            // 
            Admin_pannel.BackColor = Color.White;
            Admin_pannel.Dock = DockStyle.Fill;
            Admin_pannel.ForeColor = SystemColors.Control;
            Admin_pannel.Location = new Point(381, 91);
            Admin_pannel.Name = "Admin_pannel";
            Admin_pannel.Size = new Size(1226, 908);
            Admin_pannel.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(86, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 54);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(53, 211);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 54);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(53, 329);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 54);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(53, 440);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(54, 54);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(53, 539);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(54, 54);
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(53, 649);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(54, 54);
            pictureBox7.TabIndex = 19;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.White;
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(53, 767);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(54, 54);
            pictureBox8.TabIndex = 20;
            pictureBox8.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(3, 68, 136);
            button2.Location = new Point(40, 865);
            button2.Name = "button2";
            button2.Size = new Size(297, 81);
            button2.TabIndex = 21;
            button2.Text = "Sales Report";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.White;
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(62, 879);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(54, 54);
            pictureBox9.TabIndex = 22;
            pictureBox9.TabStop = false;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1607, 999);
            Controls.Add(Admin_pannel);
            Controls.Add(pnlNavbar);
            Controls.Add(panel1);
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += AdminMainForm_Load;
            panel1.ResumeLayout(false);
            pnlNavbar.ResumeLayout(false);
            pnlNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_UserManagment;
        private Label label1;
        private Button btn_Suppliers;
        private Button btn_StockTransaction;
        private Button btn_Sale;
        private Button btn_ProductManagment;
        private Panel pnlNavbar;
        private Label lblDateTime;
        private PictureBox pictureBox1;
        private Label lblUsername;
        private Button Home;
        private Button but_newSale;
        private Label lbl_role;
        private Button button1;
        private FlowLayoutPanel Admin_pannel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox9;
        private Button button2;
    }
}