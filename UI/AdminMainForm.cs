using InventoryManagementSystem.Admin_Controls;
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
using InventoryManagementSystem.UI;

namespace InventoryManagementSystem.UI
{
    public partial class AdminMainForm : Form
    {
        private string _role;
        public int _id;
        public string _name;
        private UserService _user;
        public AdminMainForm(string role, int id, string name)
        {
            InitializeComponent();
            this._role = role;
            this._id = id;
            this._name = name;
            _user = new UserService();
        }



        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy, h:mm tt");
            // Assuming getUserByID() returns a User object
            lblUsername.Text = "Welcome " + _name;
            lbl_role.Text = _role;




        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btn_ProductManagment_Click(object sender, EventArgs e)
        {
            Admin_pannel.Controls.Clear();
            Ucontrol_Products productsControl = new Ucontrol_Products();
            Admin_pannel.Controls.Add(productsControl);
        }

        private void btn_UserManagment_Click(object sender, EventArgs e)
        {
            Admin_pannel.Controls.Clear();
            UserManagement UserList = new UserManagement(_role);
            Admin_pannel.Controls.Add(UserList);


        }


        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_pannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            Admin_pannel.Controls.Clear();
            SupplierManagementForm supplierControl = new SupplierManagementForm();
            Admin_pannel.Controls.Add(supplierControl);
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            Admin_pannel.Controls.Clear();
            SalesHistory salesControl = new SalesHistory();
            Admin_pannel.Controls.Add(salesControl);
        }

        private void but_newSale_Click(object sender, EventArgs e)
        {
            Admin_pannel.Controls.Clear();
            NewSale salesControl = new NewSale();
            Admin_pannel.Controls.Add(salesControl);
        }
        private void Home_Click(object sender, EventArgs e)
        {
            Admin_pannel.Controls.Clear();
            Dashbord dashbord = new Dashbord();
            Admin_pannel.Controls.Add(dashbord);

        }

        private void lbl_role_Click(object sender, EventArgs e)
        {

        }

        private void btn_StockTransaction_Click(object sender, EventArgs e)
        {
            Admin_pannel.Controls.Clear();
            StockTransaction stock = new StockTransaction();
            Admin_pannel.Controls.Add(stock);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}


