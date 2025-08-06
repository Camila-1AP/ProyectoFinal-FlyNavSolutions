using DocumentFormat.OpenXml.Math;
using FlyNavSolutions.Administrador.Crear;
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

namespace FlyNavSolutions.Administrador.CrearModal
{
    public partial class CrearNacionalcs : Form
    {

        Dictionary<string, decimal> precios = new Dictionary<string, decimal>();
        Dictionary<string, List<string>> destinosPorPais = new Dictionary<string, List<string>>();
        Dictionary<string, TimeSpan> duraciones = new Dictionary<string, TimeSpan>();

        decimal itbis;
        decimal precio;
        public TourInfo TourEditado { get; set; }

        
        public bool ModoEdicion { get; set; } = false;
        public event Action AlCerrarConCambios;


        Crear.Crear validarFecha = new Crear.Crear();
        public CrearNacionalcs()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        
            this.StartPosition = FormStartPosition.CenterParent; 
        }


        private void CrearNacionalcs_Load(object sender, EventArgs e)
        {

            Crear.Crear cerrarModalCrear = new Crear.Crear();
          

            dtpHora.ValueChanged += (s, e1) => validarFecha.ValidarHora(dtpHora);
          

            CatalogoDestinos.CargarDestinosNacionales(cmbDestino);
           


            if (ModoEdicion && TourEditado != null)
            {
                
             
                txtNombreTour.Text = TourEditado.Nombre;
                
                cmbDestino.Text = TourEditado.Destino;
                maskTel.Text = TourEditado.Telefono;
                maskCedula.Text = TourEditado.Cedula;
                dtpFecha.Value = TourEditado.FechaHora.Date;
                dtpHora.Value = DateTime.Today + TourEditado.FechaHora.TimeOfDay;
              
               
                iconButton6.Text = "Guardar cambios";
            }
            



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
       string.IsNullOrEmpty(cmbDestino.Text) || string.IsNullOrEmpty(maskTel.Text) || string.IsNullOrEmpty(maskCedula.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            
           
            Crear.Crear crear = new Crear.Crear();
          

            if (string.IsNullOrEmpty(txtNombreTour.Text) || string.IsNullOrEmpty(cmbDestino.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (ModoEdicion && TourEditado != null)
            {
                TourEditado.Nombre = txtNombreTour.Text.Trim();
                TourEditado.Destino = cmbDestino.Text;
                TourEditado.Telefono = maskTel.Text;
                TourEditado.Cedula = maskCedula.Text;
                TourEditado.FechaHora = dtpFecha.Value.Date + dtpHora.Value.TimeOfDay;
               
                TourEditado.Precio = CatalogoDestinos.ObtenerPreciosNacional(TourEditado.Destino);
                TourEditado.Duracion = CatalogoDestinos.ObtenerDuracionNacional(TourEditado.Destino);

               
                crear.CalcularEstado(TourEditado.FechaHora, TourEditado.Duracion.Days);

              

                if (!TourEditado.RolOrigen.StartsWith("E-"))
                    TourEditado.RolOrigen = "E- " + TourEditado.RolOrigen;


                AlCerrarConCambios?.Invoke();
                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("Tour actualizado correctamente.");
                return;
            }

            var nuevoTour = ConstructorDeTours.CrearTourNacional(
                txtNombreTour.Text,
                cmbDestino.Text,
                maskTel.Text,
                maskCedula.Text,
                dtpFecha.Value.Date,
                dtpHora.Value.TimeOfDay,
                "Administrador Nacional"
                 
            );

           

            if (crear.CalcularEstado(nuevoTour.FechaHora, nuevoTour.Duracion.Days) == "Vigente")
            {
                if (!TourValidador.PuedeCrearNuevoTour(nuevoTour.FechaHora, nuevoTour.Destino, TipoTour.Nacional, null))
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
                MessageBox.Show("No se puede crear un tour con una fecha/hora pasada o inválida.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (precios.ContainsKey(cmbDestino.Text))
            {
                precio = precios[cmbDestino.Text];
                itbis = precio * 0.18m;
                lblPrecioA2.Text = $"RD${itbis + precio:N2} ITBIS Incluido";
            }
        }
    }
}
