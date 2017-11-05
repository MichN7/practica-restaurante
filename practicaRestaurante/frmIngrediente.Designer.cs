namespace practicaRestaurante
{
    partial class frmIngrediente
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
            this.pnlIngrediente = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtNombreIngrediente = new System.Windows.Forms.TextBox();
            this.lblNombreIngrediente = new System.Windows.Forms.Label();
            this.btnAgregarIngrediente = new System.Windows.Forms.Button();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.pnlIngrediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIngrediente
            // 
            this.pnlIngrediente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlIngrediente.Controls.Add(this.txtCantidad);
            this.pnlIngrediente.Controls.Add(this.lblCantidad);
            this.pnlIngrediente.Controls.Add(this.txtNombreIngrediente);
            this.pnlIngrediente.Controls.Add(this.lblNombreIngrediente);
            this.pnlIngrediente.Controls.Add(this.btnAgregarIngrediente);
            this.pnlIngrediente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlIngrediente.Location = new System.Drawing.Point(27, 35);
            this.pnlIngrediente.Name = "pnlIngrediente";
            this.pnlIngrediente.Size = new System.Drawing.Size(312, 216);
            this.pnlIngrediente.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(19, 103);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(181, 22);
            this.txtCantidad.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(16, 83);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtNombreIngrediente
            // 
            this.txtNombreIngrediente.Location = new System.Drawing.Point(19, 44);
            this.txtNombreIngrediente.Name = "txtNombreIngrediente";
            this.txtNombreIngrediente.Size = new System.Drawing.Size(181, 22);
            this.txtNombreIngrediente.TabIndex = 3;
            // 
            // lblNombreIngrediente
            // 
            this.lblNombreIngrediente.AutoSize = true;
            this.lblNombreIngrediente.Location = new System.Drawing.Point(16, 21);
            this.lblNombreIngrediente.Name = "lblNombreIngrediente";
            this.lblNombreIngrediente.Size = new System.Drawing.Size(133, 17);
            this.lblNombreIngrediente.TabIndex = 2;
            this.lblNombreIngrediente.Text = "Nombre Ingrediente";
            // 
            // btnAgregarIngrediente
            // 
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(134, 154);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(162, 35);
            this.btnAgregarIngrediente.TabIndex = 1;
            this.btnAgregarIngrediente.Text = "Agregar Ingrediente";
            this.btnAgregarIngrediente.UseVisualStyleBackColor = true;
            this.btnAgregarIngrediente.Click += new System.EventHandler(this.btnAgregarIngrediente_Click);
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Location = new System.Drawing.Point(410, 35);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.RowTemplate.Height = 24;
            this.dgvIngredientes.Size = new System.Drawing.Size(306, 216);
            this.dgvIngredientes.TabIndex = 8;
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Location = new System.Drawing.Point(493, 286);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(223, 27);
            this.btnIngredientes.TabIndex = 9;
            this.btnIngredientes.Text = "Consultar ingredientes";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // frmIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 342);
            this.Controls.Add(this.btnIngredientes);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.pnlIngrediente);
            this.Name = "frmIngrediente";
            this.Text = "frmIngrediente";
            this.pnlIngrediente.ResumeLayout(false);
            this.pnlIngrediente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIngrediente;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtNombreIngrediente;
        private System.Windows.Forms.Label lblNombreIngrediente;
        private System.Windows.Forms.Button btnAgregarIngrediente;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.Button btnIngredientes;
    }
}