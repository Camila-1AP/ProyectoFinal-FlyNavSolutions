using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using FlyNavSolutions.Administrador.Crear;
using FlyNavSolutions.BorderRadius;
using FlyNavSolutions.Tour;
using FontAwesome.Sharp;
using iTextSharp.text.pdf.codec.wmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace FlyNavSolutions
{
    public partial class UcAgendarNacional : UserControl
    {

        decimal precio;
        decimal itbis;


        private Image[] imagenes;
        private int indiceActual = 0;


        private int indiceImagen = 0;
        private Timer timerCarrusel;
        Crear validarFecha = new Crear();
        public UcAgendarNacional()
        {
            InitializeComponent();


            BorderRadius.borderRadius.AplicarRadius(panelQR, 30);
        }

        private void UcAgendarNacional_Load(object sender, EventArgs e)
        {

            borderRadius.AplicarRadius(panelInfo, 20);
          
            richTextBoxInfo.ReadOnly = true;
            richTextBoxInfo.BorderStyle = BorderStyle.None;
          

           
            richTextBoxInfo.Text = "• 🗺️ Los tours nacionales tienen una duración de un día completo, con salida y regreso el mismo día.\n" +
    "• 👥 Cupo limitado a 20 personas por tour.\n" +
    "• 🏨 No incluye alojamiento, ya que no es necesario para este tipo de experiencia.\n" +
    "• 💰 El precio mostrado ya incluye ITBIS.\n" +
    "• 📄 Recibirás un comprobante digital al finalizar tu reserva.\n"+
    "• 📞 Contacto: Teléfono: (809) 524-1090 | Correo electrónico: flynavSolutions@gmail.com.";

          
            iconPictureBoxToggle.IconChar = IconChar.Eye; 
            iconPictureBoxToggle.Cursor = Cursors.Hand;

       
            iconPictureBoxToggle.Click += (s, e3) =>
            {
                panelInfo.Visible = !panelInfo.Visible;
                iconPictureBoxToggle.IconChar = panelInfo.Visible ? IconChar.EyeSlash : IconChar.Eye;
            };

            

            dtpHora.ValueChanged += (s, e1) => validarFecha.ValidarHora(dtpHora);



            CatalogoDestinos.CargarDestinosNacionales(cmbDestino);
            PersistenciaLocal.Cargar();

            iconButtonAgendar.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonAgendar.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonAgendar.BackColor = System.Drawing.Color.WhiteSmoke;

            iconButtonnNombreTour.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonnNombreTour.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonnNombreTour.BackColor = System.Drawing.Color.WhiteSmoke;

            iconButtonDestino.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonDestino.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonDestino.BackColor = System.Drawing.Color.WhiteSmoke;


            iconButtonFecha.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonFecha.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonFecha.BackColor = System.Drawing.Color.WhiteSmoke;


            iconButtonHora.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonHora.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonHora.BackColor = System.Drawing.Color.WhiteSmoke;

            iconButtonTelefono.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonTelefono.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonTelefono.BackColor = System.Drawing.Color.WhiteSmoke;


            iconButtonCedula.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonCedula.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonCedula.BackColor = System.Drawing.Color.WhiteSmoke;




        }


        private void imagenesSamana()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "samana1.jpg");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "samana2..jpg");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "samana3.jpg");

            try
            {
                imagenes = new Image[]
            {
                Image.FromFile(ruta1),
                Image.FromFile(ruta2),
                Image.FromFile(ruta3),
            };
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al cargar las imagenes {e}");
            }


        
            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

            // Configurar Timer
            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }

        private void imagenesPuntaCana()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "puntaCana1.jpg");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "puntaCana2.jpg");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "puntaCana3.jpg");

            try
            {
                imagenes = new Image[]
            {
                Image.FromFile(ruta1),
                Image.FromFile(ruta2),
                Image.FromFile(ruta3),
            };
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al cargar las imagenes {e}");
            }


       
            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }
        private void imagenesSantiago()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "santiago1.jpg");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "santiago2.jpg");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "santiago3.jpg");

            try
            {
                imagenes = new Image[]
            {
                Image.FromFile(ruta1),
                Image.FromFile(ruta2),
                Image.FromFile(ruta3),
            };
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al cargar las imagenes {e}");
            }


            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

           
            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }
        private void imagenesPuertoPlata()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "puertoPlata.png");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "puertoPlata2.jpg");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "puertoPlata3.jpg");

            try
            {
                imagenes = new Image[]
            {
                Image.FromFile(ruta1),
                Image.FromFile(ruta2),
                Image.FromFile(ruta3),
            };
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al cargar las imagenes {e}");
            }


            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }
        private void imagenesLaRomana()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "romana1.jpg");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "romana2.jpg");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "romana3.jpg");

            try
            {
                imagenes = new Image[]
            {
                Image.FromFile(ruta1),
                Image.FromFile(ruta2),
                Image.FromFile(ruta3),
            };
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al cargar las imagenes {e}");
            }


         
            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

            // Configurar Timer
            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
           
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            indiceActual++;
            if (indiceActual >= imagenes.Length)
                indiceActual = 0;

            picGaleria.Image = imagenes[indiceActual];
        }
        private void MostrarMapa(string destino)
        {
            string url = $"https://www.google.com/maps/search/{Uri.EscapeDataString(destino)}";
            webView21.Source = new Uri(url);
        }


        private void iconButtonAgendar_MouseEnter(object sender, EventArgs e)
        {
            iconButtonAgendar.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonAgendar.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonAgendar.BackColor = System.Drawing.Color.WhiteSmoke;


        }

        private void iconButtonAgendar_MouseLeave(object sender, EventArgs e)
        {
            iconButtonAgendar.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonAgendar.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonAgendar.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void iconButtonnNombreTour_MouseEnter(object sender, EventArgs e)
        {
            iconButtonnNombreTour.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonnNombreTour.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonnNombreTour.BackColor = System.Drawing.Color.WhiteSmoke;

        }

        private void iconButtonnNombreTour_MouseLeave(object sender, EventArgs e)
        {
            iconButtonnNombreTour.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonnNombreTour.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonnNombreTour.BackColor = System.Drawing.Color.WhiteSmoke;

        }

        private void iconButtonDestino_MouseEnter(object sender, EventArgs e)
        {
            iconButtonDestino.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonDestino.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonDestino.BackColor = System.Drawing.Color.WhiteSmoke;

        }

        private void iconButtonDestino_MouseLeave(object sender, EventArgs e)
        {
            iconButtonDestino.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonDestino.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonDestino.BackColor = System.Drawing.Color.WhiteSmoke;

        }

        private void iconButtonFecha_MouseEnter(object sender, EventArgs e)
        {
            iconButtonFecha.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonFecha.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonFecha.BackColor = System.Drawing.Color.WhiteSmoke;

        }

        private void iconButtonFecha_MouseLeave(object sender, EventArgs e)
        {
            iconButtonFecha.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonFecha.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonFecha.BackColor = System.Drawing.Color.WhiteSmoke;

        }

        private void iconButtonHora_MouseEnter(object sender, EventArgs e)
        {
            iconButtonHora.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonHora.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonHora.BackColor =  System.Drawing.Color.WhiteSmoke;

        }

        private void iconButtonHora_MouseLeave(object sender, EventArgs e)
        {
            iconButtonHora.ForeColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonHora.IconColor = System.Drawing.Color.FromArgb(29, 38, 77);
            iconButtonHora.BackColor = System.Drawing.Color.WhiteSmoke;
            
        }

        private void iconButtonAgendar_MouseHover(object sender, EventArgs e)
        {
            iconButtonAgendar.BackColor = System.Drawing.Color.WhiteSmoke;



        }

        private void panelAgendar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Crear crear = new Crear();

            DateTime fechaInicio = dtpFecha.Value.Date + dtpHora.Value.TimeOfDay;

            if (fechaInicio < DateTime.Now)
            {
                System.Windows.Forms.MessageBox.Show("No se puede seleccionar una fecha/hora que ya pasó.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtNombreTour.Text) ||
      string.IsNullOrEmpty(cmbDestino.Text) || string.IsNullOrEmpty(maskTel.Text) || string.IsNullOrEmpty(maskCedula.Text))
            {
                System.Windows.Forms.MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            TourInfo nuevo = ConstructorDeTours.CrearTourNacional(
            txtNombreTour.Text.Trim(),
            cmbDestino.Text,
            maskTel.Text,
            maskCedula.Text,
            dtpFecha.Value.Date,
            dtpHora.Value.TimeOfDay,
            "Público Nacional"
            );

            //crear.CalcularEstado(nuevo.FechaHora, nuevo.Duracion.Days);

            Crear obtenterEstado = new Crear();
           

            if (obtenterEstado.CalcularEstado(nuevo.FechaHora, nuevo.Duracion.Days) == "Vigente") //nuevo.Estado == "Vigente"
            {
                


                if (!TourValidador.PuedeCrearNuevoTour(nuevo.FechaHora, nuevo.Destino, TipoTour.Internacional, nuevo.Pais))
                {
                    System.Windows.Forms.MessageBox.Show("Ya se alcanzó el máximo de tours permitidos con esa combinación.");
                    return;
                }
                else
                {
                    TourRepositorio.Tours.Add(nuevo);
                    PersistenciaLocal.Guardar();

                    UcAgendar pdf = new UcAgendar();

                   

                    string rutaTemporal = pdf.GenerarReciboPDF(nuevo.Nombre, null, nuevo.Telefono, nuevo.Cedula, nuevo.Destino, nuevo.FechaHora, nuevo.Precio, nuevo.ITBIS, nuevo.Duracion, nuevo.Estado, nuevo.Id);
                   
                    System.Diagnostics.Process.Start(rutaTemporal);

                    
                    DialogResult resultado = System.Windows.Forms.MessageBox.Show("¿Deseas guardar este recibo?",
                                                             "Confirmación", MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string carpeta = Path.Combine(escritorio, "Recibos");
                        Directory.CreateDirectory(carpeta);

                        string nombreArchivo = Path.GetFileName(rutaTemporal).Replace("_Preview", "");
                        string rutaFinal = Path.Combine(carpeta, nombreArchivo);

                        File.Copy(rutaTemporal, rutaFinal, true);
                        System.Windows.Forms.MessageBox.Show("¡Recibo guardado con éxito!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        File.Delete(rutaTemporal);
                    }


                    System.Windows.Forms.MessageBox.Show("¡Registro exitoso!");

                    

                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("El tour está vencido y no se puede generar el recibo.");
            }



            
        }

        private void txtNombreTour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquear caracteres no permitidos
            }

            if (!e.KeyChar.Equals((char)Keys.Back) && !e.KeyChar.Equals((char)Keys.Delete))
            {
                // Limitar a 50 caracteres
                if (txtNombreTour.Text.Length >= 50)
                {
                    e.Handled = true; // Bloquear si ya tiene 50 caracteres
                }
            }
        }

        private void cmbDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }

            if (!e.KeyChar.Equals((char)Keys.Back) && !e.KeyChar.Equals((char)Keys.Delete))
            {
               
                if (txtNombreTour.Text.Length >= 50)
                {
                    e.Handled = true; 
                }
            }
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CatalogoDestinos.PreciosPorDestinoNacional.ContainsKey(cmbDestino.Text))
            {
                precio = CatalogoDestinos.PreciosPorDestinoNacional[cmbDestino.Text];
                itbis = precio * 0.18m;
                lblPrecio.Text = $"RD${itbis + precio:N2} ITBIS Incluido";
            }
            if (cmbDestino.Text == "Samaná")
            {
              
                imagenesSamana();
                MostrarMapa("Samaná");
                pictureBox1.Image = Properties.Resources.SamanaQR;
                panelQR.Visible = true;

              

            }
            else if (cmbDestino.Text == "Punta Cana")
            {
              
                imagenesPuntaCana();
                MostrarMapa("Punta Cana");
                pictureBox1.Image = Properties.Resources.PuntaCanaQR;
                panelQR.Visible = true;
             
            }
            else if (cmbDestino.Text == "Puerto Plata")
            {
                imagenesPuertoPlata();
                MostrarMapa("Punta Plata");
                pictureBox1.Image = Properties.Resources.PuertoPlataQR;
                panelQR.Visible = true;
            }
            else if (cmbDestino.Text == "Santiago")
            {
                imagenesSantiago();
                MostrarMapa("Santiago");
                pictureBox1.Image = Properties.Resources.SantiagoQR;
                panelQR.Visible = true;
            }
            else if (cmbDestino.Text == "La Romana")
            {
                imagenesLaRomana();
                MostrarMapa("La Romana");
                pictureBox1.Image = Properties.Resources.RomanaQR;
                panelQR.Visible = true;
            }
            else
            {
                picGaleria.Image = null; 
                webView21.Source = null; 
                panelQR.Visible = false; 
            }
        }

        private void panelTopNacional_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
