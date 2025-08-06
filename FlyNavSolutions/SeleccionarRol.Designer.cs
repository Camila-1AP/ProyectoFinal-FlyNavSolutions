namespace FlyNavSolutions
{
    partial class SeleccionarRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarRol));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.publico = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.administrador = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.userAdmin = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.passAdmin = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconMood = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.publico);
            this.panel1.Location = new System.Drawing.Point(969, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 357);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // publico
            // 
            this.publico.BackColor = System.Drawing.SystemColors.HotTrack;
            this.publico.FlatAppearance.BorderSize = 0;
            this.publico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publico.ForeColor = System.Drawing.Color.Ivory;
            this.publico.Location = new System.Drawing.Point(28, 302);
            this.publico.Name = "publico";
            this.publico.Size = new System.Drawing.Size(244, 41);
            this.publico.TabIndex = 16;
            this.publico.Text = "Público";
            this.publico.UseVisualStyleBackColor = false;
            this.publico.Click += new System.EventHandler(this.publico_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.administrador);
            this.panel2.Location = new System.Drawing.Point(1313, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 357);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // administrador
            // 
            this.administrador.BackColor = System.Drawing.SystemColors.HotTrack;
            this.administrador.FlatAppearance.BorderSize = 0;
            this.administrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrador.ForeColor = System.Drawing.Color.Ivory;
            this.administrador.Location = new System.Drawing.Point(48, 302);
            this.administrador.Name = "administrador";
            this.administrador.Size = new System.Drawing.Size(212, 41);
            this.administrador.TabIndex = 17;
            this.administrador.Text = "Administrador";
            this.administrador.UseVisualStyleBackColor = false;
            this.administrador.Click += new System.EventHandler(this.administrador_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAdmin.Controls.Add(this.labelError);
            this.panelAdmin.Controls.Add(this.userAdmin);
            this.panelAdmin.Controls.Add(this.panel3);
            this.panelAdmin.Controls.Add(this.pictureBox4);
            this.panelAdmin.Controls.Add(this.pictureBox3);
            this.panelAdmin.Controls.Add(this.btnEnter);
            this.panelAdmin.Controls.Add(this.passAdmin);
            this.panelAdmin.Controls.Add(this.panel4);
            this.panelAdmin.Location = new System.Drawing.Point(1412, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(516, 775);
            this.panelAdmin.TabIndex = 7;
            this.panelAdmin.Visible = false;
            this.panelAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdmin_Paint);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Crimson;
            this.labelError.Location = new System.Drawing.Point(105, 551);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(259, 18);
            this.labelError.TabIndex = 20;
            this.labelError.Text = "Usuario o Contraseña incorrectos 🚫.";
            this.labelError.Visible = false;
            // 
            // userAdmin
            // 
            this.userAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAdmin.Location = new System.Drawing.Point(154, 282);
            this.userAdmin.Name = "userAdmin";
            this.userAdmin.Size = new System.Drawing.Size(305, 21);
            this.userAdmin.TabIndex = 8;
            this.userAdmin.TextChanged += new System.EventHandler(this.userAdmin_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(149, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 22);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(90, 355);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(90, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.Ivory;
            this.btnEnter.Location = new System.Drawing.Point(90, 607);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(375, 45);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Acceder";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // passAdmin
            // 
            this.passAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passAdmin.Location = new System.Drawing.Point(154, 368);
            this.passAdmin.Mask = "999999";
            this.passAdmin.Name = "passAdmin";
            this.passAdmin.PasswordChar = '◉';
            this.passAdmin.PromptChar = '•';
            this.passAdmin.Size = new System.Drawing.Size(305, 21);
            this.passAdmin.TabIndex = 9;
            this.passAdmin.UseSystemPasswordChar = true;
            this.passAdmin.ValidatingType = typeof(int);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Location = new System.Drawing.Point(149, 368);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 22);
            this.panel4.TabIndex = 15;
            // 
            // iconMood
            // 
            this.iconMood.AccessibleDescription = "Cambiar a modo ocuro";
            this.iconMood.FlatAppearance.BorderSize = 0;
            this.iconMood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMood.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.iconMood.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconMood.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconMood.IconSize = 90;
            this.iconMood.Location = new System.Drawing.Point(27, 23);
            this.iconMood.Name = "iconMood";
            this.iconMood.Size = new System.Drawing.Size(99, 69);
            this.iconMood.TabIndex = 19;
            this.iconMood.UseVisualStyleBackColor = true;
            this.iconMood.Click += new System.EventHandler(this.iconMood_Click);
            this.iconMood.MouseEnter += new System.EventHandler(this.iconMood_MouseEnter);
            // 
            // SeleccionarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 767);
            this.Controls.Add(this.iconMood);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeleccionarRol";
            this.Text = "Seleccionar Rol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SeleccionarRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.TextBox userAdmin;
        private System.Windows.Forms.MaskedTextBox passAdmin;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button publico;
        private System.Windows.Forms.Button administrador;
        private FontAwesome.Sharp.IconButton iconMood;
        private System.Windows.Forms.Label labelError;
    }
}