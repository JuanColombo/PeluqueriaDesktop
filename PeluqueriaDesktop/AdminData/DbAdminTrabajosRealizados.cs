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

        public IEnumerable<object> ObtenerTodos()
        {
            //using PeluqueriaContext db = new PeluqueriaContext();
            //    var trabajosAListar = from detalleTrabajo in db.DetalleTrabajos
            //                      select new
            //                      {
            //                          Id = detalleTrabajo.Id,
            //                          Fecha = detalleTrabajo.Fecha,
            //                          Detalle = detalleTrabajo.DetalleTrabajo,
            //                          Cliente = detalleTrabajo.cliente.Nombre + " " + detalleTrabajo.cliente.Apellido,
            //                          FormaPago = detalleTrabajo.FormaDePago
            //                      };
            //return trabajosAListar.ToList();
            throw new NotImplementedException();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            ////instanciamos nuestro objeto db Context
            //using PeluqueriaContext db = new PeluqueriaContext();
            //////consultamos en la cadena buscada si contiene la expresion
            // var trabajosAListar = from detalleTrabajo in db.DetalleTrabajos
            //                            select new
            //                            {
            //                                Id = detalleTrabajo.Id,
            //                                Fecha = detalleTrabajo.Fecha,
            //                                Detalle = detalleTrabajo.DetalleTrabajo,
            //                                Cliente = detalleTrabajo.cliente.Nombre +" "+detalleTrabajo.cliente.Apellido,
            //                                FormaPago = detalleTrabajo.FormaDePago
            //                            };
            //return trabajosAListar.Where(c => c.Cliente.Contains(cadenaBuscada)).ToList();
            ////db.DetalleTrabajos.Where(c => c.cliente.Nombre.Contains(cadenaBuscada)||c.cliente.Apellido.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList().ToList();
            throw new NotImplementedException();
        }


        //    using (var db = new InmobiliariaContext())
        //        {
        //            //creamos una coleccion para seleccionar los datos que queremos mostrar en la grilla 
        //            var propietariosAListar = from propietario in db.Propietario
        //                                      select new
        //                                      {
        //                                          Id = propietario.Id,
        //                                          Nombre = propietario.Apellido + " " + propietario.Nombre,
        //                                          DNI = propietario.Dni,
        //                                          Telefono = propietario.Telefono,
        //                                          Domicilio = propietario.Domicilio,
        //                                          Localidad = propietario.Localidad
        //                                      };
        ////cargamos la grilla con la coleccion creada

        //Grid.DataSource = propietariosAListar.ToList();
        //        }

        public void Restaurar(int idSeleccionado)
        {
            throw new NotImplementedException();
        }
    }
}
