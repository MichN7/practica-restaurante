namespace practicaRestaurante
{
    partial class frmMesas
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
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.cbNumeroMesa = new System.Windows.Forms.ComboBox();
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.pnlCuenta = new System.Windows.Forms.Panel();
            this.lblEncargadoPlaro = new System.Windows.Forms.Label();
            this.cbNombreMesa = new System.Windows.Forms.ComboBox();
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPlato = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAceptarCuenta = new System.Windows.Forms.Button();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.cbPlato = new System.Windows.Forms.ComboBox();
            this.txtNombreMesa = new System.Windows.Forms.TextBox();
            this.lblNombreMesa = new System.Windows.Forms.Label();
            this.bntAgregarPlatillo = new System.Windows.Forms.Button();
            this.pnlCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(50, 237);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(102, 28);
            this.btnCrearCuenta.TabIndex = 0;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbNumeroMesa
            // 
            this.cbNumeroMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroMesa.FormattingEnabled = true;
            this.cbNumeroMesa.Location = new System.Drawing.Point(31, 69);
            this.cbNumeroMesa.Name = "cbNumeroMesa";
            this.cbNumeroMesa.Size = new System.Drawing.Size(121, 24);
            this.cbNumeroMesa.TabIndex = 1;
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.Location = new System.Drawing.Point(28, 36);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(42, 17);
            this.lblNumeroMesa.TabIndex = 4;
            this.lblNumeroMesa.Text = "Mesa";
            // 
            // pnlCuenta
            // 
            this.pnlCuenta.Controls.Add(this.lblEncargadoPlaro);
            this.pnlCuenta.Controls.Add(this.cbNombreMesa);
            this.pnlCuenta.Controls.Add(this.dgvPlatos);
            this.pnlCuenta.Controls.Add(this.lblCantidad);
            this.pnlCuenta.Controls.Add(this.lblPlato);
            this.pnlCuenta.Controls.Add(this.txtCantidad);
            this.pnlCuenta.Controls.Add(this.btnAceptarCuenta);
            this.pnlCuenta.Controls.Add(this.btnAgregarPlato);
            this.pnlCuenta.Controls.Add(this.cbPlato);
            this.pnlCuenta.Location = new System.Drawing.Point(176, 36);
            this.pnlCuenta.Name = "pnlCuenta";
            this.pnlCuenta.Size = new System.Drawing.Size(616, 347);
            this.pnlCuenta.TabIndex = 5;
            // 
            // lblEncargadoPlaro
            // 
            this.lblEncargadoPlaro.AutoSize = true;
            this.lblEncargadoPlaro.Location = new System.Drawing.Point(22, 175);
            this.lblEncargadoPlaro.Name = "lblEncargadoPlaro";
            this.lblEncargadoPlaro.Size = new System.Drawing.Size(96, 17);
            this.lblEncargadoPlaro.TabIndex = 9;
            this.lblEncargadoPlaro.Text = "Nombre Mesa";
            // 
            // cbNombreMesa
            // 
            this.cbNombreMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreMesa.FormattingEnabled = true;
            this.cbNombreMesa.Location = new System.Drawing.Point(22, 198);
            this.cbNombreMesa.Name = "cbNombreMesa";
            this.cbNombreMesa.Size = new System.Drawing.Size(121, 24);
            this.cbNombreMesa.TabIndex = 8;
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Cantidad});
            this.dgvPlatos.Location = new System.Drawing.Point(217, 22);
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.ReadOnly = true;
            this.dgvPlatos.RowTemplate.Height = 24;
            this.dgvPlatos.Size = new System.Drawing.Size(373, 207);
            this.dgvPlatos.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(15, 99);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPlato
            // 
            this.lblPlato.AutoSize = true;
            this.lblPlato.Location = new System.Drawing.Point(15, 22);
            this.lblPlato.Name = "lblPlato";
            this.lblPlato.Size = new System.Drawing.Size(40, 17);
            this.lblPlato.TabIndex = 5;
            this.lblPlato.Text = "Plato";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(18, 121);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 4;
            // 
            // btnAceptarCuenta
            // 
            this.btnAceptarCuenta.Location = new System.Drawing.Point(469, 287);
            this.btnAceptarCuenta.Name = "btnAceptarCuenta";
            this.btnAceptarCuenta.Size = new System.Drawing.Size(121, 29);
            this.btnAceptarCuenta.TabIndex = 3;
            this.btnAceptarCuenta.Text = "Aceptar";
            this.btnAceptarCuenta.UseVisualStyleBackColor = true;
            this.btnAceptarCuenta.Click += new System.EventHandler(this.btnAceptarCuenta_Click);
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.Location = new System.Drawing.Point(25, 287);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(167, 37);
            this.btnAgregarPlato.TabIndex = 1;
            this.btnAgregarPlato.Text = "Agregar plato a cuenta";
            this.btnAgregarPlato.UseVisualStyleBackColor = true;
            this.btnAgregarPlato.Click += new System.EventHandler(this.btnAgregarPlato_Click);
            // 
            // cbPlato
            // 
            this.cbPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlato.FormattingEnabled = true;
            this.cbPlato.Location = new System.Drawing.Point(18, 47);
            this.cbPlato.Name = "cbPlato";
            this.cbPlato.Size = new System.Drawing.Size(167, 24);
            this.cbPlato.TabIndex = 0;
            // 
            // txtNombreMesa
            // 
            this.txtNombreMesa.Location = new System.Drawing.Point(31, 166);
            this.txtNombreMesa.Name = "txtNombreMesa";
            this.txtNombreMesa.Size = new System.Drawing.Size(121, 22);
            this.txtNombreMesa.TabIndex = 6;
            // 
            // lblNombreMesa
            // 
            this.lblNombreMesa.AutoSize = true;
            this.lblNombreMesa.Location = new System.Drawing.Point(28, 135);
            this.lblNombreMesa.Name = "lblNombreMesa";
            this.lblNombreMesa.Size = new System.Drawing.Size(58, 17);
            this.lblNombreMesa.TabIndex = 7;
            this.lblNombreMesa.Text = "Nombre";
            // 
            // bntAgregarPlatillo
            // 
            this.bntAgregarPlatillo.Location = new System.Drawing.Point(50, 290);
            this.bntAgregarPlatillo.Name = "bntAgregarPlatillo";
            this.bntAgregarPlatillo.Size = new System.Drawing.Size(102, 45);
            this.bntAgregarPlatillo.TabIndex = 8;
            this.bntAgregarPlatillo.Text = "Agregar Platillo";
            this.bntAgregarPlatillo.UseVisualStyleBackColor = true;
            this.bntAgregarPlatillo.Click += new System.EventHandler(this.bntAgregarPlatillo_Click);
            // 
            // frmMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 428);
            this.Controls.Add(this.bntAgregarPlatillo);
            this.Controls.Add(this.lblNombreMesa);
            this.Controls.Add(this.txtNombreMesa);
            this.Controls.Add(this.pnlCuenta);
            this.Controls.Add(this.lblNumeroMesa);
            this.Controls.Add(this.cbNumeroMesa);
            this.Controls.Add(this.btnCrearCuenta);
            this.Name = "frmMesas";
            this.Text = "frmMesas";
            this.pnlCuenta.ResumeLayout(false);
            this.pnlCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.ComboBox cbNumeroMesa;
        private System.Windows.Forms.Label lblNumeroMesa;
        private System.Windows.Forms.Panel pnlCuenta;
        private System.Windows.Forms.TextBox txtNombreMesa;
        private System.Windows.Forms.Label lblNombreMesa;
        private System.Windows.Forms.Button btnAceptarCuenta;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.ComboBox cbPlato;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPlato;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvPlatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label lblEncargadoPlaro;
        private System.Windows.Forms.ComboBox cbNombreMesa;
        private System.Windows.Forms.Button bntAgregarPlatillo;
    }
}