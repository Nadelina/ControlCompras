using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlCompras.Models
{
    public class Marca
    {
        [Key]
        public int IdMarca { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Display(Name ="Proveedor")]
        public int IdProveedor { get; set; }
        public virtual ICollection<Producto> Producto { get; set;}
        public virtual Proveedor Proveedor { get; set; }
    }
}