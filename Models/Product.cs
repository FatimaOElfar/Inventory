﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; } = new Supplier();
        public virtual List<Sale> Sales { get; set; } = new List<Sale>();
        public virtual List<StockTransaction> StockTransactions { get; set; } = new List<StockTransaction>();
        //public string QRCode { get; set; }
    }
}
