﻿using System.Text;

namespace InventoryManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } // Admin, Manager, Staff

        public virtual List<Sale> Sales { get; set; } = new List<Sale>();

    }
} 
