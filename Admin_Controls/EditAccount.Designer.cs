namespace InventoryManagementSystem.Admin_Controls
{
    partial class EditAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccount));
            txt_new_pass = new TextBox();
            btnSave = new Button();
            label2 = new Label();
            lbl_role = new Label();
            txt_old_psss = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_new_pass
            // 
            txt_new_pass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_new_pass.Location = new Point(287, 623);
            txt_new_pass.Multiline = true;
            txt_new_pass.Name = "txt_new_pass";
            txt_new_pass.PlaceholderText = "New Password...";
            txt_new_pass.Size = new Size(334, 53);
            txt_new_pass.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(3, 68, 136);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(214, 730);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(358, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(3, 68, 136);
            label2.Location = new Point(96, 635);
            label2.Name = "label2";
            label2.Size = new Size(157, 30);
            label2.TabIndex = 6;
            label2.Text = "New Password";
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.BackColor = Color.FromArgb(3, 68, 136);
            lbl_role.Font = new Font("Arial Rounded MT Bold", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_role.ForeColor = Color.White;
            lbl_role.Location = new Point(180, 17);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(392, 49);
            lbl_role.TabIndex = 8;
            lbl_role.Text = "Change Password";
            // 
            // txt_old_psss
            // 
            txt_old_psss.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_old_psss.Location = new Point(287, 517);
            txt_old_psss.Multiline = true;
            txt_old_psss.Name = "txt_old_psss";
            txt_old_psss.PlaceholderText = "Your Current Password...";
            txt_old_psss.Size = new Size(334, 53);
            txt_old_psss.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(3, 68, 136);
            label1.Location = new Point(77, 530);
            label1.Name = "label1";
            label1.Size = new Size(187, 30);
            label1.TabIndex = 5;
            label1.Text = "Current Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_new_pass);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txt_old_psss);
            panel1.Location = new Point(311, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 816);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 68, 136);
            panel2.Controls.Add(lbl_role);
            panel2.Location = new Point(0, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 86);
            panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 364);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // EditAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 68, 136);
            Controls.Add(panel1);
            Name = "EditAccount";
            Size = new Size(1359, 843);
            Load += EditAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txt_new_pass;
        private Button btnSave;
        private Label label2;
        private Label lbl_role;
        private TextBox txt_old_psss;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}
