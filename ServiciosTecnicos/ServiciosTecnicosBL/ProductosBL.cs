using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicosBL
{
    public class ProductosBL
    {
        Contexto _contexto;
        public ProductosBL()
        {
            _contexto = new Contexto();
        }


        public List<Producto> ObtenerProductos()
        {
            _contexto.Productos.ToList();

            var producto = new Producto();
            producto.Id = 1;
            producto.Descripcion = "Mantenimiento de Sistema";
            producto.Precio = 2500;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Limpieza de Computadora";
            producto2.Precio = 3000;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Configuracion de Router";
            producto3.Precio = 1500;

            var listadeproductos = new List<Producto>();
            listadeproductos.Add(producto);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);

            return listadeproductos;
        }
    }
}
