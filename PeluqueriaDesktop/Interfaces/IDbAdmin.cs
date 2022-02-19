using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaDesktop.Interfaces
{
    public interface IDbAdmin
    {
        IEnumerable<object> ObtenerTodos();
        IEnumerable<object> ObtenerEliminados();
        IEnumerable<object> ObtenerEliminados(string cadenaBuscada);
        IEnumerable<object> ObtenerTodos(string cadenaBuscada);
        void Eliminar(int idSeleccionado);
        void Restaurar(int idSeleccionado);
        object Obtener(int? idObtener);
        void Agregar(object Modelo);
        void Actualizar(object Modelo);
    }
}
