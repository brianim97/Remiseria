using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();

            
        }

        public string IMidpago;
        
        public string IMnombreapellido;
        public string IMvehiculo;
        public string IMpatente;
        public string IMmonto;
        public string IMhora;
        public string IMfecha;
        public string IMdni;
        public string IMmovil;

        public static string MINombre;
        public static string miid;

        public void HabilitarCriteriosDeBusqueda(bool nombre = false, bool mes = false, bool ano = false,bool dia = false, bool movil = false){
            txtBuscarNomA.Enabled = nombre;
            cbBuscarMes.Enabled = mes;
            cbAnio.Enabled = ano;
            cbDiaInicio.Enabled = dia;
            cbDiaFin.Enabled = dia;
            txtMovil.Enabled = movil;
        }

        private void SumarColumnas()
        {
            float sumatoria = 0f;

            foreach (DataGridViewRow row in dgvPagos.Rows)
            {
                sumatoria += Convert.ToInt32(row.Cells["Monto"].Value);
            }

            lblMontoTotal.Text = "MONTO TOTAL: " + Convert.ToString(sumatoria);
        }
        private void Limpiar()
        {
            this.dtpFechaPago.Text = string.Empty;
            this.btnSelChofer.Enabled = false;
            this.txtMonto.Text = string.Empty;

        }
        private void BloquearCampos(bool value)
        {
           
            dtpFechaPago.Enabled = value;
            btnSelChofer.Enabled = value;
            txtMonto.Enabled = value;
            btnGuardar.Enabled = value;
        }
        private void OcultarColumnaId()
        {
            this.dgvPagos.Columns[0].Visible = false;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
            btnSelChofer.Enabled = true;
            btnNuevo.Enabled = false;
            

        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            HabilitarCriteriosDeBusqueda();
            BloquearCampos(false);
            MostrarTodosLosPagos();
            btnImprimir.Enabled = false;
            txtBuscarNomA.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dtpFechaPago.Text == string.Empty || txtMonto.Text == string.Empty)
            {
                MessageBox.Show("¡No se admiten campos vacios");
            }
            else
            {
                try
                {
                    frmSeleccionarChofer frm = new frmSeleccionarChofer();
                    NPago.Insertar(dtpFechaPago.Value.Day.ToString(), dtpFechaPago.Value.Month.ToString(),dtpFechaPago.Value.Year.ToString(), dtpFechaPago.Value.Hour.ToString() + ":" + dtpFechaPago.Value.Minute.ToString(), Convert.ToInt32(miid), Convert.ToDouble(txtMonto.Text));
                   // GuardarDatosImpresion(dtpFechaPago.Value.Day.ToString()+"/"+dtpFechaPago.Value.Month.ToString() + "/" + dtpFechaPago.Value.Year.ToString(), dtpFechaPago.Value.Hour.ToString() + ":" + dtpFechaPago.Value.Minute.ToString());
                    MessageBox.Show("Datos Ingresados Correctamente");
                    MostrarTodosLosPagos();
                    btnNuevo.Enabled = true;
                   
                    BloquearCampos(false);
                    Limpiar();
                    lblChofer.Text = "Chofer";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);

                }
               
            }
           
        }

        
        private void MostrarTodosLosPagos()
        {
            NPago.Mostrar(dgvPagos);
            chkEliminar.Checked = false;
            OcultarColumnaId();
            lblTotal.Text = "REGISTROS: " + dgvPagos.Rows.Count.ToString();
            SumarColumnas();
        }

        private void cbBuscarMes_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {

            if (chkEliminar.Checked)
            {
                this.dgvPagos.Columns[0].Visible = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                this.dgvPagos.Columns[0].Visible = false;
                btnEliminar.Enabled = false;
            }
        }

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvPagos.Columns["X"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvPagos.Rows[e.RowIndex].Cells["X"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar los registros", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;


                    foreach (DataGridViewRow row in dgvPagos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = row.Cells[1].Value.ToString();
                            NPago.Eliminar(Convert.ToInt32(Codigo));
                            MessageBox.Show("Se Elimino correctamente el registro");


                        }
                    }
                }
                chkEliminar.Checked = false;

                this.MostrarTodosLosPagos();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                MessageBox.Show("No se puedo eliminar el registro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BloquearCampos(false);
            Limpiar();
            btnNuevo.Enabled = true;
            lblChofer.Text = "Chofer";
        }

        private void btnSelChofer_Click(object sender, EventArgs e)
        {
            frmSeleccionarChofer frm = new frmSeleccionarChofer();
            frm.ShowDialog();
            lblChofer.Text =  MINombre;
        }

        private void GuardarDatosImpresion(string id, string nombreapellido, string dni, string vehiculo, string patente, string monto, string fecha, string hora)
        {
            IMidpago = id;
            IMnombreapellido = nombreapellido;
            IMdni = dni;
            IMvehiculo = vehiculo;
            IMpatente = patente;
            IMmonto = monto;
            IMfecha = fecha;
            IMhora = hora;


        }

       

        private void dgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnImprimir.Enabled = true;
            IMidpago = Convert.ToString(dgvPagos.CurrentRow.Cells["N°Pago"].Value);
            IMnombreapellido = Convert.ToString(dgvPagos.CurrentRow.Cells["NombreApellido"].Value);
            IMdni = Convert.ToString(dgvPagos.CurrentRow.Cells["Dni"].Value);
            IMvehiculo = Convert.ToString(dgvPagos.CurrentRow.Cells["Vehiculo"].Value);
            IMpatente = Convert.ToString(dgvPagos.CurrentRow.Cells["Patente"].Value);
            IMfecha =  Convert.ToString(dgvPagos.CurrentRow.Cells["Dia"].Value)+"/"+ Convert.ToString(dgvPagos.CurrentRow.Cells["Mes"].Value) + "/" + Convert.ToString(dgvPagos.CurrentRow.Cells["Anio"].Value);
            IMhora = Convert.ToString(dgvPagos.CurrentRow.Cells["Hora"].Value);
            IMmonto = Convert.ToString(dgvPagos.CurrentRow.Cells["Monto"].Value);
            IMmovil = Convert.ToString(dgvPagos.CurrentRow.Cells["Movil"].Value);


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("REMISERIA 5 ESTRELLAS", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(100, 50));
            e.Graphics.DrawString("(Comprobante de Pago)", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new PointF(150, 75));
            e.Graphics.DrawString("PAGO N°: " + IMidpago, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 120));
            e.Graphics.DrawString("CHOFER: " + IMnombreapellido, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 150));
            e.Graphics.DrawString("DNI: " + IMdni, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 180));
            e.Graphics.DrawString("VEHICULO: " + IMvehiculo, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 210));
            e.Graphics.DrawString("PATENTE: " + IMpatente, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 240));
            e.Graphics.DrawString("MONTO: " +"$"+ IMmonto, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 270));
            e.Graphics.DrawString("FECHA: " + IMfecha, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 300));
            e.Graphics.DrawString("HORA: " + IMhora, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 330));
            e.Graphics.DrawString("MOVIL: " + IMmovil, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 360));

            e.Graphics.DrawString("FIRMA ___________________   ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 420));
            e.Graphics.DrawString("ACLARACION_____________________", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 450));
           
            e.Graphics.DrawString("REMISERIA 5 ESTRELLAS", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(450, 50));
            e.Graphics.DrawString("(Comprobante de Pago)", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new PointF(500, 75));
            e.Graphics.DrawString("PAGO N°: " + IMidpago, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 120));
            e.Graphics.DrawString("CHOFER: " + IMnombreapellido, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 150));
            e.Graphics.DrawString("DNI: " + IMdni, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 180));
            e.Graphics.DrawString("VEHICULO: " + IMvehiculo, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 210));
            e.Graphics.DrawString("PATENTE: " + IMpatente, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 240));
            e.Graphics.DrawString("MONTO: " + "$" + IMmonto, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 270));
            e.Graphics.DrawString("FECHA: " + IMfecha, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 300));
            e.Graphics.DrawString("HORA: " + IMhora, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 330));
            e.Graphics.DrawString("MOVIL: " + IMmovil, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 360));

            e.Graphics.DrawString("FIRMA ___________________    ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 420));
            e.Graphics.DrawString("ACLARACION_____________________", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 450));
            
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbBuscarMes.Text = string.Empty;
            txtBuscarNomA.Text = string.Empty;
            MostrarTodosLosPagos();
           
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
           
        }

        private void lblMontoTotal_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void cbDiaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDiaFin_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void cbTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbTipoBusqueda.Text == string.Empty)
            {
                MostrarTodosLosPagos();
                HabilitarCriteriosDeBusqueda();
            }
            else if (cbTipoBusqueda.Text == "Mes+Dias+Año")
            {
                HabilitarCriteriosDeBusqueda(dia:true, mes:true, ano:true);

            }
            else if (cbTipoBusqueda.Text == "Nombre+Mes+Dias+Año")
            {
                HabilitarCriteriosDeBusqueda(nombre:true, dia: true, mes: true, ano: true);


            }
            else if (cbTipoBusqueda.Text == "Nombre+Mes+Año")
            {
                HabilitarCriteriosDeBusqueda(nombre: true, mes: true, ano: true);

            }
            else if (cbTipoBusqueda.Text == "Movil+Mes+Año")
            {
                HabilitarCriteriosDeBusqueda(movil: true, mes: true, ano: true);
            }
            else if (cbTipoBusqueda.Text == "Movil+Mes+Dias+Año")
            {
                HabilitarCriteriosDeBusqueda(movil: true, mes: true,dia: true, ano: true);
            }

            lblTotal.Text = "REGISTROS: " + dgvPagos.Rows.Count.ToString();
            SumarColumnas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                if (cbTipoBusqueda.Text == "Mes+Dias+Año") { 
                
                    NPago.BuscarPorDiasyMesAnio(dgvPagos, cbBuscarMes.Text, cbDiaInicio.Text, cbDiaFin.Text, cbAnio.Text);
                }
                else if (cbTipoBusqueda.Text == "Nombre+Mes+Dias+Año")
                {
                  

                    NPago.BuscarPorNombreDiasyMesAnio(dgvPagos, txtBuscarNomA.Text, cbBuscarMes.Text, cbDiaInicio.Text, cbDiaFin.Text, cbAnio.Text);
                }
                else if (cbTipoBusqueda.Text == "Nombre+Mes+Año")
                {
                   
                    NPago.BuscarNombreyMesAnio(dgvPagos, txtBuscarNomA.Text, cbBuscarMes.Text, cbAnio.Text);
                }
                else if (cbTipoBusqueda.Text == "Movil+Mes+Año")
                {


                    NPago.BuscarMovilMesAnio(dgvPagos, txtMovil.Text, cbBuscarMes.Text, cbAnio.Text);
                }
                else if (cbTipoBusqueda.Text == "Movil+Mes+Dias+Año")
                {


                    NPago.BuscarPorMovilDiasMesAnio(dgvPagos, txtMovil.Text, cbBuscarMes.Text, cbDiaInicio.Text, cbDiaFin.Text, cbAnio.Text);
                }
                lblTotal.Text = "REGISTROS: " + dgvPagos.Rows.Count.ToString();
                SumarColumnas();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
    //Nombre+Mes+Año
  //  Nombre+Mes+Dias+Año
     //Mes+Dias+Año

}
