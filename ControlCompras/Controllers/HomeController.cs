using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControlCompras.Models;
namespace ControlCompras.Controllers
{
    public class HomeController : Controller
    {
        Contexto db = new Contexto();
        public ActionResult Index()
        {
            var queryProducto = (from prducto in db.Producto select prducto).ToList();
            ViewData["Productos"] = queryProducto;

            var queryCategoria = (from cat in db.Categoria select cat).ToList();
            ViewData["Categoria"] = queryCategoria;

            var queryMarca = (from marca in db.Marca select marca).ToList();
            ViewData["Marca"] = queryMarca;

            var queryUbicacion = (from u in db.Ubicacion select u).ToList();
            ViewData["Ubicaciones"] = queryUbicacion;

            var queryProveedores = (from pv in db.Proveedor select pv).ToList();
            ViewData["Provedores"] = queryProveedores;

            var queryFactura = (from fc in db.Factura select fc).ToList();
            ViewData["Factura"] = queryFactura;

            //var querydFactura = (from f in db.Factura
            //                    join df in db.DetalleFactura
            //                    on f.IdFactura equals df.IdFactura

            //                     ).ToList(); 
            //ViewData["Categoria"] = queryCategoria;

            return View();
        }
        public ActionResult Iniciar()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}