﻿using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Negocio
{
    public class NPago
    {
        public SQLiteDataAdapter TraerVistaPago()
        {
            return new Datos.DPago().TraerVistaPago();
        }


        public static int Insertar(string dia, string mes, string anio, string hora, int idChofer, double monto)
        {
            DPago obj = new DPago();
            obj.Dia = dia;
            obj.Mes = mes;
            obj.Anio = anio;
            obj.Hora = hora;
            obj.IdChofer = idChofer;
            obj.Monto = monto;

            return obj.Insertar(obj);
        }

        public static string Editar(int idPago, string dia, string mes, string anio, string hora, int idChofer, double monto)
        {
            DPago obj = new DPago();
            obj.IdPago = idChofer;
            obj.Dia = dia;
            obj.Mes = mes;
            obj.Anio = anio;
            obj.Hora = hora;
            obj.IdChofer = idChofer;
            obj.Monto = monto;

            //TODO revisar si va editar o va insertar
            return obj.Editar(obj);
        }
        public static string Eliminar(int idpago)
        {
            DPago obj = new DPago();
            obj.IdPago = idpago;
            return obj.Eliminar(obj);

        }
        public static void Mostrar(DataGridView dgv)
        {
            DPago obj = new DPago();
            obj.Mostrar(dgv);

        }
        public static void BuscarNombreyMesAnio(DataGridView dgv, string nombre, string mes, string anio)
        {
            DPago obj = new DPago();
            obj.BuscarPorNombreyMesAnio(dgv, nombre, mes, anio);

        }
        public static void BuscarPorDiasyMesAnio(DataGridView dgv,string mes, string DiaInicio, string DiaFin, string anio)
        {
            DPago obj = new DPago();
            obj.BuscarPorDiasyMesAnio(dgv, mes, DiaInicio, DiaFin, anio);
        }
        public static void BuscarPorNombreDiasyMesAnio(DataGridView dgv, string nombre, string mes, string DiaInicio, string DiaFin, string anio)
        {
            DPago obj = new DPago();
            obj.BuscarPorNombreDiasyMesAnio(dgv, nombre, mes, DiaInicio, DiaFin, anio);
        }
        public static void BuscarMovilMesAnio(DataGridView dgv, string movil, string mes, string anio)
        {
            DPago obj = new DPago();
            obj.BuscarPorMovilMesAnio(dgv, movil, mes, anio);

        }
        public static void BuscarPorMovilDiasMesAnio(DataGridView dgv, string movil, string mes, string DiaInicio, string DiaFin, string anio)
        {
            DPago obj = new DPago();
            obj.BuscarPorMovilDiasMesAnio(dgv, movil, mes, DiaInicio, DiaFin, anio);
        }


    }
}
