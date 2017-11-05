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
    public partial class frmPlatillo : Form
    {

        MySqlCommand comando;
        Conexion conBD = new Conexion();

        public frmPlatillo()
        {
            InitializeComponent();

            cbReceta.Items.Clear();


            DataTable dtReceta = conBD.cargarDatos("SELECT * FROM receta");

            DataTable dtCategoria = conBD.cargarDatos("SELECT * FROM categoria");

            for (int i = 0; i < dtCategoria.Rows.Count; i++)
            {
                cbCategoria.ValueMember = dtCategoria.Rows[i][0].ToString();
                cbCategoria.Items.Add(dtCategoria.Rows[i][1].ToString());
            }

            for (int i = 0; i < dtReceta.Rows.Count; i++)
            {
                cbReceta.ValueMember = dtReceta.Rows[i][0].ToString();
                cbReceta.Items.Add(dtReceta.Rows[i][2].ToString());
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            this.opdPlatillo.ShowDialog();
        }

        private void opdPlatillo_FileOk(object sender, CancelEventArgs e)
        {
            this.pbPlatillo.Image = Image.FromFile(this.opdPlatillo.FileName);
        }

        private void btnAgregarPlatillo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePlatillo.Text;
            string descripcion = txtDescripcionPlatillo.Text;
            string dificultad = cbDificultad.Text;
            string foto = this.opdPlatillo.FileName;
            int precio = Int32.Parse(txtPrecio.Text);
            int fk_id_receta = cbReceta.SelectedIndex+1;
            int fk_id_categoria = cbCategoria.SelectedIndex+1;

            MessageBox.Show(foto);
            //ANTES DE SUBIR A LA BD AÑADIR DOBLE "//" Y SUBIRLO
            var builder = new StringBuilder();

            foreach (var c in foto)
            {
                string change = c.ToString();
                builder.Append(c);
                if (change == "\\")
                {
                    builder.Append("\\");
                }
               
            }
            foto = builder.ToString();
            MessageBox.Show(foto);
            MessageBox.Show(fk_id_categoria.ToString());

            string comando = "INSERT INTO plato (nombre, descripcion, dificultad, foto, precio, fk_id_receta, fk_id_categoria) VALUES ('"+nombre+"', '"+descripcion+"', '"+dificultad+"', '"+foto+"', "+precio+", "+fk_id_receta+", "+fk_id_categoria+");";
            conBD.ejecutarQuery(comando);
        }
    }
}
