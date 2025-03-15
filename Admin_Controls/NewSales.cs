using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
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

namespace InventoryManagementSystem.Admin_Controls
{
    public partial class NewSales : Control
    {
        private InventoryDbContext _context = new InventoryDbContext();
        private BindingList<Sale> saleItems = new BindingList<Sale>();

        public NewSales()
        {
            InitializeComponent();
            InitializeDataGridView();

        }
        private DateTimePicker dateTimePicker = new DateTimePicker();


        private void InitializeDataGridView()
        {
            // Remove full docking
            dgv_ShowData.Dock = DockStyle.None;
            dgv_ShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Load products and users from the database
            DataTable productData = LoadProducts();
            DataTable userData = LoadUsers();

            // Create columns
            DataGridViewComboBoxColumn productColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Product Name",
                Name = "ProductName",
                DataSource = productData,
                DisplayMember = "ProductName",
                ValueMember = "ProductID",
                Width = 150
            };

            DataGridViewComboBoxColumn userColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "User Name",
                Name = "UserName",
                DataSource = userData,
                DisplayMember = "UserName",
                ValueMember = "UserID",
                Width = 150
            };

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                Name = "Quantity",
                Width = 100
            };

            DataGridViewTextBoxColumn unitPriceColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Unit Price",
                Name = "UnitPrice",
                ReadOnly = true,
                Width = 100
            };

            DataGridViewTextBoxColumn totalPriceColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Price",
                Name = "TotalPrice",
                ReadOnly = true,
                Width = 120
            };

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Sale Date",
                Name = "SaleDate",
                Width = 120
            };

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Name = "Delete",
                Text = "🗑️",
                UseColumnTextForButtonValue = true,
                Width = 80
            };

            // Add columns to DataGridView
            dgv_ShowData.Columns.Add(userColumn);
            dgv_ShowData.Columns.Add(productColumn);
            dgv_ShowData.Columns.Add(quantityColumn);
            dgv_ShowData.Columns.Add(unitPriceColumn);
            dgv_ShowData.Columns.Add(totalPriceColumn);
            dgv_ShowData.Columns.Add(dateColumn);
            dgv_ShowData.Columns.Add(deleteColumn);

            // Add DateTimePicker
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Visible = false;
            dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
            dgv_ShowData.Controls.Add(dateTimePicker);

            // Attach event handlers
            dgv_ShowData.CellClick += DataGridView1_CellClick;
            dgv_ShowData.CellValueChanged += DataGridView1_CellValueChanged;

            // Add DataGridView to the form
            this.Controls.Add(dgv_ShowData);

            // Center DataGridView
            CenterDataGridView();
        }

        private void CenterDataGridView()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int dgvWidth = dgv_ShowData.Width;
            int dgvHeight = dgv_ShowData.Height;

            // Calculate the centered position
            int x = (formWidth - dgvWidth) / 2;
            int y = (formHeight - dgvHeight) / 2;

            dgv_ShowData.Location = new Point(x, y);
        }



        private DataTable LoadProducts()
        {
            using (var context = new InventoryDbContext())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ProductID", typeof(int));
                dt.Columns.Add("ProductName", typeof(string));
                dt.Columns.Add("Price", typeof(decimal)); // Include Price for auto-update

                var products = context.Products.Select(p => new { p.Id, p.Name, p.Price }).ToList();
                foreach (var product in products)
                {
                    dt.Rows.Add(product.Id, product.Name, product.Price);
                }
                return dt;
            }
        }

        private DataTable LoadUsers()
        {
            using (var context = new InventoryDbContext())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("UserID", typeof(int));
                dt.Columns.Add("UserName", typeof(string));

                var users = context.Users.Select(u => new { u.Id, u.Username }).ToList();

                if (users.Count == 0)
                {
                    MessageBox.Show("No users found in the database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                foreach (var user in users)
                {
                    dt.Rows.Add(user.Id, user.Username);
                }

                return dt;
            }
        }



        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // If a product is selected, load its price
                if (e.ColumnIndex == dgv_ShowData.Columns["ProductName"].Index)
                {
                    var productId = dgv_ShowData.Rows[e.RowIndex].Cells["ProductName"].Value;

                    if (productId != null)
                    {
                        using (var context = new InventoryDbContext())
                        {
                            var product = context.Products.FirstOrDefault(p => p.Id == (int)productId);
                            if (product != null)
                            {
                                // Load unit price
                                dgv_ShowData.Rows[e.RowIndex].Cells["UnitPrice"].Value = product.Price;

                                // If quantity exists, calculate total price
                                var quantityValue = dgv_ShowData.Rows[e.RowIndex].Cells["Quantity"].Value;
                                if (quantityValue != null && int.TryParse(quantityValue.ToString(), out int quantity) && quantity > 0)
                                {
                                    dgv_ShowData.Rows[e.RowIndex].Cells["TotalPrice"].Value = product.Price * quantity;
                                }
                                else
                                {
                                    dgv_ShowData.Rows[e.RowIndex].Cells["TotalPrice"].Value = product.Price;
                                }
                            }
                        }
                    }
                }

                // If the quantity is changed, calculate the total price
                if (e.ColumnIndex == dgv_ShowData.Columns["Quantity"].Index)
                {
                    var productPrice = dgv_ShowData.Rows[e.RowIndex].Cells["UnitPrice"].Value;
                    var quantityValue = dgv_ShowData.Rows[e.RowIndex].Cells["Quantity"].Value;

                    if (productPrice != null && quantityValue != null)
                    {
                        if (decimal.TryParse(productPrice.ToString(), out decimal price) &&
                            int.TryParse(quantityValue.ToString(), out int quantity) && quantity > 0)
                        {
                            dgv_ShowData.Rows[e.RowIndex].Cells["TotalPrice"].Value = price * quantity;
                        }
                        else
                        {
                            dgv_ShowData.Rows[e.RowIndex].Cells["TotalPrice"].Value = 0;
                        }
                    }
                }
            }
        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle Sale Date Picker
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_ShowData.Columns["SaleDate"].Index)
            {
                Rectangle cellRectangle = dgv_ShowData.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                dateTimePicker.Location = new Point(
                    dgv_ShowData.Left + cellRectangle.X,
                    dgv_ShowData.Top + cellRectangle.Y
                );

                dateTimePicker.Size = new Size(cellRectangle.Width, cellRectangle.Height);
                dateTimePicker.Visible = true;
                dateTimePicker.Tag = new Point(e.RowIndex, e.ColumnIndex);

                if (dgv_ShowData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null &&
                    DateTime.TryParse(dgv_ShowData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out DateTime tempDate))
                {
                    dateTimePicker.Value = tempDate;
                }
                else
                {
                    dateTimePicker.Value = DateTime.Today;
                }

                dateTimePicker.Focus();
            }
            // Handle Trash Bin (🗑️) Button Click for Row Deletion
            else if (e.ColumnIndex == dgv_ShowData.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dgv_ShowData.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        // Update the DataGridView cell with the selected date
        //private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentCell != null)
        //    {
        //        dataGridView1.CurrentCell.Value = dateTimePicker.Value.ToShortDateString();
        //    }
        //    dateTimePicker.Visible = false;
        //}





        //private void but_saveSale_Click(object sender, EventArgs e)
        //{
        //    var customerName = txt_cus.Text;

        //    if (string.IsNullOrEmpty(customerName) || dgv_ShowData.Rows.Count == 0)
        //    {
        //        MessageBox.Show("Please enter a customer and add at least one product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    List<Sale> saleItems = new List<Sale>();

        //    // Extract data from DataGridView and add to saleItems
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        if (row.IsNewRow) continue; // Skip empty new row

        //        if (row.Cells["ProductName"].Value == null || row.Cells["Quantity"].Value == null)
        //        {
        //            MessageBox.Show("Ensure all products have a quantity entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        var sale = new Sale
        //        {
        //            CustomerName = customerName,
        //            SaleDate = DateTime.Now,
        //            ProductId = Convert.ToInt32(row.Cells["ProductName"].Value),
        //            UserId = Convert.ToInt32(row.Cells["UserName"].Value),
        //            Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
        //            TotalPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value)
        //        };

        //        saleItems.Add(sale);
        //    }

        //    if (saleItems.Count == 0)
        //    {
        //        MessageBox.Show("No valid sales data to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    _context.Sales.AddRange(saleItems);
        //    _context.SaveChanges();

        //    MessageBox.Show("Sale saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    this.FindForm().Close(); // Use FindForm to close the form
        //}

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            if (e.Context == DataGridViewDataErrorContexts.Commit ||
                e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Invalid selection. Please select a valid product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.ThrowException = false; // Prevents crash
            }


        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Tag is Point cellPosition)
            {
                dgv_ShowData.Rows[cellPosition.X].Cells[cellPosition.Y].Value = dateTimePicker.Value.ToShortDateString();
            }
            dateTimePicker.Visible = false;
        }

        private void NewSale_Resize(object sender, EventArgs e)
        {
            CenterDataGridView();
        }
    }
}

