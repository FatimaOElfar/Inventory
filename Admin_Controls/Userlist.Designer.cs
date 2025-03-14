namespace InventoryManagementSystem.Admin_Controls
{
    partial class Userlist
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
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).BeginInit();
            SuspendLayout();
            // 
            // dgv_ShowData
            // 
            dgv_ShowData.BackgroundColor = SystemColors.GradientActiveCaption;
            dgv_ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowData.Location = new Point(13, 228);
            dgv_ShowData.Name = "dgv_ShowData";
            dgv_ShowData.RowHeadersWidth = 51;
            dgv_ShowData.Size = new Size(1263, 760);
            dgv_ShowData.TabIndex = 2;
       
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(524, 31);
            label6.Name = "label6";
            label6.Size = new Size(234, 46);
            label6.TabIndex = 22;
            label6.Text = "User Accounts";
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(63, 173);
            button1.Name = "button1";
            button1.Size = new Size(177, 49);
            button1.TabIndex = 23;
            button1.Text = "New Customer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Userlist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dgv_ShowData);
            Name = "Userlist";
            Size = new Size(1359, 991);
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgv_ShowData;

        public Userlist(DataGridView dgv_ShowData)
        {
            this.dgv_ShowData = dgv_ShowData;
        }

        private Label label6;
        private Button button1;
    }
}
#endregion