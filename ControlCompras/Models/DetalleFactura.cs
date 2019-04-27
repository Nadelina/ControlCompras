using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlCompras.Models
{
    public class DetalleFactura
    {
        [Key]
        public int IdDetalle { get; set; }
        [Display(Name = "Factura ")]
        public int IdFactura { get; set; }
        [Display(Name = "Producto ")]
        public int IdProducto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        [Display(Name = "Precio Compra")]
        public decimal PrecioCompra { get; set; }
        [Required]
        public decimal Total { get; set; }

        public virtual Factura Factura { get; set; }
        public virtual Producto Producto { get; set; }
    }   
}