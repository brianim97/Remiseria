﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmDeudores : Form, ISeleccionarChofer
    {
        public frmDeudores()
        {
            InitializeComponent();
            MostrarTablaCompleta();
            OcultarColumnaChk();
            DesabilitarBotonEliminar(true);
        }
        private void SumarColumnaMonto()
        {
            float sumatoria = 0f;

            foreach (DataGridViewRow row in dgvDeudores.Rows)
            {
                sumatoria += Convert.ToInt32(row.Cells["Monto"].Value);
            }

            lblMontoTotal.Text = "MONTO TOTAL: " + Convert.ToString(sumatoria);
        }
        private void MostrarTablaCompleta()
        {
            dgvDeudores.DataSource = new Negocio.NDeuda().Mostrar();
            lblTotalRegistros.Text = "REGISTROS: " + dgvDeudores.Rows.Count.ToString();
            SumarColumnaMonto();
        }
        private void OcultarColumnaChk()
        {
            dgvDeudores.Columns[0].Visible = false;
        }
        private void DesabilitarBotonEliminar(bool opcion)
        {
            if(opcion)
                btnEliminar.Enabled = false;
            else
                btnEliminar.Enabled = true;
        }
        string miid,minombre,idChoferPago,MontoPago;
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbTipoBusqueda.Text == "Movil")
            {
                dgvDeudores.DataSource = new Negocio.NDeuda().MostrarPorMovil((txtBusqueda.Text));
            }
            else if (cbTipoBusqueda.Text == "Nombre/Apellido")
            {
                dgvDeudores.DataSource = new Negocio.NDeuda().MostrarPorNombreApellido((txtBusqueda.Text));
            }
            else
                MostrarTablaCompleta();

            lblTotalRegistros.Text = "REGISTROS: " + dgvDeudores.Rows.Count.ToString();
            SumarColumnaMonto();
        }

        private void frmDeudores_Load(object sender, EventArgs e)
        {
            
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dgvDeudores.Columns[0].Visible = true;
                DesabilitarBotonEliminar(false);
            }
            else
            {
                this.dgvDeudores.Columns[0].Visible = false;
                DesabilitarBotonEliminar(true);
            }
        }

        public void RecuperarId(string id, string name)
        {
            miid = id;
            minombre = name;
        }

        private void dgvDeudores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDeudores.Columns["X"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvDeudores.Rows[e.RowIndex].Cells["X"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dgvDeudores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RecuperarId(Convert.ToString(dgvDeudores.CurrentRow.Cells["idDeuda"].Value), Convert.ToString(dgvDeudores.CurrentRow.Cells["NombreApellido"].Value));
            idChoferPago = Convert.ToString(dgvDeudores.CurrentRow.Cells["ID"].Value);
            MontoPago = Convert.ToString(dgvDeudores.CurrentRow.Cells["Monto"].Value);
            btnCobrar.Enabled = true;


        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == string.Empty)
                MostrarTablaCompleta();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Entidades.Deuda d = new Entidades.Deuda();
            d.IdChofer = Convert.ToInt32(idChoferPago);
            d.Monto = Convert.ToDouble(MontoPago);
            frmPago frm = new frmPago(d);
            frm.Show();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new Negocio.NDeuda().Eliminar(Convert.ToInt32(miid)))
            {
                MessageBox.Show("Se Elimino Correctamente el Registro");
                MostrarTablaCompleta();
            }
            else
                MessageBox.Show("Error al eliminar el Registro");
        }   
    }
}
