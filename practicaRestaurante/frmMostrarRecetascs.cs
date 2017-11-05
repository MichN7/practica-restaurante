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
    public partial class frmMostrarRecetascs : Form
    {

        MySqlCommand comando;
        Conexion conBD = new Conexion();

        public frmMostrarRecetascs()
        {
            InitializeComponent();
            DataTable dtReceta = conBD.cargarDatos("SELECT * FROM receta");

            for (int i = 0; i < dtReceta.Rows.Count; i++)
            {
                cbRecetas.ValueMember = dtReceta.Rows[i][0].ToString();
                cbRecetas.Items.Add(dtReceta.Rows[i][2].ToString());
            }
        }

        private void btnAceptarReceta_Click(object sender, EventArgs e)
        {
            string descripcion;
            string nombre;
            //string[] ingredientes;
            List<string> ingredientes = new List<string>();

            DataTable dtReceta = conBD.cargarDatos("SELECT * FROM receta");
            for (int i = 0; i < dtReceta.Rows.Count; i++)
            {
                if (dtReceta.Rows[i][2].ToString() == cbRecetas.Text) {

                    descripcion = dtReceta.Rows[i][1].ToString();
                    lblDescripcionRecetaMostrar.Text = descripcion;

                    nombre = dtReceta.Rows[i][2].ToString();
                    lblNombreRecetaMostrar.Text = nombre;

                    string alpha = dtReceta.Rows[i][3].ToString();
                    var builder = new StringBuilder();
                    
                    foreach (var c in alpha)
                    {
                        if (c == '~')
                        {
                            ingredientes.Add(builder.ToString());
                            builder = new StringBuilder();
                        }
                        else
                        {
                            builder.Append(c);
                        }
                    }
                    
                }
            }

            foreach (string s in ingredientes) {
                lbIngredientes.Items.Add(s);
            }
        }
    }
}
