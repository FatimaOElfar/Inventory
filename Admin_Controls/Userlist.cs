using InventoryManagementSystem.Data;
using InventoryManagementSystem.Services;
using InventoryManagementSystem.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Admin_Controls
{
    public partial class Userlist : UserControl
    {
        private UserService _service;
        private AdminMainForm _mainForm;
        private UserManagement _userManagement;

        private string _role;
        private int _id;
        private string _name;
        private int _selectedUserId;


        public Userlist(string role, int id, string name, AdminMainForm mainForm )
        {
            InitializeComponent();
            this._role = role;
            this._id = id;
            this._name = name;
         
            this._mainForm = mainForm;
            _service = new UserService();

            LoadUsers();
        }

        private void LoadUsers()
        {
            dgv_ShowData.DataSource = null;
            var users = _service.getAllUsers();
            dgv_ShowData.DataSource = users;

            if (dgv_ShowData.Columns["Password"] != null)
            {
                dgv_ShowData.Columns["Password"].Visible = false;
            }

            ApplyGridViewStyle();
        }

        private void ApplyGridViewStyle()
        {
            dgv_ShowData.Font = new Font("Segoe UI", 8);
            dgv_ShowData.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dgv_ShowData.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_ShowData.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_ShowData.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_ShowData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv_ShowData.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_ShowData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_ShowData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ShowData.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgv_ShowData.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_ShowData.GridColor = Color.Gray;
            dgv_ShowData.BorderStyle = BorderStyle.None;
            dgv_ShowData.RowHeadersVisible = true;
            dgv_ShowData.RowHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_ShowData.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_ShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ShowData.AllowUserToResizeRows = false;
            dgv_ShowData.AllowUserToResizeColumns = false;
            dgv_ShowData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ShowData.MultiSelect = false;
            dgv_ShowData.DefaultCellStyle.Padding = new Padding(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _mainForm.View_pannel.Controls.Clear();
            _mainForm.View_pannel.Controls.Add(_userManagement);
        }

        
            }
        }

