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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ucontrol_Products));
            dgv_ShowData = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            la = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            txt_name = new TextBox();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            txt_id = new TextBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            cb_supplier = new ComboBox();
            cb_category = new ComboBox();
            btn_Edit = new Button();
            btn_remove = new Button();
            btn_save = new Button();
            txt_quantity = new TextBox();
            txt_price = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_ShowData
            // 
            dgv_ShowData.BackgroundColor = Color.RosyBrown;
            dgv_ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowData.Location = new Point(3, 320);
            dgv_ShowData.Name = "dgv_ShowData";
            dgv_ShowData.RowHeadersWidth = 51;
            dgv_ShowData.Size = new Size(1115, 342);
            dgv_ShowData.TabIndex = 0;
            dgv_ShowData.RowHeaderMouseDoubleClick += dgv_ShowData_RowHeaderMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 10);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "ProductID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 212);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Product Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 109);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 3;
            label4.Text = "Product Supplier:";
            // 
            // la
            // 
            la.AutoSize = true;
            la.Location = new Point(507, 10);
            la.Name = "la";
            la.Size = new Size(123, 20);
            la.TabIndex = 4;
            la.Text = "Product Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(507, 212);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 5;
            label6.Text = "Product Category:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 109);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 6;
            label7.Text = "Product Name:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(43, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 43);
            panel1.TabIndex = 19;
            // 
            // txt_name
            // 
            txt_name.Dock = DockStyle.Top;
            txt_name.Location = new Point(0, 0);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(287, 46);
            txt_name.TabIndex = 12;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Dock = DockStyle.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(287, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_id);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(43, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 43);
            panel2.TabIndex = 20;
            // 
            // txt_id
            // 
            txt_id.Dock = DockStyle.Top;
            txt_id.Location = new Point(0, 0);
            txt_id.Multiline = true;
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(287, 43);
            txt_id.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(cb_supplier);
            panel3.Controls.Add(cb_category);
            panel3.Controls.Add(btn_Edit);
            panel3.Controls.Add(btn_remove);
            panel3.Controls.Add(btn_save);
            panel3.Controls.Add(txt_quantity);
            panel3.Controls.Add(txt_price);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(la);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dgv_ShowData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1121, 668);
            panel3.TabIndex = 2;
            // 
            // cb_supplier
            // 
            cb_supplier.FormattingEnabled = true;
            cb_supplier.Location = new Point(507, 163);
            cb_supplier.Name = "cb_supplier";
            cb_supplier.Size = new Size(319, 28);
            cb_supplier.TabIndex = 28;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(507, 245);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(319, 28);
            cb_category.TabIndex = 27;
            // 
            // btn_Edit
            // 
            btn_Edit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Edit.ForeColor = Color.FromArgb(9, 111, 187);
            btn_Edit.Location = new Point(898, 123);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(157, 58);
            btn_Edit.TabIndex = 26;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            //btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_remove
            // 
            btn_remove.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove.ForeColor = Color.FromArgb(9, 111, 187);
            btn_remove.Location = new Point(898, 212);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(157, 58);
            btn_remove.TabIndex = 25;
            btn_remove.Text = "remove";
            btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.FromArgb(9, 111, 187);
            btn_save.Location = new Point(898, 40);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(157, 58);
            btn_save.TabIndex = 24;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(507, 40);
            txt_quantity.Multiline = true;
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(319, 46);
            txt_quantity.TabIndex = 23;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(43, 245);
            txt_price.Multiline = true;
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(335, 46);
            txt_price.TabIndex = 21;
            // 
            // Ucontrol_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "Ucontrol_Products";
            Size = new Size(1121, 668);
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ShowData;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label la;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private TextBox txt_name;
        private PictureBox pictureBox4;
        private Panel panel2;
        private TextBox txt_id;
        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox txt_price;
        private TextBox txt_quantity;
        private Button btn_Edit;
        private Button btn_remove;
        private Button btn_save;
        private ComboBox cb_category;
        private ComboBox cb_supplier;
    }
}
