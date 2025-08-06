
using CefSharp;
using CefSharp.Handler;
using CefSharp.WinForms;
using FlyNavSolutions.Administrador;
using FlyNavSolutions.CustomColorTable;
using FlyNavSolutions.Handler;
using FlyNavSolutions.Nacionales;
using FlyNavSolutions.Tour;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyNavSolutions
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser browser;

        

        public Form1()
        {
            InitializeComponent();
           

            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            CatalogoDestinos.Inicializar();

            browser = new ChromiumWebBrowser("https://www.perplexity.ai"); 
           



           browser.Dock = DockStyle.Fill;  

          
            panelAI.Controls.Add(browser); 

            menuStrip1.BackColor = Color.MidnightBlue;
            homeTool.ForeColor = Color.White;
            homeTool.BackColor = Color.MidnightBlue;


            internacionalesToolStripMenuItem.ForeColor = Color.White;

            internacionalesToolStripMenuItem.BackColor = Color.MidnightBlue;

            nacionelesToolStripMenuItem.BackColor = Color.MidnightBlue;
            nacionelesToolStripMenuItem.ForeColor = Color.White;
            menuStrip1.Renderer = new MyRenderer();


    

        }


        public void ConfigurarMenuRol(string rol)
        {
            
            homeTool.Visible = true;
            internacionalesToolStripMenuItem.Visible = false;
            nacionelesToolStripMenuItem.Visible = false;
            gestionarToursToolStripMenuItem.Visible = false;
          
           
            if (rol == "Publico")
            {
                    
                internacionalesToolStripMenuItem.Visible = true;
                nacionelesToolStripMenuItem.Visible = true;
            }
            else if (rol == "Admin")
            {
               
        
                internacionalesToolStripMenuItem.Visible = false;
                nacionelesToolStripMenuItem.Visible = false;
                gestionarToursToolStripMenuItem.Visible = true;
            }
            else
            {
               
                homeTool.Visible = false;
                internacionalesToolStripMenuItem.Visible = false;
                nacionelesToolStripMenuItem.Visible = false;
                gestionarToursToolStripMenuItem.Visible = false;
            }
        }
        private void EstilizarMenu(ToolStripItemCollection items)
        {
          
        }
        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeTool_MouseHover(object sender, EventArgs e)
        {
            
            


            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.BackColor = Color.BlueViolet; 
                item.ForeColor = Color.White;   
            }

        }

        private void homeTool_MouseLeave(object sender, EventArgs e)
        {
           

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.BackColor = Color.MidnightBlue; 
                item.ForeColor = Color.White; 
            }


        }

        private void internacionalesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
           

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.BackColor = Color.BlueViolet; 
                item.ForeColor = Color.White; 
            }

        }

        private void internacionalesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
           

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.BackColor = Color.MidnightBlue; 
                item.ForeColor = Color.White; 
            }
        }

        private void nacionelesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.BackColor = Color.BlueViolet; 
                item.ForeColor = Color.White; 
            }
        }

        private void nacionelesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.BackColor = Color.MidnightBlue; 
                item.ForeColor = Color.White; 
            }
        }

        private void homeTool_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.BackColor = Color.BlueViolet; 
                item.ForeColor = Color.White; 
            }
        }

        private void internacionalesToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.BackColor = Color.BlueViolet; 
                item.ForeColor = Color.White; 
            }
        }

        private void nacionelesToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.BackColor = Color.BlueViolet; 
                item.ForeColor = Color.White; 
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void internacionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panelAI.Visible = false;

            

            RolPublico rolPInternacional = new RolPublico
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized 
            };

            rolPInternacional.Show();
            rolPInternacional.WindowState = FormWindowState.Maximized;

        }

        private void homeTool_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
            {
                if (frm != this)
                    frm.Hide(); 
            }
            panelAI.Visible = true; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Solo descomentar estas líneas si quiere reiniciar los datos de la aplicación | Se esta utilizando para pruebas y enviar el proyecto limpio
          

            //if (DialogResult.Yes == MessageBox.Show("¿Desea reiniciar los datos de la aplicación?", "Reiniciar Datos",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //{
            //    MessageBox.Show("Reiniciando datos...", "Datos Reiniciados");
            //    PreparadorEntrega.ResetearDatos();
            //    return;
            //}
            //else
            //{
            //    // No hacer nada, los datos no se reinician
            //}




        }

        private void gestionarToursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAI.Visible = false;
            RolAdmin rolAdmin = new RolAdmin
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
               
            };
            rolAdmin.Show();
            rolAdmin.WindowState = FormWindowState.Maximized;
        }

        private void nacionelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAI.Visible = false;
          
            RolPublicoNacional frmNacional = new RolPublicoNacional
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized 
            };
            frmNacional.Show();
            frmNacional.WindowState = FormWindowState.Maximized;

        }
    }
}
