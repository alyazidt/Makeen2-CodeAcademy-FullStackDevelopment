using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeAcademyShop.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeAcademyShop.Context
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-B3O3TOQ\\MSSQLS;" +
                "Initial Catalog=CodeAcademyShopDB;" +
                "Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=True;" +
                "Trust Server Certificate=True;" +
                "Application Intent=ReadWrite;" +
                "Multi Subnet Failover=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Product>()
        //        .Property(p => p.HasDiscount)
        //        .HasDefaultValue(false);



        //    modelBuilder.Entity<Product>()
        //        .Property(p => p.Descreption)
        //        .IsRequired(false)
        //        .HasMaxLength(60);


        //    modelBuilder.Entity<Product>()
        //        .HasOne<Categories>()
        //        .WithMany();
        //}



        public DbSet<Product> products { get; set; }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Tag> tags { get; set; }
    } 
}
