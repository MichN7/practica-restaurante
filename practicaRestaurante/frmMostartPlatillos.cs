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
    public partial class frmMostartPlatillos : Form
    {

        MySqlCommand comando;
        Conexion conBD = new Conexion();

        public frmMostartPlatillos()
        {
            InitializeComponent();

            cbPlatillos.Items.Clear();


            DataTable dtPlatillos= conBD.cargarDatos("SELECT * FROM plato");

            for (int i = 0; i < dtPlatillos.Rows.Count; i++)
            {
                cbPlatillos.ValueMember = dtPlatillos.Rows[i][0].ToString();
                cbPlatillos.Items.Add(dtPlatillos.Rows[i][1].ToString());
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dtPlatillos = conBD.cargarDatos("SELECT * FROM plato");
            string nombre;
            string descripcion;
            string dificultad;
            string foto;
            string precio;

            for (int i = 0; i < dtPlatillos.Rows.Count; i++)
            {
                if (dtPlatillos.Rows[i][1].ToString() == cbPlatillos.Text) {

                    nombre = dtPlatillos.Rows[i][1].ToString();
                    lblNombrePlatilloMostrar.Text = nombre;

                    descripcion = dtPlatillos.Rows[i][2].ToString();
                    lblDescripcionPlatilloMostrar.Text = descripcion;

                    dificultad = dtPlatillos.Rows[i][3].ToString();
                    lblDificultadPlatilloMostrar.Text = dificultad;

                    foto = dtPlatillos.Rows[i][4].ToString();
                    this.pictureBox1.Image = Image.FromFile(foto);

                    precio = dtPlatillos.Rows[i][5].ToString();
                    lblPrecioPlatilloMostrar.Text = precio;
                }
            }

            

        }

       
    }
}
