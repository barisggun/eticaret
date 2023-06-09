﻿using ETicaretApp_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ETicaretApp_DataAccess.Concrete
{
    public class Context : DbContext
    {                    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //("server=ISILAY;database=ETicaretApp;Trusted_Connection=true;TrustServerCertificate=true");
            
            //optionsBuilder.UseSqlServer("server=ISILAY;database=ETicaretApp;Trusted_Connection=true;TrustServerCertificate=true");
            optionsBuilder.UseSqlServer("server =(localdb)\\MSSQLLocalDB;database=ETic;Trusted_Connection=true;TrustServerCertificate=true");
            
        }
    
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductCategory>()
        //            .HasKey(c => new { c.CategoryId, c.ProductId });
        //}
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("server=ISILAY;database=ETicaretApp;integrated security=true; TrustServerCertificate = true ");
        //    //Connection string oluşturmak için bu yapıya ihtiyaç vardır.
        //    //optionsBuilder.UseSqlServer("server=LAPTOP-TKFJC4RO\\SQLEXPRESS;database=ETicaretApp;integrated security=true; TrustServerCertificate = true ");
        //}   


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryProperties> CategoryProperties { get; set; }
        public DbSet<PropertyValue> PropertyValues { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
