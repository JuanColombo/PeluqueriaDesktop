using Microsoft.EntityFrameworkCore;
using PeluqueriaDesktop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeluqueriaDesktop.AdminData
{
    class DbAdminTurnos : IDbAdmin
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
            using PeluqueriaContext db = new PeluqueriaContext();
            var turno = db.Turnos.Find(idSeleccionado);

            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            turno.Eliminado = true;
            turno.FechaHoraEliminacion = DateTime.Now;
            turno.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(turno).State = EntityState.Modified;
            db.SaveChanges();
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
            //using PeluqueriaContext db = new PeluqueriaContext();
            //return db.Turnos.ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            throw new NotImplementedException();
        }

        public void Restaurar(int idSeleccionado)
        {
            throw new NotImplementedException();
        }
    }
}
