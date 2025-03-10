using System;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Services;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Admin_Controls
{
    public partial class SupplierManagementForm : UserControl
    {
        private readonly SupplierService _supplierService;
        private int _selectedSupplierId = -1;

        public SupplierManagementForm()
        {
            InitializeComponent();
            _supplierService = new SupplierService();
            LoadSuppliers();
            SetupInitialState();
        }

        private void LoadSuppliers()
        {
            dgv_ShowData.DataSource = _supplierService.getAllSuppliers()
                .Select(s => new { s.Id, s.Name, s.ContactInfo, s.Address })
                .ToList();
            ApplyGridViewStyle();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_contact.Text) || string.IsNullOrWhiteSpace(txt_address.Text))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var supplier = new Supplier
                {
                    Name = txt_name.Text,
                    ContactInfo = txt_contact.Text,
                    Address = txt_address.Text
                };

                _supplierService.addSupplier(supplier);
                MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSuppliers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierId == -1)
            {
                MessageBox.Show("Please select a supplier to edit!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_contact.Text) || string.IsNullOrWhiteSpace(txt_address.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var updatedSupplier = new Supplier
            {
                Id = _selectedSupplierId,
                Name = txt_name.Text,
                ContactInfo = txt_contact.Text,
                Address = txt_address.Text
            };

            _supplierService.updateSupplier(updatedSupplier);
            MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadSuppliers();
            ClearFields();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierId == -1)
            {
                MessageBox.Show("Please select a supplier to delete!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Deletion",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _supplierService.deleteSupplier(_selectedSupplierId);

                MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
                ClearFields();
            }
        }

        private void dgv_ShowData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_ShowData.Rows[e.RowIndex];
                _selectedSupplierId = Convert.ToInt32(row.Cells["Id"].Value);
                txt_name.Text = row.Cells["Name"].Value?.ToString() ?? string.Empty;
                txt_contact.Text = row.Cells["ContactInfo"].Value?.ToString() ?? string.Empty;
                txt_address.Text = row.Cells["Address"].Value?.ToString() ?? string.Empty;

                btn_save.Visible = false;
                btn_edit.Visible = true;
                btn_delete.Visible = true;
                lbl_GoBack.Visible = true;
            }
        }

        private void lbl_GoBack_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txt_name.Clear();
            txt_contact.Clear();
            txt_address.Clear();
            _selectedSupplierId = -1;

            btn_save.Visible = true;
            btn_edit.Visible = false;
            btn_delete.Visible = false;
            lbl_GoBack.Visible = false;
        }

        private void SetupInitialState()
        {
            btn_save.Visible = true;
            btn_edit.Visible = false;
            btn_delete.Visible = false;
            lbl_GoBack.Visible = false;
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
    }
}
