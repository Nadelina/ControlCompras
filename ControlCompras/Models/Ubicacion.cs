using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlCompras.Models
{
    public class Ubicacion
    {
        [Key]
        public int IdUbicacion { get; set; }
        [Required]
        public string Descripcion { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}