using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PeluqueriaDesktop
{
    public class Turno : ModeloBase
    {
       
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public DateTime Hora { get; set; }
        [Required]
        public string TrabajoARealizar { get; set; }
        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
