using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Refresh1_24.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Refresh1_24.Data
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string absoluteDbPath = Path.GetFullPath("../../../databases/database_farm.db");
            Console.WriteLine(absoluteDbPath);
            optionsBuilder.UseSqlite($"Data Source={absoluteDbPath}");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<AnimalFarmer> AnimalFarmer { get; set; }
        public DbSet<AnimalProduct> AnimalProduct { get; set; }
        public DbSet<FarmerProduct> FarmerProduct { get; set; }
        public DbSet<FarmerItem> FarmerItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>();
            //modelBuilder.Entity<Cattle>();
            //modelBuilder.Entity<Dog>();
            //modelBuilder.Entity<Sheep>();

            //modelBuilder.Entity<AnimalProduct>()
            //    .HasKey(ap => new { ap.AnimalId, ap.ProductId });
            //modelBuilder.Entity<AnimalProduct>()
            //    .HasOne(a => a.Animal)
            //    .WithMany(o => o.AnimalProduct)
            //    .HasForeignKey(a => a.AnimalId);
            //modelBuilder.Entity<AnimalProduct>()
            //    .HasOne(p => p.Product)
            //    .WithMany(o => o.AnimalProduct)
            //    .HasForeignKey(p => p.ProductId);

            //modelBuilder.Entity<AnimalOwner>()
            //    .HasKey(ap => new { ap.AnimalId, ap.FarmerId });
            //modelBuilder.Entity<AnimalOwner>()
            //    .HasOne(a => a.Animal)
            //    .WithMany(o => o.AnimalOwner)
            //    .HasForeignKey(a => a.AnimalId);
            //modelBuilder.Entity<AnimalOwner>()
            //    .HasOne(f => f.Farmer)
            //    .WithMany(o => o.AnimalOwner)
            //    .HasForeignKey(f => f.FarmerId);



            //modelBuilder.Entity<FarmerProduct>()
            //    .HasKey(ap => new { ap.FarmerId, ap.ProductId });
            //modelBuilder.Entity<FarmerProduct>()
            //    .HasOne(f => f.Farmer)
            //    .WithMany(o => o.FarmerProduct)
            //    .HasForeignKey(f => f.FarmerId);
            //modelBuilder.Entity<FarmerProduct>()
            //    .HasOne(p => p.Product)
            //    .WithMany(o => o.FarmerProduct)
            //    .HasForeignKey(p => p.ProductId);

            //modelBuilder.Entity<FarmerItem>()
            //    .HasKey(ap => new { ap.FarmerId, ap.ItemId });
            //modelBuilder.Entity<FarmerItem>()
            //    .HasOne(f => f.Farmer)
            //    .WithMany(o => o.FarmerItem)
            //    .HasForeignKey(f => f.FarmerId);
            //modelBuilder.Entity<FarmerItem>()
            //    .HasOne(i => i.Item)
            //    .WithMany(o => o.FarmerItem)
            //    .HasForeignKey(i => i.ItemId);

            //modelBuilder.Entity<Animal>()
            //    .HasMany(e => e.Products)
            //    .WithMany(e => e.Animals);
            //modelBuilder.Entity<Animal>()
            //    .HasMany(e => e.Farmers)
            //    .WithMany(e => e.Animals);
            //modelBuilder.Entity<Farmer>()
            //   .HasMany(e => e.Items)
            //   .WithMany(e => e.Farmers);
            //modelBuilder.Entity<Farmer>()
            //   .HasMany(e => e.Products)
            //   .WithMany(e => e.Farmers);

            base.OnModelCreating(modelBuilder);
        }
    }
}
