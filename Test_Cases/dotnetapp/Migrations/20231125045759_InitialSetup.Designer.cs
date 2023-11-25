﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetapp.Data;

#nullable disable

namespace dotnetapp.Migrations
{
    [DbContext(typeof(LaundryDbContext))]
    [Migration("20231125045759_InitialSetup")]
    partial class InitialSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("dotnetapp.Models.LaundryStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LaundryStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Scheduled"
                        },
                        new
                        {
                            Id = 2,
                            Name = "PickedUp"
                        },
                        new
                        {
                            Id = 3,
                            Name = "UnderLaundry"
                        },
                        new
                        {
                            Id = 4,
                            Name = "QualityCheck"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Delivered"
                        });
                });

            modelBuilder.Entity("dotnetapp.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClothesPerMonth")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerKg")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Packages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClothesPerMonth = 70,
                            Description = "Per/kg",
                            Name = "Wash & Fold",
                            PricePerKg = 5.0m
                        },
                        new
                        {
                            Id = 2,
                            ClothesPerMonth = 65,
                            Description = "Per/kg",
                            Name = "Wash & Iron",
                            PricePerKg = 7.0m
                        },
                        new
                        {
                            Id = 3,
                            ClothesPerMonth = 60,
                            Description = "60 Clothes /month",
                            Name = "Individual Package",
                            PricePerKg = 4.0m
                        },
                        new
                        {
                            Id = 4,
                            ClothesPerMonth = 110,
                            Description = "110 Clothes /month",
                            Name = "Family Package",
                            PricePerKg = 10.0m
                        },
                        new
                        {
                            Id = 5,
                            ClothesPerMonth = 80,
                            Description = "Per cloth",
                            Name = "Pay Per Cloth",
                            PricePerKg = 11.5m
                        },
                        new
                        {
                            Id = 6,
                            ClothesPerMonth = 45,
                            Description = "Per saree",
                            Name = "Saree Polishing",
                            PricePerKg = 9.0m
                        },
                        new
                        {
                            Id = 7,
                            ClothesPerMonth = 50,
                            Description = "Per/kg",
                            Name = "DryCleaning",
                            PricePerKg = 8.0m
                        },
                        new
                        {
                            Id = 8,
                            ClothesPerMonth = 50,
                            Description = "Per/kg",
                            Name = "Premium Laundry",
                            PricePerKg = 10.0m
                        });
                });

            modelBuilder.Entity("dotnetapp.Models.UserSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpectedDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<string>("PickupDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PickupTimeSlot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("StatusId");

                    b.ToTable("UserSchedules");
                });

            modelBuilder.Entity("dotnetapp.Models.UserSchedule", b =>
                {
                    b.HasOne("dotnetapp.Models.Package", "Package")
                        .WithMany()
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnetapp.Models.LaundryStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
