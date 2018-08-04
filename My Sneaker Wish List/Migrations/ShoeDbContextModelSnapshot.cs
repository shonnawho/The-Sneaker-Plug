﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySneakerWishList.Data;

namespace MySneakerWishList.Migrations
{
    [DbContext(typeof(ShoeDbContext))]
    partial class ShoeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MySneakerWishList.Models.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("MySneakerWishList.Models.Shoe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Shoes");
                });

            modelBuilder.Entity("MySneakerWishList.Models.ShoeCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MySneakerWishList.Models.ShoeMenu", b =>
                {
                    b.Property<int>("ShoeID");

                    b.Property<int>("MenuID");

                    b.Property<int?>("ShoeMenuMenuID");

                    b.Property<int?>("ShoeMenuShoeID");

                    b.HasKey("ShoeID", "MenuID");

                    b.HasIndex("MenuID");

                    b.HasIndex("ShoeMenuShoeID", "ShoeMenuMenuID");

                    b.ToTable("ShoeMenus");
                });

            modelBuilder.Entity("MySneakerWishList.Models.Shoe", b =>
                {
                    b.HasOne("MySneakerWishList.Models.ShoeCategory", "Category")
                        .WithMany("Shoes")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MySneakerWishList.Models.ShoeMenu", b =>
                {
                    b.HasOne("MySneakerWishList.Models.Menu", "Menu")
                        .WithMany("ShoeMenus")
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MySneakerWishList.Models.Shoe", "Shoe")
                        .WithMany("ShoeMenus")
                        .HasForeignKey("ShoeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MySneakerWishList.Models.ShoeMenu")
                        .WithMany("ShoeMenus")
                        .HasForeignKey("ShoeMenuShoeID", "ShoeMenuMenuID");
                });
#pragma warning restore 612, 618
        }
    }
}
