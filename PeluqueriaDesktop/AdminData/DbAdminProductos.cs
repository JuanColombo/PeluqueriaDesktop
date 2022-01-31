
using Microsoft.EntityFrameworkCore;
using PeluqueriaDesktop.Interfaces;
using PeluqueriaDesktop.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeluqueriaDesktop.AdminData
{
    class DbAdminProductos : IDbAdmin
    {
        public void Actualizar(object producto)
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            db.Entry(producto).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(object producto)
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            db.Producto.Add((Producto)producto);
            db.SaveChanges();
        }

        public void Eliminar(int idSeleccionado)
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            var producto = db.Producto.Find(idSeleccionado);
            
            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            producto.Eliminado = true;
            producto.FechaHoraEliminacion = DateTime.Now;
            producto.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(producto).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using PeluqueriaContext db = new PeluqueriaContext();
            return db.Producto.Find(idObtener);
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            return db.Producto.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }

        public IEnumerable<object> ObtenerTodos()
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            return db.Producto.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using PeluqueriaContext db = new PeluqueriaContext();
            ////consultamos en la cadena buscada si contiene la expresion
            return db.Producto.Where(c => c.Descripcion.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList().ToList();
        }

        public void Restaurar(int idSeleccionado)
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            var producto = db.Producto.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            producto.Eliminado = false;
            db.Entry(producto).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
