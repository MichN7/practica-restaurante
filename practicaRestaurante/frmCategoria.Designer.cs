namespace practicaRestaurante
{
    partial class frmCategoria
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
            this.pnlCategoria = new System.Windows.Forms.Panel();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.txtEncargadoCategoria = new System.Windows.Forms.TextBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.btnAgregarcategoria = new System.Windows.Forms.Button();
            this.pnlCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCategoria
            // 
            this.pnlCategoria.Controls.Add(this.btnCategoria);
            this.pnlCategoria.Controls.Add(this.txtEncargadoCategoria);
            this.pnlCategoria.Controls.Add(this.dgvCategorias);
            this.pnlCategoria.Controls.Add(this.txtDescripcionCategoria);
            this.pnlCategoria.Controls.Add(this.txtNombreCategoria);
            this.pnlCategoria.Controls.Add(this.lblEncargado);
            this.pnlCategoria.Controls.Add(this.lblDescripcionCategoria);
            this.pnlCategoria.Controls.Add(this.lblNombreCategoria);
            this.pnlCategoria.Controls.Add(this.btnAgregarcategoria);
            this.pnlCategoria.Location = new System.Drawing.Point(12, 12);
            this.pnlCategoria.Name = "pnlCategoria";
            this.pnlCategoria.Size = new System.Drawing.Size(395, 601);
            this.pnlCategoria.TabIndex = 3;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(204, 551);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(164, 37);
            this.btnCategoria.TabIndex = 4;
            this.btnCategoria.Text = "Consultar categorias";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // txtEncargadoCategoria
            // 
            this.txtEncargadoCategoria.Location = new System.Drawing.Point(28, 209);
            this.txtEncargadoCategoria.Name = "txtEncargadoCategoria";
            this.txtEncargadoCategoria.Size = new System.Drawing.Size(248, 22);
            this.txtEncargadoCategoria.TabIndex = 6;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(19, 316);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(352, 216);
            this.dgvCategorias.TabIndex = 3;
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(28, 115);
            this.txtDescripcionCategoria.Multiline = true;
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(248, 52);
            this.txtDescripcionCategoria.TabIndex = 5;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(28, 49);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(248, 22);
            this.txtNombreCategoria.TabIndex = 4;
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Location = new System.Drawing.Point(25, 179);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(77, 17);
            this.lblEncargado.TabIndex = 3;
            this.lblEncargado.Text = "Encargado";
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(25, 95);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcionCategoria.TabIndex = 2;
            this.lblDescripcionCategoria.Text = "Descripcion";
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(25, 18);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(123, 17);
            this.lblNombreCategoria.TabIndex = 1;
            this.lblNombreCategoria.Text = "Nombre Categoría";
            // 
            // btnAgregarcategoria
            // 
            this.btnAgregarcategoria.Location = new System.Drawing.Point(204, 262);
            this.btnAgregarcategoria.Name = "btnAgregarcategoria";
            this.btnAgregarcategoria.Size = new System.Drawing.Size(132, 33);
            this.btnAgregarcategoria.TabIndex = 0;
            this.btnAgregarcategoria.Text = "Agregar Categoría";
            this.btnAgregarcategoria.UseVisualStyleBackColor = true;
            this.btnAgregarcategoria.Click += new System.EventHandler(this.btnAgregarcategoria_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 617);
            this.Controls.Add(this.pnlCategoria);
            this.Name = "frmCategoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.pnlCategoria.ResumeLayout(false);
            this.pnlCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategoria;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.TextBox txtEncargadoCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.Button btnAgregarcategoria;
    }
}