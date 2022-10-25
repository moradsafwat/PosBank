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
                .WithOne(P => P.Product )
                .HasForeignKey(p => p.ProductId);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductsDetails { get; set; }
    }
}
