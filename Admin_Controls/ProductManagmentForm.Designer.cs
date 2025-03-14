namespace InventoryManagementSystem
{
    partial class Ucontrol_Products
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ucontrol_Products));
            dgv_ShowData = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            la = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            btn_clear = new Button();
            txt_category = new TextBox();
            panel1 = new Panel();
            txt_name_search = new TextBox();
            search_picture = new PictureBox();
            cb_supplier = new ComboBox();
            btn_Edit = new Button();
            btn_remove = new Button();
            btn_save = new Button();
            txt_quantity = new TextBox();
            txt_price = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Products = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)search_picture).BeginInit();
            SuspendLayout();
            // 
            // dgv_ShowData
            // 
            dgv_ShowData.AllowUserToAddRows = false;
            dgv_ShowData.AllowUserToDeleteRows = false;
            dgv_ShowData.BackgroundColor = Color.FromArgb(3, 68, 136);
            dgv_ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowData.Location = new Point(0, 592);
            dgv_ShowData.Name = "dgv_ShowData";
            dgv_ShowData.ReadOnly = true;
            dgv_ShowData.RowHeadersWidth = 51;
            dgv_ShowData.Size = new Size(1355, 387);
            dgv_ShowData.TabIndex = 0;
            dgv_ShowData.RowHeaderMouseDoubleClick += dgv_ShowData_RowHeaderMouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(9, 111, 187);
            label3.Location = new Point(340, 178);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 2;
            label3.Text = "Product Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(9, 111, 187);
            label4.Location = new Point(340, 484);
            label4.Name = "label4";
            label4.Size = new Size(170, 28);
            label4.TabIndex = 3;
            label4.Text = "Product Supplier:";
            // 
            // la
            // 
            la.AutoSize = true;
            la.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la.ForeColor = Color.FromArgb(9, 111, 187);
            la.Location = new Point(338, 381);
            la.Name = "la";
            la.Size = new Size(172, 28);
            la.TabIndex = 4;
            la.Text = "Product Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(9, 111, 187);
            label6.Location = new Point(340, 285);
            label6.Name = "label6";
            label6.Size = new Size(176, 25);
            label6.TabIndex = 5;
            label6.Text = "Product Category:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(9, 111, 187);
            label7.Location = new Point(340, 67);
            label7.Name = "label7";
            label7.Size = new Size(146, 25);
            label7.TabIndex = 6;
            label7.Text = "Product Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(Products);
            panel3.Controls.Add(btn_clear);
            panel3.Controls.Add(txt_category);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(cb_supplier);
            panel3.Controls.Add(btn_Edit);
            panel3.Controls.Add(btn_remove);
            panel3.Controls.Add(btn_save);
            panel3.Controls.Add(txt_quantity);
            panel3.Controls.Add(txt_price);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(la);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dgv_ShowData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1359, 991);
            panel3.TabIndex = 2;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.FromArgb(9, 111, 187);
            btn_clear.Location = new Point(851, 131);
            btn_clear.Margin = new Padding(3, 4, 3, 4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(179, 59);
            btn_clear.TabIndex = 33;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_category
            // 
            txt_category.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_category.Location = new Point(340, 328);
            txt_category.Multiline = true;
            txt_category.Name = "txt_category";
            txt_category.PlaceholderText = "Product Category";
            txt_category.Size = new Size(317, 43);
            txt_category.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_name_search);
            panel1.Controls.Add(search_picture);
            panel1.Location = new Point(340, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 43);
            panel1.TabIndex = 30;
            // 
            // txt_name_search
            // 
            txt_name_search.Dock = DockStyle.Top;
            txt_name_search.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name_search.Location = new Point(0, 0);
            txt_name_search.Multiline = true;
            txt_name_search.Name = "txt_name_search";
            txt_name_search.PlaceholderText = "Search Product By name";
            txt_name_search.Size = new Size(270, 47);
            txt_name_search.TabIndex = 12;
            // 
            // search_picture
            // 
            search_picture.BackColor = Color.Transparent;
            search_picture.BackgroundImageLayout = ImageLayout.Zoom;
            search_picture.BorderStyle = BorderStyle.Fixed3D;
            search_picture.Dock = DockStyle.Right;
            search_picture.Image = (Image)resources.GetObject("search_picture.Image");
            search_picture.Location = new Point(270, 0);
            search_picture.Name = "search_picture";
            search_picture.Size = new Size(47, 43);
            search_picture.SizeMode = PictureBoxSizeMode.Zoom;
            search_picture.TabIndex = 16;
            search_picture.TabStop = false;
            search_picture.Click += search_picture_Click;
            // 
            // cb_supplier
            // 
            cb_supplier.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_supplier.FormattingEnabled = true;
            cb_supplier.Location = new Point(340, 529);
            cb_supplier.Name = "cb_supplier";
            cb_supplier.Size = new Size(317, 36);
            cb_supplier.TabIndex = 28;
            // 
            // btn_Edit
            // 
            btn_Edit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Edit.ForeColor = Color.FromArgb(9, 111, 187);
            btn_Edit.Location = new Point(851, 367);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(179, 59);
            btn_Edit.TabIndex = 26;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click_1;
            // 
            // btn_remove
            // 
            btn_remove.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove.ForeColor = Color.FromArgb(9, 111, 187);
            btn_remove.Location = new Point(851, 484);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(179, 59);
            btn_remove.TabIndex = 25;
            btn_remove.Text = "remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.FromArgb(9, 111, 187);
            btn_save.Location = new Point(851, 237);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(179, 59);
            btn_save.TabIndex = 24;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txt_quantity
            // 
            txt_quantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_quantity.Location = new Point(340, 428);
            txt_quantity.Multiline = true;
            txt_quantity.Name = "txt_quantity";
            txt_quantity.PlaceholderText = "Product Quantity";
            txt_quantity.Size = new Size(317, 43);
            txt_quantity.TabIndex = 23;
            // 
            // txt_price
            // 
            txt_price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_price.Location = new Point(340, 222);
            txt_price.Multiline = true;
            txt_price.Name = "txt_price";
            txt_price.PlaceholderText = "Product Price";
            txt_price.Size = new Size(317, 43);
            txt_price.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Products
            // 
            Products.AutoSize = true;
            Products.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Products.ForeColor = Color.FromArgb(9, 111, 187);
            Products.Location = new Point(13, 13);
            Products.Name = "Products";
            Products.Size = new Size(271, 57);
            Products.TabIndex = 34;
            Products.Text = "Products List";
            // 
            // Ucontrol_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "Ucontrol_Products";
            Size = new Size(1359, 991);
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)search_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ShowData;
        private Label label3;
        private Label label4;
        private Label la;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private TextBox txt_price;
        private TextBox txt_quantity;
        private Button btn_Edit;
        private Button btn_remove;
        private Button btn_save;
        private ComboBox cb_supplier;
        private Panel panel1;
        private TextBox txt_name_search;
        private PictureBox search_picture;
        private TextBox txt_category;
        private Button btn_clear;
        private ContextMenuStrip contextMenuStrip1;
        private Label Products;
    } }
