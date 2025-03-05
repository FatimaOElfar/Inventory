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
    class StockTransactionservices
    {
        InventoryDbContext context;
        public StockTransactionservices()
        {
            context = new InventoryDbContext();
        }
        public StockTransaction GetByID(int id)
        {
            return context.StockTransactions.FirstOrDefault(x => x.Id == id);
        }
        public List<StockTransaction> GetAll()
        {
            return context.StockTransactions.ToList();
        }
        public void Add(StockTransaction stockTransaction)
        {
            context.StockTransactions.Add(stockTransaction);
            context.SaveChanges();
        }
        public void Update(StockTransaction stockTransaction)
        {
            context.StockTransactions.Update(stockTransaction);
            context.SaveChanges();
        }
        public void Delete(StockTransaction stockTransaction)
        {
            context.StockTransactions.Remove(stockTransaction);
            context.SaveChanges();
        }

    }
}
