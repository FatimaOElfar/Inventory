using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Services
{
    class UserService
    {
        private readonly InventoryDbContext context;

        public UserService()
        {
            context = new InventoryDbContext();
        }

        // Get User by ID (No Tracking for Read-Only Use)
        public User? getUserByID(int id)
        {
            return context.Users.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        // Get User by Username
        public User? getUserByname(string username)
        {
            return context.Users.AsNoTracking().FirstOrDefault(x => x.Username == username);
        }

        // Get all Users
        public List<User> getAllUsers()
        {
            return context.Users.ToList();
        }

        // Add a New User
        public void addUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        // Update User Details
        public void updateUser(User user)
        {
            var existingUser = context.Users.Find(user.Id);

            if (existingUser != null)
            {
                existingUser.Username = user.Username;
                existingUser.Password = user.Password;
                existingUser.Age = user.Age;
                existingUser.Address = user.Address;
                existingUser.Email = user.Email;
                existingUser.Role = user.Role;

                context.SaveChanges();
            }
        }

        // Delete a User
        public void deleteUser(int userId)
        {
            var userToRemove = context.Users.Find(userId);
            if (userToRemove != null)
            {
                context.Users.Remove(userToRemove);
                context.SaveChanges();
            }
        }
    }
}
