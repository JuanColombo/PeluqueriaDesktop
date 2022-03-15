using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PeluqueriaDesktop;
using PeluqueriaDesktop.Modelos;

namespace PeluqueriaDesktop
{
   public class PeluqueriaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(HelperPeluqueria.ObtenerCadenaDeConexion());

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().HasData(
              new Usuario { Id = 1, Nombre = "Ivan Valle", User = "ivan", Password = "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3", TipoUsuario = TipoUsuarioEnum.Administrador },
              new Usuario { Id = 2, Nombre = "Juan Pablo Colombo", User = "juan", Password = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", TipoUsuario = TipoUsuarioEnum.Administrador },
              new Usuario { Id = 3, Nombre = "Andrea Dellguste", User = "andrea", Password = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", TipoUsuario = TipoUsuarioEnum.Dueño }
                );



        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DetalleTrabajos> DetalleTrabajos { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Caja> Caja { get; set; }



        public PeluqueriaContext(DbContextOptions<PeluqueriaContext> options) : base(options)
        {

        }

        public PeluqueriaContext()
        {
        }

    }
}
