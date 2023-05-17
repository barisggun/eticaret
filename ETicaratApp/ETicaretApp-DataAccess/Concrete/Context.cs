using ETicaretApp_EntityLayer.Concrete;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string oluşturmak için bu yapıya ihtiyaç vardır.
            optionsBuilder.UseSqlServer("server=ISILAY;database=ETicaretApp;integrated security=true; TrustServerCertificate = true ");
        }

        DbSet<Product> Products { get; set; }   
    }
}
