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
    public partial class frmAcciones : Form, ISeleccionarChofer
    {
        public frmAcciones()
        {
            InitializeComponent();
        }

        public string miid;
        public string miNombre;

        public void RecuperarId(string id, string name)
        {
            miid = id;
            miNombre = name;
        }

       

        private void frmAcciones_Load(object sender, EventArgs e)
        {
           
        }

       
        private void CargarTicketsParticular()
        {
            if(txtValorDeBase.Text != string.Empty && cbMes.Text != string.Empty && cbAno.Text != string.Empty)
            {
               
                var deuda = new Entidades.Deuda();
                for (int i = 1; i < 5; i++)
                {
                    deuda.IdChofer = Convert.ToInt32(miid);
                    deuda.IdPago = null;
                    deuda.Monto = Convert.ToDouble(txtValorDeBase.Text);
                    deuda.Fecha = new DateTime(Convert.ToInt32(cbAno.Text) , Convert.ToInt32(cbMes.Text), i);
                    new Negocio.NDeuda().Insertar(deuda);
                }
            }
        }

        private void btnGenTickParticular_Click(object sender, EventArgs e)
        {
            frmSeleccionarChofer frm = new frmSeleccionarChofer(this);
            frm.ShowDialog();
            CargarTicketsParticular();
            lbl_nombre.Text = miNombre;
        }

        private void txtValorDeBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            


        }
    }
}
