﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TopKala.DataAccess.Data;

namespace TopKala.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TopKala.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Value")
                        .IsUnique()
                        .HasFilter("[Value] IS NOT NULL");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("TopKala.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("Value")
                        .IsUnique()
                        .HasFilter("[Value] IS NOT NULL");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TopKala.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("Value")
                        .IsUnique()
                        .HasFilter("[Value] IS NOT NULL");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("TopKala.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Writer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TopKala.Models.Info", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Value")
                        .IsUnique()
                        .HasFilter("[Value] IS NOT NULL");

                    b.ToTable("Info");
                });

            modelBuilder.Entity("TopKala.Models.InfoGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Value")
                        .IsUnique()
                        .HasFilter("[Value] IS NOT NULL");

                    b.ToTable("InfoGroup");
                });

            modelBuilder.Entity("TopKala.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId")
                        .IsUnique()
                        .HasFilter("[BrandId] IS NOT NULL");

                    b.HasIndex("CategoryId")
                        .IsUnique()
                        .HasFilter("[CategoryId] IS NOT NULL");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TopKala.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("TopKala.Models.ProductInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InfoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductInfoGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InfoId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductInfoGroupId");

                    b.ToTable("ProductInfo");
                });

            modelBuilder.Entity("TopKala.Models.ProductInfoGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InfoGroupId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InfoGroupId")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInfoGroup");
                });

            modelBuilder.Entity("TopKala.Models.ProductSeller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("PriceOff")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<string>("Warrenty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ColorId")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.HasIndex("SellerId")
                        .IsUnique();

                    b.ToTable("ProductSeller");
                });

            modelBuilder.Entity("TopKala.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Value")
                        .IsUnique()
                        .HasFilter("[Value] IS NOT NULL");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("TopKala.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsImageUploaded")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNewsletterSubscripted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUserForeign")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TopKala.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("TopKala.Models.Category", b =>
                {
                    b.HasOne("TopKala.Models.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("TopKala.Models.Color", b =>
                {
                    b.HasOne("TopKala.Models.Product", null)
                        .WithMany("Colors")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TopKala.Models.Comment", b =>
                {
                    b.HasOne("TopKala.Models.Comment", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TopKala.Models.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TopKala.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TopKala.Models.Product", b =>
                {
                    b.HasOne("TopKala.Models.Brand", "Brand")
                        .WithOne()
                        .HasForeignKey("TopKala.Models.Product", "BrandId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TopKala.Models.Category", "Category")
                        .WithOne()
                        .HasForeignKey("TopKala.Models.Product", "CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TopKala.Models.ProductImage", b =>
                {
                    b.HasOne("TopKala.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TopKala.Models.ProductInfo", b =>
                {
                    b.HasOne("TopKala.Models.Info", "Info")
                        .WithMany()
                        .HasForeignKey("InfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TopKala.Models.Product", null)
                        .WithMany("ProductTopInfo")
                        .HasForeignKey("ProductId");

                    b.HasOne("TopKala.Models.ProductInfoGroup", "ProductInfoGroup")
                        .WithMany("ProductInfos")
                        .HasForeignKey("ProductInfoGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Info");

                    b.Navigation("ProductInfoGroup");
                });

            modelBuilder.Entity("TopKala.Models.ProductInfoGroup", b =>
                {
                    b.HasOne("TopKala.Models.InfoGroup", "InfoGroup")
                        .WithOne()
                        .HasForeignKey("TopKala.Models.ProductInfoGroup", "InfoGroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TopKala.Models.Product", "Product")
                        .WithMany("ProductInfoGroups")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("InfoGroup");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TopKala.Models.ProductSeller", b =>
                {
                    b.HasOne("TopKala.Models.Color", "Color")
                        .WithOne()
                        .HasForeignKey("TopKala.Models.ProductSeller", "ColorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TopKala.Models.Product", "Product")
                        .WithMany("ProductSellers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TopKala.Models.Seller", "Seller")
                        .WithOne()
                        .HasForeignKey("TopKala.Models.ProductSeller", "SellerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Product");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("TopKala.Models.User", b =>
                {
                    b.HasOne("TopKala.Models.UserRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("TopKala.Models.Category", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("TopKala.Models.Comment", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("TopKala.Models.Product", b =>
                {
                    b.Navigation("Colors");

                    b.Navigation("Comments");

                    b.Navigation("Images");

                    b.Navigation("ProductInfoGroups");

                    b.Navigation("ProductSellers");

                    b.Navigation("ProductTopInfo");
                });

            modelBuilder.Entity("TopKala.Models.ProductInfoGroup", b =>
                {
                    b.Navigation("ProductInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
