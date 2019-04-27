using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlCompras.Models
{
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }
        [Required]
        [Display(Name = "N° Factura ")]
        public int NumeroFactura { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "yyyy/MM/dd", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de compra ")]
        public DateTime FechaCompra { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "yyyy/MM/dd", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de registro ")]
        public DateTime FechaRegistro { get; set; }

        public virtual ICollection<DetalleFactura> Detalle { get; set; }
    }
}