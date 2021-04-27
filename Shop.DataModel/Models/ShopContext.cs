﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Shop.DataModel.Models
{
    public partial class ShopContext : DbContext
    {
        public ShopContext()
        {
        }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.Categoryid);

                entity.ToTable("Categories", "Production");

                entity.HasIndex(e => e.Categoryname)
                    .HasName("categoryname");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Categoryname)
                    .IsRequired()
                    .HasColumnName("categoryname")
                    .HasMaxLength(15);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationUser)
                    .HasColumnName("creation_user")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DeleteDate)
                    .HasColumnName("delete_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasColumnName("delete_user");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.Productid);

                entity.ToTable("Products", "Production");

                entity.HasIndex(e => e.Categoryid)
                    .HasName("idx_nc_categoryid");

                entity.HasIndex(e => e.Productname)
                    .HasName("idx_nc_productname");

                entity.HasIndex(e => e.Supplierid)
                    .HasName("idx_nc_supplierid");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationUser)
                    .HasColumnName("creation_user")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DeleteDate)
                    .HasColumnName("delete_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasColumnName("delete_user");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Discontinued).HasColumnName("discontinued");

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Productname)
                    .IsRequired()
                    .HasColumnName("productname")
                    .HasMaxLength(40);

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Unitprice)
                    .HasColumnName("unitprice")
                    .HasColumnType("money");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Categories");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Supplierid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Suppliers");
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.HasKey(e => e.Supplierid);

                entity.ToTable("Suppliers", "Production");

                entity.HasIndex(e => e.Companyname)
                    .HasName("idx_nc_companyname");

                entity.HasIndex(e => e.Postalcode)
                    .HasName("idx_nc_postalcode");

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(60);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(15);

                entity.Property(e => e.Companyname)
                    .IsRequired()
                    .HasColumnName("companyname")
                    .HasMaxLength(40);

                entity.Property(e => e.Contactname)
                    .IsRequired()
                    .HasColumnName("contactname")
                    .HasMaxLength(30);

                entity.Property(e => e.Contacttitle)
                    .IsRequired()
                    .HasColumnName("contacttitle")
                    .HasMaxLength(30);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(15);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationUser)
                    .HasColumnName("creation_user")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DeleteDate)
                    .HasColumnName("delete_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteUser).HasColumnName("delete_user");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(24);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(24);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(15);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}