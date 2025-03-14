using InventoryManagementSystem.Admin_Controls;
using InventoryManagementSystem.Services;
using System;
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
        private UserManagement userManagement;

        // Removed the duplicate definition of Admin_pannel
        public AdminMainForm(string role, int id, string name)
        {
            InitializeComponent();
            this._role = role;
            this._id = id;
            this._name = name;
            //this.userManagement = new UserManagement();
            _user = new UserService();
            ConfigureButtonsByRole();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy, h:mm tt");
            lblUsername.Text = "Welcome " + _name;
            //lbl_role.Text = _role;
            if (_role == "Admin")
            {
                btnsave.Text = "Admin Account";
            }
            else if (_role == "Manager")
            {
                btnsave.Text = "Manger Account";
            }
            else
            {
                btnsave.Text = "Staff Account";
            }
        }

        private void ConfigureButtonsByRole()
        {
            btn_UserManagment.Visible = false;
            btn_ProductManagment.Visible = false;
            btn_Suppliers.Visible = false;
            btn_StockTransaction.Visible = false;
            btn_Sale.Visible = false;
            but_newSale.Visible = false;
            btnReport.Visible = false;

            if (_role.Trim().ToLower() == "admin")
            {
                btn_UserManagment.Visible = true;
                btn_ProductManagment.Visible = true;
                btn_Suppliers.Visible = true;
                btn_StockTransaction.Visible = true;
                btn_Sale.Visible = true;
                but_newSale.Visible = true;
                btnReport.Visible = true;
            }
            else if (_role.Trim().ToLower() == "manager")
            {
                btn_ProductManagment.Visible = true;
                btn_Suppliers.Visible = true;
                btn_StockTransaction.Visible = true;
                btn_Sale.Visible = true;
                but_newSale.Visible = true;
                btnReport.Visible = true;
                pictureBox3.Visible = false;
            }
            else if (_role.Trim().ToLower() == "staff")
            {
                btn_Sale.Visible = true;
                but_newSale.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
            }
        }

        private void btn_ProductManagment_Click(object sender, EventArgs e)
        {
            View_pannel.Controls.Clear();
            Ucontrol_Products productsControl = new Ucontrol_Products();
            View_pannel.Controls.Add(productsControl);
        }

        private void btn_UserManagment_Click(object sender, EventArgs e)
        {
            View_pannel.Controls.Clear();
            UserManagement UserList = new UserManagement(_role);
            View_pannel.Controls.Add(UserList);
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            View_pannel.Controls.Clear();
            SupplierManagementForm supplierControl = new SupplierManagementForm();
            View_pannel.Controls.Add(supplierControl);
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            View_pannel.Controls.Clear();
            SalesHistory salesControl = new SalesHistory();
            View_pannel.Controls.Add(salesControl);
        }

        private void but_newSale_Click(object sender, EventArgs e)
        {
            View_pannel.Controls.Clear();
            var salesControl = new NewSale(); // Ensure it's a valid UserControl
            View_pannel.Controls.Add(salesControl);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            View_pannel.Controls.Clear();
            Dashbord dashbord = new Dashbord();
            View_pannel.Controls.Add(dashbord);
        }

        private void btn_StockTransaction_Click(object sender, EventArgs e)
        {
            View_pannel.Controls.Clear();
            StockTransaction stock = new StockTransaction();
            View_pannel.Controls.Add(stock);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnReport_Click(object sender, EventArgs e)
        {
            View_pannel.Controls.Clear();
            ReportsControl reportsControl = new ReportsControl();
            View_pannel.Controls.Add(reportsControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            View_pannel.Controls.Clear();
            Userlist newAccount = new Userlist(_role, _id, _name, this);
            View_pannel.Controls.Add(newAccount);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            View_pannel.Controls.Clear();
            EditAccount editAccount = new EditAccount(_id,_role);
            View_pannel.Controls.Add(editAccount);
        }
        public Panel GetAdminPanel()
        {
            return View_pannel;
        }

        private void lbl_role_Click(object sender, EventArgs e)
        {

        }
    }
}