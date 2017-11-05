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
    public partial class frmMostrarCuenta : Form
    {
        MySqlCommand comando;
        Conexion conBD = new Conexion();

        public frmMostrarCuenta()
        {
            InitializeComponent();

            
            DataTable dtCuenta = conBD.cargarDatos("SELECT * FROM cuenta");
            for (int i = 0; i < dtCuenta.Rows.Count; i++)
            {
                cbNombreCuenta.ValueMember = dtCuenta.Rows[i][0].ToString();
                cbNombreCuenta.Items.Add(dtCuenta.Rows[i][3].ToString());
            }

            btnCerrarCuenta.Visible = false;

        }

       

        private void btnMostrarCuenta_Click(object sender, EventArgs e)
        {
            DataTable dtCuenta = conBD.cargarDatos("SELECT * FROM cuenta");
            int idMesa = 0;
           
            for (int i = 0; i < dtCuenta.Rows.Count; i++)
            {
                if (cbNombreCuenta.Text == dtCuenta.Rows[i][3].ToString())
                {
                    idMesa = Int32.Parse(dtCuenta.Rows[i][4].ToString());
                }

            }

            string comandoDos = "UPDATE mesa SET ocupada ='0' WHERE id_mesa='" + idMesa + "';";
            conBD.ejecutarQuery(comandoDos);
        }

        private void dgvCuentas_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            btnCerrarCuenta.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dgvPedidos.Rows.Clear();
            DataTable dtCuenta = conBD.cargarDatos("SELECT * FROM cuenta");
            int idMesa = 0;
            int idCuenta = 0;
            int total = 0;
            string fecha = "";
            for (int i = 0; i < dtCuenta.Rows.Count; i++)
            {
                if (cbNombreCuenta.Text == dtCuenta.Rows[i][3].ToString()) {
                    idMesa = Int32.Parse(dtCuenta.Rows[i][4].ToString());
                    idCuenta = Int32.Parse(dtCuenta.Rows[i][0].ToString());
                    total = Int32.Parse(dtCuenta.Rows[i][2].ToString());
                    fecha = dtCuenta.Rows[i][1].ToString();
                }
                
            }
            
            DataTable dtMesa = conBD.cargarDatos("SELECT * FROM mesa WHERE id_mesa ="+idMesa+";");
            List<string> idsPlatillos = new List<string>();

            List<int> cantidadPlatillos = new List<int>();

            DataTable dtDetallesCuenta = conBD.cargarDatos("SELECT * FROM detalles_cuenta WHERE fkcuenta =" + idCuenta +";");
            for (int i = 0; i < dtDetallesCuenta.Rows.Count; i++)
            {
               idsPlatillos.Add(dtDetallesCuenta.Rows[i][2].ToString());
                cantidadPlatillos.Add(Int32.Parse(dtDetallesCuenta.Rows[i][1].ToString()));
            }

            DataTable dtPlatillos = conBD.cargarDatos("SELECT * FROM plato");
            for (int i = 0; i < dtPlatillos.Rows.Count; i++)
            {
                for (int j = 0; j < idsPlatillos.Count; j++)
                {
                    if (dtPlatillos.Rows[i][0].ToString() == idsPlatillos[j]) {
                        string nombre = dtPlatillos.Rows[i][1].ToString();
                        string descripcion = dtPlatillos.Rows[i][2].ToString();
                        string dificultad = dtPlatillos.Rows[i][3].ToString();
                        string precio = dtPlatillos.Rows[i][5].ToString();
                        dgvPedidos.Rows.Add(nombre, descripcion, dificultad, precio);

                    }
                    
                }
              
            }

            for (int k = 0; k < cantidadPlatillos.Count; k++)
            {
                int cantidad = Int32.Parse(dtDetallesCuenta.Rows[k][1].ToString());
                dgvPedidos.Rows[k].Cells[4].Value = cantidad;
            }

            lblTotalMostrar.Text = total.ToString();
            lblFechaMostrar.Text = fecha;
            btnCerrarCuenta.Visible = true;

        }
    }
}
