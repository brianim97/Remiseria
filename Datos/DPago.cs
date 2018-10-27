﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class DPago
    {
        private int _IdPago;
        private string _Dia;
        private string _Mes;


        public SQLiteDataAdapter TraerVistaPago()
        {
            string str = @"SELECT * FROM ReportePago";
            SQLiteDataAdapter da = new SQLiteDataAdapter(str,Conexion.strConexion);
            return da;
        }

        private string _Anio;
        private string _Hora;
        private int _idChofer;
        private double _Monto;



        public int IdPago { get => _IdPago; set => _IdPago = value; }
        public string Dia { get => _Dia; set => _Dia = value; }
        public string Mes { get => _Mes; set => _Mes = value; }
        public string Anio { get => _Anio; set => _Anio = value; }
        public string Hora { get => _Hora; set => _Hora = value; }
        public int IdChofer { get => _idChofer; set => _idChofer = value; }
        public double Monto { get => _Monto; set => _Monto = value; }
       

        public DPago()
        {

        }

        public DPago(int idpago, string dia, string mes, string anio, string hora ,int idchofer, double monto)
        {
            this.IdPago = idpago;
            this.Dia = dia;
            this.Mes = mes;
            this.Anio = anio;
            this.Hora = hora;
            this.IdChofer = idchofer;
            this.Monto = monto;
        }

        //Insertar
        public int Insertar(DPago Pago)
        {
            //Conexion con = new Conexion();
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            string sql = ("insert into Pago (Dia, Mes, Anio ,Hora, idChofer, Monto) " +
                "values (?,?,?,?,?,?)");
            try
            {


                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("Dia", Pago.Dia));
                cmd.Parameters.Add(new SQLiteParameter("Mes", Pago.Mes));
                cmd.Parameters.Add(new SQLiteParameter("Anio", Pago.Anio));
                cmd.Parameters.Add(new SQLiteParameter("Hora", Pago.Hora));
                cmd.Parameters.Add(new SQLiteParameter("idChofer", Pago.IdChofer));
                cmd.Parameters.Add(new SQLiteParameter("Monto", Pago.Monto));
                conector.Open();
                cmd.ExecuteNonQuery();

                SQLiteCommand cmd2 = new SQLiteCommand("SELECT last_insert_rowid() ", conector);
                int id = Convert.ToInt32(cmd2.ExecuteScalar());
                conector.Close();
                return id;

            }
            catch(Exception)
            {
                return -1;
            }



        }
        public string Editar(DPago Pago)
        {
            //Conexion con = new Conexion();
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            string rpta = "";
            string sql = ("update Pago "
                    + "set idPago = ?, Dia = ?, Mes = ?, Anio = ?, Hora = ?, idChofer = ?, Monto = ?"
                    + "where idPago = ?");
            try
            {


                SQLiteCommand cmd = new SQLiteCommand(sql, conector);

                cmd.Parameters.Add(new SQLiteParameter("Dia", Pago.Dia));
                cmd.Parameters.Add(new SQLiteParameter("Mes", Pago.Mes));
                cmd.Parameters.Add(new SQLiteParameter("Anio", Pago.Anio));
                cmd.Parameters.Add(new SQLiteParameter("Hora", Pago.Hora));
                cmd.Parameters.Add(new SQLiteParameter("idChofer", Pago.IdChofer));
                cmd.Parameters.Add(new SQLiteParameter("Monto", Pago.Monto));
                cmd.Parameters.Add(new SQLiteParameter("idPago", Pago.IdPago));
                conector.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se edito el registro";
                conector.Close();
                return rpta;

            }
            catch (SQLiteException ex)
            {
                return rpta = ex.Message;
            }



        }
        public string Eliminar(DPago Pago)
        {
            //Conexion con = new Conexion();
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            string rpta = "";
            string sql = ("delete from  Pago where idPago = ?");
            try
            {


                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("idPago", Pago.IdPago));
                conector.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el registro";
                conector.Close();
                return rpta;

            }
            catch (SQLiteException ex)
            {
                return rpta = ex.Message;
            }



        }
        public void Mostrar(DataGridView dgb)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            conector.Open();
            DataTable dtRes = new DataTable();
            String sql = "SELECT  idPago as N°Pago,Chofer.Movil, Chofer.NombreApellido, Chofer.Dni, Chofer.MarcaModelo as Vehiculo, Chofer.Patente, Pago.Dia, Pago.Mes, Pago.Anio, Pago.Hora, Pago.Monto  FROM Pago" +
                " INNER JOIN Chofer ON Pago.idChofer = Chofer.idChofer";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conector);
            da.Fill(dtRes);
            dgb.DataSource = dtRes;
            conector.Close();

        }

        public void BuscarPorNombreyMesAnio(DataGridView dgb, string nombreapellido, string mes, string anio)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            try
            {
                conector.Open();


                string sql = "SELECT idPago as N°Pago,Chofer.Movil, Chofer.NombreApellido, Chofer.Dni, Chofer.MarcaModelo as Vehiculo, Chofer.Patente, Pago.Dia, Pago.Mes, Pago.Anio, Pago.Hora ,Pago.Monto  FROM Pago INNER JOIN Chofer ON Pago.idChofer = Chofer.idChofer WHERE  Chofer.NombreApellido LIKE ?  AND Pago.Mes LIKE ? AND Pago.Anio LIKE ? ";
                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("NombreApellido", "%" + nombreapellido + "%"));
                cmd.Parameters.Add(new SQLiteParameter("Mes",mes ));
                cmd.Parameters.Add(new SQLiteParameter("Anio",  anio));
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dtRes = new DataTable();
                da.Fill(dtRes);
                dgb.DataSource = dtRes;
                conector.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void BuscarPorNombreDiasyMesAnio(DataGridView dgb, string nombreapellido, string mes ,string DiaInicio, string DiaFin, string anio)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            try
            {
                conector.Open();


                string sql = "SELECT idPago as N°Pago,Chofer.Movil, Chofer.NombreApellido, Chofer.Dni, Chofer.MarcaModelo as Vehiculo, Chofer.Patente, Pago.Dia, Pago.Mes, Pago.Anio, Pago.Hora ,Pago.Monto  FROM Pago INNER JOIN Chofer ON Pago.idChofer = Chofer.idChofer WHERE  Chofer.NombreApellido LIKE @nombreapellido AND Pago.Mes LIKE @mes  AND Pago.Dia >= cast(@diainicio as int) AND Pago.Dia <= cast(@diafin as int) AND Pago.Anio LIKE @anio";
                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("@nombreapellido", "%" + nombreapellido + "%"));
                cmd.Parameters.Add(new SQLiteParameter("@mes",   mes ));
                cmd.Parameters.Add(new SQLiteParameter("@diainicio", DiaInicio ));
                cmd.Parameters.Add(new SQLiteParameter("@diafin",  DiaFin ));
                cmd.Parameters.Add(new SQLiteParameter("@anio", anio));
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dtRes = new DataTable();
                da.Fill(dtRes);
                dgb.DataSource = dtRes;
                conector.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void BuscarPorDiasyMesAnio(DataGridView dgb,  string mes, string DiaInicio, string DiaFin, string anio)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            try
            {
                conector.Open();


                string sql = "SELECT idPago as N°Pago,Chofer.Movil, Chofer.NombreApellido, Chofer.Dni, Chofer.MarcaModelo as Vehiculo, Chofer.Patente, Pago.Dia, Pago.Mes, Pago.Anio, Pago.Hora ,Pago.Monto  FROM Pago INNER JOIN Chofer ON Pago.idChofer = Chofer.idChofer WHERE   Pago.Mes LIKE @mes  AND Pago.Dia >=cast(@diainicio as int) AND Pago.Dia <= cast(@diafin as int) AND Pago.Anio LIKE @anio";
                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("@mes", mes));
                cmd.Parameters.Add(new SQLiteParameter("@diainicio", DiaInicio));
                cmd.Parameters.Add(new SQLiteParameter("@diafin", DiaFin));
                cmd.Parameters.Add(new SQLiteParameter("@anio", anio));
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dtRes = new DataTable();
                da.Fill(dtRes);
                dgb.DataSource = dtRes;
                conector.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void BuscarPorMovilDiasMesAnio(DataGridView dgb, string movil, string mes, string DiaInicio, string DiaFin, string anio)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            try
            {
                conector.Open();


                string sql = "SELECT idPago as N°Pago,Chofer.Movil, Chofer.NombreApellido, Chofer.Dni, Chofer.MarcaModelo as Vehiculo, Chofer.Patente, Pago.Dia, Pago.Mes, Pago.Anio, Pago.Hora ,Pago.Monto  FROM Pago INNER JOIN Chofer ON Pago.idChofer = Chofer.idChofer WHERE  Chofer.Movil LIKE @movil AND Pago.Mes LIKE @mes  AND Pago.Dia >= cast(@diainicio as int) AND Pago.Dia <= cast(@diafin as int) AND Pago.Anio LIKE @anio";
                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("@movil", "%" + movil + "%"));
                cmd.Parameters.Add(new SQLiteParameter("@mes", mes));
                cmd.Parameters.Add(new SQLiteParameter("@diainicio", DiaInicio));
                cmd.Parameters.Add(new SQLiteParameter("@diafin", DiaFin));
                cmd.Parameters.Add(new SQLiteParameter("@anio", anio));
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dtRes = new DataTable();
                da.Fill(dtRes);
                dgb.DataSource = dtRes;
                conector.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void BuscarPorMovilMesAnio(DataGridView dgb, string movil, string mes, string anio)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            try
            {
                conector.Open();


                string sql = "SELECT idPago as N°Pago,Chofer.Movil, Chofer.NombreApellido, Chofer.Dni, Chofer.MarcaModelo as Vehiculo, Chofer.Patente, Pago.Dia, Pago.Mes, Pago.Anio, Pago.Hora ,Pago.Monto  FROM Pago INNER JOIN Chofer ON Pago.idChofer = Chofer.idChofer WHERE  Chofer.Movil LIKE ?  AND Pago.Mes LIKE ? AND Pago.Anio LIKE ? ";
                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("Movil", "%" + movil + "%"));
                cmd.Parameters.Add(new SQLiteParameter("Mes", mes));
                cmd.Parameters.Add(new SQLiteParameter("Anio", anio));
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dtRes = new DataTable();
                da.Fill(dtRes);
                dgb.DataSource = dtRes;
                conector.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




    }
}
