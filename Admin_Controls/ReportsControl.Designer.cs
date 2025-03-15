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
            cmbReportType = new ComboBox();
            label1 = new Label();
            btnGenerateReport = new Button();
            btnExportPDF = new Button();
            dgvReport = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // cmbReportType
            // 
            cmbReportType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(216, 89);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(301, 36);
            cmbReportType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(64, 89);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 1;
            label1.Text = "Report Type";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = SystemColors.HotTrack;
            btnGenerateReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = SystemColors.ButtonHighlight;
            btnGenerateReport.Location = new Point(555, 84);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(201, 40);
            btnGenerateReport.TabIndex = 2;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.DarkRed;
            btnExportPDF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportPDF.ForeColor = SystemColors.ButtonHighlight;
            btnExportPDF.Location = new Point(914, 344);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(166, 40);
            btnExportPDF.TabIndex = 3;
            btnExportPDF.Text = "Export to PDF";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // dgvReport
            // 
            dgvReport.BackgroundColor = SystemColors.MenuBar;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.GridColor = SystemColors.MenuText;
            dgvReport.Location = new Point(3, 400);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(1086, 348);
            dgvReport.TabIndex = 4;
            // 
            // ReportsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvReport);
            Controls.Add(btnExportPDF);
            Controls.Add(btnGenerateReport);
            Controls.Add(label1);
            Controls.Add(cmbReportType);
            Name = "ReportsControl";
            Size = new Size(1092, 751);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbReportType;
        private Label label1;
        private Button btnGenerateReport;
        private Button btnExportPDF;
        private DataGridView dgvReport;
    }
}
