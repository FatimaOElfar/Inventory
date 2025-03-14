using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem.UI
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public string _role;

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();

            txt_Pass.PasswordChar = '●';
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txt_userName.Text;
            string password = txt_Pass.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _userService.getAllUsers()

                     .FirstOrDefault(u => u.Username == txt_userName.Text && u.Password == txt_Pass.Text);


            if (user != null)
            {
                MessageBox.Show($"Welcome, {user.Username}! You are logged in as {user.Role}.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Always navigate to AdminMainForm regardless of role
                AdminMainForm mainForm = new AdminMainForm(user.Role, user.Id, user.Username);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pass.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }

        private void lblSignUp_Click_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Ensure the form loads correctly
        }

        private void txt_userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
