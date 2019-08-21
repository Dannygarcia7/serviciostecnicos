using System.Collections.Generic;

namespace ServiciosTecnicosBL
{
    public interface IProductosBL
    {
        List<Producto> Listadeprodutos { get; set; }

        void EliminarProducto(int id);
        void GuardarProductos(Producto producto);
        Producto ObtenerProducto(int id);
        List<Producto> ObtenerProductos();
    }
}