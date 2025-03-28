﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Services
{
    class SaleService
    {
        InventoryDbContext context;
        public SaleService()
        {
            context = new InventoryDbContext();
        }
        public Sale getSaleByID(int id)
        {
            return context.Sales.FirstOrDefault(x => x.Id == id);
        }
        public List<Sale> getAllSales()
        {
            return context.Sales.ToList();
        }
        public void addSale(Sale sale)
        {
            context.Sales.Add(sale);
            context.SaveChanges();
        }

        public void updateSale(Sale sale)
        {
            context.Sales.Update(sale);
            context.SaveChanges();
        }
        public void deleteSale(Sale sale)
        {
            context.Sales.Remove(sale);
            context.SaveChanges();
        }

        public async Task<List<Sale>> GetFilteredSales(string customerName, DateTime startDate, DateTime endDate)
        {
            return await context.Sales
                .Where(s => s.CustomerName == customerName && s.SaleDate >= startDate && s.SaleDate <= endDate)
                .ToListAsync();
        }
    }
}

