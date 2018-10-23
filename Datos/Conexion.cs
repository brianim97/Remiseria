using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{

    internal static class Conexion
    {
        public static string strConexion = "Data Source="+Application.StartupPath+"\\remiseria.db;Version = 3";
    }
}
   
