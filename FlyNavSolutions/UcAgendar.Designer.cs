namespace FlyNavSolutions
{
    partial class UcAgendar
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAgendar));
            this.txtNombreTour = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panelAgendandoPublico = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.panelQR = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.maskCedula = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maskTel = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBoxToggle = new FontAwesome.Sharp.IconPictureBox();
            this.picGaleria = new System.Windows.Forms.PictureBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelAgendandoPublico.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCampos.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelBorder.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGaleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreTour
            // 
            this.txtNombreTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTour.Location = new System.Drawing.Point(14, 0);
            this.txtNombreTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreTour.Name = "txtNombreTour";
            this.txtNombreTour.Size = new System.Drawing.Size(517, 23);
            this.txtNombreTour.TabIndex = 0;
            this.txtNombreTour.TextChanged += new System.EventHandler(this.txtNombreTour_TextChanged);
            this.txtNombreTour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreTour_KeyPress);
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(13, 0);
            this.cmbPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(519, 33);
            this.cmbPais.TabIndex = 1;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged_1);
            this.cmbPais.Click += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            this.cmbPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPais_KeyPress);
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(13, 0);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(519, 33);
            this.cmbDestino.TabIndex = 2;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged_1);
            this.cmbDestino.Click += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            this.cmbDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDestino_KeyPress);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(13, 1);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(519, 30);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dtpHora
            // 
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(13, 0);
            this.dtpHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(519, 30);
            this.dtpHora.TabIndex = 4;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(588, 718);
            this.btnAgendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(272, 48);
            this.btnAgendar.TabIndex = 5;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEstado.Location = new System.Drawing.Point(65, 583);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 29);
            this.lblEstado.TabIndex = 11;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrecio.Location = new System.Drawing.Point(42, 295);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 20);
            this.lblPrecio.TabIndex = 12;
            // 
            // panelAgendandoPublico
            // 
            this.panelAgendandoPublico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAgendandoPublico.Controls.Add(this.panelInfo);
            this.panelAgendandoPublico.Controls.Add(this.panelQR);
            this.panelAgendandoPublico.Controls.Add(this.panelCampos);
            this.panelAgendandoPublico.Controls.Add(this.iconButton5);
            this.panelAgendandoPublico.Controls.Add(this.iconButton4);
            this.panelAgendandoPublico.Controls.Add(this.iconButton6);
            this.panelAgendandoPublico.Controls.Add(this.iconButton3);
            this.panelAgendandoPublico.Controls.Add(this.iconButton2);
            this.panelAgendandoPublico.Controls.Add(this.iconButton9);
            this.panelAgendandoPublico.Controls.Add(this.iconButton8);
            this.panelAgendandoPublico.Controls.Add(this.btnAgendar);
            this.panelAgendandoPublico.Controls.Add(this.iconButton7);
            this.panelAgendandoPublico.Controls.Add(this.iconButton1);
            this.panelAgendandoPublico.Controls.Add(this.panel1);
            this.panelAgendandoPublico.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAgendandoPublico.Location = new System.Drawing.Point(0, 0);
            this.panelAgendandoPublico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAgendandoPublico.Name = "panelAgendandoPublico";
            this.panelAgendandoPublico.Size = new System.Drawing.Size(1037, 976);
            this.panelAgendandoPublico.TabIndex = 13;
            this.panelAgendandoPublico.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAgendandoPublico_Paint);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelInfo.Controls.Add(this.richTextBoxInfo);
            this.panelInfo.Location = new System.Drawing.Point(283, 93);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(642, 465);
            this.panelInfo.TabIndex = 0;
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.richTextBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInfo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBoxInfo.Location = new System.Drawing.Point(24, 22);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(595, 418);
            this.richTextBoxInfo.TabIndex = 0;
            this.richTextBoxInfo.Text = "";
            // 
            // panelQR
            // 
            this.panelQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelQR.Controls.Add(this.pictureBox1);
            this.panelQR.Location = new System.Drawing.Point(370, 702);
            this.panelQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelQR.Name = "panelQR";
            this.panelQR.Size = new System.Drawing.Size(293, 270);
            this.panelQR.TabIndex = 16;
            this.panelQR.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelCampos
            // 
            this.panelCampos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCampos.Controls.Add(this.panel7);
            this.panelCampos.Controls.Add(this.panel3);
            this.panelCampos.Controls.Add(this.lblPrecio);
            this.panelCampos.Controls.Add(this.lblEstado);
            this.panelCampos.Controls.Add(this.panel2);
            this.panelCampos.Controls.Add(this.panel4);
            this.panelCampos.Controls.Add(this.panel5);
            this.panelCampos.Controls.Add(this.panelBorder);
            this.panelCampos.Controls.Add(this.panel6);
            this.panelCampos.Location = new System.Drawing.Point(383, 64);
            this.panelCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(655, 729);
            this.panelCampos.TabIndex = 12;
            this.panelCampos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCampos_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.maskCedula);
            this.panel7.Location = new System.Drawing.Point(33, 602);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(531, 32);
            this.panel7.TabIndex = 7;
            // 
            // maskCedula
            // 
            this.maskCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCedula.Location = new System.Drawing.Point(13, 0);
            this.maskCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskCedula.Mask = "00000000000";
            this.maskCedula.Name = "maskCedula";
            this.maskCedula.Size = new System.Drawing.Size(519, 30);
            this.maskCedula.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.maskTel);
            this.panel3.Location = new System.Drawing.Point(34, 527);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 32);
            this.panel3.TabIndex = 7;
            // 
            // maskTel
            // 
            this.maskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTel.Location = new System.Drawing.Point(13, 0);
            this.maskTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskTel.Mask = "(999)000-0000";
            this.maskTel.Name = "maskTel";
            this.maskTel.Size = new System.Drawing.Size(519, 30);
            this.maskTel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtNombreTour);
            this.panel2.Location = new System.Drawing.Point(34, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 22);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.cmbPais);
            this.panel4.Location = new System.Drawing.Point(34, 170);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 32);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.cmbDestino);
            this.panel5.Location = new System.Drawing.Point(33, 260);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(531, 30);
            this.panel5.TabIndex = 13;
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.SystemColors.Control;
            this.panelBorder.Controls.Add(this.dtpFecha);
            this.panelBorder.Location = new System.Drawing.Point(33, 341);
            this.panelBorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(531, 30);
            this.panelBorder.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.dtpHora);
            this.panel6.Location = new System.Drawing.Point(33, 439);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(531, 30);
            this.panel6.TabIndex = 15;
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.Enabled = false;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Gray;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton5.IconSize = 39;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 645);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(11, 20, 0, 20);
            this.iconButton5.Size = new System.Drawing.Size(1037, 80);
            this.iconButton5.TabIndex = 18;
            this.iconButton5.Text = "Cédula";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.Enabled = false;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.Gray;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 39;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 563);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(11, 20, 0, 20);
            this.iconButton4.Size = new System.Drawing.Size(1037, 82);
            this.iconButton4.TabIndex = 17;
            this.iconButton4.Text = "Teléfono";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Location = new System.Drawing.Point(0, 910);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(251, 0, 0, 0);
            this.iconButton6.Size = new System.Drawing.Size(1037, 66);
            this.iconButton6.TabIndex = 6;
            this.iconButton6.Text = "Agendar";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.Enabled = false;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Gray;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 39;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 473);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(11, 20, 0, 20);
            this.iconButton3.Size = new System.Drawing.Size(1037, 90);
            this.iconButton3.TabIndex = 11;
            this.iconButton3.Text = "Hora del Tour";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.Enabled = false;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gray;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 39;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 379);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(11, 20, 0, 20);
            this.iconButton2.Size = new System.Drawing.Size(1037, 94);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.Text = "Fecha del Tour";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton9
            // 
            this.iconButton9.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton9.Enabled = false;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton9.ForeColor = System.Drawing.Color.Gray;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.MapPin;
            this.iconButton9.IconColor = System.Drawing.Color.Black;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 39;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.Location = new System.Drawing.Point(0, 300);
            this.iconButton9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Padding = new System.Windows.Forms.Padding(11, 20, 0, 20);
            this.iconButton9.Size = new System.Drawing.Size(1037, 79);
            this.iconButton9.TabIndex = 9;
            this.iconButton9.Text = "Destino";
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton9.UseVisualStyleBackColor = true;
            // 
            // iconButton8
            // 
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton8.Enabled = false;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton8.ForeColor = System.Drawing.Color.Gray;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.MapLocationDot;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 39;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(0, 221);
            this.iconButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Padding = new System.Windows.Forms.Padding(11, 20, 0, 20);
            this.iconButton8.Size = new System.Drawing.Size(1037, 79);
            this.iconButton8.TabIndex = 8;
            this.iconButton8.Text = "País de destino";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // iconButton7
            // 
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton7.Enabled = false;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.Gray;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.PlaneDeparture;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 39;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(0, 142);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(11, 20, 0, 20);
            this.iconButton7.Size = new System.Drawing.Size(1037, 79);
            this.iconButton7.TabIndex = 7;
            this.iconButton7.Text = "Nombre del Tour";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gray;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 64);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(1037, 78);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Agendar Tour";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.iconPictureBoxToggle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconPictureBoxToggle
            // 
            this.iconPictureBoxToggle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBoxToggle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxToggle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBoxToggle.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxToggle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxToggle.IconSize = 43;
            this.iconPictureBoxToggle.Location = new System.Drawing.Point(17, 16);
            this.iconPictureBoxToggle.Name = "iconPictureBoxToggle";
            this.iconPictureBoxToggle.Size = new System.Drawing.Size(44, 43);
            this.iconPictureBoxToggle.TabIndex = 0;
            this.iconPictureBoxToggle.TabStop = false;
            this.iconPictureBoxToggle.Click += new System.EventHandler(this.iconPictureBoxToggle_Click);
            // 
            // picGaleria
            // 
            this.picGaleria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGaleria.Location = new System.Drawing.Point(1035, 2);
            this.picGaleria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picGaleria.Name = "picGaleria";
            this.picGaleria.Size = new System.Drawing.Size(733, 420);
            this.picGaleria.TabIndex = 14;
            this.picGaleria.TabStop = false;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(1035, 423);
            this.webView21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(733, 549);
            this.webView21.TabIndex = 15;
            this.webView21.ZoomFactor = 1D;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // UcAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.picGaleria);
            this.Controls.Add(this.panelAgendandoPublico);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcAgendar";
            this.Size = new System.Drawing.Size(1771, 976);
            this.Load += new System.EventHandler(this.UcAgendar_Load);
            this.panelAgendandoPublico.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelQR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelBorder.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGaleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreTour;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Panel panelAgendandoPublico;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox picGaleria;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelQR;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox maskTel;
        private System.Windows.Forms.MaskedTextBox maskCedula;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxToggle;
    }
}
