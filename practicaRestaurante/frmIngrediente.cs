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
    public partial class frmIngrediente : Form
    {
        MySqlCommand comando;
        Conexion conBD = new Conexion();

        public frmIngrediente()
        {
            InitializeComponent();
        }

        private void btnAgregarIngrediente_Click(object sender, EventArgs e)
        {
            string comando = "INSERT INTO ingrediente (cantidad_almacen, nombre) VALUES('" + txtCantidad.Text + "','" + txtNombreIngrediente.Text +"');";

            conBD.ejecutarQuery(comando);
        }

      

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            dgvIngredientes.Rows.Clear();
            DataTable dtIngredientes = conBD.cargarDatos("SELECT * FROM ingrediente");
            if (dtIngredientes != null)
            {
                dgvIngredientes.DataSource = dtIngredientes;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
