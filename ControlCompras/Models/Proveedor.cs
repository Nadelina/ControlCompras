using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlCompras.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }
        [Required]
        [Display(Name = "Razon social ")]
        public string RazonSocial { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "DUI ")]
        public string Dui { get; set; }
        [Required]
        [Display(Name = "NIT ")]
        public string Nit { get; set; }
        [Required]
        [Display(Name = "NRC ")]
        public string Nrc { get; set; }

        public virtual ICollection<Marca> Marca { get; set; }
    }
}