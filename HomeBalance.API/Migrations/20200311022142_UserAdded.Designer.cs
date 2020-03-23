﻿// <auto-generated />
using HomeBalance.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeBalance.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200311022142_UserAdded")]
    partial class UserAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("HomeBalance.API.Model.Cuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountType")
                        .HasColumnType("TEXT");

                    b.Property<int>("Balance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BankName")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoutingNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cuentas");
                });
#pragma warning restore 612, 618
        }
    }
}
