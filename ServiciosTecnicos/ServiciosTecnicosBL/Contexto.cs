using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicosBL
{
    public class Contexto: DbContext
    {
        public Contexto(): base("ServiciosTecnicosDB")
        {

        }

        public DbSet<Producto> Productos { get; set; }

    }
}
