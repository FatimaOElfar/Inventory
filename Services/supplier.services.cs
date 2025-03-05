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
    class supplierservices
    {
        InventoryDbContext context;
        public supplierservices()
        {
            context = new InventoryDbContext();
        }
        public Supplier GetByID(int id)
        {
            return context.Suppliers.FirstOrDefault(x => x.Id == id);
        }
        public List<Supplier> GetAll()
        {
            return context.Suppliers.ToList();
        }
        public void Add(Supplier supplier)
        {
            context.Suppliers.Add(supplier);
            context.SaveChanges();
        }
        public void Update(Supplier supplier)
        {
            context.Suppliers.Update(supplier);
            context.SaveChanges();
        }
        public void Delete(Supplier supplier)
        {
            context.Suppliers.Remove(supplier);
            context.SaveChanges();
        }
    }


}
