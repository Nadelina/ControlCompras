using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlCompras.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public string BarCode { get; set; }
        [Required]
        [Display(Name ="Nombre producto")]
        public string Nombre { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }
        [Display(Name = "Marca")]
        public int IdMarca { get; set; }
        [Display(Name = "Categoria")]
        public int IdCategoria { get; set; }
        [Display(Name ="Ubicacion")]
        public int IdUbicacion { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }

    }
}