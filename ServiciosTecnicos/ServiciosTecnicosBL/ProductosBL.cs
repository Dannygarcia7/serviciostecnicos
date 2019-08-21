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
        public List<Producto> Listadeprodutos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            Listadeprodutos = new List<Producto>();
        }


        public List<Producto> ObtenerProductos()
        {
            Listadeprodutos = _contexto.Productos.ToList();
            return Listadeprodutos;
        }
    }
}
