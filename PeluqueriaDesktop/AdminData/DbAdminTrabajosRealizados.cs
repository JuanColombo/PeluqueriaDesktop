using Microsoft.EntityFrameworkCore;
using PeluqueriaDesktop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeluqueriaDesktop.AdminData
{
    class DbAdminTrabajosRealizados : IDbAdmin
    {
        public void Actualizar(object Modelo)
        {
            throw new NotImplementedException();
        }

        public void Agregar(object Modelo)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int idSeleccionado)
        {
            throw new NotImplementedException();
        }

        public object Obtener(int? idObtener)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> ObtenerEliminados(string cadenaBuscada)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using PeluqueriaContext db = new PeluqueriaContext();
            ////consultamos en la cadena buscada si contiene la expresion
            return db.DetalleTrabajos.Where(c => c.cliente.Nombre.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList().ToList();
        }


     

        public void Restaurar(int idSeleccionado)
        {
            throw new NotImplementedException();
        }
    }
}
