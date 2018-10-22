using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDeuda
    {
        public bool Insertar(Entidades.Deuda d)
        {
            return new Datos.DDeuda().Insertar(d); 
        }

        public bool Eliminar(int id)
        {
            return new Datos.DDeuda().Eliminar(id);
        }

        public DataTable Mostrar()
        {
            return new Datos.DDeuda().Mostrar();
        }

        public DataTable MostrarPorMovil(int movil)
        {
            return new Datos.DDeuda().MostrarPorMovil(movil);
        }
    }
}
