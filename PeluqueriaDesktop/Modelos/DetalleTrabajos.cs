using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PeluqueriaDesktop.Modelos
{
   public class DetalleTrabajos : ModeloBase
    {
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public int ClienteId { get; set; }
        public Cliente cliente { get; set; }
        [Required]
        public string DetalleTrabajo { get; set; }
        [Required]
        public TipoDePagoEnum FormaDePago { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public double Entrega { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}
