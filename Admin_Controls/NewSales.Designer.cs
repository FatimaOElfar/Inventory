namespace InventoryManagementSystem.Admin_Controls
{
    partial class NewSales
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
            dgv_ShowData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).BeginInit();
            SuspendLayout();
            // 
            // dgv_ShowData
            // 
            dgv_ShowData.BackgroundColor = Color.RosyBrown;
            dgv_ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowData.Location = new Point(92, 77);
            dgv_ShowData.Margin = new Padding(3, 2, 3, 2);
            dgv_ShowData.Name = "dgv_ShowData";
            dgv_ShowData.RowHeadersWidth = 51;
            dgv_ShowData.Size = new Size(745, 256);
            dgv_ShowData.TabIndex = 2;
            // 
            // NewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(dgv_ShowData);
            this.Name = "NewSales";
            this.Size = new Size(1000, 466);
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ShowData;
        private System.Drawing.SizeF AutoScaleDimensions;
        private System.Windows.Forms.AutoScaleMode AutoScaleMode;
    }
}
