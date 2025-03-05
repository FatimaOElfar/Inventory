using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services
{
    class saleservices
    {
        InventoryDbContext context;
        public saleservices()
        {
            context = new InventoryDbContext();
        }
        public Sale GetByID(int id)
        {
            return context.Sales.FirstOrDefault(x => x.Id == id);
        }
        public List<Sale> GetAll()
        {
            return context.Sales.ToList();
        }
        public void Add(Sale sale)
        {
            context.Sales.Add(sale);
            context.SaveChanges();
        }

        public void Update(Sale sale)
        {
            context.Sales.Update(sale);
            context.SaveChanges();
        }
        public void Delete(Sale sale)
        {
            context.Sales.Remove(sale);
            context.SaveChanges();
        }
    }
}
