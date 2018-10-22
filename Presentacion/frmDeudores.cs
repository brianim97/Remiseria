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
    public partial class frmDeudores : Form
    {
        public frmDeudores()
        {
            InitializeComponent();
            dgvDeudores.DataSource = new Negocio.NDeuda().Mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtMovil.Text != string.Empty)
                new Negocio.NDeuda().MostrarPorMovil(Convert.ToInt32(txtMovil.Text));
            
        }

        private void frmDeudores_Load(object sender, EventArgs e)
        {
            
        }

    }
}
