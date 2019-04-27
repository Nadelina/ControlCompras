using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlCompras.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}