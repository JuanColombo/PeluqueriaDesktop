
using Microsoft.EntityFrameworkCore;
using PeluqueriaDesktop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeluqueriaDesktop.AdminData
{
     class DbAdminClientes : IDbAdmin
    {
        public void Actualizar(object cliente)
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(object cliente)
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            db.Cliente.Add((Cliente)cliente);
            db.SaveChanges();
        }

        public void Eliminar(int idSeleccionado)
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            var cliente = db.Cliente.Find(idSeleccionado);

            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            cliente.Eliminado = true;
            cliente.FechaHoraEliminacion = DateTime.Now;
            cliente.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using PeluqueriaContext db = new PeluqueriaContext();
            return db.Cliente.Find(idObtener);
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            return db.Cliente.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }
        public IEnumerable<object> ObtenerEliminados(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using PeluqueriaContext db = new PeluqueriaContext();
            ////consultamos en la cadena buscada si contiene la expresion
            return db.Cliente.Where(c => c.Nombre.Contains(cadenaBuscada) || c.Apellido.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList().ToList();
        }

        public IEnumerable<object> ObtenerTodos()
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            return db.Cliente.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }
        public IEnumerable<object> ObtenerTodosyEliminados()
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            return db.Cliente.Include(u => u.Usuario).ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using PeluqueriaContext db = new PeluqueriaContext();
            ////consultamos en la cadena buscada si contiene la expresion
            return db.Cliente.Where(c => c.Nombre.Contains(cadenaBuscada) || c.Apellido.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList().ToList();
        }

        public void Restaurar(int idSeleccionado)
        {
            using PeluqueriaContext db = new PeluqueriaContext();
            var cliente = db.Cliente.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            cliente.Eliminado = false;
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
