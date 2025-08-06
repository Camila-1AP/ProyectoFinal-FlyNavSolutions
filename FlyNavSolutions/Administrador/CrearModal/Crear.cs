using DocumentFormat.OpenXml.Spreadsheet;
using FlyNavSolutions.Administrador.CrearModal;
using FlyNavSolutions.BorderRadius;
using FlyNavSolutions.Tour;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyNavSolutions.Administrador.Crear
{
    
    public partial class Crear : Form
    {
        Dictionary<string, decimal> precios = new Dictionary<string, decimal>();
        Dictionary<string, List<string>> destinosPorPais = new Dictionary<string, List<string>>();
        Dictionary<string, TimeSpan> duraciones = new Dictionary<string, TimeSpan>();

        decimal itbis;
        decimal precio;
       
        public TourInfo TourEditado { get; set; }
        public bool ModoEdicion { get; set; } = false;
        public event Action AlCerrarConCambios;


        public void ValidarHora(DateTimePicker picker)
        {
            DateTime horaSeleccionada = picker.Value;

            DateTime horaMinima = DateTime.Today.AddHours(6);      // 06:00 AM
            DateTime horaMaxima = DateTime.Today.AddHours(22.5);   // 10:30 PM

            if (horaSeleccionada < horaMinima || horaSeleccionada > horaMaxima)
            {
                MessageBox.Show("La hora debe estar entre 06:00 y 22:30", "Hora inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                picker.Value = horaMinima;
            }

            picker.BackColor = (horaSeleccionada >= horaMinima && horaSeleccionada <= horaMaxima) ? System.Drawing.Color.White : System.Drawing.Color.LightPink;
        }


        public Crear()
        {
            InitializeComponent();

            //InicializarDatos1();
            //InicializarPrecios();
            //InicializarDuraciones();
            
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
          
            this.StartPosition = FormStartPosition.CenterParent; 

           


        }
        private void InicializarDatos1()
        {
            UcAgendar initDatos1 = new UcAgendar();
            initDatos1.InicializarDatos1();
        }
        private void InicializarPrecios()
        {
            UcAgendar initPrecios = new UcAgendar();
            initPrecios.InicializarPrecios();
        }
        private void InicializarDuraciones()
        {
            UcAgendar initDuraciones = new UcAgendar();
            initDuraciones.InicializarDuraciones();
        }


        private void Crear_Load(object sender, EventArgs e)
        {
            

            borderRadius.AplicarRadius(iconButton5, 20);
            borderRadius.AplicarRadius(iconButtonNacional, 20);


            dtpHora.ValueChanged += (s, e1) => ValidarHora(dtpHora);

            CatalogoDestinos.CargarPaises(cmbPais);


            cmbPais.SelectedIndexChanged += (s, e2) =>
            {
                CatalogoDestinos.CargarDestinos(cmbDestino, cmbPais.Text);
                if (cmbDestino.Items.Count > 0)
                {
                    cmbDestino.SelectedIndex = 0;
                }
            };




            if (ModoEdicion && TourEditado != null)
            {
                groupCrear.Visible = true;
                
                txtNombreTour.Text = TourEditado.Nombre;
                cmbPais.Text = TourEditado.Pais;
                cmbDestino.Text = TourEditado.Destino;
               
                maskTel.Text = TourEditado.Telefono;
                maskCedula.Text = TourEditado.Cedula;
              

                dtpFecha.Value = TourEditado.FechaHora.Date;
                dtpHora.Value = DateTime.Today + TourEditado.FechaHora.TimeOfDay;
               
                iconAgendar.Text = "Guardar cambios";
            }
            else {
                iconButton5.Visible = true;
                iconButtonNacional.Visible = true;
            }

  
         
        }

       

        private void iconButtonInterncional_Click(object sender, EventArgs e)
        {
           
            
        }

        private void iconButtonNacional_Click(object sender, EventArgs e)
        {


            this.Hide();
          


            CrearModal.CrearNacionalcs crearModalNacional = new CrearModal.CrearNacionalcs();

           
            crearModalNacional.StartPosition = FormStartPosition.CenterParent; 


       
            crearModalNacional.ShowDialog(this);
            this.Close();
           
            

        }

        private void CrearModalNacional_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {


            iconButtonNacional.Visible = false;
            groupCrear.Visible = true;
            iconButton5.Visible = false;


      
            
        }
        public string CalcularEstado(DateTime fechaInicio, int duracionDias)
        {
            var fechaFin = fechaInicio.AddDays(duracionDias);
            return (fechaFin >= DateTime.Now) ? "Vigente" : "No Vigente";
        }

        private void iconAgendar_Click(object sender, EventArgs e)
        {
            


            DateTime fechaInicio = dtpFecha.Value.Date + dtpHora.Value.TimeOfDay;// dtpHora.Text = TourEditado.FechaHora.ToString("hh:mm tt"); // Formato de 12 horas

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


            if (ModoEdicion && TourEditado != null)
            {


                // -------- EDICIÓN --------
                TourEditado.Nombre = txtNombreTour.Text.Trim();
                TourEditado.Pais = cmbPais.Text;
                TourEditado.Telefono = maskTel.Text;



                //maskCedula.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                TourEditado.Cedula = maskCedula.Text;
                TourEditado.Destino = cmbDestino.Text;
                TourEditado.FechaHora = dtpFecha.Value.Date + dtpHora.Value.TimeOfDay;
                TourEditado.Precio = CatalogoDestinos.ObtenerPrecio(TourEditado.Destino);
                TourEditado.Duracion = CatalogoDestinos.ObtenerDuracion(TourEditado.Destino);

                CalcularEstado(TourEditado.FechaHora, TourEditado.Duracion.Days);

                if (!TourEditado.RolOrigen.StartsWith("E-"))
                    TourEditado.RolOrigen = "E- " + TourEditado.RolOrigen;



                AlCerrarConCambios?.Invoke();
                DialogResult = DialogResult.OK;
                MessageBox.Show("El Tour ha sido actualizado satisfactoriamente!", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);


                
                Close();
                return;
            }

            // ---- Caso normal de crear ----
            var nuevoTour = ConstructorDeTours.CrearTourInternacional(

                    txtNombreTour.Text.Trim(),
                    cmbPais.Text,
                    maskTel.Text,
                    maskCedula.Text,
                    cmbDestino.Text,
                    dtpFecha.Value.Date,
                    dtpHora.Value.TimeOfDay,
                    "Administrador Internacional"



            );
        

            if (CalcularEstado(nuevoTour.FechaHora, nuevoTour.Duracion.Days) == "Vigente")
            {
                if (!TourValidador.PuedeCrearNuevoTour(nuevoTour.FechaHora, nuevoTour.Destino, TipoTour.Internacional, nuevoTour.Pais))
                {
                    MessageBox.Show("Ya se alcanzó el máximo de tours permitidos con esa combinación.");
                    return;
                }
                else
                {
                    TourRepositorio.Tours.Add(nuevoTour);
                    PersistenciaLocal.Guardar();
                    MessageBox.Show("¡Registro exitoso!");
                    DialogResult = DialogResult.OK;
                    if (DialogResult == DialogResult.OK)
                    {
                        PersistenciaLocal.Guardar(); // actualiza el archivo JSON
                    }
                    Close();

                }
            }
            else
            {
                MessageBox.Show("No se puede crear un tour con una fecha/hora que ya ha pasado o no es vigente.");
                return;
            }
            




        }


        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (precios.ContainsKey(cmbDestino.Text))
            {
                precio = precios[cmbDestino.Text];
                itbis = precio * 0.18m;
                lblPrecioA.Text = $"RD${itbis + precio:N2} ITBIS Incluido";
            }
            
        }

        private void groupCrear_Enter(object sender, EventArgs e)
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
                e.Handled = true; 
            }

            if (!e.KeyChar.Equals((char)Keys.Back) && !e.KeyChar.Equals((char)Keys.Delete))
            {
                if (txtNombreTour.Text.Length >= 50)
                {
                    e.Handled = true; 
                }
            }
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            //{
            //    e.Handled = true; // Bloquear caracteres no permitidos
            //}
        }

        private void cmbDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquear caracteres no permitidos
            }

            if (!e.KeyChar.Equals((char)Keys.Back) && !e.KeyChar.Equals((char)Keys.Delete))
            {
               
                if (txtNombreTour.Text.Length >= 50)
                {
                    e.Handled = true; // Bloquear si ya tiene 50 caracteres
                }
            }
        }

        private void dtpHora_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}