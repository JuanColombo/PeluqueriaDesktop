using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PeluqueriaDesktop.Modelos
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        public string Cantidad { get; set; }
        [Required]
        public double Codigo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
