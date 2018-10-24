using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Datos
{
    public class DDeuda
    {
        public bool Insertar(Entidades.Deuda d)
        {
            if (Contains(d.IdChofer, d.Fecha.ToString("yyyy-MM-dd")))
            {
                return false;
            }

            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            string sql = "INSERT INTO Deuda (idChofer, idPago, Monto, Fecha) " +
                         "VALUES ( @idchofer, @idpago, @monto, @fecha)";

            SQLiteCommand cmd = new SQLiteCommand(sql, conector);
            cmd.Parameters.Add(new SQLiteParameter("@idchofer", d.IdChofer));
            cmd.Parameters.Add(new SQLiteParameter("@idpago", d.IdPago));
            cmd.Parameters.Add(new SQLiteParameter("@monto", d.Monto));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", d.Fecha.ToString("yyyy-MM-dd")));

            conector.Open();
            cmd.ExecuteNonQuery();
            conector.Close();
            return true;
        }

        public bool Eliminar(int iddeuda)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);

            string sql = "DELETE FROM Deuda WHERE idDeuda = @iddeuda";

            SQLiteCommand cmd = new SQLiteCommand(sql, conector);
            cmd.Parameters.Add(new SQLiteParameter("@iddeuda", iddeuda));

            conector.Open();
            cmd.ExecuteNonQuery();
            conector.Close();
            return true;

        }

        public DataTable Mostrar()
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            conector.Open();
            string sql = @"SELECT Chofer.NombreApellido, Chofer.Movil, Deuda.Monto, Deuda.Fecha, Deuda.idDeuda FROM Deuda INNER JOIN Chofer ON Deuda.idChofer = Chofer.idChofer";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conector);
            DataTable dt = new DataTable("Deudores");
            da.Fill(dt);
            conector.Close();
            return dt;
        }

        public DataTable MostrarPorMovil(string movil)
        {

            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            conector.Open();
            string sql = @"SELECT Chofer.NombreApellido, Chofer.Movil, Deuda.Monto, Deuda.Fecha, Deuda.idDeuda FROM Deuda INNER JOIN Chofer ON Deuda.idChofer = Chofer.idChofer WHERE Chofer.Movil LIKE @movil ";
            SQLiteCommand cmd = new SQLiteCommand(sql, conector);
            cmd.Parameters.Add(new SQLiteParameter("@movil","%"+ movil+ "%"));
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable("Deudores");
            da.Fill(dt);
            conector.Close();
            return dt;
        }

        public DataTable MostrarPorNombreApellido(string nombreapellido)
        {

            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            conector.Open();
            string sql = @"SELECT Chofer.NombreApellido, Chofer.Movil, Deuda.Monto, Deuda.Fecha, Deuda.idDeuda FROM Deuda INNER JOIN Chofer ON Deuda.idChofer = Chofer.idChofer WHERE Chofer.NombreApellido LIKE @nombreapellido ";
            SQLiteCommand cmd = new SQLiteCommand(sql, conector);
            cmd.Parameters.Add(new SQLiteParameter("@nombreapellido", "%" + nombreapellido + "%"));
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable("Deudores");
            da.Fill(dt);
            conector.Close();
            return dt;
        }

        public bool Contains(int id, string fecha)
        {

            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);

            string sql = "Select Exists (Select 1 from Deuda inner join Chofer on Deuda.idChofer = Chofer.idChofer Where Chofer.EsActivo = 1 AND Deuda.Fecha = @fecha And Chofer.idChofer = @idChofer);";

            SQLiteCommand cmd = new SQLiteCommand(sql, conector);
            cmd.Parameters.Add(new SQLiteParameter("@idChofer", id));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", fecha));

            conector.Open();
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            conector.Close();

            return a == 1;
        }

    }
}
