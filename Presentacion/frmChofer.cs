using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmChofer : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        string RutaImagenChofer = null;

        string DniChofer;
        string NombreChofer;

        string[] arregloImagenes = new string[4];
        
        int i = 0;
       
        private void BloquearCampos(bool value)
        {
            txtMovil.Enabled = value;
            txtId.Enabled = value;
            txtNombreApellido.Enabled = value;
            txtDni.Enabled = value;
            dtpFecha.Enabled = value;
            txtTelefono.Enabled = value;
            txtDireccion.Enabled = value;
            cbEstadoCivil.Enabled = value;
            dtpFechaIngreso.Enabled = value;
            txtMarcaModelo.Enabled = value;
            txtAnio.Enabled = value;
            txtPatente.Enabled = value;
            txtNroChasis.Enabled = value;
            txtNroMotor.Enabled = value;
            btnSelImgChof.Enabled = value;
            txtPropietario.Enabled = value;
            txtTelPropietario.Enabled = value;
            flowLayoutPanel1.Enabled = value;
            SelectFileButton.Enabled = value;
        }

        private void Limpiar()
        {
            this.txtMovil.Text = string.Empty;
            this.txtId.Text = string.Empty;
            this.txtNombreApellido.Text = string.Empty;
            this.txtDni.Text = string.Empty;
            this.dtpFecha.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.cbEstadoCivil.Text = string.Empty;
            this.dtpFechaIngreso.Text = string.Empty;
            this.txtMarcaModelo.Text = string.Empty;
            this.txtAnio.Text = string.Empty;
            this.txtPatente.Text = string.Empty;
            this.txtNroChasis.Text = string.Empty;
            this.txtNroMotor.Text = string.Empty;
            this.txtPropietario.Text = string.Empty;
            this.txtTelPropietario.Text = string.Empty;
            this.pbxImagen.Image = null;
            this.flowLayoutPanel1.Controls.Clear();
            this.SelectFileButton.Enabled = false;
            for (int i = 0; i < arregloImagenes.Length; i++)
            {
                arregloImagenes[i] = null;
            }

        }
        private void OcultarColumnas()
        {
            this.dgbListado.Columns[0].Visible = false;
        }

        public frmChofer()
        {
            InitializeComponent();
        }

        private void frmChofer_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);
            Mostrar();
            pbxImagen.Image = null;
            InitializeOpenFileDialog();
        }

        private void Mostrar()
        {
            NChofer.Mostrar(dgbListado);
            OcultarColumnas();
            lblTotal.Text = "REGISTROS: " + dgbListado.Rows.Count.ToString();
        }






        private void txtBuscarListado_TextChanged(object sender, EventArgs e)
        {
            if (cbTipoBusqueda.Text == "Nombre/Apellido")
            {
                NChofer.BuscarPorNombre(dgbListado, txtBuscarListado.Text);
                OcultarColumnas();
                chkEliminar.Checked = false;
                lblTotal.Text = "REGISTROS: " + dgbListado.Rows.Count.ToString();
            }
            else if (cbTipoBusqueda.Text == "Dni")
            {
                NChofer.BuscarPorDni(dgbListado, txtBuscarListado.Text);
                OcultarColumnas();
                chkEliminar.Checked = false;
                lblTotal.Text = "REGISTROS: " + dgbListado.Rows.Count.ToString();
            }
            else if (cbTipoBusqueda.Text == "Modelo")
            {
                NChofer.BuscarPorMarcaModelo(dgbListado, txtBuscarListado.Text);
                OcultarColumnas();
                chkEliminar.Checked = false;
                lblTotal.Text = "REGISTROS: " + dgbListado.Rows.Count.ToString();
            }
            else if (cbTipoBusqueda.Text == "Patente")
            {
                NChofer.BuscarPorPatente(dgbListado, txtBuscarListado.Text);
                OcultarColumnas();
                chkEliminar.Checked = false;
                lblTotal.Text = "REGISTROS: " + dgbListado.Rows.Count.ToString();
            }
            else
            {
                Mostrar();
                chkEliminar.Checked = false;
                lblTotal.Text = "REGISTROS: " + dgbListado.Rows.Count.ToString();
            }
            OcultarColumnas();
            chkEliminar.Checked = false;
            lblTotal.Text = "REGISTROS: " + dgbListado.Rows.Count.ToString();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Tag = "Vacio";
            IsNuevo = true;
            IsEditar = false;
            BloquearCampos(true);
            txtId.Enabled = false;
            for (int i = 0; i < arregloImagenes.Length; i++)
            {
                arregloImagenes[i] = null;
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            try
            {

                if (pbxImagen.Image == null || (string)flowLayoutPanel1.Tag == "Vacio")
                {
                    DialogResult result = MessageBox.Show("Guardar sin Imagen?", "Advertencia!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if(pbxImagen.Image == null && (string)flowLayoutPanel1.Tag == "Cargado")
                        {
                            NuevoOEditar(false, true);
                        }else if(pbxImagen.Image != null && (string)flowLayoutPanel1.Tag == "Vacio")
                        {
                            NuevoOEditar(true, false);
                        }else if(pbxImagen.Image == null && (string)flowLayoutPanel1.Tag == "Vacio")
                        {
                            NuevoOEditar(false, false);
                        }
                        
                        return;
                    }
                    else
                    {

                        return;
                    }
                }
                else
                {
                    NuevoOEditar(true,true);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }


           
        }
        //METODOS DE IMAGEN -------------------------------------------------------------------
        private string AlmacenarDireccionImagen(bool bandera)
        {
            if (bandera)
            {
                try
                {
                    string imagen = openFileDialog2.FileName;
                    pbxImagen.Image = Image.FromFile(imagen);
                    return openFileDialog2.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        private void GuardarImagenChofer(string ruta, string dni,bool bandera)
        {
            if (bandera)
            {
                File.Copy(ruta, Application.StartupPath + "\\Choferes\\" + dni + ".jpg");
            }
            else
            {
                return;
            }
           
        }
        private void EditarImagenChofer(string ruta, string dni, bool bandera)
        {   
            if (bandera)
            {
                File.Delete(Application.StartupPath + "\\Choferes\\" + dni + ".jpg");
                File.Copy(ruta, Application.StartupPath + "\\Choferes\\" + dni + ".jpg");
                return;
               
            }
            else
            {
                return;
            }
        }
        private void GuardarImagenesVehiculo( string dni,string nombreapellido, bool bandera)
        {
            if (bandera)
            {
                int k = 0;
                Directory.CreateDirectory(Application.StartupPath + "\\Vehiculos\\" + nombreapellido);
                foreach (var item in arregloImagenes)
                {
                    if(item != null)
                    {
                        File.Copy(item, Application.StartupPath + "\\Vehiculos\\" + nombreapellido + "\\" + dni + k.ToString() + ".jpg");
                        k++;
                    }
                    else
                    {
                        MessageBox.Show("Se Cargaron Menos de 4 Fotos");
                        Limpiar();
                        BloquearCampos(false);
                    }
                   
                }
            }
            else
            {
                return;
            }
        }
        private void EditarImagenesVehiculo(string dni, string nombreapellido, bool bandera)
        {
            try
            {
                if (bandera)
                {
                    int k = 0;
                    foreach (var item in arregloImagenes)
                    {
                        File.Delete(Application.StartupPath + "\\Vehiculos\\" + nombreapellido + "\\" + dni + k.ToString() + ".jpg");
                        File.Copy(item, Application.StartupPath + "\\Vehiculos\\" + nombreapellido + "\\" + dni + k.ToString() + ".jpg");
                        k++;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Vehiculos\\" + nombreapellido);
                int k = 0;
                foreach (var item in arregloImagenes)
                {
                   
                    File.Copy(item, Application.StartupPath + "\\Vehiculos\\" + nombreapellido + "\\" + dni + k.ToString() + ".jpg");
                    k++;
                }
            }
           
        }
        private void AlmacenarRutasImgVehi(string ruta)
        {

            if (i < 4)
            {
                arregloImagenes[i] = ruta;
                Console.WriteLine(arregloImagenes[i]);
                i++;
            }
            else
            {
                i = 0;
                return;
            }  
        }
        private void EliminarImagenChofer(string dni)
        {
            File.Delete(Application.StartupPath + "\\Choferes\\" + dni + ".jpg");
        }
        private void EliminarImagenesVehiculos (string nombreapellido)
        {
            Directory.Delete( Application.StartupPath + "\\Vehiculos\\" + nombreapellido,true);
        }

        //----------------------------------------------------------------

        private void NuevoOEditar(bool banderaCHofer, bool banderaVehiculo)
        {
            try
            {
                if (txtMovil.Text == string.Empty || txtNombreApellido.Text == string.Empty || txtDni.Text == string.Empty || dtpFecha.Text == string.Empty || txtTelefono.Text == string.Empty || txtDireccion.Text == string.Empty || cbEstadoCivil.Text == string.Empty || txtMarcaModelo.Text == string.Empty || txtAnio.Text == string.Empty || txtPatente.Text == string.Empty || txtPropietario.Text == string.Empty)
                {
                    MessageBox.Show("¡No se admiten campos vacios en (Movil, Nombre/Apellido, Dni, FechaNacimiento, Telefono, Direccion, Estado Civil, Marca/Modelo, Año, Patente!");
                }
                else if (Convert.ToInt32(txtDni.Text) <= 99999999 && Convert.ToInt32(txtDni.Text) >= 999999)
                {
                    if (IsNuevo == true)
                    {  
                        NChofer.Insertar(txtMovil.Text,txtNombreApellido.Text, Convert.ToInt32(txtDni.Text), dtpFecha.Value.ToString(), txtTelefono.Text, txtDireccion.Text, cbEstadoCivil.Text, txtMarcaModelo.Text, txtAnio.Text, txtPatente.Text, txtNroChasis.Text, txtNroMotor.Text, dtpFechaIngreso.Value.ToString(), txtPropietario.Text, txtTelPropietario.Text);
                        GuardarImagenChofer(AlmacenarDireccionImagen(banderaCHofer), txtDni.Text, banderaCHofer);
                        GuardarImagenesVehiculo(txtDni.Text, txtNombreApellido.Text, banderaVehiculo);
                        MessageBox.Show("Datos Guardados Correctamente!");
                        Mostrar();
                        Limpiar();
                        BloquearCampos(false);
                        IsNuevo = false;
                        frmChofer frm = new frmChofer();
                        frm.Show();
                        this.Close();


                    }
                    else if (IsEditar == true)
                    {  
                        NChofer.Editar(Convert.ToInt32(txtId.Text),txtMovil.Text, txtNombreApellido.Text, Convert.ToInt32(txtDni.Text), dtpFecha.Value.ToString(), txtTelefono.Text, txtDireccion.Text, cbEstadoCivil.Text, txtMarcaModelo.Text, txtAnio.Text, txtPatente.Text, txtNroChasis.Text, txtNroMotor.Text, dtpFechaIngreso.Value.ToString(), txtPropietario.Text, txtTelPropietario.Text);
                        EditarImagenChofer(AlmacenarDireccionImagen(banderaCHofer), txtDni.Text, banderaCHofer);
                        EditarImagenesVehiculo(txtDni.Text, txtNombreApellido.Text, banderaVehiculo);
                        MessageBox.Show("Datos Editados Correctamente!");
                        Mostrar();
                        Limpiar();
                        BloquearCampos(false);
                        IsEditar = false;
                        frmChofer frm = new frmChofer();
                        frm.Show();
                        this.Close();

                    }
                    else MessageBox.Show("Error Editar/Nuevo");

                }
                else MessageBox.Show("¡Dni Incorrecto!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
           
            }
            
        }

        private void btnCancelarChofer_Click(object sender, EventArgs e)
        {
            Limpiar();
            BloquearCampos(false);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgbListado_DoubleClick(object sender, EventArgs e)
        {
            //al hacer doble click en el datagridview se pasan los datos de una fila a la parte de mantenimiento
            this.txtId.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["ID"].Value);
            this.txtMovil.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["Movil"].Value);
            this.txtNombreApellido.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["NombreApellido"].Value);
            this.txtDni.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["Dni"].Value);
            this.dtpFecha.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["FechaNacimiento"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["NroTelefono"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["Direccion"].Value);
            this.cbEstadoCivil.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["EstadoCivil"].Value);
            this.dtpFechaIngreso.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["FechaIngreso"].Value);
            this.txtMarcaModelo.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["MarcaModelo"].Value);
            this.txtAnio.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["Anio"].Value);
            this.txtPatente.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["Patente"].Value);
            this.txtNroChasis.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["NroChasis"].Value);
            this.txtNroMotor.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["NroMotor"].Value);
            this.txtPropietario.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["Propietario"].Value);
            this.txtTelPropietario.Text = Convert.ToString(this.dgbListado.CurrentRow.Cells["TelPropietario"].Value);
            this.tabControl1.SelectedIndex = 0;
            BloquearCampos(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Tag = "Vacio";
            BloquearCampos(true);
            IsEditar = true;
            IsNuevo = false;
        }
 
        
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dgbListado.Columns[0].Visible = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                this.dgbListado.Columns[0].Visible = false;
                btnEliminar.Enabled = false;
            }
        }

        private void dgbListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgbListado.Columns["X"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgbListado.Rows[e.RowIndex].Cells["X"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar los registros", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string dni, nombreapell;
                    string Codigo;


                    foreach (DataGridViewRow row in dgbListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(dgbListado.CurrentRow.Cells["ID"].Value);
                            dni = Convert.ToString(dgbListado.CurrentRow.Cells["Dni"].Value);
                            nombreapell = Convert.ToString(dgbListado.CurrentRow.Cells["NombreApellido"].Value);
                            NChofer.Eliminar(Convert.ToInt32(Codigo));
                            EliminarImagenChofer(dni);
                            EliminarImagenesVehiculos(nombreapell);
                           
                            MessageBox.Show("Se Elimino correctamente el registro");


                        }
                    }
                }
                chkEliminar.Checked = false;
            
                this.Mostrar();
            }
            catch (System.IO.DirectoryNotFoundException)
            {
          
                MessageBox.Show("Error al eliminar");
                this.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
             MessageBox.Show("No se puedo eliminar el registro");
                this.Mostrar();
            }
        }

        private void btnSelImgChof_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    RutaImagenChofer = AlmacenarDireccionImagen(true);
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnPb1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pbxImagen.Image = Image.FromFile(imagen);
                    pbxImagen.Tag = openFileDialog1.FileName;
                    //File.Copy(openFileDialog1.FileName, Application.StartupPath + "\\Choferes\\aa.jpg");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "All files (*.*)|*.*";

            // Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "My Image Browser";
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                int j = 0;
               
                
                    foreach (String file in openFileDialog1.FileNames)
                    {
                        // Create a PictureBox.
                        try
                        {
                            if (j < 4)
                            {
                                
                                PictureBox pb = new PictureBox();
                                if(Image.FromFile(file) != null)
                            {
                                Image loadedImage = Image.FromFile(file);
                                //resizeImage(loadedImage,2000,2000); 
                                pb.Width = 400;
                                pb.Height = 300;
                                pb.SizeMode = PictureBoxSizeMode.Zoom;
                                pb.BackgroundImageLayout = ImageLayout.Tile;
                                pb.Image = loadedImage;
                                flowLayoutPanel1.Tag = "Cargado";
                                flowLayoutPanel1.Controls.Add(pb);
                                AlmacenarRutasImgVehi(file);
                                j++;
                            }
                            else
                            {
                                return;
                            }
                               
                            }
                        else
                        {
                            return;
                        }
                            
                        }
                        catch (SecurityException ex)
                        {
                            // The user lacks appropriate permissions to read files, discover paths, etc.
                            MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                                "Error message: " + ex.Message + "\n\n" +
                                "Details (send to Support):\n\n" + ex.StackTrace
                            );
                        }
                        catch (Exception ex)
                        {
                            // Could not load the image - probably related to Windows file system permissions.
                            MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                                + ". You may not have permission to read the file, or " +
                                "it may be corrupt.\n\nReported error: " + ex.Message);
                        }
                    }                
            }
        }

        private void btnVerImagenes_Click(object sender, EventArgs e)
        {
            FrmVerImagenes frm = new FrmVerImagenes();
            string ruta = Application.StartupPath + "\\Choferes\\" + DniChofer + ".jpg";
                if (frm.MostrarImagenChofer(ruta))
                {
                    if(frm.MostrarImagenesVehiculor(DniChofer, NombreChofer))
                {
                    frm.ShowDialog();
                    return;
                }
                else
                {
                    frm.ShowDialog();
                    return;
                }

            }
            else if (frm.MostrarImagenesVehiculor(DniChofer, NombreChofer))
            {
                
                frm.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("No se encuentra ninguna Imagen!");
                return;
            }
               
            
            
               
           

        }

        private void dgbListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NombreChofer = Convert.ToString(dgbListado.CurrentRow.Cells["NombreApellido"].Value);
            DniChofer = Convert.ToString(dgbListado.CurrentRow.Cells["Dni"].Value);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        
    }

}



