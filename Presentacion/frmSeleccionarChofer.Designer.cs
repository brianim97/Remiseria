namespace Presentacion
{
    partial class frmSeleccionarChofer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSelChofer = new System.Windows.Forms.DataGridView();
            this.cbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelChofer
            // 
            this.dgvSelChofer.AllowUserToAddRows = false;
            this.dgvSelChofer.AllowUserToDeleteRows = false;
            this.dgvSelChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelChofer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSelChofer.Location = new System.Drawing.Point(0, 83);
            this.dgvSelChofer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSelChofer.Name = "dgvSelChofer";
            this.dgvSelChofer.ReadOnly = true;
            this.dgvSelChofer.Size = new System.Drawing.Size(345, 347);
            this.dgvSelChofer.TabIndex = 0;
            this.dgvSelChofer.DoubleClick += new System.EventHandler(this.dgvSelChofer_DoubleClick);
            // 
            // cbTipoBusqueda
            // 
            this.cbTipoBusqueda.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoBusqueda.FormattingEnabled = true;
            this.cbTipoBusqueda.Items.AddRange(new object[] {
            "Nombre/Apellido",
            "Dni",
            "Modelo",
            "Patente"});
            this.cbTipoBusqueda.Location = new System.Drawing.Point(14, 32);
            this.cbTipoBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoBusqueda.Name = "cbTipoBusqueda";
            this.cbTipoBusqueda.Size = new System.Drawing.Size(140, 24);
            this.cbTipoBusqueda.TabIndex = 2;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(181, 33);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(150, 24);
            this.txtBusqueda.TabIndex = 3;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // frmSeleccionarChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(345, 430);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cbTipoBusqueda);
            this.Controls.Add(this.dgvSelChofer);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeleccionarChofer";
            this.Text = "SELECCIONAR CHOFER";
            this.Load += new System.EventHandler(this.frmSeleccionarChofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelChofer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelChofer;
        private System.Windows.Forms.ComboBox cbTipoBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}