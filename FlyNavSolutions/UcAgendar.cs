using FlyNavSolutions.Administrador.Crear;
using FlyNavSolutions.BorderRadius;
using FlyNavSolutions.Tour;
using FontAwesome.Sharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Web.WebView2.WinForms;
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
    public partial class UcAgendar : UserControl
    {
        public List<TourInfo> listaTours = new List<TourInfo>();
        public List<TourInfo> ToursAgendados => listaTours;

        // Lista de imágenes
        private System.Drawing.Image[] imagenes;
        private int indiceActual = 0;



        Dictionary<string, decimal> precios = new Dictionary<string, decimal>();
        Dictionary<string, List<string>> destinosPorPais = new Dictionary<string, List<string>>();
        Dictionary<string, TimeSpan> duraciones = new Dictionary<string, TimeSpan>();
        private List<string> imagenesMadrid = new List<string>();
        
        private int indiceImagen = 0;
        private Timer timerCarrusel;



        string nombreTour;
        string pais;
        string destino;
        DateTime fecha;
        TimeSpan hora;
        DateTime fechaHora;

        decimal precio;
        decimal itbis;
        TimeSpan duracion;
        string estado;
        string id;

        string telefono;
        string cedula;


        Crear validarFecha = new Crear();
       
    

        public UcAgendar()
        {
            InitializeComponent();
            InicializarDatos1();
            InicializarPrecios();
            InicializarDuraciones();

            BorderRadius.borderRadius.AplicarRadius(panelQR, 30);



        }

        private void InicializarImagenesMadrid()
        {
            imagenesMadrid.Clear();
            imagenesMadrid.Add("https://images.app.goo.gl/whGDiYtAw1CVHT2R8");
            imagenesMadrid.Add("https://images.app.goo.gl/Ltr6tZBuNucq6ipq5");
            imagenesMadrid.Add("https://images.app.goo.gl/akGrFbN3ik3pE8VZ9");
            imagenesMadrid.Add("https://images.app.goo.gl/Q4qoc16UdSDhV3Sr8");



        }

        public void InicializarDatos1()
        {
            destinosPorPais.Add("Reino Unido", new List<string> { "Londres"});
            destinosPorPais.Add("España", new List<string> { "Madrid", "Barcelona", "Sevilla" });
            destinosPorPais.Add("Francia", new List<string> { "París", "Marsella", "Burdeos" });

            cmbPais.Items.AddRange(destinosPorPais.Keys.ToArray());



            
        }
        private void imagenesSpain()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "españa1.jpg");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "españa2pg.jpg");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "españa3.jpg");

            imagenes = new System.Drawing.Image[]
            {
                System.Drawing.Image.FromFile(ruta1),
                System.Drawing.Image.FromFile(ruta2),
                System.Drawing.Image.FromFile(ruta3),
            };
            
            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

            // Configurar Timer
            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }

        private void imagenesBarcelona()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "barcelona1.jpg");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "barcelona2.jpg");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "barcelona3.jpg");

            
            imagenes = new System.Drawing.Image[]
            {
                System.Drawing.Image.FromFile(ruta1),
                System.Drawing.Image.FromFile(ruta2),
                System.Drawing.Image.FromFile(ruta3),
            };

            // Configurar PictureBox
            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

            // Configurar Timer
            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }

        private void imagenesSevilla()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "sevillajpg.jpg");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "sevillla2.jpg");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "sevilla3jpg.jpg");

            imagenes = new System.Drawing.Image[]
            {
                System.Drawing.Image.FromFile(ruta1),
                System.Drawing.Image.FromFile(ruta2),
                System.Drawing.Image.FromFile(ruta3),
            };

            // Configurar PictureBox
            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

            // Configurar Timer
            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }
        private void imagenesParis()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "paris1.jpg");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "paris2.jpg");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "paris3.jpg");

            imagenes = new System.Drawing.Image[]
            {
                System.Drawing.Image.FromFile(ruta1),
                System.Drawing.Image.FromFile(ruta2),
                System.Drawing.Image.FromFile(ruta3),
            };

            // Configurar PictureBox
            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

            // Configurar Timer
            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }
        private void imagenesMarsella()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "marsella1.png");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "marsella2.jpg");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "marsella3.jpg");

            imagenes = new System.Drawing.Image[]
            {
                System.Drawing.Image.FromFile(ruta1),
                System.Drawing.Image.FromFile(ruta2),
                System.Drawing.Image.FromFile(ruta3),
            };

            // Configurar PictureBox
            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

            // Configurar Timer
            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }

        private void imagenesBurdeos()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "burdeos1.jpg");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "burdeos2.jpg");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "burdeos3.jpg");

            imagenes = new System.Drawing.Image[]
            {
                System.Drawing.Image.FromFile(ruta1),
                System.Drawing.Image.FromFile(ruta2),
                System.Drawing.Image.FromFile(ruta3),
            };

            // Configurar PictureBox
            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

            // Configurar Timer
            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }

        private void imagenesLondres()
        {

            string ruta1 = Path.Combine(Application.StartupPath, "imagenes", "londres1.jpg");
            string ruta2 = Path.Combine(Application.StartupPath, "imagenes", "londres2.png");
            string ruta3 = Path.Combine(Application.StartupPath, "imagenes", "londres3.jpg");

            try
            {
                imagenes = new System.Drawing.Image[]
            {
                System.Drawing.Image.FromFile(ruta1),
                System.Drawing.Image.FromFile(ruta2),
                System.Drawing.Image.FromFile(ruta3),
            };
            } catch (Exception e)
            {
                MessageBox.Show($"Error al cargar las imagenes {e}");
            }
            

            // Configurar PictureBox
            picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            picGaleria.Image = imagenes[indiceActual];

            // Configurar Timer
            timer1.Interval = 3000; // Cambia cada 3 segundos
            timer1.Tick += timer1_Tick_1;
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Cambiar imagen
            indiceActual++;
            if (indiceActual >= imagenes.Length)
                indiceActual = 0;

            picGaleria.Image = imagenes[indiceActual];
        }

        public void ExportarCSV()

        {


            // Ruta: Escritorio/TourCSV
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string carpeta = Path.Combine(escritorio, "TourCSV");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            string ruta = Path.Combine(carpeta, "Tour_" + DateTime.Now.Ticks + ".csv");

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("ID,Nombre,Pais,Destino,FechaHora,Precio,ITBIS,Duracion,Estado");

                foreach (TourInfo tour in listaTours)
                {
                    sw.WriteLine($"{tour.Id},{tour.Nombre},{tour.Pais},{tour.Telefono}, {tour.Cedula}, {tour.Destino},{tour.FechaHora:f}," +
                                 $"{tour.Precio},{tour.ITBIS},{tour.Duracion.TotalHours} horas,{tour.Estado}");
                }
            }

            MessageBox.Show("Exportación CSV completada:\n" + ruta, "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ExportarExcel()
        {
            MessageBox.Show("Hash de instancia: " + this.GetHashCode());

            MessageBox.Show($"Cantidad de registros: {listaTours.Count}");

         
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string carpeta = Path.Combine(escritorio, "TourExcel");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

 
            string ruta = Path.Combine(carpeta, $"Tour_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");

      
            var workbook = new ClosedXML.Excel.XLWorkbook();
            var hoja = workbook.Worksheets.Add("Tours");

            hoja.Cell(1, 1).Value = "ID";
            hoja.Cell(1, 2).Value = "Nombre";
            hoja.Cell(1, 3).Value = "País";
            hoja.Cell(1, 4).Value = "Teléfono";
            hoja.Cell(1, 5).Value = "Cédula";
            hoja.Cell(1, 4).Value = "Destino";
            hoja.Cell(1, 5).Value = "Fecha y Hora";
            hoja.Cell(1, 6).Value = "Precio";
            hoja.Cell(1, 7).Value = "ITBIS";
            hoja.Cell(1, 8).Value = "Duración";
            hoja.Cell(1, 9).Value = "Estado";

            int fila = 2;
            foreach (TourInfo tour in listaTours)
            {
                hoja.Cell(fila, 1).Value = tour.Id;
                hoja.Cell(fila, 2).Value = tour.Nombre;
                hoja.Cell(fila, 3).Value = tour.Pais;
                hoja.Cell(fila, 4).Value = tour.Telefono;
                hoja.Cell(fila, 5).Value = tour.Cedula;
                hoja.Cell(fila, 4).Value = tour.Destino;
                hoja.Cell(fila, 5).Value = tour.FechaHora;
                hoja.Cell(fila, 6).Value = tour.Precio;
                hoja.Cell(fila, 7).Value = tour.ITBIS;
                hoja.Cell(fila, 8).Value = tour.Duracion;
                hoja.Cell(fila, 9).Value = tour.Estado;
                fila++;
            }

            workbook.SaveAs(ruta);

            MessageBox.Show($"Exportación Excel completada:\n{ruta}", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void InicializarDuraciones()
        {
            duraciones.Add("Londres", new TimeSpan(2, 6, 0, 0));      // 2 días, 6 horas
     
            duraciones.Add("Madrid", new TimeSpan(3, 0, 0, 0));       // 3 días
            duraciones.Add("Barcelona", new TimeSpan(2, 18, 0, 0));   // 2 días, 18 horas
            duraciones.Add("Sevilla", new TimeSpan(2, 12, 0, 0));     // 2 días, 12 horas
            duraciones.Add("París", new TimeSpan(2, 0, 0, 0));
            duraciones.Add("Marsella", new TimeSpan(1, 18, 0, 0));
            duraciones.Add("Burdeos", new TimeSpan(1, 20, 0, 0));
        }
        public void InicializarPrecios()
        {
            precios.Add("Londres", 8500m);
          
            precios.Add("Madrid", 15000m);
            precios.Add("Barcelona", 14500m);
            precios.Add("Sevilla", 13800m);
            precios.Add("París", 9500m);
            precios.Add("Marsella", 8700m);
            precios.Add("Burdeos", 8900m);


          
        }
        private void InicializarDatos()
        {

        }
        private void MostrarCarruselMadrid()
        {
            if (imagenesMadrid.Count == 0)
            {
                MessageBox.Show("No hay imágenes disponibles para Madrid.");
                return;
            }

            try
            {
                picGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
                picGaleria.Load(imagenesMadrid[0]);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la imagen inicial.");
                return;
            }

            if (timerCarrusel != null)
            {
                timerCarrusel.Stop();
                timerCarrusel.Dispose();
            }

            indiceImagen = 0;
            timerCarrusel = new Timer();
            timerCarrusel.Interval = 3000;
            timerCarrusel.Tick += (s, e) =>
            {
                try
                {
                    indiceImagen = (indiceImagen + 1) % imagenesMadrid.Count;
                    picGaleria.Load(imagenesMadrid[indiceImagen]);
                }
                catch
                {
                    timerCarrusel.Stop();
                    MessageBox.Show("Error al cargar una imagen del carrusel.");
                }
            };
            timerCarrusel.Start();
        }
        private void MostrarMapa(string destino)
        {
            string url = $"https://www.google.com/maps/search/{Uri.EscapeDataString(destino)}";
            webView21.Source = new Uri(url);
        }

        public string GenerarReciboPDF(string nombreTour, string pais, string telefono, string cedula, string destino, DateTime fechaHora,
                               decimal precio, decimal itbis, TimeSpan duracion, string estado, string id)
        {
            


            string ruta = Path.Combine(Path.GetTempPath(), $"Recibo_{id}_Preview.pdf");

            Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
            PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
            doc.Open();

            doc.AddAuthor("FlyNav Solutions");
            

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Users\camil\OneDrive\Desktop\Fondos WindForm\FlyNav.png ");
            logo.ScaleAbsolute(200, 100);
            logo.Alignment = Element.ALIGN_CENTER;
            doc.Add(logo);

           
            iTextSharp.text.Font titulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
            iTextSharp.text.Font cuerpo = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.DARK_GRAY);
            iTextSharp.text.Font agradecimiento = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 12, BaseColor.GRAY);

            
            Paragraph encabezado = new Paragraph($"Recibo de Reserva de Tour | {nombreTour}", titulo);
            encabezado.Alignment = Element.ALIGN_CENTER;
            encabezado.SpacingAfter = 20;
     
            doc.Add(encabezado);

           

           
            PdfPTable tabla = new PdfPTable(2);
            tabla.WidthPercentage = 80;
            tabla.SpacingBefore = 10;
            tabla.HorizontalAlignment = Element.ALIGN_CENTER;

            tabla.AddCell("ID del Tour");
            tabla.AddCell(id);
            tabla.AddCell("Nombre del Tour");
            tabla.AddCell(nombreTour);
            tabla.AddCell("País");
            tabla.AddCell(pais);
            tabla.AddCell("Teléfono");
            tabla.AddCell(telefono);
            tabla.AddCell("Cédula");
            tabla.AddCell(cedula);
            tabla.AddCell("Destino");
            tabla.AddCell(destino);
            tabla.AddCell("Fecha y Hora");
            tabla.AddCell(fechaHora.ToString("f"));
            tabla.AddCell("Precio");
            tabla.AddCell($"RD${precio:N2}");
            tabla.AddCell("ITBIS (18%)");
            
            tabla.AddCell($"RD${itbis:N2}");
            tabla.AddCell("Total con ITBIS");
            tabla.AddCell($"RD${precio + itbis:N2}");
            tabla.AddCell("Duración");
            tabla.AddCell($"{duracion.Days} días y {duracion.Hours} horas");
            tabla.AddCell("Estado");
            tabla.AddCell(estado);

            doc.Add(tabla);

           
            Paragraph mensaje = new Paragraph("\nGracias por reservar con nosotros ❤️", agradecimiento);
            mensaje.Alignment = Element.ALIGN_CENTER;
            doc.Add(mensaje);

            doc.Close();

            return ruta; 

          
        }

        

        private void GenerarReciboPDFElegante(TourInfo tour)
        {
           
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UcAgendar_Load(object sender, EventArgs e)
        {
            

            borderRadius.AplicarRadius(panelInfo, 10);
            // Configurar el RichTextBox
            richTextBoxInfo.ReadOnly = true;
            richTextBoxInfo.BorderStyle = BorderStyle.None;
           

         
            richTextBoxInfo.Text = "• 🏨 Este tour incluye alojamiento compartido en 10 habitaciones dobles (2 personas por habitación).\n" +
        "• 🛌 Si deseas una habitación privada, puedes solicitarlo directamente con nuestro equipo (sujeto a disponibilidad y costo adicional).\n" +
        "• 📞 Contacto: Teléfono: (809) 524-1090 | Correo electrónico: flynavSolutions@gmail.com.\n" +
        "• 💰 El precio mostrado ya incluye ITBIS.\n" +
        "• 📄 Recibirás un comprobante digital al finalizar tu reserva.\n" +
        "• 💱 ¿Quieres ver el precio en otra moneda? Usa nuestro asistente inteligente para convertirlo al instante.\n" +
        "• 💺 El boleto de avión no está incluido en el precio del tour.\n" +
        "• ✈️ Nuestro asistente inteligente también puede ayudarte como guía y compañero de viaje.";

          
            iconPictureBoxToggle.IconChar = IconChar.Eye; 
            iconPictureBoxToggle.Cursor = Cursors.Hand;

      
            iconPictureBoxToggle.Click += (s, e3) =>
            {
                panelInfo.Visible = !panelInfo.Visible;
                iconPictureBoxToggle.IconChar = panelInfo.Visible ? IconChar.EyeSlash : IconChar.Eye;
            };

           
            dtpHora.ValueChanged += (s, e1) => validarFecha.ValidarHora(dtpHora);



            CatalogoDestinos.CargarPaises(cmbPais);

           

            cmbPais.SelectedIndexChanged += cmbPais_SelectedIndexChanged_1;

            PersistenciaLocal.Cargar();
        
            panel2.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            panel4.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            panel5.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            panelBorder.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            panel6.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            panel3.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            panel7.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);


        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

            
        }

        private void cmbPais_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbDestino.Items.Clear(); 

            if (destinosPorPais.TryGetValue(cmbPais.Text, out var destinos))
            {
                cmbDestino.Items.AddRange(destinos.ToArray());
                

                if (cmbDestino.Items.Count > 0)
                {
                    cmbDestino.SelectedIndex = 0; // Selecciona el primero automáticamente
                }
  

            }
            
        }

        private void cmbDestino_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (precios.ContainsKey(cmbDestino.Text))
            {
                precio = precios[cmbDestino.Text];
                itbis = precio * 0.18m;
                lblPrecio.Text = $"RD${itbis + precio:N2} ITBIS Incluido";
            }
            if (cmbDestino.Text == "Madrid")
            {
                //InicializarImagenesMadrid();
                //MostrarCarruselMadrid();
                imagenesSpain();
                MostrarMapa("Madrid");
                panelQR.Visible = true;

               

            }
            else if (cmbDestino.Text == "Barcelona")
            {
                imagenesBarcelona();
                MostrarMapa("Barcelona");

                pictureBox1.Image = Properties.Resources.BarcelonaQR;
                panelQR.Visible = true;
            }
            else if (cmbDestino.Text == "Sevilla")
            {
                imagenesSevilla();
                MostrarMapa("Sevilla");
                pictureBox1.Image = Properties.Resources.SevillaQR;

                panelQR.Visible = true;
            }
            else if (cmbDestino.Text == "París")
            {
                imagenesParis();
                MostrarMapa("París");
                pictureBox1.Image = Properties.Resources.ParisQR;

                panelQR.Visible = true;
            }
            else if (cmbDestino.Text == "Marsella")
            {
                imagenesMarsella();
                MostrarMapa("Marsella");
                pictureBox1.Image = Properties.Resources.MarsellaQR;

                panelQR.Visible = true;
            }
            else if (cmbDestino.Text == "Burdeos")
            {
                imagenesBurdeos();
                MostrarMapa("Burdeos");
                pictureBox1.Image = Properties.Resources.BurdeosQR;

                panelQR.Visible = true;
            }
            else if (cmbDestino.Text == "Londres")
            {
             
                imagenesLondres();
                MostrarMapa("Londres");
                pictureBox1.Image = Properties.Resources.LondresQR;

                panelQR.Visible = true;
            }
            else
            {
                picGaleria.Image = null; 
                webView21.Source = null; 
                panelQR.Visible = false; 
            }
           
          

        }



        private void txtNombreTour_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDestino_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaTour_Click(object sender, EventArgs e)
        {

        }

        private void lblHoraTour_Click(object sender, EventArgs e)
        {

        }

        private void lblPaisDestino_Click(object sender, EventArgs e)
        {

        }
       


        private void iconButton6_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFecha.Value.Date + dtpHora.Value.TimeOfDay;

            if (fechaInicio < DateTime.Now)
            {
                MessageBox.Show("No se puede seleccionar una fecha/hora que ya pasó.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtNombreTour.Text) ||
       string.IsNullOrEmpty(cmbDestino.Text) || string.IsNullOrEmpty(maskTel.Text) || string.IsNullOrEmpty(maskCedula.Text) ||
       (cmbPais.Visible && string.IsNullOrEmpty(cmbPais.Text)))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }


            TourInfo nuevo = ConstructorDeTours.CrearTourInternacional(
            txtNombreTour.Text.Trim(),
            cmbPais.Text,
            maskTel.Text,
            maskCedula.Text,
            cmbDestino.Text,
            dtpFecha.Value.Date,
            dtpHora.Value.TimeOfDay,
            "Público Internacional"
             );

            Crear obtenterEstado = new Crear();
            obtenterEstado.CalcularEstado(nuevo.FechaHora, nuevo.Duracion.Days);

            if (obtenterEstado.CalcularEstado(nuevo.FechaHora, nuevo.Duracion.Days) == "Vigente") //(nuevo.Estado == "Vigente")
            {
               
                if (!TourValidador.PuedeCrearNuevoTour(nuevo.FechaHora, nuevo.Destino, TipoTour.Internacional, nuevo.Pais))
                {
                    MessageBox.Show("Ya se alcanzó el máximo de tours permitidos con esa combinación.");
                    return;
                }
                else
                {
                    TourRepositorio.Tours.Add(nuevo);
                    PersistenciaLocal.Guardar();

                    string rutaTemporal = GenerarReciboPDF(nuevo.Nombre, nuevo.Pais, nuevo.Telefono, nuevo.Cedula, nuevo.Destino, nuevo.FechaHora, nuevo.Precio, nuevo.ITBIS, nuevo.Duracion, nuevo.Estado, nuevo.Id);
                    
                    System.Diagnostics.Process.Start(rutaTemporal);

                 
                    DialogResult resultado = MessageBox.Show("¿Deseas guardar este recibo?",
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
                        MessageBox.Show("¡Recibo guardado con éxito!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        File.Delete(rutaTemporal); 
                    }

                   
                }
            }
            else
            {
                MessageBox.Show("El tour está vencido y no se puede generar el recibo.");
            }

         
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
          
            indiceActual++;
            if (indiceActual >= imagenes.Length)
                indiceActual = 0;

            picGaleria.Image = imagenes[indiceActual];
        }

        private void panelCampos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelAgendandoPublico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombreTour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
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

        private void cmbPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquear caracteres no permitidos
            }

            if (!e.KeyChar.Equals((char)Keys.Back) && !e.KeyChar.Equals((char)Keys.Delete))
            {
                
                if (txtNombreTour.Text.Length >= 50)
                {
                    e.Handled = true; 
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

        private void iconPictureBoxToggle_Click(object sender, EventArgs e)
        {

        }
    }
}
