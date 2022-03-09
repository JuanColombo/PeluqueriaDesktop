﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeluqueriaDesktop;

namespace PeluqueriaDesktop.Migrations
{
    [DbContext(typeof(PeluqueriaContext))]
    [Migration("20220309181253_caja2")]
    partial class caja2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PeluqueriaDesktop.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DetalleTrabajosId")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Telefono")
                        .HasColumnType("float");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DetalleTrabajosId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Valle",
                            Eliminado = false,
                            Nombre = "Ivan Carlos",
                            Telefono = 3498459297.0
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Colombo",
                            Eliminado = false,
                            Nombre = "Juan Pablo",
                            Telefono = 3498463367.0
                        });
                });

            modelBuilder.Entity("PeluqueriaDesktop.Modelos.Caja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("RetiroCaja")
                        .HasColumnType("float");

                    b.Property<double>("TotalCaja")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Caja");
                });

            modelBuilder.Entity("PeluqueriaDesktop.Modelos.DetalleTrabajos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("DetalleTrabajo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormaDePago")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("DetalleTrabajos");
                });

            modelBuilder.Entity("PeluqueriaDesktop.Modelos.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cantidad")
                        .HasColumnType("float");

                    b.Property<double>("Codigo")
                        .HasColumnType("float");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cantidad = 1.0,
                            Codigo = 3145.0,
                            Descripcion = "Tintura color morado",
                            Eliminado = false,
                            Marca = "Avon"
                        },
                        new
                        {
                            Id = 2,
                            Cantidad = 5.0,
                            Codigo = 10444584.0,
                            Descripcion = "Shampoo manzana",
                            Eliminado = false,
                            Marca = "Plusbelle"
                        });
                });

            modelBuilder.Entity("PeluqueriaDesktop.Turno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrabajoARealizar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Turnos");
                });

            modelBuilder.Entity("PeluqueriaDesktop.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eliminado = false,
                            Nombre = "Ivan Valle",
                            Password = "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3",
                            TipoUsuario = 3,
                            User = "ivan"
                        },
                        new
                        {
                            Id = 2,
                            Eliminado = false,
                            Nombre = "Juan Pablo Colombo",
                            Password = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                            TipoUsuario = 3,
                            User = "juan"
                        });
                });

            modelBuilder.Entity("PeluqueriaDesktop.Cliente", b =>
                {
                    b.HasOne("PeluqueriaDesktop.Modelos.DetalleTrabajos", null)
                        .WithMany("Clientes")
                        .HasForeignKey("DetalleTrabajosId");

                    b.HasOne("PeluqueriaDesktop.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("PeluqueriaDesktop.Modelos.DetalleTrabajos", b =>
                {
                    b.HasOne("PeluqueriaDesktop.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeluqueriaDesktop.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("PeluqueriaDesktop.Modelos.Producto", b =>
                {
                    b.HasOne("PeluqueriaDesktop.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("PeluqueriaDesktop.Turno", b =>
                {
                    b.HasOne("PeluqueriaDesktop.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeluqueriaDesktop.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("PeluqueriaDesktop.Usuario", b =>
                {
                    b.HasOne("PeluqueriaDesktop.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId1");
                });
#pragma warning restore 612, 618
        }
    }
}
