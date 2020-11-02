﻿// <auto-generated />
using System;
using JCDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JCDB.Migrations
{
    [DbContext(typeof(JCContext))]
    [Migration("20201102203955_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("JCDB.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("text");

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("BrandId");

                    b.HasIndex("ProductId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("JCDB.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<string>("ExpDate")
                        .HasColumnType("text");

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("JCDB.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("QuantityOnHand")
                        .HasColumnType("integer");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("JCDB.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int?>("InventoryId")
                        .HasColumnType("integer");

                    b.Property<string>("LocationName")
                        .HasColumnType("text");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.HasKey("LocationId");

                    b.HasIndex("InventoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("JCDB.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("OrderDate")
                        .HasColumnType("text");

                    b.Property<int?>("OrderLineId")
                        .HasColumnType("integer");

                    b.HasKey("OrderId");

                    b.HasIndex("OrderLineId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("JCDB.Models.OrderLine", b =>
                {
                    b.Property<int>("OrderLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("OrderLineId");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("JCDB.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("InventoryId")
                        .HasColumnType("integer");

                    b.Property<int>("ListPrice")
                        .HasColumnType("integer");

                    b.Property<int?>("OrderLineId")
                        .HasColumnType("integer");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.HasKey("ProductId");

                    b.HasIndex("InventoryId");

                    b.HasIndex("OrderLineId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("JCDB.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("ManagerStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<string>("PassWord")
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.HasIndex("OrderId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JCDB.Models.Brand", b =>
                {
                    b.HasOne("JCDB.Models.Product", null)
                        .WithMany("Brand")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("JCDB.Models.Category", b =>
                {
                    b.HasOne("JCDB.Models.Product", null)
                        .WithMany("Category")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("JCDB.Models.Location", b =>
                {
                    b.HasOne("JCDB.Models.Inventory", null)
                        .WithMany("Location")
                        .HasForeignKey("InventoryId");

                    b.HasOne("JCDB.Models.Order", null)
                        .WithMany("Location")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("JCDB.Models.Order", b =>
                {
                    b.HasOne("JCDB.Models.OrderLine", null)
                        .WithMany("Order")
                        .HasForeignKey("OrderLineId");
                });

            modelBuilder.Entity("JCDB.Models.Product", b =>
                {
                    b.HasOne("JCDB.Models.Inventory", null)
                        .WithMany("Product")
                        .HasForeignKey("InventoryId");

                    b.HasOne("JCDB.Models.OrderLine", null)
                        .WithMany("Product")
                        .HasForeignKey("OrderLineId");
                });

            modelBuilder.Entity("JCDB.Models.User", b =>
                {
                    b.HasOne("JCDB.Models.Order", null)
                        .WithMany("User")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}