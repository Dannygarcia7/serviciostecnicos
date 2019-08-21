using ServiciosTecnicosBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiciosTecnicos.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var productosBL = new Producto();
            var listadeproductos = productosBL.ObtenerProductos();

            return View(listadeproductos);
        }
    }
}