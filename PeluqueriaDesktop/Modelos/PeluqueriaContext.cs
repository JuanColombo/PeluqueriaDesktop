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
          


        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }



        public PeluqueriaContext(DbContextOptions<PeluqueriaContext> options) : base(options)
        {

        }

        public PeluqueriaContext()
        {
        }

    }
}
