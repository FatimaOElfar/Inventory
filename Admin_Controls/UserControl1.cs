using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Ucontrol_Products : UserControl
    {
        private ProductService _service;

        public Ucontrol_Products()
        {
            InitializeComponent();
            _service = new ProductService();
            LoadProducts();
            LoadSuppliers();
        }
        //load product in datagridview
        private void LoadProducts()
        {
            dgv_ShowData.DataSource = _service.getAllProducts();
        }
        //load supplier in combobox
        private void LoadSuppliers()
        {
            using (var context = new InventoryDbContext())
            {
                var suppliers = context.Suppliers
                                       .Select(s => new { s.Id, s.Name })
                                       .ToList();

                cb_supplier.DataSource = suppliers;
                cb_supplier.DisplayMember = "Name";
                cb_supplier.ValueMember = "Id";
                cb_supplier.SelectedIndex = -1; //no selected any item in default
            }
        }

        //load catigories
        private void LoadCategories()
        {
            try
            {
                using (var context = new InventoryDbContext()) 
                {
                    var categories = context.Products
                                            .Select(c => new { c.Category })
                                            .ToList();

                    cb_category.DataSource = categories;
                    cb_category.DisplayMember = "CategoryName"; // Show category names
                    cb_category.ValueMember = "CategoryId"; // Store category IDs internally
                    cb_category.SelectedIndex = -1; // No selection initially
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //add product
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_name.Text))
                {
                    MessageBox.Show("Product Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txt_price.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Please enter a valid price!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_quantity.Text, out int quantity) || quantity < 0)
                {
                    MessageBox.Show("Please enter a valid stock quantity!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cb_supplier.SelectedItem == null)
                {
                    MessageBox.Show("Please select a supplier!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int supplierId = (int)cb_supplier.SelectedValue;

                if (cb_category.SelectedItem == null)
                {
                    MessageBox.Show("Please select a category!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // when all validations is correct, we will create the product object
                var product = new Product
                {
                    Name = txt_name.Text,
                    Price = price,
                    StockQuantity = quantity,
                    SupplierId = supplierId,
                    Category = cb_category.SelectedItem.ToString()
                };

                _service.addProduct(product);


                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearFields()
        {
            txt_name.Clear();
            txt_price.Clear();
            txt_quantity.Clear();
            cb_supplier.SelectedIndex = -1;
            cb_category.SelectedIndex = -1;
        }

        //choose row i need to edit TO fill all filed with data
        int _selectedProductId = 0;
        private void dgv_ShowData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ShowData.Rows[e.RowIndex];
                _selectedProductId = Convert.ToInt32(row.Cells["Id"].Value);
                txt_name.Text = row.Cells["Name"].Value.ToString();
                txt_price.Text = row.Cells["Price"].Value.ToString();
                txt_quantity.Text = row.Cells["StockQuantity"].Value.ToString();
                cb_supplier.SelectedValue = row.Cells["SupplierId"].Value; 
                cb_category.SelectedItem = row.Cells["Category"].Value.ToString(); 
            }
        }
        //edit product
        private void btn_Edit_Click(object sender, EventArgs e)
        {

            try
            {
                if (_selectedProductId == -1)
                {
                    MessageBox.Show("Please select a product to edit!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_name.Text))
                {
                    MessageBox.Show("Product Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txt_price.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Please enter a valid price!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_quantity.Text, out int quantity) || quantity < 0)
                {
                    MessageBox.Show("Please enter a valid stock quantity!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cb_supplier.SelectedItem == null)
                {
                    MessageBox.Show("Please select a supplier!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int supplierId = (int)cb_supplier.SelectedValue;

                if (cb_category.SelectedItem == null)
                {
                    MessageBox.Show("Please select a category!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create updated product object
                var updatedProduct = new Product
                {
                   Id = _selectedProductId,
                    Name = txt_name.Text,
                    Price = price,
                    StockQuantity = quantity,
                    SupplierId = supplierId,
                    Category = cb_category.SelectedItem.ToString()
                };

                //  the update function from the Product service class
                _service.updateProduct(updatedProduct);
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts(); // Refresh DataGridView
                ClearFields(); // Clear input fields
                _selectedProductId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }











    }
    //add product




}

