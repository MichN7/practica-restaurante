using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaRestaurante
{
    public partial class MainMenu : Form
    {
        MySqlCommand comando;
        Conexion conBD = new Conexion();
        string strIngredientes = "";

        public MainMenu()
        {
            InitializeComponent();
            pnlAgregarReceta.Visible = false;
            

        }

        private void añadirNuevaRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAgregarReceta.Visible = true;
           
            
            cbIngredientes.Items.Clear();

            
            DataTable dtIngredientes = conBD.cargarDatos("SELECT * FROM ingrediente");

            

            for (int i = 0; i < dtIngredientes.Rows.Count; i++)
            {
                cbIngredientes.ValueMember = dtIngredientes.Rows[i][0].ToString();
                cbIngredientes.Items.Add(dtIngredientes.Rows[i][2].ToString());
            }

        }

        private void añadirNuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();
        }

        private void btnAgregarReceta_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcionReceta.Text;
            string nombre = txtNombreReceta.Text;
            string ingredientes = strIngredientes;

            string comando = "INSERT INTO receta (descripcion, nombre, ingredientes) VALUES('" 
                                       + descripcion + "','" + nombre + "','" + ingredientes +"');";
            
            conBD.ejecutarQuery(comando);
        }

        private void añadirIngredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngrediente ingrediente = new frmIngrediente();
            ingrediente.ShowDialog();
        }

        private void btnAgregarIngrediente_Click(object sender, EventArgs e)
        {
            dgvIngredientes.Rows.Add(cbIngredientes.Text);
            strIngredientes += cbIngredientes.Text + "~";
        }

        private void verPlatillosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostartPlatillos verPlatillo = new frmMostartPlatillos();
            verPlatillo.Show();
        }

        private void añadirPlatillosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlatillo platillo = new frmPlatillo();
            platillo.ShowDialog();
        }

        private void verMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesas mesas = new frmMesas();
            mesas.ShowDialog();
        }

        private void verRecetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarRecetascs recetas = new frmMostrarRecetascs();
            recetas.ShowDialog();
        }

        private void verCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarCuenta cuentas = new frmMostrarCuenta();
            cuentas.ShowDialog();
        }
    }
}
