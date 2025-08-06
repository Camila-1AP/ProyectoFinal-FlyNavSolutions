using FlyNavSolutions.Tour;
using FontAwesome.Sharp;
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

namespace FlyNavSolutions.Nacionales
{
    public partial class RolPublicoNacional : Form
    {
        
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private int borderSize = 2;
        public RolPublicoNacional()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);


            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenuPublicoNacional.Controls.Add(leftBorderBtn);
        }

        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(255, 147, 152, 173);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(255, 159, 150, 212);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(255, 184, 224, 153);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(255, 237, 145, 153);
           

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

              
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
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

        private void RolPublicoNacional_Load(object sender, EventArgs e)
        {
            panelMenuPublicoNacional.BackColor = Color.FromArgb(29, 38, 77);
        }

        private void iconButtonBar_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {

            if (this.panelMenuPublicoNacional.Width > 200)
            {
                panelMenuPublicoNacional.Width = 150;
                pictureBox1.Visible = false;
                iconButtonBar.Dock = DockStyle.Top;
              


                foreach (Button menuButton in panelMenuPublicoNacional.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0, 10, 0, 0);
                    iconButtonBar.ImageAlign = ContentAlignment.MiddleCenter;


                }
            }
            else
            {
                panelMenuPublicoNacional.Width = 444;
                pictureBox1.Visible = true;
                iconButtonBar.Dock = DockStyle.Top;

              

                foreach (Button menuButton in panelMenuPublicoNacional.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 20, 0);
                    iconButtonBar.ImageAlign = ContentAlignment.MiddleLeft;



                }

            }
        }
        public void ExportarCSV()

        {


    
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string carpeta = Path.Combine(escritorio, "TourCSV");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            string ruta = Path.Combine(carpeta, "Tour_" + DateTime.Now.Ticks + ".csv");

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("ID,Nombre,Pais,Destino,FechaHora,Precio,ITBIS,Duracion,Estado");

                foreach (TourInfo tour in TourRepositorio.Tours)
                {
                    sw.WriteLine($"{tour.Id},{tour.Nombre},{tour.Pais},{tour.Destino},{tour.FechaHora:f}," +
                                 $"{tour.Precio},{tour.ITBIS},{tour.Duracion.TotalHours} horas,{tour.Estado}");
                }
            }

            MessageBox.Show("Exportación CSV completada:\n" + ruta, "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButtonAgendar1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

            panelContenidoNacional.Controls.Clear(); 

            UcAgendarNacional control = new UcAgendarNacional();

            control.Dock = DockStyle.Fill;       
            panelContenidoNacional.Controls.Add(control); 



        }

        private void iconButtonExcel_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void iconButtonCSV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            if (TourRepositorio.Tours.Count == 0)
            {
                MessageBox.Show("No hay tours agendados para exportar.");
                return;
            }

            ExportarCSV();

        }

        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            ActivateButton(sender, RGBColors.color4);
            DialogResult confirmacion = MessageBox.Show(
            "¿Estás seguro que deseas salir?",
            "Salir del sistema",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
                Application.Exit(); 

        }

        private void panelMenuPublicoNacional_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
