using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Negocio
{
    public class NChofer
    {
        public static string Insertar(string movil,string nombreapellido, int dni, string fechanacimiento, string nrotelefono, string direccion, string estadocivil, string marcamodelo, string anio, string patente, string nrochasis, string nromotor, string fechaingreso, string propietario, string telpropietario)
        {
            DChofer obj = new DChofer();
            obj.Movil = movil;
            obj.NombreApellido = nombreapellido;
            obj.Dni = dni;
            obj.FechaNacimiento = fechanacimiento;
            obj.NroTelefono = nrotelefono;
            obj.Direccion = direccion;
            obj.EstadoCivil = estadocivil;
            obj.MarcaModelo = marcamodelo;
            obj.Anio = anio;
            obj.Patente = patente;
            obj.NroChasis = nrochasis;
            obj.NroMotor = nromotor;
            obj.FechaIngreso = fechaingreso;
            obj.Propietario = propietario;
            obj.TelefonoPropietario = telpropietario;
          
            return obj.Insertar(obj);
        }
        public static string Editar(int idchofer,string movil,string nombreapellido, int dni, string fechanacimiento, string nrotelefono, string direccion, string estadocivil, string marcamodelo, string anio, string patente, string nrochasis, string nromotor, string fechaingreso, string propietario, string telpropietario)
        {
            DChofer obj = new DChofer();
            obj.IdChofer = idchofer;
            obj.Movil = movil;
            obj.NombreApellido = nombreapellido;
            obj.Dni = dni;
            obj.FechaNacimiento = fechanacimiento;
            obj.NroTelefono = nrotelefono;
            obj.Direccion = direccion;
            obj.EstadoCivil = estadocivil;
            obj.MarcaModelo = marcamodelo;
            obj.Anio = anio;
            obj.Patente = patente;
            obj.NroChasis = nrochasis;
            obj.NroMotor = nromotor;
            obj.FechaIngreso = fechaingreso;
            obj.Propietario = propietario;
            obj.TelefonoPropietario = telpropietario;

            return obj.Editar(obj);
        }
        public static void Eliminar(int id)
        {
            DChofer obj = new DChofer();
            obj.IdChofer = id;
            obj.Eliminar(obj);
        }

        public static void Mostrar(DataGridView dgv)
        {
            DChofer obj = new DChofer();
            obj.Mostrar(dgv);
        }

        public DataTable Mostrar2()
        {
            DChofer obj = new DChofer();
            return obj.Mostrar2();
        }

        public static void BuscarPorNombre(DataGridView dgb, string textobuscar)
        {
            DChofer obj = new DChofer();
            obj.BuscarPorNombre(dgb,textobuscar);
        }
        public static void BuscarPorDni(DataGridView dgb, string textobuscar)
        {
            DChofer obj = new DChofer();
            obj.BuscarPorDni(dgb, textobuscar);
        }
        public static void BuscarPorMarcaModelo(DataGridView dgb, string textobuscar)
        {
            DChofer obj = new DChofer();
            obj.BuscarPorMarcaModelo(dgb, textobuscar);
        }
        public static void BuscarPorPatente(DataGridView dgb, string textobuscar)
        {
            DChofer obj = new DChofer();
            obj.BuscarPorPatente(dgb, textobuscar);
        }

    }
}
