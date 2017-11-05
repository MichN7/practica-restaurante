namespace practicaRestaurante
{
    partial class frmMostartPlatillos
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
            this.cbPlatillos = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombrePlatillo = new System.Windows.Forms.Label();
            this.lblNombrePlatilloMostrar = new System.Windows.Forms.Label();
            this.lblDescripcionPlatilloMostrar = new System.Windows.Forms.Label();
            this.lblDescripcionPlatillo = new System.Windows.Forms.Label();
            this.lblDificultadPlatilloMostrar = new System.Windows.Forms.Label();
            this.lblDificultadPlatillo = new System.Windows.Forms.Label();
            this.lblPrecioPlatilloMostrar = new System.Windows.Forms.Label();
            this.lblPrecioPlatillo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPlatillos
            // 
            this.cbPlatillos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlatillos.FormattingEnabled = true;
            this.cbPlatillos.Location = new System.Drawing.Point(26, 46);
            this.cbPlatillos.Name = "cbPlatillos";
            this.cbPlatillos.Size = new System.Drawing.Size(167, 24);
            this.cbPlatillos.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(107, 98);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 32);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(351, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 243);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombrePlatillo
            // 
            this.lblNombrePlatillo.AutoSize = true;
            this.lblNombrePlatillo.Location = new System.Drawing.Point(351, 288);
            this.lblNombrePlatillo.Name = "lblNombrePlatillo";
            this.lblNombrePlatillo.Size = new System.Drawing.Size(62, 17);
            this.lblNombrePlatillo.TabIndex = 3;
            this.lblNombrePlatillo.Text = "Nombre:";
            // 
            // lblNombrePlatilloMostrar
            // 
            this.lblNombrePlatilloMostrar.AutoSize = true;
            this.lblNombrePlatilloMostrar.Location = new System.Drawing.Point(437, 288);
            this.lblNombrePlatilloMostrar.Name = "lblNombrePlatilloMostrar";
            this.lblNombrePlatilloMostrar.Size = new System.Drawing.Size(26, 17);
            this.lblNombrePlatilloMostrar.TabIndex = 4;
            this.lblNombrePlatilloMostrar.Tag = "";
            this.lblNombrePlatilloMostrar.Text = "ms";
            // 
            // lblDescripcionPlatilloMostrar
            // 
            this.lblDescripcionPlatilloMostrar.AutoSize = true;
            this.lblDescripcionPlatilloMostrar.Location = new System.Drawing.Point(437, 327);
            this.lblDescripcionPlatilloMostrar.Name = "lblDescripcionPlatilloMostrar";
            this.lblDescripcionPlatilloMostrar.Size = new System.Drawing.Size(26, 17);
            this.lblDescripcionPlatilloMostrar.TabIndex = 6;
            this.lblDescripcionPlatilloMostrar.Tag = "";
            this.lblDescripcionPlatilloMostrar.Text = "ms";
            // 
            // lblDescripcionPlatillo
            // 
            this.lblDescripcionPlatillo.AutoSize = true;
            this.lblDescripcionPlatillo.Location = new System.Drawing.Point(351, 327);
            this.lblDescripcionPlatillo.Name = "lblDescripcionPlatillo";
            this.lblDescripcionPlatillo.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcionPlatillo.TabIndex = 5;
            this.lblDescripcionPlatillo.Text = "Descripción:";
            // 
            // lblDificultadPlatilloMostrar
            // 
            this.lblDificultadPlatilloMostrar.AutoSize = true;
            this.lblDificultadPlatilloMostrar.Location = new System.Drawing.Point(437, 369);
            this.lblDificultadPlatilloMostrar.Name = "lblDificultadPlatilloMostrar";
            this.lblDificultadPlatilloMostrar.Size = new System.Drawing.Size(26, 17);
            this.lblDificultadPlatilloMostrar.TabIndex = 8;
            this.lblDificultadPlatilloMostrar.Tag = "";
            this.lblDificultadPlatilloMostrar.Text = "ms";
            // 
            // lblDificultadPlatillo
            // 
            this.lblDificultadPlatillo.AutoSize = true;
            this.lblDificultadPlatillo.Location = new System.Drawing.Point(351, 369);
            this.lblDificultadPlatillo.Name = "lblDificultadPlatillo";
            this.lblDificultadPlatillo.Size = new System.Drawing.Size(70, 17);
            this.lblDificultadPlatillo.TabIndex = 7;
            this.lblDificultadPlatillo.Text = "Dificultad:";
            // 
            // lblPrecioPlatilloMostrar
            // 
            this.lblPrecioPlatilloMostrar.AutoSize = true;
            this.lblPrecioPlatilloMostrar.Location = new System.Drawing.Point(437, 410);
            this.lblPrecioPlatilloMostrar.Name = "lblPrecioPlatilloMostrar";
            this.lblPrecioPlatilloMostrar.Size = new System.Drawing.Size(26, 17);
            this.lblPrecioPlatilloMostrar.TabIndex = 10;
            this.lblPrecioPlatilloMostrar.Tag = "";
            this.lblPrecioPlatilloMostrar.Text = "ms";
            // 
            // lblPrecioPlatillo
            // 
            this.lblPrecioPlatillo.AutoSize = true;
            this.lblPrecioPlatillo.Location = new System.Drawing.Point(351, 410);
            this.lblPrecioPlatillo.Name = "lblPrecioPlatillo";
            this.lblPrecioPlatillo.Size = new System.Drawing.Size(52, 17);
            this.lblPrecioPlatillo.TabIndex = 9;
            this.lblPrecioPlatillo.Text = "Precio:";
            // 
            // frmMostartPlatillos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 495);
            this.Controls.Add(this.lblPrecioPlatilloMostrar);
            this.Controls.Add(this.lblPrecioPlatillo);
            this.Controls.Add(this.lblDificultadPlatilloMostrar);
            this.Controls.Add(this.lblDificultadPlatillo);
            this.Controls.Add(this.lblDescripcionPlatilloMostrar);
            this.Controls.Add(this.lblDescripcionPlatillo);
            this.Controls.Add(this.lblNombrePlatilloMostrar);
            this.Controls.Add(this.lblNombrePlatillo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbPlatillos);
            this.Name = "frmMostartPlatillos";
            this.Text = "frmMostartPlatillos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlatillos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombrePlatillo;
        private System.Windows.Forms.Label lblNombrePlatilloMostrar;
        private System.Windows.Forms.Label lblDescripcionPlatilloMostrar;
        private System.Windows.Forms.Label lblDescripcionPlatillo;
        private System.Windows.Forms.Label lblDificultadPlatilloMostrar;
        private System.Windows.Forms.Label lblDificultadPlatillo;
        private System.Windows.Forms.Label lblPrecioPlatilloMostrar;
        private System.Windows.Forms.Label lblPrecioPlatillo;
    }
}