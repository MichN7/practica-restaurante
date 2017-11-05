namespace practicaRestaurante
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirNuevaRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRecetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirNuevaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirIngredienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platillosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPlatillosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPlatillosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAgregarReceta = new System.Windows.Forms.Panel();
            this.btnAgregarReceta = new System.Windows.Forms.Button();
            this.btnAgregarIngrediente = new System.Windows.Forms.Button();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.cbIngredientes = new System.Windows.Forms.ComboBox();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcionReceta = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreReceta = new System.Windows.Forms.Label();
            this.txtNombreReceta = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.pnlAgregarReceta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recetaToolStripMenuItem,
            this.platillosToolStripMenuItem,
            this.cuentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recetaToolStripMenuItem
            // 
            this.recetaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirNuevaRecetaToolStripMenuItem,
            this.verRecetasToolStripMenuItem,
            this.añadirNuevaCategoriaToolStripMenuItem,
            this.añadirIngredienteToolStripMenuItem});
            this.recetaToolStripMenuItem.Name = "recetaToolStripMenuItem";
            this.recetaToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.recetaToolStripMenuItem.Text = "Recetas";
            // 
            // añadirNuevaRecetaToolStripMenuItem
            // 
            this.añadirNuevaRecetaToolStripMenuItem.Name = "añadirNuevaRecetaToolStripMenuItem";
            this.añadirNuevaRecetaToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.añadirNuevaRecetaToolStripMenuItem.Text = "Añadir nueva receta";
            this.añadirNuevaRecetaToolStripMenuItem.Click += new System.EventHandler(this.añadirNuevaRecetaToolStripMenuItem_Click);
            // 
            // verRecetasToolStripMenuItem
            // 
            this.verRecetasToolStripMenuItem.Name = "verRecetasToolStripMenuItem";
            this.verRecetasToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.verRecetasToolStripMenuItem.Text = "Ver recetas";
            this.verRecetasToolStripMenuItem.Click += new System.EventHandler(this.verRecetasToolStripMenuItem_Click);
            // 
            // añadirNuevaCategoriaToolStripMenuItem
            // 
            this.añadirNuevaCategoriaToolStripMenuItem.Name = "añadirNuevaCategoriaToolStripMenuItem";
            this.añadirNuevaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.añadirNuevaCategoriaToolStripMenuItem.Text = "Añadir nueva categoria";
            this.añadirNuevaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.añadirNuevaCategoriaToolStripMenuItem_Click);
            // 
            // añadirIngredienteToolStripMenuItem
            // 
            this.añadirIngredienteToolStripMenuItem.Name = "añadirIngredienteToolStripMenuItem";
            this.añadirIngredienteToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.añadirIngredienteToolStripMenuItem.Text = "Añadir ingrediente";
            this.añadirIngredienteToolStripMenuItem.Click += new System.EventHandler(this.añadirIngredienteToolStripMenuItem_Click);
            // 
            // platillosToolStripMenuItem
            // 
            this.platillosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPlatillosToolStripMenuItem,
            this.añadirPlatillosToolStripMenuItem});
            this.platillosToolStripMenuItem.Name = "platillosToolStripMenuItem";
            this.platillosToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.platillosToolStripMenuItem.Text = "Platillos";
            // 
            // verPlatillosToolStripMenuItem
            // 
            this.verPlatillosToolStripMenuItem.Name = "verPlatillosToolStripMenuItem";
            this.verPlatillosToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.verPlatillosToolStripMenuItem.Text = "Ver platillos";
            this.verPlatillosToolStripMenuItem.Click += new System.EventHandler(this.verPlatillosToolStripMenuItem_Click);
            // 
            // añadirPlatillosToolStripMenuItem
            // 
            this.añadirPlatillosToolStripMenuItem.Name = "añadirPlatillosToolStripMenuItem";
            this.añadirPlatillosToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.añadirPlatillosToolStripMenuItem.Text = "Añadir platillos";
            this.añadirPlatillosToolStripMenuItem.Click += new System.EventHandler(this.añadirPlatillosToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.verCuentaToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.cuentaToolStripMenuItem.Text = "Crear Cuenta";
            this.cuentaToolStripMenuItem.Click += new System.EventHandler(this.cuentaToolStripMenuItem_Click);
            // 
            // verCuentaToolStripMenuItem
            // 
            this.verCuentaToolStripMenuItem.Name = "verCuentaToolStripMenuItem";
            this.verCuentaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.verCuentaToolStripMenuItem.Text = "Ver Cuenta";
            this.verCuentaToolStripMenuItem.Click += new System.EventHandler(this.verCuentaToolStripMenuItem_Click);
            // 
            // pnlAgregarReceta
            // 
            this.pnlAgregarReceta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlAgregarReceta.Controls.Add(this.btnAgregarReceta);
            this.pnlAgregarReceta.Controls.Add(this.btnAgregarIngrediente);
            this.pnlAgregarReceta.Controls.Add(this.lblIngredientes);
            this.pnlAgregarReceta.Controls.Add(this.cbIngredientes);
            this.pnlAgregarReceta.Controls.Add(this.dgvIngredientes);
            this.pnlAgregarReceta.Controls.Add(this.txtDescripcionReceta);
            this.pnlAgregarReceta.Controls.Add(this.lblDescripcion);
            this.pnlAgregarReceta.Controls.Add(this.lblNombreReceta);
            this.pnlAgregarReceta.Controls.Add(this.txtNombreReceta);
            this.pnlAgregarReceta.Location = new System.Drawing.Point(21, 41);
            this.pnlAgregarReceta.Name = "pnlAgregarReceta";
            this.pnlAgregarReceta.Size = new System.Drawing.Size(541, 447);
            this.pnlAgregarReceta.TabIndex = 1;
            // 
            // btnAgregarReceta
            // 
            this.btnAgregarReceta.Location = new System.Drawing.Point(300, 374);
            this.btnAgregarReceta.Name = "btnAgregarReceta";
            this.btnAgregarReceta.Size = new System.Drawing.Size(212, 33);
            this.btnAgregarReceta.TabIndex = 7;
            this.btnAgregarReceta.Text = "Agregar Receta";
            this.btnAgregarReceta.UseVisualStyleBackColor = true;
            this.btnAgregarReceta.Click += new System.EventHandler(this.btnAgregarReceta_Click);
            // 
            // btnAgregarIngrediente
            // 
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(74, 273);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(146, 30);
            this.btnAgregarIngrediente.TabIndex = 16;
            this.btnAgregarIngrediente.Text = "Agregar Ingrediente";
            this.btnAgregarIngrediente.UseVisualStyleBackColor = true;
            this.btnAgregarIngrediente.Click += new System.EventHandler(this.btnAgregarIngrediente_Click);
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(22, 184);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(86, 17);
            this.lblIngredientes.TabIndex = 15;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // cbIngredientes
            // 
            this.cbIngredientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIngredientes.FormattingEnabled = true;
            this.cbIngredientes.Location = new System.Drawing.Point(20, 221);
            this.cbIngredientes.Name = "cbIngredientes";
            this.cbIngredientes.Size = new System.Drawing.Size(200, 24);
            this.cbIngredientes.TabIndex = 14;
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvIngredientes.Location = new System.Drawing.Point(276, 200);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.RowTemplate.Height = 24;
            this.dgvIngredientes.Size = new System.Drawing.Size(236, 103);
            this.dgvIngredientes.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // txtDescripcionReceta
            // 
            this.txtDescripcionReceta.Location = new System.Drawing.Point(20, 101);
            this.txtDescripcionReceta.Multiline = true;
            this.txtDescripcionReceta.Name = "txtDescripcionReceta";
            this.txtDescripcionReceta.Size = new System.Drawing.Size(205, 55);
            this.txtDescripcionReceta.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(22, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombreReceta
            // 
            this.lblNombreReceta.AutoSize = true;
            this.lblNombreReceta.Location = new System.Drawing.Point(17, 17);
            this.lblNombreReceta.Name = "lblNombreReceta";
            this.lblNombreReceta.Size = new System.Drawing.Size(107, 17);
            this.lblNombreReceta.TabIndex = 3;
            this.lblNombreReceta.Text = "Nombre Receta";
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.Location = new System.Drawing.Point(20, 38);
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Size = new System.Drawing.Size(205, 22);
            this.txtNombreReceta.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 513);
            this.Controls.Add(this.pnlAgregarReceta);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAgregarReceta.ResumeLayout(false);
            this.pnlAgregarReceta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirNuevaRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRecetasToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAgregarReceta;
        private System.Windows.Forms.Button btnAgregarReceta;
        private System.Windows.Forms.TextBox txtDescripcionReceta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreReceta;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.ToolStripMenuItem añadirNuevaCategoriaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem añadirIngredienteToolStripMenuItem;
        private System.Windows.Forms.Button btnAgregarIngrediente;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.ComboBox cbIngredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.ToolStripMenuItem platillosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPlatillosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirPlatillosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCuentaToolStripMenuItem;
    }
}

