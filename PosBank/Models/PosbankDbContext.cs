using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Models
{
    public class PosbankDbContext : DbContext
    {
        public PosbankDbContext(DbContextOptions<PosbankDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>()
                .HasMany(D => D.ProductsDetails)
                .WithOne(P => P.Product)
                .HasForeignKey(p => p.ProductId);

            builder.Entity<OrderItem>()
                .HasMany(p => p.OrderItem_ProductDetails)
                .WithOne(o => o.OrderItem)
                .HasForeignKey(f => f.OrderItemId);

            builder.Entity<ProductDetails>()
                .HasMany(p => p.OrderItem_ProductDetails)
                .WithOne(p=> p.ProductDetails)
                .HasForeignKey(f => f.ProductDetailsId);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductsDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderItem_ProductDetails> OrderItem_ProductDetails { get; set; }
    }
}
