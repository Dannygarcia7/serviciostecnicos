using ServiciosTecnicos.Web.Models;
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
            var producto = new ProductosModel();
            producto.Id = 1;
            producto.Descripcion = "Mantenimiento de Sistema";

            var producto2 = new ProductosModel();
            producto2.Id = 2;
            producto2.Descripcion = "Limpeza de Computadora";

            var producto3 = new ProductosModel();
            producto3.Id = 3;
            producto3.Descripcion = "Configuracion de Router";

            var listadeproductos = new List<ProductosModel>();
            listadeproductos.Add(producto);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);

            return View(listadeproductos);
        }
    }
}