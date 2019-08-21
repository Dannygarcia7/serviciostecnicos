using ServiciosTecnicosBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiciosTecnicos.WebAdmin.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriasBL _categoriasBL;

        public CategoriasController()
        {
            _categoriasBL = new CategoriasBL();
        }

        // GET: Categorias
        public ActionResult Index()
        {
            var listadecategorias = _categoriasBL.ObtenerCategorias();
            return View(listadecategorias);
        }

        public ActionResult Crear()
        {
            var nuevacategoria = new Categoria();
            return View(nuevacategoria);
        }

        [HttpPost]
        public ActionResult Crear(Categoria producto)
        {
            _categoriasBL.GuargarCategorias(producto);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);
        }

        [HttpPost]
        public ActionResult Editar(Categoria producto)
        {
            _categoriasBL.GuargarCategorias(producto);
            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);
        }

        [HttpPost]
        public ActionResult Eliminar(Categoria producto)
        {
            _categoriasBL.EliminarCategoria(producto.Id);
            return RedirectToAction("Index");
        }



    }
}