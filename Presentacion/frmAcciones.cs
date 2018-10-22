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

        public void RecuperarId(string id)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSeleccionarChofer frm = new frmSeleccionarChofer(this);
            frm.ShowDialog();
        }
    }
}
