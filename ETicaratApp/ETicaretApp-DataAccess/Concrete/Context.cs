﻿using ETicaretApp_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_DataAccess.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("server=ISILAY;database=ETicaretApp;integrated security=true; TrustServerCertificate = true ");
        //    //Connection string oluşturmak için bu yapıya ihtiyaç vardır.
        //    //optionsBuilder.UseSqlServer("server=LAPTOP-TKFJC4RO\\SQLEXPRESS;database=ETicaretApp;integrated security=true; TrustServerCertificate = true ");
        //}   


        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
