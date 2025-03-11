namespace InventoryManagementSystem.Admin_Controls
{
    partial class StockTransaction
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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            dgv_ShowData = new DataGridView();
            btn_search = new Button();
            Print = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).BeginInit();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(195, 98);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(481, 98);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 1;
            // 
            // dgv_ShowData
            // 
            dgv_ShowData.BackgroundColor = Color.RosyBrown;
            dgv_ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowData.Location = new Point(3, 147);
            dgv_ShowData.Name = "dgv_ShowData";
            dgv_ShowData.RowHeadersWidth = 51;
            dgv_ShowData.Size = new Size(1072, 601);
            dgv_ShowData.TabIndex = 2;
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ActiveCaption;
            btn_search.Location = new Point(782, 98);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 3;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // Print
            // 
            Print.BackColor = SystemColors.ActiveCaption;
            Print.Location = new Point(939, 96);
            Print.Name = "Print";
            Print.Size = new Size(94, 29);
            Print.TabIndex = 4;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = false;
            Print.Click += Print_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(309, 0);
            label1.Name = "label1";
            label1.Size = new Size(444, 46);
            label1.TabIndex = 5;
            label1.Text = "Stock Transections Summary";
            // 
            // StockTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(Print);
            Controls.Add(btn_search);
            Controls.Add(dgv_ShowData);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Name = "StockTransaction";
            Size = new Size(1091, 751);
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private DataGridView dgv_ShowData;
        private Button btn_search;
        private Button Print;
        private Label label1;
    }
}
