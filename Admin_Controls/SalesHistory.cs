using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Admin_Controls
{
    public partial class SalesHistory : UserControl
    {
        private readonly SaleService _service;
        private readonly InventoryDbContext _context;
        public SalesHistory()
        {
            InitializeComponent();
            _service = new SaleService();
            _context = new InventoryDbContext();
            LoadData();
        }
        private void LoadData()
        {
            LoadSales();
        }

        private void LoadSales()
        {
            var products = _service.getAllSales();
            var formatSales = FormatSales(products);
            dgv_ShowData.DataSource = formatSales;
            ApplyGridViewStyle();
        }

        private List<object> FormatSales(List<Sale> sales)
        {
            return sales.Select(s => (object)new
            {
                s.Id,
                s.CustomerName,
                saleDate = s.SaleDate,
                s.ProductId,
                s.TotalPrice,
                s.UserId,
                Product = s.Product?.Name
            }).ToList();
        }

        public async Task<List<Sale>> GetFilteredSales(string? customerName, DateTime? startDate, DateTime? endDate)
        {
            var query = _context.Sales.AsQueryable();

            if (!string.IsNullOrEmpty(customerName))
            {
                query = query.Where(s => EF.Functions.Like(s.CustomerName, $"%{customerName}%"));
            }

            if (startDate.HasValue)
            {
                query = query.Where(s => s.SaleDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(s => s.SaleDate <= endDate.Value);
            }

            return await query.ToListAsync();
        }


        //private void ApplyGridViewStyle()
        //{

        //    dgv_ShowData.Font = new Font("Segoe UI", 10);


        //    dgv_ShowData.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
        //    dgv_ShowData.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

        //    // Set the default row style
        //    dgv_ShowData.RowsDefaultCellStyle.BackColor = Color.White;
        //    dgv_ShowData.RowsDefaultCellStyle.ForeColor = Color.Black;

        //    // Set the header style
        //    dgv_ShowData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        //    dgv_ShowData.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
        //    dgv_ShowData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    dgv_ShowData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //    // Set the selection style
        //    dgv_ShowData.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
        //    dgv_ShowData.DefaultCellStyle.SelectionForeColor = Color.White;

        //    // Customize grid lines
        //    dgv_ShowData.GridColor = Color.Gray;
        //    dgv_ShowData.BorderStyle = BorderStyle.None;

        //    // Enable row headers and customize their appearance
        //    dgv_ShowData.RowHeadersVisible = true;
        //    dgv_ShowData.RowHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
        //    dgv_ShowData.RowHeadersDefaultCellStyle.ForeColor = Color.White;

        //    // Auto-size columns to fit the content
        //    dgv_ShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        //    // Disable user resizing of rows and columns
        //    dgv_ShowData.AllowUserToResizeRows = false;
        //    dgv_ShowData.AllowUserToResizeColumns = false;

        //    // Enable row selection by clicking anywhere on the row
        //    dgv_ShowData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        //    // Disable multi-row selection
        //    dgv_ShowData.MultiSelect = false;

        //    // Add padding to cells
        //    dgv_ShowData.DefaultCellStyle.Padding = new Padding(5);

        //    // Format specific columns (e.g., Price column as currency)
        //    if (dgv_ShowData.Columns["Price"] != null)
        //    {
        //        dgv_ShowData.Columns["Price"].DefaultCellStyle.Format = "C2"; // Currency format with 2 decimal places
        //        dgv_ShowData.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //    }

        //    // Conditional formatting for low stock quantity
        //    //dgv_ShowData.CellFormatting += (sender, e) =>
        //    //{
        //    //    if (e.ColumnIndex == dgv_ShowData.Columns["StockQuantity"].Index && e.Value != null)
        //    //    {
        //    //        if (int.TryParse(e.Value.ToString(), out int stockQuantity))
        //    //        {
        //    //            if (stockQuantity < 10) // Highlight rows with low stock
        //    //            {
        //    //                e.CellStyle.BackColor = Color.LightCoral;
        //    //                e.CellStyle.ForeColor = Color.White;
        //    //            }
        //    //        }
        //    //    }
        //    //};
        //}
        private void ApplyGridViewStyle()
        {
            // Enable double buffering for smooth scrolling
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgv_ShowData, new object[] { true });

            // Enable scrollbars & set border
            dgv_ShowData.ScrollBars = ScrollBars.Both;
            dgv_ShowData.BorderStyle = BorderStyle.FixedSingle;

            // Remove the following line as DataGridViewRow does not have a Width property
            dgv_ShowData.RowTemplate.Height = 60;


            // Column header styling
            dgv_ShowData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv_ShowData.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_ShowData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_ShowData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Row styling
            dgv_ShowData.DefaultCellStyle.BackColor = Color.White;
            dgv_ShowData.DefaultCellStyle.ForeColor = Color.Black;
            //dgv_ShowData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            //dgv_ShowData.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // Selection style
            dgv_ShowData.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgv_ShowData.DefaultCellStyle.SelectionForeColor = Color.White;

            // Grid customization
            dgv_ShowData.GridColor = Color.Gray;
            dgv_ShowData.BorderStyle = BorderStyle.None;
            //dgv_ShowData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Row header styling
            dgv_ShowData.RowHeadersVisible = true;
            dgv_ShowData.RowHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_ShowData.RowHeadersDefaultCellStyle.ForeColor = Color.White;

            // Auto-size columns after data is loaded
            dgv_ShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable resizing
            dgv_ShowData.AllowUserToResizeRows = false;
            dgv_ShowData.AllowUserToResizeColumns = false;

            // Enable full row selection
            dgv_ShowData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ShowData.MultiSelect = false;

            // Add padding inside cells
            dgv_ShowData.DefaultCellStyle.Padding = new Padding(8);

            // Adjust scrollbar visibility inside a panel
            //panelContainer.AutoScroll = true;
            dgv_ShowData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // Adjust column width after data is loaded
            dgv_ShowData.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn col in dgv_ShowData.Columns)
                {
                    col.Width = 120; // Adjust all column widths
                }

                // Format price column
                if (dgv_ShowData.Columns.Contains("Price"))
                {
                    dgv_ShowData.Columns["Price"].DefaultCellStyle.Format = "C2";
                    dgv_ShowData.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            };

            // Conditional formatting for low stock
            dgv_ShowData.CellFormatting += (sender, e) =>
            {
                if (dgv_ShowData.Columns.Contains("StockQuantity") && e.ColumnIndex == dgv_ShowData.Columns["StockQuantity"].Index && e.Value != null)
                {
                    if (int.TryParse(e.Value.ToString(), out int stockQuantity) && stockQuantity < 10)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
            };
        }



        private void lblnewSale_Click_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newsale = new NewSale();
            newsale.Show(); // Changed from ShowDialog to Show
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        

          
        

        private  async void la_search_Click_1(object sender, EventArgs e)
        {
            string customerName = txt_nameSearch.Text.Trim();
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1); // To cover the whole day

            var query = _context.Sales.AsQueryable();

            // Case-insensitive search
            if (!string.IsNullOrWhiteSpace(customerName))
            {
                query = query.Where(s => EF.Functions.Like(s.CustomerName.ToLower(), $"%{customerName.ToLower()}%"));
            }

            // Date range filtering (making sure time is handled properly)
            query = query.Where(s => s.SaleDate >= startDate && s.SaleDate <= endDate);

            dgv_ShowData.DataSource = await query.ToListAsync();
        }
    }
}
