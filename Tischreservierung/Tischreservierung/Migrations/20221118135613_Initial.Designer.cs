﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tischreservierung.Data;

#nullable disable

namespace Tischreservierung.Migrations
{
    [DbContext(typeof(OnlineReservationContext))]
    [Migration("20221118135613_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RestaurantTypeOfRestaurant", b =>
                {
                    b.Property<string>("RestaurantTypesRestaurantType")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RestaurantsId")
                        .HasColumnType("int");

                    b.HasKey("RestaurantTypesRestaurantType", "RestaurantsId");

                    b.HasIndex("RestaurantsId");

                    b.ToTable("RestaurantTypeOfRestaurant");
                });

            modelBuilder.Entity("Tischreservierung.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("Tischreservierung.Models.TypeOfRestaurant", b =>
                {
                    b.Property<string>("RestaurantType")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RestaurantType");

                    b.ToTable("TypeOfRestaurant");
                });

            modelBuilder.Entity("RestaurantTypeOfRestaurant", b =>
                {
                    b.HasOne("Tischreservierung.Models.TypeOfRestaurant", null)
                        .WithMany()
                        .HasForeignKey("RestaurantTypesRestaurantType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tischreservierung.Models.Restaurant", null)
                        .WithMany()
                        .HasForeignKey("RestaurantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}