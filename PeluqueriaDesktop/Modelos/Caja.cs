using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PeluqueriaDesktop.Modelos
{
   public class Caja
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        public double TotalCaja { get; set; }
        [Required]
        public double RetiroCaja { get; set; }
    }
}
