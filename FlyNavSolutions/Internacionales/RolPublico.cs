using FlyNavSolutions.Tour;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;


namespace FlyNavSolutions
{
    public partial class RolPublico : Form
    {
      
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private int borderSize = 2;
        public RolPublico()
        {
            InitializeComponent();
          

            this.Padding = new Padding(borderSize);
            this.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new System.Drawing.Size(7, 60);
            panelMenuPublico.Controls.Add(leftBorderBtn);
            
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

        private void RolPublico_Load(object sender, EventArgs e)
        {
            panelMenuPublico.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
        
            iconButtonBar.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);

            iconButtonAgendar1.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            iconButtonExcel.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            iconButtonSalir.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
        }

        private void btnAgendarPublico_Click(object sender, EventArgs e)
        {
          
        }

        private void iconButtonAgendar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButtonExportar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            UcAgendar csv = new UcAgendar();
            csv.ExportarCSV();

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

        private void panelBarPublico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonBar_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
          
            if (this.panelMenuPublico.Width > 200)
            {
                panelMenuPublico.Width = 150;
                pictureBox1.Visible = false;
                iconButtonBar.Dock = DockStyle.Top;
               
               
                
                foreach(Button menuButton in panelMenuPublico.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0,10,0,0);
                    iconButtonBar.ImageAlign = ContentAlignment.MiddleCenter;


                }
            }
            else
            {
                panelMenuPublico.Width = 444;
                pictureBox1.Visible= true;
                iconButtonBar.Dock = DockStyle.Top;

              


                foreach (Button menuButton in panelMenuPublico.Controls.OfType<Button>())
                {
                    menuButton.Text = "   "+ menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10,0,20,0);
                    iconButtonBar.ImageAlign = ContentAlignment.MiddleLeft;



                }

            }
        }

        private void panelMenuPublico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonAgendar1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);


            panelContenido.Controls.Clear(); 

            UcAgendar control = new UcAgendar(); 
            control.Dock = DockStyle.Fill;  
            panelContenido.Controls.Add(control); 
        }
        public void ExportarExcel()
        {
            

            System.Windows.Forms.MessageBox.Show($"Cantidad de registros: {TourRepositorio.Tours.Count}");

          
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
            hoja.Cell(1, 6).Value = "Destino";
            hoja.Cell(1, 7).Value = "Fecha y Hora";
            hoja.Cell(1, 8).Value = "Precio";
            hoja.Cell(1, 9).Value = "ITBIS";
            hoja.Cell(1, 10).Value = "Duración";
            hoja.Cell(1, 11).Value = "Estado";

            int fila = 2;
            foreach (TourInfo tour in TourRepositorio.Tours)
            {
                hoja.Cell(fila, 1).Value = tour.Id;
                hoja.Cell(fila, 2).Value = tour.Nombre;
                hoja.Cell(fila, 3).Value = tour.Pais;
                hoja.Cell(fila, 4).Value = tour.Telefono;
                hoja.Cell(fila, 5).Value = tour.Cedula;
                hoja.Cell(fila, 6).Value = tour.Destino;
                hoja.Cell(fila, 7).Value = tour.FechaHora.ToString("f"); //fechaHora.ToString("f"))
                hoja.Cell(fila, 8).Value = tour.Precio;
                hoja.Cell(fila, 9).Value = tour.ITBIS;
                hoja.Cell(fila, 10).Value = ($"{tour.Duracion.Days} días y {tour.Duracion.Hours} horas");
                hoja.Cell(fila, 11).Value = tour.Estado;
                fila++;
            }

            workbook.SaveAs(ruta);

            System.Windows.Forms.MessageBox.Show($"Exportación Excel completada:\n{ruta}", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ExportarCSV()

        {


            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string carpeta = Path.Combine(escritorio, "TourCSV");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            string ruta = Path.Combine(carpeta, "Tour_" + DateTime.Now.Ticks + ".csv");

            using (StreamWriter sw = new StreamWriter(ruta, false, Encoding.UTF8))
            {
                sw.WriteLine("ID, Nombre, País, Destino, Teléfono, Cédula, Fecha/Hora, Precio, ITBIS, Duración, Estado");

                foreach (TourInfo tour in TourRepositorio.Tours)
                {
                    sw.WriteLine($"{tour.Id}, {tour.Nombre}, {tour.Pais}, {tour.Destino}, {tour.Telefono}, {tour.Cedula}, {tour.FechaHora:f}, " +
                                 $"{tour.Precio}, {tour.ITBIS}, {$"{tour.Duracion.Days} D y {tour.Duracion.Hours} H"}, {tour.Estado}");
                }
            }

            System.Windows.Forms.MessageBox.Show("Exportación CSV completada:\n" + ruta, "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void iconButtonExportar1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            if (TourRepositorio.Tours.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No hay tours agendados para exportar.");
                return;
            }

            ExportarExcel();


        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonCSV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            if (TourRepositorio.Tours.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No hay tours agendados para exportar.");
                return;
            }

            ExportarCSV();

        }
    }
}
