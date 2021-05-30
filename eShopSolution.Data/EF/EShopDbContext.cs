using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Data.Entities;

namespace eShopSolution.Data.EF
{
    public class EShopDbContext: DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> AppConfigs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> AppRoles { get; set; }
        public DbSet<Product> AppUsers { get; set; }
        public DbSet<Product> Carts { get; set; }
        public DbSet<Product> Categorys { get; set; }
        public DbSet<Product> CategoryTranslations { get; set; }
        public DbSet<Product> Contacts { get; set; }
        public DbSet<Product> Languages { get; set; }
        public DbSet<Product> Orders { get; set; }
        public DbSet<Product> OrderDetail { get; set; }
        public DbSet<Product> ProductImages { get; set; }
        public DbSet<Product> ProductInCategorys { get; set; }
        public DbSet<Product> ProductTranslations { get; set; }
        public DbSet<Product> Promotions { get; set; }
        public DbSet<Product> Transactions { get; set; } 
    }
}
