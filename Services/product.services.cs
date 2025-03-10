using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Services
{
    class ProductService
    {
        InventoryDbContext context;
        public ProductService()
        {
            context = new InventoryDbContext();
        }
        public Product? GetProductByID(int id)
        {
            return context.Products.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public Product? GetProductByName(string name)
        {
            return context.Products.AsNoTracking().FirstOrDefault(x => x.Name == name);
        }

        public List<Product> getAllProducts()
        {
            return context.Products.ToList();
        }
        public void addProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void updateProduct(Product product)
        {
            var existingProduct = context.Products.Find(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Category = product.Category;
                existingProduct.Price = product.Price;
                existingProduct.StockQuantity = product.StockQuantity;
                existingProduct.SupplierId = product.SupplierId;
                context.SaveChanges();
            }
        }
        public void deleteProduct(Product product)
        {
            var productToRemove = context.Products.Find(product.Id);
            if (productToRemove != null)
            {
                context.Products.Remove(productToRemove);
                context.SaveChanges();
            }
        }
    }
}
