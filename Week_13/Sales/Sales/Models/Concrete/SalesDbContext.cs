using Microsoft.EntityFrameworkCore;
using Sales.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * Microsoft.EntityFrameworkCore
 * Microsoft.EntityFrameworkCore.SqlServer
 * Microsoft.EntityFrameworkCore.Tools
 * Microsoft.EntityFrameworkCore.Design
*/
namespace Sales.Models.Concrete
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=ENE\\SQLEXPRESS;Database=SalesDb;Trusted_Connection=true;");
        //        //optionsBuilder.UseSqlServer("Name=ConnectionStrings:SqlConn");
        //    }
        //}


    }
}
