using ServiciosTecnicosBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiciosTecnicos.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {
        ProductosBL _productosBL;
        CategoriasBL _categoriasBL;

        public ProductosController()
        {
            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();
        }
        // GET: Productos
        public ActionResult Index()
        {
            var listadeproductos = _productosBL.ObtenerProductos();

            return View(listadeproductos);
        }

        public ActionResult Crear()
        {
            var nuevoproducto = new Producto();
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.Listadecategorias = 
                new SelectList(categorias, "Id", "Descripcion");

            return View(nuevoproducto);
        }

        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
            _productosBL.GuardarProductos(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            var categoria = _categoriasBL.ObtenerCategoria(id);

            ViewBag.CategoriaId = 
                new SelectList(categoria, "Id" , "Descripcion" , producto.CategoriaId);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Editar(Producto producto)
        {
            _productosBL.GuardarProductos(producto);
            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            return View(producto);
        }

       public ActionResult Eliminar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            return View(producto);
        }

        [HttpPost]
        public ActionResult Eliminar(Producto producto)
        {
            _productosBL.EliminarProducto(producto.Id);
            return RedirectToAction("Index");
        }
    }
}