using Negocio;
using System;
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
    public partial class frmSeleccionarChofer : Form
    {
        public ISeleccionarChofer frmPadre;

        public frmSeleccionarChofer(ISeleccionarChofer frmPadre)
        {
            this.frmPadre = frmPadre;
            InitializeComponent();
            Mostrar();
        }
        private void Mostrar()
        {
            NChofer.Mostrar(dgvSelChofer);
            //OcultarColumnas();
        }
        
        private void frmSeleccionarChofer_Load(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cbTipoBusqueda.Text == "Nombre/Apellido")
            {
                NChofer.BuscarPorNombre(dgvSelChofer, txtBusqueda.Text);
                //OcultarColumnas();
                
            }
            else if (cbTipoBusqueda.Text == "Dni")
            {
                NChofer.BuscarPorDni(dgvSelChofer, txtBusqueda.Text);
                //OcultarColumnas();
               
            }
            else if (cbTipoBusqueda.Text == "Modelo")
            {
                NChofer.BuscarPorMarcaModelo(dgvSelChofer, txtBusqueda.Text);
                //OcultarColumnas();
                
            }
            else if (cbTipoBusqueda.Text == "Patente")
            {
                NChofer.BuscarPorPatente(dgvSelChofer, txtBusqueda.Text);
                //OcultarColumnas();
              
            }
            else
            {
                Mostrar();
                
            }
            //OcultarColumnas();
            
        }

        private void dgvSelChofer_DoubleClick(object sender, EventArgs e)
        {
            string idAA, idBB;
            idAA = (this.dgvSelChofer.CurrentRow.Cells["ID"].Value).ToString();
            idBB = (this.dgvSelChofer.CurrentRow.Cells["NombreApellido"].Value).ToString();
            
            //frmPago.miid = idAA;
            frmPago.MINombre = idBB;
            frmPadre.RecuperarId(idAA);
            this.Hide();
        }

    }
}
