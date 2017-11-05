namespace practicaRestaurante
{
    partial class frmPlatillo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarPlatillo = new System.Windows.Forms.Button();
            this.txtDescripcionPlatillo = new System.Windows.Forms.TextBox();
            this.txtNombrePlatillo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.cbDificultad = new System.Windows.Forms.ComboBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.opdPlatillo = new System.Windows.Forms.OpenFileDialog();
            this.pbPlatillo = new System.Windows.Forms.PictureBox();
            this.cbReceta = new System.Windows.Forms.ComboBox();
            this.lblReceta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblReceta);
            this.panel1.Controls.Add(this.cbReceta);
            this.panel1.Controls.Add(this.pbPlatillo);
            this.panel1.Controls.Add(this.btnAgregarPlatillo);
            this.panel1.Controls.Add(this.txtDescripcionPlatillo);
            this.panel1.Controls.Add(this.txtNombrePlatillo);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.lblDificultad);
            this.panel1.Controls.Add(this.cbDificultad);
            this.panel1.Controls.Add(this.btnCargarImagen);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 566);
            this.panel1.TabIndex = 0;
            // 
            // btnAgregarPlatillo
            // 
            this.btnAgregarPlatillo.Location = new System.Drawing.Point(522, 490);
            this.btnAgregarPlatillo.Name = "btnAgregarPlatillo";
            this.btnAgregarPlatillo.Size = new System.Drawing.Size(130, 40);
            this.btnAgregarPlatillo.TabIndex = 31;
            this.btnAgregarPlatillo.Text = "Agregar platillo";
            this.btnAgregarPlatillo.UseVisualStyleBackColor = true;
            this.btnAgregarPlatillo.Click += new System.EventHandler(this.btnAgregarPlatillo_Click);
            // 
            // txtDescripcionPlatillo
            // 
            this.txtDescripcionPlatillo.Location = new System.Drawing.Point(27, 123);
            this.txtDescripcionPlatillo.Multiline = true;
            this.txtDescripcionPlatillo.Name = "txtDescripcionPlatillo";
            this.txtDescripcionPlatillo.Size = new System.Drawing.Size(203, 61);
            this.txtDescripcionPlatillo.TabIndex = 30;
            // 
            // txtNombrePlatillo
            // 
            this.txtNombrePlatillo.Location = new System.Drawing.Point(24, 63);
            this.txtNombrePlatillo.Name = "txtNombrePlatillo";
            this.txtNombrePlatillo.Size = new System.Drawing.Size(206, 22);
            this.txtNombrePlatillo.TabIndex = 29;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(24, 103);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 28;
            this.lblDescripcion.Text = "Descripcion ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(27, 338);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 26;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(27, 363);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 25;
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.Location = new System.Drawing.Point(24, 187);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(66, 17);
            this.lblDificultad.TabIndex = 21;
            this.lblDificultad.Text = "Dificultad";
            // 
            // cbDificultad
            // 
            this.cbDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDificultad.FormattingEnabled = true;
            this.cbDificultad.Items.AddRange(new object[] {
            "Facil",
            "Medio",
            "Dificil"});
            this.cbDificultad.Location = new System.Drawing.Point(24, 219);
            this.cbDificultad.Name = "cbDificultad";
            this.cbDificultad.Size = new System.Drawing.Size(168, 24);
            this.cbDificultad.TabIndex = 19;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(519, 353);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(133, 42);
            this.btnCargarImagen.TabIndex = 23;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(24, 285);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(168, 24);
            this.cbCategoria.TabIndex = 20;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(27, 261);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.Text = "Categoria";
            // 
            // opdPlatillo
            // 
            this.opdPlatillo.FileName = "openFileDialog1";
            this.opdPlatillo.FileOk += new System.ComponentModel.CancelEventHandler(this.opdPlatillo_FileOk);
            // 
            // pbPlatillo
            // 
            this.pbPlatillo.Location = new System.Drawing.Point(266, 46);
            this.pbPlatillo.Name = "pbPlatillo";
            this.pbPlatillo.Size = new System.Drawing.Size(386, 275);
            this.pbPlatillo.TabIndex = 32;
            this.pbPlatillo.TabStop = false;
            // 
            // cbReceta
            // 
            this.cbReceta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReceta.FormattingEnabled = true;
            this.cbReceta.Location = new System.Drawing.Point(24, 443);
            this.cbReceta.Name = "cbReceta";
            this.cbReceta.Size = new System.Drawing.Size(121, 24);
            this.cbReceta.TabIndex = 33;
            // 
            // lblReceta
            // 
            this.lblReceta.AutoSize = true;
            this.lblReceta.Location = new System.Drawing.Point(24, 414);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(53, 17);
            this.lblReceta.TabIndex = 34;
            this.lblReceta.Text = "Receta";
            // 
            // frmPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 597);
            this.Controls.Add(this.panel1);
            this.Name = "frmPlatillo";
            this.Text = "Platillo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarPlatillo;
        private System.Windows.Forms.TextBox txtDescripcionPlatillo;
        private System.Windows.Forms.TextBox txtNombrePlatillo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.ComboBox cbDificultad;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.OpenFileDialog opdPlatillo;
        private System.Windows.Forms.PictureBox pbPlatillo;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.ComboBox cbReceta;
    }
}