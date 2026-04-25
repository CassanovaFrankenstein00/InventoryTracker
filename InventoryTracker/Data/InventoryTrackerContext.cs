using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventoryTracker.Models;

namespace InventoryTracker.Data
{
    public class InventoryTrackerContext : DbContext
    {
        public InventoryTrackerContext (DbContextOptions<InventoryTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryTracker.Models.Product> Product { get; set; } = default!;
        public DbSet<InventoryTracker.Models.Category> Category { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding Initial Data for Products an
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Galaxy Book 6 Ultra", Description = "laptop", Qty = 10, Make = "Samsung", CategoryId = 1 },
                new Product { Id = 2, Name = "IPhone 17", Description = "Smartphone", Qty = 50, Make = "Apple", CategoryId = 1},
                new Product { Id = 3, Name = "Office Chair", Description = "Ergonomic chair", Qty = 20, Make = "Herman Miller", CategoryId = 2 },
                new Product { Id = 4, Name = "Dining Table", Description = "Wooden dining table", Qty = 5, Make = "Ikea", CategoryId = 2 },
                new Product { Id = 5, Name = "Refrigerator", Description = "Double-door fridge", Qty = 8, Make = "LG", CategoryId = 3 },
                new Product { Id = 6, Name = "Microwave Oven", Description = "Countertop microwave", Qty = 15, Make = "Panasonic", CategoryId = 3 }
            );
            // Seeding Initial Data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Furniture" },
                new Category { Id = 3, Name = "Appliances" }
            );
        }
    }
}
