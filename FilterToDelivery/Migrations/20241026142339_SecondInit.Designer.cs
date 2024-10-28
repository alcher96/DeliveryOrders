﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilterToDelivery.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20241026142339_SecondInit")]
    partial class SecondInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Entities.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("OrderId");

                    b.Property<string>("CityDistrict")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DeliveryTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderWeight")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de704"),
                            CityDistrict = "Центральный",
                            DeliveryTime = new DateTime(2024, 10, 22, 17, 38, 12, 0, DateTimeKind.Unspecified),
                            OrderWeight = 12
                        },
                        new
                        {
                            OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de111"),
                            CityDistrict = "Северный",
                            DeliveryTime = new DateTime(2024, 11, 22, 17, 38, 12, 0, DateTimeKind.Unspecified),
                            OrderWeight = 12
                        },
                        new
                        {
                            OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de112"),
                            CityDistrict = "Восточный",
                            DeliveryTime = new DateTime(2024, 11, 23, 17, 38, 12, 0, DateTimeKind.Unspecified),
                            OrderWeight = 12
                        },
                        new
                        {
                            OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de113"),
                            CityDistrict = "Центральный",
                            DeliveryTime = new DateTime(2024, 11, 24, 17, 38, 12, 0, DateTimeKind.Unspecified),
                            OrderWeight = 12
                        },
                        new
                        {
                            OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de114"),
                            CityDistrict = "Центральный",
                            DeliveryTime = new DateTime(2024, 11, 25, 17, 38, 12, 0, DateTimeKind.Unspecified),
                            OrderWeight = 12
                        },
                        new
                        {
                            OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de115"),
                            CityDistrict = "Центральный",
                            DeliveryTime = new DateTime(2024, 11, 26, 17, 38, 12, 0, DateTimeKind.Unspecified),
                            OrderWeight = 12
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
