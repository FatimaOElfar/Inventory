namespace InventoryManagementSystem.Admin_Controls
{
    partial class ReportsControl
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
            dgvReport = new DataGridView();
            cmbReportType = new ComboBox();
            label1 = new Label();
            btnGenerateReport = new Button();
            btnExportPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // dgvReport
            // 
            dgvReport.BackgroundColor = Color.RosyBrown;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(3, 362);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(1015, 303);
            dgvReport.TabIndex = 0;
            // 
            // cmbReportType
            // 
            cmbReportType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(205, 50);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(300, 36);
            cmbReportType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(68, 50);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 2;
            label1.Text = "Report Type";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.Green;
            btnGenerateReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = SystemColors.ButtonHighlight;
            btnGenerateReport.Location = new Point(556, 50);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(195, 39);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.DarkRed;
            btnExportPDF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportPDF.ForeColor = SystemColors.ButtonHighlight;
            btnExportPDF.Location = new Point(828, 300);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(169, 39);
            btnExportPDF.TabIndex = 4;
            btnExportPDF.Text = "Export To PDF";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // ReportsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExportPDF);
            Controls.Add(btnGenerateReport);
            Controls.Add(label1);
            Controls.Add(cmbReportType);
            Controls.Add(dgvReport);
            Name = "ReportsControl";
            Size = new Size(1021, 668);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReport;
        private ComboBox cmbReportType;
        private Label label1;
        private Button btnGenerateReport;
        private Button btnExportPDF;
    }
}
