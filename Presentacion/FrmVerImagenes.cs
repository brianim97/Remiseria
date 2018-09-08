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
    public partial class FrmVerImagenes : Form
    {
        public FrmVerImagenes()
        {
            InitializeComponent();
        }
        string[] arreglo = new string[4];
        public bool MostrarImagenChofer( string ruta)
        {
            try
            {
                pbxVerImagen.Image = Image.FromFile(ruta);
                return true;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("EL CHOFER NO TIENE IMAGEN");
                return false;

            }
           
        }
        private void AlmacenarImagenesVehiculo(string dni, string nombreapellido)
        {
           
            int i = 0;
            try
            {
                while (i < 4)
                {
                    arreglo[i] = (Application.StartupPath + "\\Vehiculos\\" + nombreapellido + "\\" + dni + i.ToString() + ".jpg");
                    Console.WriteLine(arreglo[i]);
                    i++;
                }

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.HResult.ToString());
            }
            






        }
        public bool MostrarImagenesVehiculor(string dni, string nombreapellido)
        {
            bool a = false;
            AlmacenarImagenesVehiculo(dni, nombreapellido);

            // Create a PictureBox.
            try
            {
                foreach (String file in arreglo)
                {
                    if (Image.FromFile(file) != null)
                    {
                        PictureBox pb = new PictureBox();
                        Image loadedImage = Image.FromFile(file);
                        pb.Height = 300;
                        pb.Width = 400;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Image = loadedImage;
                        flpVerImagenes.Controls.Add(pb);
                        a = true;
                    }
                    else
                    {
                        break;
                    }

                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("EL VEHICULO NO TIENE IMAGEN");
                return a = false;

            }
               
            
            return a;
        }
        private void FrmVerImagenes_Load(object sender, EventArgs e)
        {
         

        }
    }
}
