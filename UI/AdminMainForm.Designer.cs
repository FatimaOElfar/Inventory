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
            label6 = new Label();
            label5 = new Label();
            btn_StockTransaction = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Home = new Button();
            label1 = new Label();
            btn_Reports = new Button();
            btn_Suppliers = new Button();
            btn_Sale = new Button();
            btn_ProductManagment = new Button();
            btn_UserManagment = new Button();
            Admin_pannel = new Panel();
            pnlNavbar = new Panel();
            lbl_role = new Label();
            exit = new PictureBox();
            lblUsername = new Label();
            pictureBox1 = new PictureBox();
            lblDateTime = new Label();
            panel1.SuspendLayout();
            pnlNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_StockTransaction);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Home);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Reports);
            panel1.Controls.Add(btn_Suppliers);
            panel1.Controls.Add(btn_Sale);
            panel1.Controls.Add(btn_ProductManagment);
            panel1.Controls.Add(btn_UserManagment);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 862);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(12, 575);
            label6.Name = "label6";
            label6.Size = new Size(61, 28);
            label6.TabIndex = 13;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 461);
            label5.Name = "label5";
            label5.Size = new Size(58, 28);
            label5.TabIndex = 12;
            label5.Text = "Sales";
            // 
            // btn_StockTransaction
            // 
            btn_StockTransaction.BackColor = Color.WhiteSmoke;
            btn_StockTransaction.Location = new Point(18, 606);
            btn_StockTransaction.Name = "btn_StockTransaction";
            btn_StockTransaction.Size = new Size(302, 53);
            btn_StockTransaction.TabIndex = 4;
            btn_StockTransaction.Text = "Stock Transaction";
            btn_StockTransaction.UseVisualStyleBackColor = false;
            btn_StockTransaction.Click += btn_StockTransaction_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(8, 374);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 11;
            label4.Text = "Suppliers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(6, 160);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 10;
            label3.Text = "Customers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 261);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 9;
            label2.Text = "Products";
            // 
            // Home
            // 
            Home.BackColor = Color.Transparent;
            Home.Location = new Point(3, 104);
            Home.Name = "Home";
            Home.Size = new Size(327, 53);
            Home.TabIndex = 7;
            Home.Text = "Dashboard";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(327, 88);
            label1.TabIndex = 6;
            label1.Text = "Welcome to Inventory Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Reports
            // 
            btn_Reports.BackColor = Color.RosyBrown;
            btn_Reports.Location = new Point(18, 695);
            btn_Reports.Name = "btn_Reports";
            btn_Reports.Size = new Size(302, 53);
            btn_Reports.TabIndex = 2;
            btn_Reports.Text = "Sales Reports";
            btn_Reports.UseVisualStyleBackColor = false;
            // 
            // btn_Suppliers
            // 
            btn_Suppliers.BackColor = Color.Transparent;
            btn_Suppliers.Location = new Point(12, 405);
            btn_Suppliers.Name = "btn_Suppliers";
            btn_Suppliers.Size = new Size(308, 53);
            btn_Suppliers.TabIndex = 5;
            btn_Suppliers.Text = "Suppliers Management";
            btn_Suppliers.UseVisualStyleBackColor = false;
            btn_Suppliers.Click += btn_Suppliers_Click;
            // 
            // btn_Sale
            // 
            btn_Sale.BackColor = Color.RosyBrown;
            btn_Sale.Location = new Point(18, 509);
            btn_Sale.Name = "btn_Sale";
            btn_Sale.Size = new Size(302, 53);
            btn_Sale.TabIndex = 3;
            btn_Sale.Text = "Sales Management";
            btn_Sale.UseVisualStyleBackColor = false;
            btn_Sale.Click += btn_Sale_Click;
            // 
            // btn_ProductManagment
            // 
            btn_ProductManagment.BackColor = Color.Transparent;
            btn_ProductManagment.Location = new Point(6, 301);
            btn_ProductManagment.Name = "btn_ProductManagment";
            btn_ProductManagment.Size = new Size(324, 53);
            btn_ProductManagment.TabIndex = 2;
            btn_ProductManagment.Text = "Product Mangement";
            btn_ProductManagment.UseVisualStyleBackColor = false;
            btn_ProductManagment.Click += btn_ProductManagment_Click;
            // 
            // btn_UserManagment
            // 
            btn_UserManagment.BackColor = Color.Transparent;
            btn_UserManagment.Location = new Point(3, 205);
            btn_UserManagment.Name = "btn_UserManagment";
            btn_UserManagment.Size = new Size(327, 53);
            btn_UserManagment.TabIndex = 1;
            btn_UserManagment.Text = "Customer Management";
            btn_UserManagment.UseVisualStyleBackColor = false;
            btn_UserManagment.Click += btn_UserManagment_Click;
            // 
            // Admin_pannel
            // 
            Admin_pannel.BackColor = Color.White;
            Admin_pannel.Location = new Point(351, 81);
            Admin_pannel.Name = "Admin_pannel";
            Admin_pannel.Size = new Size(1390, 769);
            Admin_pannel.TabIndex = 1;
            Admin_pannel.Paint += Admin_pannel_Paint;
            // 
            // pnlNavbar
            // 
            pnlNavbar.BackColor = Color.Black;
            pnlNavbar.Controls.Add(lbl_role);
            pnlNavbar.Controls.Add(exit);
            pnlNavbar.Controls.Add(lblUsername);
            pnlNavbar.Controls.Add(pictureBox1);
            pnlNavbar.Controls.Add(lblDateTime);
            pnlNavbar.Dock = DockStyle.Top;
            pnlNavbar.Location = new Point(333, 0);
            pnlNavbar.Name = "pnlNavbar";
            pnlNavbar.Size = new Size(1420, 68);
            pnlNavbar.TabIndex = 2;
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbl_role.ForeColor = Color.RosyBrown;
            lbl_role.Location = new Point(517, 19);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(66, 35);
            lbl_role.TabIndex = 3;
            lbl_role.Text = "Role";
            lbl_role.Click += lbl_role_Click;
            // 
            // exit
            // 
            exit.BackgroundImage = (Image)resources.GetObject("exit.BackgroundImage");
            exit.BackgroundImageLayout = ImageLayout.Stretch;
            exit.Location = new Point(1364, 17);
            exit.Name = "exit";
            exit.Size = new Size(44, 35);
            exit.TabIndex = 0;
            exit.TabStop = false;
            exit.Click += exit_Click_1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.RosyBrown;
            lblUsername.Location = new Point(1008, 27);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(48, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(917, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 11F);
            lblDateTime.ForeColor = Color.RosyBrown;
            lblDateTime.Location = new Point(71, 27);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(49, 25);
            lblDateTime.TabIndex = 0;
            lblDateTime.Text = "time";
            lblDateTime.Click += lblDateTime_Click;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1753, 862);
            Controls.Add(pnlNavbar);
            Controls.Add(Admin_pannel);
            Controls.Add(panel1);
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += AdminMainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlNavbar.ResumeLayout(false);
            pnlNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_UserManagment;
        private Label label1;
        private Button btn_Reports;
        private Button btn_Suppliers;
        private Button btn_StockTransaction;
        private Button btn_Sale;
        private Button btn_ProductManagment;
        private Panel Admin_pannel;
        private Panel pnlNavbar;
        private Label lblDateTime;
        private PictureBox pictureBox1;
        private Label lblUsername;
        private Button Home;
        private PictureBox exit;
        private Label label3;
        private Label label2;
        private Label lbl_role;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}