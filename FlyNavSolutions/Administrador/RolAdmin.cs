using DocumentFormat.OpenXml.Spreadsheet;
using FlyNavSolutions.Administrador.CrearModal;
using FlyNavSolutions.Tour;
using FontAwesome.Sharp;
using iTextSharp.text.pdf.codec.wmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;



namespace FlyNavSolutions.Administrador
{
    public partial class RolAdmin : Form
    {

        private SpeechRecognitionEngine recognizer;
        private SpeechSynthesizer synthesizer;
       
        private Timer micTimeoutTimer;
        private bool speechEventReceived = false;

        private BindingSource tourBinding = new BindingSource(); 

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private int borderSize = 2;

        
        private bool modoEditarActivo = false;


        private IconPictureBox iconoDisponibilidad;
        public RolAdmin()
        {
            InitializeComponent();
            synthesizer = new SpeechSynthesizer();

            this.Padding = new Padding(borderSize);
            this.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);


            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new System.Drawing.Size(7, 60);
            panelMenuAdmin.Controls.Add(leftBorderBtn);
        }
        private struct RGBColors
        {

            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(255, 147, 152, 173);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(255, 159, 150, 212);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(255, 184, 224, 153);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(255, 237, 145, 153);

        }

        private void InicializarIcono()
        {
           
        }

        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(255, 37, 36, 81); 
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new System.Drawing.Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
                currentBtn.ForeColor = System.Drawing.Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void iconButtonBar_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {

            if (this.panelMenuAdmin.Width > 200)
            {
                panelMenuAdmin.Width = 150;
                pictureBox1.Visible = false;
                iconButtonBar.Dock = DockStyle.Top;
                //panelBarPublico.Visible = false;


                foreach (Button menuButton in panelMenuAdmin.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0, 10, 0, 0);
                    iconButtonBar.ImageAlign = ContentAlignment.MiddleCenter;


                }
            }
            else
            {
                panelMenuAdmin.Width = 444;
                pictureBox1.Visible = true;
                iconButtonBar.Dock = DockStyle.Top;



                foreach (Button menuButton in panelMenuAdmin.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 20, 0);
                    iconButtonBar.ImageAlign = ContentAlignment.MiddleLeft;



                }

            }
        }

        private void RolAdmin_Load(object sender, EventArgs e)
        {



            cmbFiltroEstado.Items.Add("Todos");
            cmbFiltroEstado.Items.Add("Vigente");
            cmbFiltroEstado.Items.Add("No vigente");
            cmbFiltroEstado.SelectedIndex = 0; 
            cmbFiltroEstado.SelectedIndexChanged += cmbFiltroEstado_SelectedIndexChanged;


            comboBoxComandos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxComandos.Items.AddRange(new string[]
            {
        "Export csv",
        "Go out",
        "Export excel"
            });
            comboBoxComandos.SelectedIndex = 0;

            panelMenuAdmin.BackColor = System.Drawing.Color.FromArgb(10, 19, 59);
            panelFoto.BackColor = System.Drawing.Color.FromArgb(10, 19, 59);
            panelFill.BackColor = System.Drawing.Color.FromArgb(234, 234, 250);


        
            PersistenciaLocal.Cargar();

            
            ConfigurarGrid();
            InitBinding();

          

            dataGridViewBD.DataSource = TourRepositorio.Tours; 

           

            pictureVoz.Image = Image.FromFile(@"C:\Users\camil\OneDrive\Desktop\IMGPF6\voz2-unscreen.gif");
            pictureVoz.SizeMode = PictureBoxSizeMode.Zoom;
            BorderRadius.borderRadius.AplicarCircular(pictureVoz);

            pictureBox2.Image = Image.FromFile(@"C:\Users\camil\OneDrive\Desktop\IMGPF6\sound-unscreen.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            BorderRadius.borderRadius.AplicarCircular(pictureVoz);


            BorderRadius.borderRadius.AplicarRadius(comboBoxComandos, 10);



        }

        private void InitBinding()
        {
            tourBinding.DataSource = TourRepositorio.Tours;
            dataGridViewBD.DataSource = tourBinding;
        }

        private void RefrescarToursEnGrid()
        {
            tourBinding.ResetBindings(false);
            dataGridViewBD.Refresh();
        }

        private void ConfigurarGrid()
        {
            

            dataGridViewBD.AutoGenerateColumns = false;
            dataGridViewBD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBD.MultiSelect = false;
            dataGridViewBD.ReadOnly = true;

            dataGridViewBD.Columns.Clear();

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TourInfo.Id),
                HeaderText = "ID",
                Width = 120
            });

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TourInfo.Nombre),
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TourInfo.Pais),
                HeaderText = "País"
            });

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TourInfo.Destino),
                HeaderText = "Destino"
            });

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TourInfo.Telefono),
                HeaderText = "Teléfono"
            });

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TourInfo.Cedula),
                HeaderText = "Cédula",
            });

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {

               
                DataPropertyName = nameof(TourInfo.FechaHora),
               
                HeaderText = "Fecha/Hora",
                DefaultCellStyle = { Format = "g" }
            });

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TourInfo.Precio),
                HeaderText = "Precio",
                DefaultCellStyle = { Format = "N2" }
            });

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TourInfo.ITBIS),
                HeaderText = "ITBIS",
                ReadOnly = true,
                DefaultCellStyle = { Format = "N2" }
            });

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TourInfo.Duracion),
                HeaderText = "Duración Días y horas"
            });

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TourInfo.Estado), 
                HeaderText = "Estado",
                ReadOnly = true
            });

            dataGridViewBD.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TourInfo.RolOrigen),
                HeaderText = "Rol Origen"
            });

           
            dataGridViewBD.CellDoubleClick += dataGridViewBD_CellDoubleClick;
        }

        private void dataGridViewBD_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridViewBD.Columns[e.ColumnIndex].Name == "Editar")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var faFont = new System.Drawing.Font("FontAwesome", 30); 
                string icono = "\uf044"; 

                TextRenderer.DrawText(
                    e.Graphics, icono, faFont, e.CellBounds,
                    System.Drawing.Color.DarkSlateGray, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                e.Handled = true;
            }
    

        }

        private void iconButtonMostrar_Click(object sender, EventArgs e)
        {
            cmbFiltroEstado.Visible = true;
            ActivateButton(sender, RGBColors.color2);

            dataGridViewBD.DataSource = TourRepositorio.Tours.ToList();
            dataGridViewBD.Visible = true;

        }

        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

            DialogResult confirmacion = System.Windows.Forms.MessageBox.Show(
              "¿Estás seguro que deseas salir?",
              "Salir del sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
                System.Windows.Forms.Application.Exit(); 
        }

        private void iconButtonCrearAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

            Crear.Crear modalCrear = new Crear.Crear();
            modalCrear.ShowDialog();

            // Actualizar visualmente Comentar
            dataGridViewBD.DataSource = null;
            dataGridViewBD.DataSource = TourRepositorio.Tours.ToList();



        }

        private void dataGridViewBD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        public void AgregarFila(string nombreTour, string pais, string destino, string telefono, string cedula, string fecha, string hora)
        {
            

            int n = dataGridViewBD.Rows.Add();
            DataGridViewRow row = dataGridViewBD.Rows[n];
            row.Cells["NombreTour"].Value = nombreTour;
            row.Cells["PaísDestino"].Value = pais;
            row.Cells["Destino"].Value = destino;
            row.Cells["Teléfono"].Value = telefono;
            row.Cells["Cédula"].Value = cedula;


            row.Cells["FechaTour"].Value = fecha;
            row.Cells["HoraTour"].Value = hora;
    

        }

        private void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);

            if (dataGridViewBD.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Selecciona una fila antes de continuar.", "Eliminar Tour", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dataGridViewBD.SelectedRows[0];
            var tourSeleccionado = filaSeleccionada.DataBoundItem as TourInfo;

            if (tourSeleccionado == null)
            {
                System.Windows.Forms.MessageBox.Show("No se pudo obtener el Tour seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmacion = System.Windows.Forms.MessageBox.Show(
                $"¿Estás seguro de eliminar el Tour \"{tourSeleccionado.Nombre}\" en {tourSeleccionado.Destino}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                TourRepositorio.Tours.Remove(tourSeleccionado);
                PersistenciaLocal.Guardar(); // actualiza el archivo JSON

                System.Windows.Forms.MessageBox.Show("Tour eliminado correctamente.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar visualmente
                dataGridViewBD.DataSource = null;
                dataGridViewBD.DataSource = TourRepositorio.Tours.ToList();
            }
        }

       

        private void iconButtonUpdateAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

          



            if (dataGridViewBD.Rows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No hay datos para editar.");
                return;
            }

            modoEditarActivo = true;
            System.Windows.Forms.MessageBox.Show("Haz doble clic en la fila que deseas editar.");

            


        }

        private void iconButtonCSV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);


            RolPublico csv = new RolPublico();

         

            if (System.Windows.Forms.MessageBox.Show("¿Desea exportar en formato .CSV?", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                csv.ExportarCSV();
            }
           


        }

        private void iconButtonExcel_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);


            if (System.Windows.Forms.MessageBox.Show("¿Desea exportar en formato Excel", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RolPublico excel = new RolPublico();
                excel.ExportarExcel();
            }


        }

        private void dataGridViewBD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (!modoEditarActivo) return;
            if (e.RowIndex < 0) return;

            var tour = (TourInfo)dataGridViewBD.Rows[e.RowIndex].DataBoundItem;
            if (tour == null) return;

            var copia = ClonarTour(tour);

            if (copia.Pais == null)
            {
                // Tour Nacional
                using (var frm = new CrearModal.CrearNacionalcs())
                {
                    frm.ModoEdicion = true;
                    frm.TourEditado = copia;

                    frm.AlCerrarConCambios += () =>
                    {
                        CopiarTour(copia, tour);
                        PersistenciaLocal.Guardar();
                    };

                    if (frm.ShowDialog(this) == DialogResult.OK)
                        RefrescarToursEnGrid();
                }
            }
            else
            {
                // Tour Internacional
                using (var frm = new Crear.Crear())
                {
                    frm.ModoEdicion = true;
                    frm.TourEditado = copia;

                    frm.AlCerrarConCambios += () =>
                    {
                        CopiarTour(copia, tour);
                        PersistenciaLocal.Guardar();
                    };

                    if (frm.ShowDialog(this) == DialogResult.OK)
                        RefrescarToursEnGrid();
                }
            }

            modoEditarActivo = false;



        }

        
        private TourInfo ClonarTour(TourInfo t) => new TourInfo
        {
            Id = t.Id,
            Nombre = t.Nombre,
            Pais = t.Pais,
            Destino = t.Destino,
            Cedula = t.Cedula,
            Telefono = t.Telefono,
            FechaHora = t.FechaHora,
            Precio = t.Precio,
            Duracion = t.Duracion,
            RolOrigen = t.RolOrigen
        };

        private void CopiarTour(TourInfo origen, TourInfo destino)
        {
            destino.Nombre = origen.Nombre;
            destino.Pais = origen.Pais;
            destino.Destino = origen.Destino;
            destino.Cedula = origen.Cedula;
            destino.Telefono = origen.Telefono;
            destino.FechaHora = origen.FechaHora;
            destino.Precio = origen.Precio;
            destino.Duracion = origen.Duracion;
            destino.RolOrigen = origen.RolOrigen;
        }

        private void pictureVoz_Click(object sender, EventArgs e)
        {
            try
            {

                if (SpeechRecognitionEngine.InstalledRecognizers().Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("No speech recognizers are installed on this system.");
                    return;
                }
                

                recognizer = new SpeechRecognitionEngine(new CultureInfo("en-US"));
                recognizer.SetInputToDefaultAudioDevice();

              
                Choices comandos = new Choices();
                comandos.Add(new string[] { "export csv", "hello", "close application", "go out", "export excel" });

                GrammarBuilder gb = new GrammarBuilder();
                gb.Culture = new CultureInfo("en-US"); 
                gb.Append(comandos);

                Grammar g = new Grammar(gb);
                recognizer.LoadGrammar(g);


                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                synthesizer.SpeakAsync("Hello, I'm the voice of Flynav. Welcome.");

                synthesizer.SpeakAsync("I'm listening Administrator. Tell me what to do.");
               


                // Iniciar temporizador para detectar silencio
                speechEventReceived = false;
                micTimeoutTimer = new Timer();
                micTimeoutTimer.Interval = 19000; 
                micTimeoutTimer.Tick += MicTimeoutTimer_Tick;
                micTimeoutTimer.Start();

                recognizer.SpeechRecognized += Reconocedor_SpeechRecognized;
              



            }
            catch (InvalidOperationException)
            {
                System.Windows.Forms.MessageBox.Show("No se detectó ningún micrófono conectado.");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error starting recognition: " + ex.Message);
               
            }

        }
        private void Recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            speechEventReceived = true;
            micTimeoutTimer?.Stop();

            if (e.Result.Confidence < 0.3)
            {
                synthesizer.SpeakAsync("I didn't understand anything.");
            }
            else
            {
                synthesizer.SpeakAsync("Almost understood, please try again.");
            }

        }
        private void Reconocedor_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {


            if (e.Result.Confidence > 0.4)
            {
                speechEventReceived = true;
                micTimeoutTimer?.Stop();
            }

            if (e.Result.Confidence < 0.65)
            {
                synthesizer.SpeakAsync("I didn't quite catch that. Could you repeat?");
                return;
            }


            string texto = e.Result.Text.ToLower();
           

            if (texto.Contains("export csv"))
            {
                synthesizer.SpeakAsync("Exporting csv...");
                TourInfo prop = new TourInfo();
                RolPublico csv = new RolPublico();
              
                csv.ExportarCSV();
               
            }
            
            if (texto.Contains("go out"))
            {
                
                synthesizer.Speak("closing the app. See you later.");

                if (recognizer != null)
                {
                    //recognizer.RecognizeAsyncStop();
                    //recognizer.Dispose();

                    try
                    {
                        recognizer.RecognizeAsyncCancel();
                    }
                    catch (ObjectDisposedException)
                    {
                        
                    }
                }
               System.Windows.Forms.Application.Exit();
            }
            if (texto.Contains("export excel"))
            {
               
                synthesizer.Speak("Exporting excel...");

                RolPublico rolPublico = new RolPublico();
                rolPublico.ExportarExcel();
            }
        }
        private void MicTimeoutTimer_Tick(object sender, EventArgs e)
        {
            micTimeoutTimer.Stop();

            if (!speechEventReceived)
            {
                synthesizer.SpeakAsync("No voice detected. Please make sure your microphone is enabled in Windows settings and try again.");
                System.Windows.Forms.MessageBox.Show("No voice input detected. Please check that your microphone is:\n\n- Connected\n- Enabled in privacy settings\n- Set as default input device",
                    "Microphone Not Detected. Or connect some headphones.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            string comandoSeleccionado = comboBoxComandos.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(comandoSeleccionado))
            {
                ProcesarTextoReconocido(comandoSeleccionado);
            }
        }
        private void ProcesarTextoReconocido(string texto)
        {
            texto = texto.ToLower();

            if (texto.Contains("export csv") || texto.Contains("exportar csv"))
            {
                synthesizer.SpeakAsync("Export csv");

               

                if (System.Windows.Forms.MessageBox.Show("¿Desea exportar en formato .CSV?", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    synthesizer.SpeakAsync("Exporting csv...");
                    RolPublico csv = new RolPublico();
                    csv.ExportarCSV();
                }
               
            }
            else if (texto.Contains("go out") || texto.Contains("cerrar aplicación"))
            {
                synthesizer.SpeakAsync("Go out");

                

                if (System.Windows.Forms.MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    synthesizer.SpeakCompleted += (s, e) => System.Windows.Forms.Application.Exit();
                    synthesizer.SpeakAsync("Go out. See you later.");
                }

                

            }
            else if (texto.Contains("export excel") || texto.Contains("exportar excel"))
            {
                synthesizer.SpeakAsync("Export excel");
          

                if (System.Windows.Forms.MessageBox.Show("¿Desea exportar en formato excel?", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    synthesizer.SpeakAsync("Exporting excel...");
                    RolPublico rolPublico = new RolPublico();
                    rolPublico.ExportarExcel();
                }
                
               
            }

            else
            {
                synthesizer.SpeakAsync("Command not recognized.");
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {

            System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
            tt.SetToolTip(pictureBox2, "Click to execute the selected command");
        }

        private void comboBoxComandos_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
            tt.SetToolTip(comboBoxComandos, "Select a command to execute");
        }

        private void comboBoxComandos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = cmbFiltroEstado.SelectedItem?.ToString();

            IEnumerable<TourInfo> toursFiltrados;

            switch (filtro)
            {
                case "Vigente":
                    toursFiltrados = TourRepositorio.Tours
                        .Where(t => t.Estado == "Vigente");
                    break;
                case "No vigente":
                    toursFiltrados = TourRepositorio.Tours
                        .Where(t => t.Estado == "Vencido");
                    
                    break;
                default:
                    toursFiltrados = TourRepositorio.Tours;
                    break;
            }

          


            dataGridViewBD.DataSource = null; 
            dataGridViewBD.DataSource = toursFiltrados.ToList();

          
            //Descomentar
            foreach (DataGridViewRow row in dataGridViewBD.Rows)
            {
                var tour = row.DataBoundItem as TourInfo;
                if (tour == null) continue;

                if (filtro == "No vigente" && tour.Estado == "Vencido")//if (tour.Estado == "Vencido")
                {


                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                    row.DefaultCellStyle.Font = new System.Drawing.Font(dataGridViewBD.Font, System.Drawing.FontStyle.Italic);


                }
                else if (filtro == "Vigente" && tour.Estado == "Vigente")
                {


                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(10, 13, 59);
                    row.DefaultCellStyle.Font = new System.Drawing.Font(dataGridViewBD.Font, System.Drawing.FontStyle.Bold);

                }



            }
        }

        private void dataGridViewBD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void dataGridViewBD_SelectionChanged(object sender, EventArgs e)
        {

            

            
        }

        // Probablemente no usemos esta función
        public void ActualizarIconoDisponibilidad()
        {
            TourInfo tour = null;

            // Verifica si hay tours disponibles
            if (TourRepositorio.Tours.Count == 0)
            {
                iconoDisponibilidad.IconChar = IconChar.QuestionCircle;
                iconoDisponibilidad.IconColor = System.Drawing.Color.Gray;
             
               System.Windows.Forms.MessageBox.Show("No hay tours disponibles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dataGridViewBD.SelectedRows.Count > 0 &&
                dataGridViewBD.SelectedRows[0].DataBoundItem is TourInfo seleccionado)
            {
                tour = seleccionado;
            }
            else
            {
                tour = TourRepositorio.Tours[0];
            }

          
            if (tour.CupoActual >= tour.CupoMaximo)
            {
                iconoDisponibilidad.IconChar = IconChar.TimesCircle;
                iconoDisponibilidad.IconColor = System.Drawing.Color.Red;
           
                System.Windows.Forms.MessageBox.Show("Cupo lleno para el tour seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tour.CupoMaximo - tour.CupoActual <= 5)
            {
                iconoDisponibilidad.IconChar = IconChar.ExclamationCircle;
                iconoDisponibilidad.IconColor = System.Drawing.Color.Goldenrod;
             
                System.Windows.Forms.MessageBox.Show("Cupos limitados para el tour seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                iconoDisponibilidad.IconChar = IconChar.CheckCircle;
                iconoDisponibilidad.IconColor = System.Drawing.Color.Green;
            
                System.Windows.Forms.MessageBox.Show("El tour seleccionado tiene cupos disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbFiltroEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    }


