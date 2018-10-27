using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class DChofer
    {
        private int _IdChofer;
        private string _Movil;
        private string _NombreApellido;
        private int _Dni;
        private string _FechaNacimiento;
        private string _NroTelefono;
        private string _Direccion;
        private string _EstadoCivil;
        private string _MarcaModelo;
        private string _Anio;
        private string _Patente;
        private string _NroChasis;
        private string _NroMotor;
        private string _FechaIngreso;
        private string _Propietario;
        private string _TelefonoPropietario;

        public int IdChofer { get => _IdChofer; set => _IdChofer = value; }
        public string NombreApellido { get => _NombreApellido; set => _NombreApellido = value; }
        public int Dni { get => _Dni; set => _Dni = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string NroTelefono { get => _NroTelefono; set => _NroTelefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string EstadoCivil { get => _EstadoCivil; set => _EstadoCivil = value; }
        public string MarcaModelo { get => _MarcaModelo; set => _MarcaModelo = value; }
        public string Anio { get => _Anio; set => _Anio = value; }
        public string Patente { get => _Patente; set => _Patente = value; }
        public string NroChasis { get => _NroChasis; set => _NroChasis = value; }
        public string NroMotor { get => _NroMotor; set => _NroMotor = value; }
        public string FechaIngreso { get => _FechaIngreso; set => _FechaIngreso = value; }
        public string Propietario { get => _Propietario; set => _Propietario = value; }
        public string TelefonoPropietario { get => _TelefonoPropietario; set => _TelefonoPropietario = value; }
        public string Movil { get => _Movil; set => _Movil = value; }

        public DChofer()
        {

        }

        public DChofer(int idchofer, string movil, string nombreapellido, int dni, string fechanacimiento, string nrotelefono, string direccion, string estadocivil, string marcamodelo, string anio, string patente, string nrochasis, string nromotor,string fechaingreso,string propietario, string telefonopropietario)
        {
            this.IdChofer = idchofer;
            this.Movil = movil;
            this.NombreApellido = nombreapellido;
            this.Dni = dni;
            this.FechaNacimiento = fechanacimiento;
            this.NroTelefono = nrotelefono;
            this.Direccion = direccion;
            this.EstadoCivil = estadocivil;
            this.MarcaModelo = marcamodelo;
            this.Anio = anio;
            this.Patente = patente;
            this.NroChasis = nrochasis;
            this.NroMotor = nromotor;
            this.FechaIngreso = fechaingreso;
            this.Propietario = propietario;
            this.TelefonoPropietario = telefonopropietario;

        }

        //metodo insertar
        public string Insertar(DChofer Chofer)
        {
            //Conexion con = new Conexion();
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            string rpta = "";
            string sql = ("insert into Chofer (Movil, NombreApellido, Dni, FechaNacimiento,NroTelefono,Direccion,EstadoCivil,MarcaModelo,Anio,Patente,NroChasis,NroMotor,FechaIngreso,Propietario,TelPropietario) " +
                "values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)");
            try
            {


                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("Movil", Chofer.Movil));
                cmd.Parameters.Add(new SQLiteParameter("NombreApellido", Chofer.NombreApellido));
                cmd.Parameters.Add(new SQLiteParameter("Dni", Chofer.Dni));
                cmd.Parameters.Add(new SQLiteParameter("FechaNacimiento", Chofer.FechaNacimiento));
                cmd.Parameters.Add(new SQLiteParameter("NroTelefono", Chofer.NroTelefono));
                cmd.Parameters.Add(new SQLiteParameter("Direccion", Chofer.Direccion));
                cmd.Parameters.Add(new SQLiteParameter("EstadoCivil", Chofer.EstadoCivil));
                cmd.Parameters.Add(new SQLiteParameter("MarcaModelo", Chofer.MarcaModelo));
                cmd.Parameters.Add(new SQLiteParameter("Anio", Chofer.Anio));
                cmd.Parameters.Add(new SQLiteParameter("Patente", Chofer.Patente));
                cmd.Parameters.Add(new SQLiteParameter("NroChasis", Chofer.NroChasis));
                cmd.Parameters.Add(new SQLiteParameter("NroMotor", Chofer.NroMotor));
                cmd.Parameters.Add(new SQLiteParameter("FechaIngreso", Chofer.FechaIngreso));
                cmd.Parameters.Add(new SQLiteParameter("Propietario", Chofer.Propietario));
                cmd.Parameters.Add(new SQLiteParameter("TelPropietario", Chofer.TelefonoPropietario));
                conector.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";
                conector.Close();
                return rpta;

            }
            catch (SQLiteException ex)
            {
                return rpta = ex.Message;
            }



        }
        public string Editar(DChofer Chofer)
        {
            //Conexion con = new Conexion();
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            string rpta = "";
            string sql = "UPDATE Chofer "
                    + " SET  Movil = @Movil ,NombreApellido = @NombreApellido ,Dni = @Dni , FechaNacimiento = @FechaNacimiento ,NroTelefono = @NroTelefono ,Direccion = @Direccion ," +
                    "EstadoCivil = @EstadoCivil ,MarcaModelo = @MarcaModelo ,Anio = @Anio ,Patente = @Patente ,NroChasis = @NroChasis ,NroMotor = @NroMotor ,FechaIngreso = @FechaIngreso , Propietario = @Propietario , TelPropietario = @TelPropietario "
                    + " WHERE idChofer = @idChofer ";
            try
            {


                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("@Movil", Chofer.Movil));
                cmd.Parameters.Add(new SQLiteParameter("@NombreApellido", Chofer.NombreApellido));
                cmd.Parameters.Add(new SQLiteParameter("@Dni", Chofer.Dni));
                cmd.Parameters.Add(new SQLiteParameter("@FechaNacimiento", Chofer.FechaNacimiento));
                cmd.Parameters.Add(new SQLiteParameter("@NroTelefono", Chofer.NroTelefono));
                cmd.Parameters.Add(new SQLiteParameter("@Direccion", Chofer.Direccion));
                cmd.Parameters.Add(new SQLiteParameter("@EstadoCivil", Chofer.EstadoCivil));
                cmd.Parameters.Add(new SQLiteParameter("@MarcaModelo", Chofer.MarcaModelo));
                cmd.Parameters.Add(new SQLiteParameter("@Anio", Chofer.Anio));
                cmd.Parameters.Add(new SQLiteParameter("@Patente", Chofer.Patente));
                cmd.Parameters.Add(new SQLiteParameter("@NroChasis", Chofer.NroChasis));
                cmd.Parameters.Add(new SQLiteParameter("@NroMotor", Chofer.NroMotor));
                cmd.Parameters.Add(new SQLiteParameter("@FechaIngreso", Chofer.FechaIngreso));
                cmd.Parameters.Add(new SQLiteParameter("@Propietario", Chofer.Propietario));
                cmd.Parameters.Add(new SQLiteParameter("@TelPropietario", Chofer.TelefonoPropietario));
                cmd.Parameters.Add(new SQLiteParameter("@idChofer", Chofer.IdChofer));
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
        public string Eliminar(DChofer Chofer)
        {
            //Conexion con = new Conexion();
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            string rpta = "";
            string sql = ("delete from  Chofer where idChofer = ?");
            try
            {


                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("idChofer", Chofer.IdChofer));
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

        public void Mostrar(DataGridView dgv)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);

            DataTable dtRes = new DataTable();
            String sql = "Select idChofer,Movil,NombreApellido,Dni,FechaNacimiento,NroTelefono,Direccion,EstadoCivil,MarcaModelo,Anio,Patente,NroChasis,NroMotor,FechaIngreso,Propietario,TelPropietario from Chofer";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conector);
            da.Fill(dtRes);
            dgv.DataSource = dtRes;
        }

        public DataTable Mostrar2()
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);

            DataTable dtRes = new DataTable();
            String sql = "Select idChofer,Movil,NombreApellido,Dni,FechaNacimiento,NroTelefono,Direccion,EstadoCivil,MarcaModelo,Anio,Patente,NroChasis,NroMotor,FechaIngreso,Propietario,TelPropietario from Chofer";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conector);
            da.Fill(dtRes);
            return dtRes;
        }

        public void BuscarPorNombre(DataGridView dgb, string textobuscar)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            try
            {
                conector.Open();


                string sql = "Select idChofer as ID,Movil,NombreApellido,Dni,FechaNacimiento,NroTelefono,Direccion,EstadoCivil,MarcaModelo,Anio,Patente,NroChasis,NroMotor,FechaIngreso,Propietario,TelPropietario FROM Chofer WHERE NombreApellido LIKE ?";
                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("NombreApellido", "%" + textobuscar + "%"));
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

        public void BuscarPorDni(DataGridView dgb, string textobuscar)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            try
            {
                conector.Open();

                string sql = "Select  idChofer as ID,Movil,NombreApellido, Dni, FechaNacimiento, NroTelefono, Direccion, EstadoCivil, MarcaModelo, Anio, Patente, NroChasis, NroMotor, FechaIngreso,Propietario,TelPropietario FROM Chofer WHERE Dni LIKE ?"; 
               
                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("Dni", "%" + textobuscar + "%"));
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
        public void BuscarPorMarcaModelo(DataGridView dgb, string textobuscar)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            try
            {
                conector.Open();

                string sql = "Select idChofer as ID,Movil,NombreApellido,Dni,FechaNacimiento,NroTelefono,Direccion,EstadoCivil,MarcaModelo,Anio,Patente,NroChasis,NroMotor,FechaIngreso,Propietario,TelPropietario FROM Chofer WHERE MarcaModelo LIKE ?";

                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("MarcaModelo", "%" + textobuscar + "%"));
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
        public void BuscarPorPatente(DataGridView dgb, string textobuscar)
        {
            SQLiteConnection conector = new SQLiteConnection(Conexion.strConexion);
            try
            {
                conector.Open();

                string sql = "Select idChofer as ID,Movil,NombreApellido,Dni,FechaNacimiento,NroTelefono,Direccion,EstadoCivil,MarcaModelo,Anio,Patente,NroChasis,NroMotor,FechaIngreso,Propietario,TelPropietario FROM Chofer WHERE Patente LIKE ?";

                SQLiteCommand cmd = new SQLiteCommand(sql, conector);
                cmd.Parameters.Add(new SQLiteParameter("Patente", "%" + textobuscar + "%"));
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
    


