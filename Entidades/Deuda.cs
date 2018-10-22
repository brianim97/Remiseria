using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deuda
    {
        public int IdDeuda { get; set; }
        public int IdChofer { get; set; }
        public int IdPago { get; set; }
        public float Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Deuda()
        {

        }
        public Deuda(int iddeuda, int idchofer, int idpago, float monto, DateTime fecha)
        {
            IdDeuda = iddeuda;
            IdChofer = idchofer;
            IdPago = idpago;
            Monto = monto;
            Fecha = fecha;

        }

    }
}
