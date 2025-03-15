using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Services;
using InventoryManagementSystem.Models;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using InventoryManagementSystem.Data;

namespace InventoryManagementSystem.Admin_Controls
{
    public partial class ReportsControl : UserControl
    {
        private readonly ProductService _productService;
        private readonly SaleService _saleService;

        public ReportsControl()
        {
            InitializeComponent();
            _productService = new ProductService();
            _saleService = new SaleService();
            InitializeReportTypeComboBox();
        }

        private void InitializeReportTypeComboBox()
        {
            cmbReportType.Items.Add("Current Stock Levels");
            cmbReportType.Items.Add("Monthly Sales Performance");
            cmbReportType.Items.Add("Low-Stock Products");
            cmbReportType.Items.Add("Most Sold Products");
            cmbReportType.SelectedIndex = 0;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedItem == null)
            {
                MessageBox.Show("Please select a report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedReport = cmbReportType.SelectedItem.ToString();
            switch (selectedReport)
            {
                case "Current Stock Levels":
                    LoadStockLevelsReport();
                    break;
                case "Monthly Sales Performance":
                    LoadMonthlySalesReport();
                    break;
                case "Low-Stock Products":
                    LoadLowStockReport();
                    break;
                case "Most Sold Products":
                    LoadMostSoldProductsReport();
                    break;
                default:
                    MessageBox.Show("Invalid report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void LoadStockLevelsReport()
        {
            using (var context = new InventoryDbContext())
            {
                dgvReport.DataSource = context.Products
                    .Select(p => new { p.Name, p.StockQuantity })
                    .ToList();
            }
        }

        private void LoadMonthlySalesReport()
        {
            using (var context = new InventoryDbContext())
            {
                dgvReport.DataSource = context.Sales
                    .OrderByDescending(s => s.SaleDate)
                    .Take(10) // آخر 10 مبيعات فقط للسرعة
                    .Select(s => new { s.Product.Name, s.Quantity, s.TotalPrice, s.SaleDate })
                    .ToList();
            }
        }

        private void LoadLowStockReport()
        {
            using (var context = new InventoryDbContext())
            {
                dgvReport.DataSource = context.Products
                    .Where(p => p.StockQuantity < 10)
                    .Select(p => new { p.Name, p.StockQuantity })
                    .ToList();
            }
        }

        private void LoadMostSoldProductsReport()
        {
            using (var context = new InventoryDbContext())
            {
                dgvReport.DataSource = context.Sales
                    .GroupBy(s => s.Product.Name)
                    .Select(g => new { Product = g.Key, TotalSold = g.Sum(s => s.Quantity) })
                    .OrderByDescending(g => g.TotalSold)
                    .ToList();
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Save Report"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToPDF(dgvReport, saveFileDialog.FileName);
                MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportDataGridViewToPDF(DataGridView dgv, string filePath)
        {
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            PdfPTable table = new PdfPTable(dgv.Columns.Count);
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                table.AddCell(new Phrase(column.HeaderText));
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                    }
                }
            }

            doc.Add(table);
            doc.Close();
        }
    }
}
