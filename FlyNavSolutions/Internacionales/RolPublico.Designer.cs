namespace FlyNavSolutions
{
    partial class RolPublico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolPublico));
            this.panelMenuPublico = new System.Windows.Forms.Panel();
            this.iconButtonCSV = new FontAwesome.Sharp.IconButton();
            this.iconButtonExcel = new FontAwesome.Sharp.IconButton();
            this.iconButtonAgendar1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonSalir = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonBar = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBarPublico = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelMenuPublico.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuPublico
            // 
            this.panelMenuPublico.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenuPublico.Controls.Add(this.iconButtonCSV);
            this.panelMenuPublico.Controls.Add(this.iconButtonExcel);
            this.panelMenuPublico.Controls.Add(this.iconButtonAgendar1);
            this.panelMenuPublico.Controls.Add(this.iconButtonSalir);
            this.panelMenuPublico.Controls.Add(this.panel1);
            this.panelMenuPublico.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuPublico.Location = new System.Drawing.Point(0, 0);
            this.panelMenuPublico.Name = "panelMenuPublico";
            this.panelMenuPublico.Size = new System.Drawing.Size(528, 771);
            this.panelMenuPublico.TabIndex = 0;
            this.panelMenuPublico.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuPublico_Paint);
            // 
            // iconButtonCSV
            // 
            this.iconButtonCSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCSV.FlatAppearance.BorderSize = 0;
            this.iconButtonCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCSV.ForeColor = System.Drawing.Color.White;
            this.iconButtonCSV.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.iconButtonCSV.IconColor = System.Drawing.Color.White;
            this.iconButtonCSV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCSV.IconSize = 50;
            this.iconButtonCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCSV.Location = new System.Drawing.Point(0, 394);
            this.iconButtonCSV.Name = "iconButtonCSV";
            this.iconButtonCSV.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonCSV.Size = new System.Drawing.Size(528, 74);
            this.iconButtonCSV.TabIndex = 10;
            this.iconButtonCSV.Tag = "Exportar .CSV";
            this.iconButtonCSV.Text = "Exportar .CSV";
            this.iconButtonCSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCSV.UseVisualStyleBackColor = true;
            this.iconButtonCSV.Visible = false;
            this.iconButtonCSV.Click += new System.EventHandler(this.iconButtonCSV_Click);
            // 
            // iconButtonExcel
            // 
            this.iconButtonExcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonExcel.FlatAppearance.BorderSize = 0;
            this.iconButtonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonExcel.ForeColor = System.Drawing.Color.White;
            this.iconButtonExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconButtonExcel.IconColor = System.Drawing.Color.White;
            this.iconButtonExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExcel.IconSize = 50;
            this.iconButtonExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExcel.Location = new System.Drawing.Point(0, 320);
            this.iconButtonExcel.Name = "iconButtonExcel";
            this.iconButtonExcel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonExcel.Size = new System.Drawing.Size(528, 74);
            this.iconButtonExcel.TabIndex = 9;
            this.iconButtonExcel.Tag = "Exportar Excel";
            this.iconButtonExcel.Text = "Exportar Excel";
            this.iconButtonExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExcel.UseVisualStyleBackColor = true;
            this.iconButtonExcel.Visible = false;
            this.iconButtonExcel.Click += new System.EventHandler(this.iconButtonExportar1_Click);
            // 
            // iconButtonAgendar1
            // 
            this.iconButtonAgendar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAgendar1.FlatAppearance.BorderSize = 0;
            this.iconButtonAgendar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAgendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAgendar1.ForeColor = System.Drawing.Color.White;
            this.iconButtonAgendar1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonAgendar1.IconColor = System.Drawing.Color.White;
            this.iconButtonAgendar1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAgendar1.IconSize = 50;
            this.iconButtonAgendar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAgendar1.Location = new System.Drawing.Point(0, 246);
            this.iconButtonAgendar1.Name = "iconButtonAgendar1";
            this.iconButtonAgendar1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonAgendar1.Size = new System.Drawing.Size(528, 74);
            this.iconButtonAgendar1.TabIndex = 8;
            this.iconButtonAgendar1.Tag = "Agendar";
            this.iconButtonAgendar1.Text = "Agendar";
            this.iconButtonAgendar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAgendar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAgendar1.UseVisualStyleBackColor = true;
            this.iconButtonAgendar1.Click += new System.EventHandler(this.iconButtonAgendar1_Click);
            // 
            // iconButtonSalir
            // 
            this.iconButtonSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonSalir.FlatAppearance.BorderSize = 0;
            this.iconButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSalir.ForeColor = System.Drawing.Color.White;
            this.iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconButtonSalir.IconColor = System.Drawing.Color.White;
            this.iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSalir.IconSize = 50;
            this.iconButtonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSalir.Location = new System.Drawing.Point(0, 697);
            this.iconButtonSalir.Name = "iconButtonSalir";
            this.iconButtonSalir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSalir.Size = new System.Drawing.Size(528, 74);
            this.iconButtonSalir.TabIndex = 6;
            this.iconButtonSalir.Tag = "Salir";
            this.iconButtonSalir.Text = "Salir";
            this.iconButtonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSalir.UseVisualStyleBackColor = true;
            this.iconButtonSalir.Click += new System.EventHandler(this.iconButtonSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonBar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 246);
            this.panel1.TabIndex = 7;
            // 
            // iconButtonBar
            // 
            this.iconButtonBar.FlatAppearance.BorderSize = 0;
            this.iconButtonBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonBar.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.iconButtonBar.IconColor = System.Drawing.Color.White;
            this.iconButtonBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBar.IconSize = 42;
            this.iconButtonBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBar.Location = new System.Drawing.Point(0, 21);
            this.iconButtonBar.Name = "iconButtonBar";
            this.iconButtonBar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.iconButtonBar.Size = new System.Drawing.Size(80, 81);
            this.iconButtonBar.TabIndex = 0;
            this.iconButtonBar.Tag = "";
            this.iconButtonBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBar.UseVisualStyleBackColor = true;
            this.iconButtonBar.Click += new System.EventHandler(this.iconButtonBar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelBarPublico
            // 
            this.panelBarPublico.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBarPublico.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarPublico.Location = new System.Drawing.Point(528, 0);
            this.panelBarPublico.Name = "panelBarPublico";
            this.panelBarPublico.Size = new System.Drawing.Size(1283, 60);
            this.panelBarPublico.TabIndex = 1;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.ForeColor = System.Drawing.Color.Black;
            this.panelContenido.Location = new System.Drawing.Point(528, 60);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1283, 711);
            this.panelContenido.TabIndex = 2;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // RolPublico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 771);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBarPublico);
            this.Controls.Add(this.panelMenuPublico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RolPublico";
            this.Text = "Rol Público";
            this.Load += new System.EventHandler(this.RolPublico_Load);
            this.panelMenuPublico.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuPublico;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private FontAwesome.Sharp.IconButton iconButtonBar;
        private System.Windows.Forms.Panel panelBarPublico;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonExcel;
        private FontAwesome.Sharp.IconButton iconButtonAgendar1;
        private FontAwesome.Sharp.IconButton iconButtonCSV;
    }
}