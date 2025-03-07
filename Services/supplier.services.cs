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
    class SupplierService
    {
        InventoryDbContext context;
        public SupplierService()
        {
            context = new InventoryDbContext();
        }
        public Supplier getSupplierByID(int id)
        {
            return context.Suppliers.FirstOrDefault(x => x.Id == id);
        }
        public List<Supplier> getAllSuppliers()
        {
            return context.Suppliers.ToList();
        }
        public void addSupplier(Supplier supplier)
        {
            context.Suppliers.Add(supplier);
            context.SaveChanges();
        }
        public void updateSupplier(Supplier supplier)
        {
            context.Suppliers.Update(supplier);
            context.SaveChanges();
        }
        public void deleteSupplier(Supplier supplier)
        {
            context.Suppliers.Remove(supplier);
            context.SaveChanges();
        }
    }


}
