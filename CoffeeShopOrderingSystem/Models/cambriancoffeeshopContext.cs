using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoffeeShopOrderingSystem.Models
{
    public partial class cambriancoffeeshopContext : DbContext
    {
        public cambriancoffeeshopContext()
        {
        }

        public cambriancoffeeshopContext(DbContextOptions<cambriancoffeeshopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Item> Items { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:sty1001-classproject.database.windows.net,1433;Initial Catalog=cambriancoffeeshop;Persist Security Info=False;User ID=dbuser;Password=Cambrian@2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("items");

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.ItemCalories).HasColumnName("itemCalories");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("itemDescription");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("itemName");

                entity.Property(e => e.ItemPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("itemPrice");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
