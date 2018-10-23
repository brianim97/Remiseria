namespace Presentacion
{
    partial class frmAcciones
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
            this.btnGenTickTotales = new System.Windows.Forms.Button();
            this.btnGenTickParticular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorDeBase = new System.Windows.Forms.TextBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenTickTotales
            // 
            this.btnGenTickTotales.BackColor = System.Drawing.Color.White;
            this.btnGenTickTotales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenTickTotales.FlatAppearance.BorderSize = 2;
            this.btnGenTickTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenTickTotales.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenTickTotales.Location = new System.Drawing.Point(48, 12);
            this.btnGenTickTotales.Name = "btnGenTickTotales";
            this.btnGenTickTotales.Size = new System.Drawing.Size(204, 33);
            this.btnGenTickTotales.TabIndex = 20;
            this.btnGenTickTotales.Text = "Generar Deudas Totales";
            this.btnGenTickTotales.UseVisualStyleBackColor = false;
            // 
            // btnGenTickParticular
            // 
            this.btnGenTickParticular.BackColor = System.Drawing.Color.White;
            this.btnGenTickParticular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenTickParticular.FlatAppearance.BorderSize = 2;
            this.btnGenTickParticular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenTickParticular.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenTickParticular.Location = new System.Drawing.Point(48, 51);
            this.btnGenTickParticular.Name = "btnGenTickParticular";
            this.btnGenTickParticular.Size = new System.Drawing.Size(204, 33);
            this.btnGenTickParticular.TabIndex = 21;
            this.btnGenTickParticular.Text = "Generar Deudas Particulares";
            this.btnGenTickParticular.UseVisualStyleBackColor = false;
            this.btnGenTickParticular.Click += new System.EventHandler(this.btnGenTickParticular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Valor de Base";
            // 
            // txtValorDeBase
            // 
            this.txtValorDeBase.BackColor = System.Drawing.Color.White;
            this.txtValorDeBase.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDeBase.Location = new System.Drawing.Point(151, 94);
            this.txtValorDeBase.Name = "txtValorDeBase";
            this.txtValorDeBase.Size = new System.Drawing.Size(80, 26);
            this.txtValorDeBase.TabIndex = 24;
            this.txtValorDeBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDeBase_KeyPress);
            // 
            // cbAno
            // 
            this.cbAno.BackColor = System.Drawing.Color.White;
            this.cbAno.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Items.AddRange(new object[] {
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
            this.cbAno.Location = new System.Drawing.Point(168, 136);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(75, 27);
            this.cbAno.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Año";
            // 
            // cbMes
            // 
            this.cbMes.BackColor = System.Drawing.Color.White;
            this.cbMes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
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
            this.cbMes.Location = new System.Drawing.Point(81, 136);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(44, 27);
            this.cbMes.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mes";
            // 
            // frmAcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 324);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorDeBase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGenTickParticular);
            this.Controls.Add(this.btnGenTickTotales);
            this.Name = "frmAcciones";
            this.Text = "ACCIONES";
            this.Load += new System.EventHandler(this.frmAcciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenTickTotales;
        private System.Windows.Forms.Button btnGenTickParticular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorDeBase;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label4;
    }
}