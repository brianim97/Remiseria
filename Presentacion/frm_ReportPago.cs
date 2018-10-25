using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SQLite;

namespace Presentacion
{
    public partial class frm_ReportPago : Form
    {
        public frm_ReportPago()
        {
            
            InitializeComponent();

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.ReportePago' table. You can move, or remove it, as needed.
            this.DataSet2.EnforceConstraints = false;
            this.ReportePagoTableAdapter.Fill(this.DataSet2.ReportePago);
            this.reportViewer1.RefreshReport();
        }
    }
}
