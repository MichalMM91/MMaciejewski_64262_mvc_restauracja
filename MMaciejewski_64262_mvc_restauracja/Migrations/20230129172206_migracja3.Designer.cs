﻿// <auto-generated />
using System;
using MMaciejewski_64262_mvc_restauracja.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MMaciejewski64262mvcrestauracja.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20230129172206_migracja3")]
    partial class migracja3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MMaciejewski_64262_mvc_restauracja.Models.Danie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("Cena")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Dieta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Ilość")
                        .HasColumnType("int");

                    b.Property<string>("Kategoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Danie");
                });
#pragma warning restore 612, 618
        }
    }
}
