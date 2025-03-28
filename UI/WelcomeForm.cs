﻿using System;
using System.Text;
using System.Windows.Forms;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.UI;
using System.Drawing;
using ZXing; // Required for QR code generation and scanning
using ZXing.Common; // Required for HybridBinarizer
using ZXing.Rendering; // Extra rendering support if needed
using QRCoder;
using ZXing.QrCode;



namespace InventoryManagementSystem
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnSignUp_Click_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
