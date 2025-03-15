using InventoryManagementSystem.Data;
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


namespace InventoryManagementSystem.Admin_Controls
{
    public partial class EditAccount : UserControl
    {
        private int _userId;
        private string _role;
        private InventoryDbContext _context;
        private User _user;

        public EditAccount(int userId, string role)
        {
            InitializeComponent();
            this._role = role;
            _userId = userId;
            _context = new InventoryDbContext();
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            //lbl_role.Text = _role;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string oldPassword = txt_old_psss.Text;
            string newPassword = txt_new_pass.Text;

            using (var _context = new InventoryDbContext())
            {

                var user = _context.Users.FirstOrDefault(u => u.Id == _userId);

                if (user == null)
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (user.Password != oldPassword)
                {
                    MessageBox.Show("Old password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                user.Password = newPassword;

                try
                {
                    _context.SaveChanges();
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}


