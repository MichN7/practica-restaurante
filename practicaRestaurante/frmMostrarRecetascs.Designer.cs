namespace practicaRestaurante
{
    partial class frmMostrarRecetascs
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
            this.btnAceptarReceta = new System.Windows.Forms.Button();
            this.cbRecetas = new System.Windows.Forms.ComboBox();
            this.lbIngredientes = new System.Windows.Forms.ListBox();
            this.lblNombreReceta = new System.Windows.Forms.Label();
            this.lblNombreRecetaMostrar = new System.Windows.Forms.Label();
            this.lblDescripcionReceta = new System.Windows.Forms.Label();
            this.lblDescripcionRecetaMostrar = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptarReceta
            // 
            this.btnAceptarReceta.Location = new System.Drawing.Point(79, 89);
            this.btnAceptarReceta.Name = "btnAceptarReceta";
            this.btnAceptarReceta.Size = new System.Drawing.Size(82, 28);
            this.btnAceptarReceta.TabIndex = 0;
            this.btnAceptarReceta.Text = "Aceptar";
            this.btnAceptarReceta.UseVisualStyleBackColor = true;
            this.btnAceptarReceta.Click += new System.EventHandler(this.btnAceptarReceta_Click);
            // 
            // cbRecetas
            // 
            this.cbRecetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecetas.FormattingEnabled = true;
            this.cbRecetas.Location = new System.Drawing.Point(40, 43);
            this.cbRecetas.Name = "cbRecetas";
            this.cbRecetas.Size = new System.Drawing.Size(121, 24);
            this.cbRecetas.TabIndex = 1;
            // 
            // lbIngredientes
            // 
            this.lbIngredientes.FormattingEnabled = true;
            this.lbIngredientes.ItemHeight = 16;
            this.lbIngredientes.Location = new System.Drawing.Point(255, 80);
            this.lbIngredientes.Name = "lbIngredientes";
            this.lbIngredientes.Size = new System.Drawing.Size(143, 148);
            this.lbIngredientes.TabIndex = 2;
            // 
            // lblNombreReceta
            // 
            this.lblNombreReceta.AutoSize = true;
            this.lblNombreReceta.Location = new System.Drawing.Point(24, 173);
            this.lblNombreReceta.Name = "lblNombreReceta";
            this.lblNombreReceta.Size = new System.Drawing.Size(62, 17);
            this.lblNombreReceta.TabIndex = 3;
            this.lblNombreReceta.Text = "Nombre:";
            // 
            // lblNombreRecetaMostrar
            // 
            this.lblNombreRecetaMostrar.AutoSize = true;
            this.lblNombreRecetaMostrar.Location = new System.Drawing.Point(115, 173);
            this.lblNombreRecetaMostrar.Name = "lblNombreRecetaMostrar";
            this.lblNombreRecetaMostrar.Size = new System.Drawing.Size(46, 17);
            this.lblNombreRecetaMostrar.TabIndex = 4;
            this.lblNombreRecetaMostrar.Text = "label2";
            // 
            // lblDescripcionReceta
            // 
            this.lblDescripcionReceta.AutoSize = true;
            this.lblDescripcionReceta.Location = new System.Drawing.Point(24, 236);
            this.lblDescripcionReceta.Name = "lblDescripcionReceta";
            this.lblDescripcionReceta.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcionReceta.TabIndex = 5;
            this.lblDescripcionReceta.Text = "Descripción:";
            // 
            // lblDescripcionRecetaMostrar
            // 
            this.lblDescripcionRecetaMostrar.AutoSize = true;
            this.lblDescripcionRecetaMostrar.Location = new System.Drawing.Point(124, 236);
            this.lblDescripcionRecetaMostrar.Name = "lblDescripcionRecetaMostrar";
            this.lblDescripcionRecetaMostrar.Size = new System.Drawing.Size(38, 17);
            this.lblDescripcionRecetaMostrar.TabIndex = 6;
            this.lblDescripcionRecetaMostrar.Text = "label";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(252, 46);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(86, 17);
            this.lblIngredientes.TabIndex = 7;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // frmMostrarRecetascs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 329);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.lblDescripcionRecetaMostrar);
            this.Controls.Add(this.lblDescripcionReceta);
            this.Controls.Add(this.lblNombreRecetaMostrar);
            this.Controls.Add(this.lblNombreReceta);
            this.Controls.Add(this.lbIngredientes);
            this.Controls.Add(this.cbRecetas);
            this.Controls.Add(this.btnAceptarReceta);
            this.Name = "frmMostrarRecetascs";
            this.Text = "frmMostrarRecetascs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarReceta;
        private System.Windows.Forms.ComboBox cbRecetas;
        private System.Windows.Forms.ListBox lbIngredientes;
        private System.Windows.Forms.Label lblNombreReceta;
        private System.Windows.Forms.Label lblNombreRecetaMostrar;
        private System.Windows.Forms.Label lblDescripcionReceta;
        private System.Windows.Forms.Label lblDescripcionRecetaMostrar;
        private System.Windows.Forms.Label lblIngredientes;
    }
}