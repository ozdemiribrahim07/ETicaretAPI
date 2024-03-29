﻿// <auto-generated />
using System;
using ETicaret.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ETicaret.Persistance.Migrations
{
    [DbContext(typeof(TicaretContext))]
    partial class TicaretContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ETicaret.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "Baby",
                            CreatedTime = new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            BrandName = "Games, Computers & Toys",
                            CreatedTime = new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = true
                        },
                        new
                        {
                            Id = 3,
                            BrandName = "Books & Baby",
                            CreatedTime = new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            BrandName = "Games, Clothing & Industrial",
                            CreatedTime = new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("ETicaret.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Elektronik",
                            CreatedTime = new DateTime(2024, 1, 18, 19, 46, 17, 295, DateTimeKind.Local).AddTicks(6673),
                            IsDeleted = false,
                            ParentId = 0,
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Ev, Yaşam",
                            CreatedTime = new DateTime(2024, 1, 18, 19, 46, 17, 295, DateTimeKind.Local).AddTicks(6676),
                            IsDeleted = false,
                            ParentId = 0,
                            Priority = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Bilgisayar",
                            CreatedTime = new DateTime(2024, 1, 18, 19, 46, 17, 295, DateTimeKind.Local).AddTicks(6678),
                            IsDeleted = false,
                            ParentId = 1,
                            Priority = 1
                        });
                });

            modelBuilder.Entity("ETicaret.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProductDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedTime = new DateTime(2024, 1, 18, 19, 46, 17, 302, DateTimeKind.Local).AddTicks(6800),
                            IsDeleted = false,
                            ProductDesc = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            ProductDiscount = 0.7467474026736730m,
                            ProductName = "Small Steel Shoes",
                            ProductPrice = 472.92m
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 1,
                            CreatedTime = new DateTime(2024, 1, 18, 19, 46, 17, 302, DateTimeKind.Local).AddTicks(7070),
                            IsDeleted = false,
                            ProductDesc = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            ProductDiscount = 7.289052186462670m,
                            ProductName = "Tasty Fresh Sausages",
                            ProductPrice = 511.56m
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            CreatedTime = new DateTime(2024, 1, 18, 19, 46, 17, 302, DateTimeKind.Local).AddTicks(7028),
                            IsDeleted = false,
                            ProductDesc = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            ProductDiscount = 2.775587319993520m,
                            ProductName = "Ergonomic Rubber Chicken",
                            ProductPrice = 220.05m
                        });
                });

            modelBuilder.Entity("ETicaret.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("ETicaret.Domain.Entities.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DetailDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DetailTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedTime = new DateTime(2024, 1, 18, 19, 46, 17, 308, DateTimeKind.Local).AddTicks(3386),
                            DetailDesc = "Non ut amet repellendus magni odit.",
                            DetailTitle = "Quas quaerat quam odio reiciendis aut et sed nihil.",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedTime = new DateTime(2024, 1, 18, 19, 46, 17, 308, DateTimeKind.Local).AddTicks(3470),
                            DetailDesc = "Voluptate saepe ullam et culpa maxime.",
                            DetailTitle = "Eum fuga quis sint aut fugit qui.",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedTime = new DateTime(2024, 1, 18, 19, 46, 17, 308, DateTimeKind.Local).AddTicks(3542),
                            DetailDesc = "Est sunt eius aut et quasi.",
                            DetailTitle = "Voluptatum voluptatem occaecati nesciunt quo voluptas.",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("ETicaret.Domain.Entities.Product", b =>
                {
                    b.HasOne("ETicaret.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ETicaret.Domain.Entities.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("ETicaret.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("ETicaret.Domain.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ETicaret.Domain.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ETicaret.Domain.Entities.ProductDetail", b =>
                {
                    b.HasOne("ETicaret.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ETicaret.Domain.Entities.Category", b =>
                {
                    b.Navigation("ProductCategories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ETicaret.Domain.Entities.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
