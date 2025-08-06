namespace FlyNavSolutions
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeTool = new System.Windows.Forms.ToolStripMenuItem();
            this.internacionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAI = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeTool,
            this.internacionalesToolStripMenuItem,
            this.nacionelesToolStripMenuItem,
            this.gestionarToursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1811, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeTool
            // 
            this.homeTool.BackColor = System.Drawing.Color.MidnightBlue;
            this.homeTool.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTool.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeTool.Name = "homeTool";
            this.homeTool.Size = new System.Drawing.Size(72, 27);
            this.homeTool.Text = "Home";
            this.homeTool.Click += new System.EventHandler(this.homeTool_Click);
            this.homeTool.MouseEnter += new System.EventHandler(this.homeTool_MouseEnter);
            this.homeTool.MouseLeave += new System.EventHandler(this.homeTool_MouseLeave);
            this.homeTool.MouseHover += new System.EventHandler(this.homeTool_MouseHover);
            // 
            // internacionalesToolStripMenuItem
            // 
            this.internacionalesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internacionalesToolStripMenuItem.Name = "internacionalesToolStripMenuItem";
            this.internacionalesToolStripMenuItem.Size = new System.Drawing.Size(144, 27);
            this.internacionalesToolStripMenuItem.Text = "Internacionales";
            this.internacionalesToolStripMenuItem.Click += new System.EventHandler(this.internacionalesToolStripMenuItem_Click);
            this.internacionalesToolStripMenuItem.MouseEnter += new System.EventHandler(this.internacionalesToolStripMenuItem_MouseEnter);
            this.internacionalesToolStripMenuItem.MouseLeave += new System.EventHandler(this.internacionalesToolStripMenuItem_MouseLeave);
            this.internacionalesToolStripMenuItem.MouseHover += new System.EventHandler(this.internacionalesToolStripMenuItem_MouseHover);
            // 
            // nacionelesToolStripMenuItem
            // 
            this.nacionelesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacionelesToolStripMenuItem.Name = "nacionelesToolStripMenuItem";
            this.nacionelesToolStripMenuItem.Size = new System.Drawing.Size(109, 27);
            this.nacionelesToolStripMenuItem.Text = "Nacionales";
            this.nacionelesToolStripMenuItem.Click += new System.EventHandler(this.nacionelesToolStripMenuItem_Click);
            this.nacionelesToolStripMenuItem.MouseEnter += new System.EventHandler(this.nacionelesToolStripMenuItem_MouseEnter);
            this.nacionelesToolStripMenuItem.MouseLeave += new System.EventHandler(this.nacionelesToolStripMenuItem_MouseLeave);
            this.nacionelesToolStripMenuItem.MouseHover += new System.EventHandler(this.nacionelesToolStripMenuItem_MouseHover);
            // 
            // gestionarToursToolStripMenuItem
            // 
            this.gestionarToursToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.gestionarToursToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarToursToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gestionarToursToolStripMenuItem.Name = "gestionarToursToolStripMenuItem";
            this.gestionarToursToolStripMenuItem.Size = new System.Drawing.Size(147, 27);
            this.gestionarToursToolStripMenuItem.Text = "Gestionar Tours";
            this.gestionarToursToolStripMenuItem.Click += new System.EventHandler(this.gestionarToursToolStripMenuItem_Click);
            // 
            // panelAI
            // 
            this.panelAI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAI.Location = new System.Drawing.Point(1200, 34);
            this.panelAI.Name = "panelAI";
            this.panelAI.Size = new System.Drawing.Size(611, 621);
            this.panelAI.TabIndex = 2;
            this.panelAI.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1811, 658);
            this.Controls.Add(this.panelAI);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FlyNav Solutions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeTool;
        private System.Windows.Forms.ToolStripMenuItem internacionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacionelesToolStripMenuItem;
        private System.Windows.Forms.Panel panelAI;
        private System.Windows.Forms.ToolStripMenuItem gestionarToursToolStripMenuItem;
    }
}

