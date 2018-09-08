namespace Presentacion
{
    partial class FrmVerImagenes
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
            this.label7 = new System.Windows.Forms.Label();
            this.pbxVerImagen = new System.Windows.Forms.PictureBox();
            this.flpVerImagenes = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 73;
            this.label7.Text = "Chofer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxVerImagen
            // 
            this.pbxVerImagen.BackColor = System.Drawing.Color.White;
            this.pbxVerImagen.Location = new System.Drawing.Point(70, 42);
            this.pbxVerImagen.Name = "pbxVerImagen";
            this.pbxVerImagen.Size = new System.Drawing.Size(213, 206);
            this.pbxVerImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxVerImagen.TabIndex = 74;
            this.pbxVerImagen.TabStop = false;
            // 
            // flpVerImagenes
            // 
            this.flpVerImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpVerImagenes.AutoScroll = true;
            this.flpVerImagenes.BackColor = System.Drawing.Color.White;
            this.flpVerImagenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flpVerImagenes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpVerImagenes.Location = new System.Drawing.Point(289, 42);
            this.flpVerImagenes.Name = "flpVerImagenes";
            this.flpVerImagenes.Size = new System.Drawing.Size(425, 463);
            this.flpVerImagenes.TabIndex = 76;
            this.flpVerImagenes.WrapContents = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 75;
            this.label6.Text = "Vehiculo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmVerImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(791, 526);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbxVerImagen);
            this.Controls.Add(this.flpVerImagenes);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.Name = "FrmVerImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IMAGENES";
            this.Load += new System.EventHandler(this.FrmVerImagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbxVerImagen;
        private System.Windows.Forms.FlowLayoutPanel flpVerImagenes;
        private System.Windows.Forms.Label label6;
    }
}