using InventoryManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Data;
namespace InventoryManagementSystem.Services
{
    class userservices
    {
        InventoryDbContext context;
        public userservices()
        {
            context = new InventoryDbContext();
        }
        public User GetByID(int id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }
        public List<User> GetAll()
        {
            return context.Users.ToList();
        }
        public void Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void Update(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void Delete(User user)
        {
            context.Users.Remove(user);
            context.SaveChanges();
        }

    }
}
