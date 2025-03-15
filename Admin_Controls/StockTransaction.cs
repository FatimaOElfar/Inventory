using InventoryManagementSystem.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Data;

//print
using System.Drawing;
using System.Drawing.Printing;

namespace InventoryManagementSystem.Admin_Controls
{
    public partial class StockTransaction : UserControl
    {

        InventoryDbContext context;
        private StockTransactionService service;
        private PrintDocument printDocument = new PrintDocument();
        private Bitmap bitmap;

        public StockTransaction()
        {
            InitializeComponent();
            context = new InventoryDbContext();
            service = new StockTransactionService();

            loadStockTransaction();
        }
        private void loadStockTransaction()
        {
            var stocks = service.getAllStockTransactions();
            dgv_ShowData.DataSource = stocks;
            ApplyGridViewStyle();
        }
        private void LoadStockSummary()
        {
            try
            {
                var startDate = dtpStartDate.Value.Date;
                var endDate = dtpEndDate.Value.Date;


                var stockSummary = context.StockTransactions
                    .Where(st => st.TransactionDate >= startDate && st.TransactionDate <= endDate)
                    .Include(st => st.Product)
                    .Select(st => new
                    {
                        st.Id,
                        ProductName = st.Product.Name,
                        st.Quantity,
                        TransactionType = st.TransactionType.ToString(),
                        TransactionDate = st.TransactionDate.ToString("yyyy-MM-dd")
                    })
                    .ToList();

                dgv_ShowData.DataSource = stockSummary;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadStockSummary();

        }
        private void ApplyGridViewStyle()
        {

            dgv_ShowData.Font = new Font("Segoe UI", 8);


            dgv_ShowData.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dgv_ShowData.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // Set the default row style
            dgv_ShowData.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_ShowData.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Set the header style
            dgv_ShowData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv_ShowData.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_ShowData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_ShowData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set the selection style
            dgv_ShowData.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgv_ShowData.DefaultCellStyle.SelectionForeColor = Color.White;

            // Customize grid lines
            dgv_ShowData.GridColor = Color.Gray;
            dgv_ShowData.BorderStyle = BorderStyle.None;

            // Enable row headers and customize their appearance
            dgv_ShowData.RowHeadersVisible = true;
            dgv_ShowData.RowHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_ShowData.RowHeadersDefaultCellStyle.ForeColor = Color.White;

            // Auto-size columns to fit the content
            dgv_ShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable user resizing of rows and columns
            dgv_ShowData.AllowUserToResizeRows = false;
            dgv_ShowData.AllowUserToResizeColumns = false;

            // Enable row selection by clicking anywhere on the row
            dgv_ShowData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Disable multi-row selection
            dgv_ShowData.MultiSelect = false;

            // Add padding to cells
            dgv_ShowData.DefaultCellStyle.Padding = new Padding(5);


        }

        private void Print_Click(object sender, EventArgs e)
        {
            // make a image from DataGridView
            int width = dgv_ShowData.Width;
            int height = dgv_ShowData.Height;
            bitmap = new Bitmap(width, height);
            dgv_ShowData.DrawToBitmap(bitmap, new Rectangle(0, 0, width, height));


            // prepare printer to open with thw image of dgv
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintPreviewDialog printPreview = new PrintPreviewDialog
            {
                Document = printDocument
            };
            printPreview.ShowDialog();
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

    }
}
