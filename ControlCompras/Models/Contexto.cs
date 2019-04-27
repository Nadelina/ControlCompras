namespace ControlCompras.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Contexto : DbContext
    {        
        public Contexto()
            : base("name=Contexto")
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }


    }


}