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
    public partial class frmCategoria : Form
    {
        MySqlCommand comando;
        Conexion conBD = new Conexion();

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            dgvCategorias.Rows.Clear();
            DataTable dtCategorias = conBD.cargarDatos("SELECT * FROM categoria");
            if (dtCategorias != null)
            {
                dgvCategorias.DataSource = dtCategorias;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAgregarcategoria_Click(object sender, EventArgs e)
        {
            string comando = "INSERT INTO categoria (nombre, descripcion, encargado) VALUES('" + txtNombreCategoria.Text + "','" + txtDescripcionCategoria.Text + "','" + txtEncargadoCategoria.Text + "');";

            conBD.ejecutarQuery(comando);
        }
    }
}
