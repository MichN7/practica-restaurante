namespace practicaRestaurante
{
    partial class frmMostrarCuenta
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
            this.btnCerrarCuenta = new System.Windows.Forms.Button();
            this.cbNombreCuenta = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechaMostrar = new System.Windows.Forms.Label();
            this.lblTotalMostrar = new System.Windows.Forms.Label();
            this.lblFechaCuenta = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblTotalCuenta = new System.Windows.Forms.Label();
            this.lblPlatillosPedidos = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarCuenta
            // 
            this.btnCerrarCuenta.Location = new System.Drawing.Point(653, 243);
            this.btnCerrarCuenta.Name = "btnCerrarCuenta";
            this.btnCerrarCuenta.Size = new System.Drawing.Size(188, 31);
            this.btnCerrarCuenta.TabIndex = 1;
            this.btnCerrarCuenta.Text = "Cerrar";
            this.btnCerrarCuenta.UseVisualStyleBackColor = true;
            this.btnCerrarCuenta.Click += new System.EventHandler(this.btnMostrarCuenta_Click);
            // 
            // cbNombreCuenta
            // 
            this.cbNombreCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreCuenta.FormattingEnabled = true;
            this.cbNombreCuenta.Location = new System.Drawing.Point(37, 51);
            this.cbNombreCuenta.Name = "cbNombreCuenta";
            this.cbNombreCuenta.Size = new System.Drawing.Size(121, 24);
            this.cbNombreCuenta.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFechaMostrar);
            this.panel1.Controls.Add(this.lblTotalMostrar);
            this.panel1.Controls.Add(this.lblFechaCuenta);
            this.panel1.Controls.Add(this.dgvPedidos);
            this.panel1.Controls.Add(this.lblTotalCuenta);
            this.panel1.Controls.Add(this.btnCerrarCuenta);
            this.panel1.Controls.Add(this.lblPlatillosPedidos);
            this.panel1.Location = new System.Drawing.Point(37, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 294);
            this.panel1.TabIndex = 3;
            // 
            // lblFechaMostrar
            // 
            this.lblFechaMostrar.AutoSize = true;
            this.lblFechaMostrar.Location = new System.Drawing.Point(88, 243);
            this.lblFechaMostrar.Name = "lblFechaMostrar";
            this.lblFechaMostrar.Size = new System.Drawing.Size(46, 17);
            this.lblFechaMostrar.TabIndex = 5;
            this.lblFechaMostrar.Text = "label2";
            // 
            // lblTotalMostrar
            // 
            this.lblTotalMostrar.AutoSize = true;
            this.lblTotalMostrar.Location = new System.Drawing.Point(74, 216);
            this.lblTotalMostrar.Name = "lblTotalMostrar";
            this.lblTotalMostrar.Size = new System.Drawing.Size(46, 17);
            this.lblTotalMostrar.TabIndex = 4;
            this.lblTotalMostrar.Text = "label1";
            // 
            // lblFechaCuenta
            // 
            this.lblFechaCuenta.AutoSize = true;
            this.lblFechaCuenta.Location = new System.Drawing.Point(30, 243);
            this.lblFechaCuenta.Name = "lblFechaCuenta";
            this.lblFechaCuenta.Size = new System.Drawing.Size(51, 17);
            this.lblFechaCuenta.TabIndex = 3;
            this.lblFechaCuenta.Text = "Fecha:";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Cantidad});
            this.dgvPedidos.Location = new System.Drawing.Point(30, 39);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(662, 163);
            this.dgvPedidos.TabIndex = 2;
            // 
            // lblTotalCuenta
            // 
            this.lblTotalCuenta.AutoSize = true;
            this.lblTotalCuenta.Location = new System.Drawing.Point(27, 216);
            this.lblTotalCuenta.Name = "lblTotalCuenta";
            this.lblTotalCuenta.Size = new System.Drawing.Size(44, 17);
            this.lblTotalCuenta.TabIndex = 1;
            this.lblTotalCuenta.Text = "Total:";
            // 
            // lblPlatillosPedidos
            // 
            this.lblPlatillosPedidos.AutoSize = true;
            this.lblPlatillosPedidos.Location = new System.Drawing.Point(27, 19);
            this.lblPlatillosPedidos.Name = "lblPlatillosPedidos";
            this.lblPlatillosPedidos.Size = new System.Drawing.Size(114, 17);
            this.lblPlatillosPedidos.TabIndex = 0;
            this.lblPlatillosPedidos.Text = "Platillos pedidos:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(193, 51);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 29);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripción";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dificultad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // frmMostrarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 427);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbNombreCuenta);
            this.Name = "frmMostrarCuenta";
            this.Text = "frmMostrarCuenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarCuenta;
        private System.Windows.Forms.ComboBox cbNombreCuenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechaCuenta;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblTotalCuenta;
        private System.Windows.Forms.Label lblPlatillosPedidos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFechaMostrar;
        private System.Windows.Forms.Label lblTotalMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}