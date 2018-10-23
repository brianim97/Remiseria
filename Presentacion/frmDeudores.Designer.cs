namespace Presentacion
{
    partial class frmDeudores
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomApell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvDeudores = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAnio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBuscarMes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(106, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 33);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtMovil);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtNomApell);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(58, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 129);
            this.panel2.TabIndex = 26;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.White;
            this.btnCobrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCobrar.FlatAppearance.BorderSize = 2;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(123, 161);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(89, 46);
            this.btnCobrar.TabIndex = 20;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            // 
            // txtMovil
            // 
            this.txtMovil.BackColor = System.Drawing.Color.White;
            this.txtMovil.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovil.Location = new System.Drawing.Point(132, 6);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(62, 26);
            this.txtMovil.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Movil";
            // 
            // txtNomApell
            // 
            this.txtNomApell.BackColor = System.Drawing.Color.White;
            this.txtNomApell.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomApell.Location = new System.Drawing.Point(132, 38);
            this.txtNomApell.Name = "txtNomApell";
            this.txtNomApell.Size = new System.Drawing.Size(158, 26);
            this.txtNomApell.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre/Apellido";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoTotal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.ForeColor = System.Drawing.Color.White;
            this.lblMontoTotal.Location = new System.Drawing.Point(357, 186);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(141, 21);
            this.lblMontoTotal.TabIndex = 25;
            this.lblMontoTotal.Text = "MONTO TOTAL: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(557, 186);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(106, 21);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "REGISTROS:";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.Location = new System.Drawing.Point(2, 186);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(40, 25);
            this.chkEliminar.TabIndex = 22;
            this.chkEliminar.Text = "X";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(42, 181);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 26);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvDeudores
            // 
            this.dgvDeudores.AllowUserToAddRows = false;
            this.dgvDeudores.AllowUserToDeleteRows = false;
            this.dgvDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X});
            this.dgvDeudores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDeudores.Location = new System.Drawing.Point(0, 211);
            this.dgvDeudores.Name = "dgvDeudores";
            this.dgvDeudores.ReadOnly = true;
            this.dgvDeudores.Size = new System.Drawing.Size(734, 262);
            this.dgvDeudores.TabIndex = 20;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.X.Width = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbAnio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbBuscarMes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(381, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 80);
            this.panel1.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Inicio";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.comboBox1.Location = new System.Drawing.Point(199, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 27);
            this.comboBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Año";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox2.Location = new System.Drawing.Point(90, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(44, 27);
            this.comboBox2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mes";
            // 
            // cbAnio
            // 
            this.cbAnio.BackColor = System.Drawing.Color.White;
            this.cbAnio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnio.FormattingEnabled = true;
            this.cbAnio.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.cbAnio.Location = new System.Drawing.Point(199, 8);
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Size = new System.Drawing.Size(75, 27);
            this.cbAnio.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Año";
            // 
            // cbBuscarMes
            // 
            this.cbBuscarMes.BackColor = System.Drawing.Color.White;
            this.cbBuscarMes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarMes.FormattingEnabled = true;
            this.cbBuscarMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbBuscarMes.Location = new System.Drawing.Point(90, 8);
            this.cbBuscarMes.Name = "cbBuscarMes";
            this.cbBuscarMes.Size = new System.Drawing.Size(44, 27);
            this.cbBuscarMes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes";
            // 
            // frmDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(734, 473);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvDeudores);
            this.Name = "frmDeudores";
            this.Text = "DEUDORES";
            this.Load += new System.EventHandler(this.frmDeudores_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomApell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDeudores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn X;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBuscarMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCobrar;
    }
}