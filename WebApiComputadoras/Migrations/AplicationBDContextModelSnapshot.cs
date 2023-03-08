﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApicomputadoras;

#nullable disable

namespace WebApicomputadoras.Migrations
{
    [DbContext(typeof(AplicationBDContext))]
    partial class AplicationBDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApicomputadoras.BD.Computadoras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("TiendaID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Computadoras");
                });

            modelBuilder.Entity("WebApicomputadoras.BD.Tienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComputadoraID")
                        .HasColumnType("int");

                    b.Property<int?>("ComputadorasId")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_tienda")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComputadorasId");

                    b.ToTable("Tiendas");
                });

            modelBuilder.Entity("WebApicomputadoras.BD.Tienda", b =>
                {
                    b.HasOne("WebApicomputadoras.BD.Computadoras", "Computadoras")
                        .WithMany("Tienda")
                        .HasForeignKey("ComputadorasId");

                    b.Navigation("Computadoras");
                });

            modelBuilder.Entity("WebApicomputadoras.BD.Computadoras", b =>
                {
                    b.Navigation("Tienda");
                });
#pragma warning restore 612, 618
        }
    }
}
