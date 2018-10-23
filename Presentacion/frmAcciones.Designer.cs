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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btnSelChofer = new System.Windows.Forms.Button();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenTickTotales
            // 
            this.btnGenTickTotales.BackColor = System.Drawing.Color.White;
            this.btnGenTickTotales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenTickTotales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenTickTotales.FlatAppearance.BorderSize = 2;
            this.btnGenTickTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenTickTotales.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenTickTotales.Location = new System.Drawing.Point(0, 0);
            this.btnGenTickTotales.Name = "btnGenTickTotales";
            this.btnGenTickTotales.Size = new System.Drawing.Size(363, 33);
            this.btnGenTickTotales.TabIndex = 20;
            this.btnGenTickTotales.Text = "GENERAR TICKETS A TODOS LOS CHOFERES";
            this.btnGenTickTotales.UseVisualStyleBackColor = false;
            // 
            // btnGenTickParticular
            // 
            this.btnGenTickParticular.BackColor = System.Drawing.Color.White;
            this.btnGenTickParticular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenTickParticular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenTickParticular.FlatAppearance.BorderSize = 2;
            this.btnGenTickParticular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenTickParticular.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenTickParticular.Location = new System.Drawing.Point(0, 349);
            this.btnGenTickParticular.Name = "btnGenTickParticular";
            this.btnGenTickParticular.Size = new System.Drawing.Size(363, 33);
            this.btnGenTickParticular.TabIndex = 21;
            this.btnGenTickParticular.Text = "GENERAR TICKETS PARA UN CHOFER";
            this.btnGenTickParticular.UseVisualStyleBackColor = false;
            this.btnGenTickParticular.Click += new System.EventHandler(this.btnGenTickParticular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Valor de Base";
            // 
            // txtValorDeBase
            // 
            this.txtValorDeBase.BackColor = System.Drawing.Color.White;
            this.txtValorDeBase.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDeBase.Location = new System.Drawing.Point(204, 125);
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
            this.cbAno.Location = new System.Drawing.Point(209, 167);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(75, 27);
            this.cbAno.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 172);
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
            this.cbMes.Location = new System.Drawing.Point(122, 167);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(44, 27);
            this.cbMes.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mes";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Location = new System.Drawing.Point(12, 51);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(339, 33);
            this.lbl_nombre.TabIndex = 29;
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelChofer
            // 
            this.btnSelChofer.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelChofer.Location = new System.Drawing.Point(87, 87);
            this.btnSelChofer.Name = "btnSelChofer";
            this.btnSelChofer.Size = new System.Drawing.Size(197, 32);
            this.btnSelChofer.TabIndex = 30;
            this.btnSelChofer.Text = "Seleccionar Chofer";
            this.btnSelChofer.UseVisualStyleBackColor = true;
            this.btnSelChofer.Click += new System.EventHandler(this.btnSelChofer_Click);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1.Location = new System.Drawing.Point(9, 36);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(38, 25);
            this.chk1.TabIndex = 31;
            this.chk1.Text = "1";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2.Location = new System.Drawing.Point(55, 36);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(38, 25);
            this.chk2.TabIndex = 32;
            this.chk2.Text = "2";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk3.Location = new System.Drawing.Point(101, 36);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(38, 25);
            this.chk3.TabIndex = 33;
            this.chk3.Text = "3";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk4.Location = new System.Drawing.Point(147, 36);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(38, 25);
            this.chk4.TabIndex = 34;
            this.chk4.Text = "4";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "SEMANAS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.chk4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.chk1);
            this.panel3.Controls.Add(this.chk2);
            this.panel3.Controls.Add(this.chk3);
            this.panel3.Location = new System.Drawing.Point(87, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 69);
            this.panel3.TabIndex = 36;
            // 
            // frmAcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(363, 382);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSelChofer);
            this.Controls.Add(this.lbl_nombre);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btnSelChofer;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}