namespace InventoryManagementSystem.Admin_Controls
{
    partial class NewSale
    {
        // ... existing code ...

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ucontrol_Products));

            la = new Label();
            txt_cus = new TextBox();
            dataGridView1 = new DataGridView();
            but_saveSale = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // la
            // 
            la.Font = new Font("Segoe UI", 11F);
            la.ForeColor = Color.FromArgb(9, 111, 187);
            la.Location = new Point(377, 40);
            la.Name = "la";
            la.Size = new Size(123, 20);
            la.TabIndex = 5;
            la.Text = "Order Sale";
            la.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_cus
            // 
            txt_cus.Location = new Point(12, 99);
            txt_cus.Multiline = true;
            txt_cus.Name = "txt_cus";
            txt_cus.PlaceholderText = "Type Customer Name";
            txt_cus.Size = new Size(469, 28);
            txt_cus.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom;
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-7, 150);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(976, 163);
            dataGridView1.TabIndex = 7;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // but_saveSale
            // 
            but_saveSale.Location = new Point(527, 104);
            but_saveSale.Name = "but_saveSale";
            but_saveSale.Size = new Size(75, 23);
            but_saveSale.TabIndex = 8;
            but_saveSale.Text = "Save";
            but_saveSale.UseVisualStyleBackColor = true;
            but_saveSale.Click += but_saveSale_Click;
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 462);
            this.Controls.Add(but_saveSale);
            this.Controls.Add(dataGridView1);
            this.Controls.Add(txt_cus);
            this.Controls.Add(la);
            this.Name = "NewSale";
            this.Text = "NewSale";
            this.Resize += NewSale_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.ComponentModel.IContainer components;
        private Label la;
        private TextBox txt_cus;
        private DataGridView dataGridView1;
        private Button but_saveSale;
        private System.Drawing.SizeF AutoScaleDimensions;
        private System.Windows.Forms.AutoScaleMode AutoScaleMode;
    }
}