using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Services
{
    class Productservice
    {
        InventoryDbContext context;
        public Productservice()
        {
            context = new InventoryDbContext();
        }
        public Product GetByID(int id)
        {
            return context.Products.FirstOrDefault(x => x.Id == id);
        }
       
        public Product GetByName(string name)
        {
            return context.Products.FirstOrDefault(x => x.Name == name);
        }
        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void Update(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }
        public void Delete(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
