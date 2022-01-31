using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PeluqueriaDesktop
{
    public class Cliente : ModeloBase
    {
       
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public double Telefono { get; set; }
        
    }
}
