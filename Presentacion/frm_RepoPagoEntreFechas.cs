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
    public partial class frm_RepoPagoEntreFechas : Form
    {
        public frm_RepoPagoEntreFechas()
        {
            InitializeComponent();
        }

        private void frm_RepoPagoEntreFechas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.ReportePago' table. You can move, or remove it, as needed.

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            dtp_hasta.Value = DateTime.Today;
            this.VistaReportePagoPorFecha.EnforceConstraints = false;
            this.ReportePagoTableAdapter.Fill(this.VistaReportePagoPorFecha.ReportePago, dtp_desde.Value.ToString("yyyy/MM/dd"), dtp_hasta.Value.ToString("yyyy/MM/dd"));

            this.reportViewer1.RefreshReport();
            dtp_desde.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Clear();
            
            label1.Text = dtp_desde.Value.ToString("yyyy/MM/dd");
            this.ReportePagoTableAdapter.Fill(this.VistaReportePagoPorFecha.ReportePago, dtp_desde.Value.ToString("yyyy/MM/dd"), dtp_hasta.Value.ToString("yyyy/MM/dd"));

            this.reportViewer1.RefreshReport();
        }
    }
}
