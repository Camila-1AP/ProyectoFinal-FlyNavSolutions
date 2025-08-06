using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace FlyNavSolutions
{
    public partial class SeleccionarRol : Form
    {
        public SeleccionarRol()
        {
            InitializeComponent();
         

        }

        private void SeleccionarRol_Load(object sender, EventArgs e)
        {
            publico.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            administrador.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            btnEnter.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            panel3.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);
            panel4.BackColor = System.Drawing.Color.FromArgb(255, 23, 43, 104);

            iconMood.IconColor = System.Drawing.Color.FromArgb(73, 75, 111);


         
            BorderRadius.borderRadius.AplicarRadius(btnEnter, 20);
            BorderRadius.borderRadius.AplicarRadius(panel1, 20);
            BorderRadius.borderRadius.AplicarRadius(panel2, 20);
            BorderRadius.borderRadius.AplicarRadius(publico, 20);
            BorderRadius.borderRadius.AplicarRadius(administrador, 20);


        }

        private void lblPublico_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frmStrip = new Form1();
            frmStrip.ConfigurarMenuRol("Publico");
           

            frmStrip.Show();
            this.Hide();



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            userAdmin.Visible = true;
            passAdmin.Visible = true;
            btnEnter.Visible = true;


            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string user = userAdmin.Text;
            string pass = passAdmin.Text;

            if (user.Equals("admin", StringComparison.OrdinalIgnoreCase) && pass == "123456")
            {
               
                
                Form1 frmStrip = new Form1();
                frmStrip.ConfigurarMenuRol("Admin");
                frmStrip.Show();
                this.Hide();

            }
            else
            {
               
                labelError.Visible = true;
                return;
            }
        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void iconMood_Click(object sender, EventArgs e)
        {
            if (iconMood.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
                iconMood.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
                iconMood.IconColor = Color.White;
                this.BackColor = Color.FromArgb(24,28,63);
                panel1.BackColor = Color.FromArgb(73, 75, 111);
                panel2.BackColor = Color.FromArgb(73, 75, 111);

                panelAdmin.BackColor = Color.FromArgb(73, 75, 111);

                labelError.ForeColor = Color.White;

                publico.BackColor = Color.FromArgb(42, 45, 111);
                administrador.BackColor = Color.FromArgb(42, 45, 111);
                btnEnter.BackColor = Color.FromArgb(42, 45, 111);
                panel3.BackColor = Color.FromArgb(42, 45, 111);
                panel4.BackColor = Color.FromArgb(42, 45, 111);

            }
            else
            {
                iconMood.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
                iconMood.IconColor = Color.FromArgb(73, 75, 111);
                
                this.BackColor = Color.WhiteSmoke;
                panel1.BackColor = Color.FromArgb(220,220,220);
                panel2.BackColor = Color.FromArgb(220, 220, 220);

                panelAdmin.BackColor = Color.FromArgb(220, 220, 220);

                labelError.ForeColor = Color.Red;
            }
            
        }

        private void iconMood_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
            tt.SetToolTip(iconMood, iconMood.IconChar == FontAwesome.Sharp.IconChar.ToggleOff
               ? "Cambiar a modo oscuro."
               : "Cambiar a modo claro.");
            
           

          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
   
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void userAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void publico_Click(object sender, EventArgs e)
        {
            Form1 frmStrip = new Form1();
            frmStrip.ConfigurarMenuRol("Publico");

            frmStrip.Show();
            this.Hide();
        }

        private void administrador_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            userAdmin.Visible = true;
            passAdmin.Visible = true;
            btnEnter.Visible = true;
        }
    }
}
