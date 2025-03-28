﻿namespace InventoryManagementSystem
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
            btnGenerateQR = new Button();
            pb_QRCode = new PictureBox();
            Products = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_QRCode).BeginInit();
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
            dgv_ShowData.Location = new Point(0, 444);
            dgv_ShowData.Margin = new Padding(3, 2, 3, 2);
            dgv_ShowData.Name = "dgv_ShowData";
            dgv_ShowData.ReadOnly = true;
            dgv_ShowData.RowHeadersWidth = 51;
            dgv_ShowData.Size = new Size(1186, 290);
            dgv_ShowData.TabIndex = 0;
            dgv_ShowData.RowHeaderMouseDoubleClick += dgv_ShowData_RowHeaderMouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(9, 111, 187);
            label3.Location = new Point(298, 134);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 2;
            label3.Text = "Product Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(9, 111, 187);
            label4.Location = new Point(298, 363);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 3;
            label4.Text = "Product Supplier:";
            // 
            // la
            // 
            la.AutoSize = true;
            la.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la.ForeColor = Color.FromArgb(9, 111, 187);
            la.Location = new Point(296, 286);
            la.Name = "la";
            la.Size = new Size(138, 21);
            la.TabIndex = 4;
            la.Text = "Product Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(9, 111, 187);
            label6.Location = new Point(298, 214);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 5;
            label6.Text = "Product Category:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(9, 111, 187);
            label7.Location = new Point(298, 50);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 6;
            label7.Text = "Product Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnGenerateQR);
            panel3.Controls.Add(pb_QRCode);
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
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1189, 743);
            panel3.TabIndex = 2;
            // 
            // btnGenerateQR
            // 
            btnGenerateQR.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateQR.ForeColor = Color.FromArgb(9, 111, 187);
            btnGenerateQR.Location = new Point(76, 214);
            btnGenerateQR.Margin = new Padding(3, 2, 3, 2);
            btnGenerateQR.Name = "btnGenerateQR";
            btnGenerateQR.Size = new Size(157, 44);
            btnGenerateQR.TabIndex = 36;
            btnGenerateQR.Text = "Generate QR";
            btnGenerateQR.UseVisualStyleBackColor = true;
            btnGenerateQR.Click += btnGenerateQR_Click;
            // 
            // pb_QRCode
            // 
            pb_QRCode.BackgroundImageLayout = ImageLayout.Stretch;
            pb_QRCode.Location = new Point(59, 59);
            pb_QRCode.Name = "pb_QRCode";
            pb_QRCode.Size = new Size(184, 150);
            pb_QRCode.TabIndex = 35;
            pb_QRCode.TabStop = false;
            // 
            // Products
            // 
            Products.AutoSize = true;
            Products.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Products.ForeColor = Color.FromArgb(9, 111, 187);
            Products.Location = new Point(11, 10);
            Products.Name = "Products";
            Products.Size = new Size(218, 46);
            Products.TabIndex = 34;
            Products.Text = "Products List";
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.FromArgb(9, 111, 187);
            btn_clear.Location = new Point(745, 98);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(157, 44);
            btn_clear.TabIndex = 33;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_category
            // 
            txt_category.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_category.Location = new Point(298, 246);
            txt_category.Margin = new Padding(3, 2, 3, 2);
            txt_category.Multiline = true;
            txt_category.Name = "txt_category";
            txt_category.PlaceholderText = "Product Category";
            txt_category.Size = new Size(278, 33);
            txt_category.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_name_search);
            panel1.Controls.Add(search_picture);
            panel1.Location = new Point(298, 88);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 32);
            panel1.TabIndex = 30;
            // 
            // txt_name_search
            // 
            txt_name_search.Dock = DockStyle.Top;
            txt_name_search.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name_search.Location = new Point(0, 0);
            txt_name_search.Margin = new Padding(3, 2, 3, 2);
            txt_name_search.Multiline = true;
            txt_name_search.Name = "txt_name_search";
            txt_name_search.PlaceholderText = "Search Product By name";
            txt_name_search.Size = new Size(235, 36);
            txt_name_search.TabIndex = 12;
            // 
            // search_picture
            // 
            search_picture.BackColor = Color.Transparent;
            search_picture.BackgroundImageLayout = ImageLayout.Zoom;
            search_picture.BorderStyle = BorderStyle.Fixed3D;
            search_picture.Dock = DockStyle.Right;
            search_picture.Image = (Image)resources.GetObject("search_picture.Image");
            search_picture.Location = new Point(235, 0);
            search_picture.Margin = new Padding(3, 2, 3, 2);
            search_picture.Name = "search_picture";
            search_picture.Size = new Size(42, 32);
            search_picture.SizeMode = PictureBoxSizeMode.Zoom;
            search_picture.TabIndex = 16;
            search_picture.TabStop = false;
            search_picture.Click += search_picture_Click;
            // 
            // cb_supplier
            // 
            cb_supplier.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_supplier.FormattingEnabled = true;
            cb_supplier.Location = new Point(298, 397);
            cb_supplier.Margin = new Padding(3, 2, 3, 2);
            cb_supplier.Name = "cb_supplier";
            cb_supplier.Size = new Size(278, 29);
            cb_supplier.TabIndex = 28;
            // 
            // btn_Edit
            // 
            btn_Edit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Edit.ForeColor = Color.FromArgb(9, 111, 187);
            btn_Edit.Location = new Point(745, 275);
            btn_Edit.Margin = new Padding(3, 2, 3, 2);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(157, 44);
            btn_Edit.TabIndex = 26;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click_1;
            // 
            // btn_remove
            // 
            btn_remove.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove.ForeColor = Color.FromArgb(9, 111, 187);
            btn_remove.Location = new Point(745, 363);
            btn_remove.Margin = new Padding(3, 2, 3, 2);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(157, 44);
            btn_remove.TabIndex = 25;
            btn_remove.Text = "remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.FromArgb(9, 111, 187);
            btn_save.Location = new Point(745, 178);
            btn_save.Margin = new Padding(3, 2, 3, 2);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(157, 44);
            btn_save.TabIndex = 24;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txt_quantity
            // 
            txt_quantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_quantity.Location = new Point(298, 321);
            txt_quantity.Margin = new Padding(3, 2, 3, 2);
            txt_quantity.Multiline = true;
            txt_quantity.Name = "txt_quantity";
            txt_quantity.PlaceholderText = "Product Quantity";
            txt_quantity.Size = new Size(278, 33);
            txt_quantity.TabIndex = 23;
            // 
            // txt_price
            // 
            txt_price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_price.Location = new Point(298, 166);
            txt_price.Margin = new Padding(3, 2, 3, 2);
            txt_price.Multiline = true;
            txt_price.Name = "txt_price";
            txt_price.PlaceholderText = "Product Price";
            txt_price.Size = new Size(278, 33);
            txt_price.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Ucontrol_Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ucontrol_Products";
            Size = new Size(1189, 743);
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_QRCode).EndInit();
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
        private Button btnGenerateQR;
        private PictureBox pb_QRCode;
    } }
