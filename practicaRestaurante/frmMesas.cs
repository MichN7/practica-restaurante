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
    public partial class frmMesas : Form
    {

        MySqlCommand comando;
        Conexion conBD = new Conexion();
        int total = 0;

        public frmMesas()
        {
            InitializeComponent();
            pnlCuenta.Visible = false;

            DataTable dtMesas = conBD.cargarDatos("SELECT * FROM mesa");
            DataTable dtPlatos = conBD.cargarDatos("SELECT * FROM plato");
           

            for (int i = 0; i < dtMesas.Rows.Count; i++)
            {
                cbNumeroMesa.ValueMember = dtMesas.Rows[i][0].ToString();
                cbNumeroMesa.Items.Add(dtMesas.Rows[i][0].ToString());
                
            }

            for (int i = 0; i < dtPlatos.Rows.Count; i++)
            {
                cbPlato.ValueMember = dtPlatos.Rows[i][0].ToString();
                cbPlato.Items.Add(dtPlatos.Rows[i][1].ToString());
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroMesa = cbNumeroMesa.Text;
            int total = 0;
            int fk_id_mesa = cbNumeroMesa.SelectedIndex + 1;
            string nombre = txtNombreMesa.Text;

            DataTable dtMesas = conBD.cargarDatos("SELECT * FROM mesa");

            int mesaAct = Int32.Parse(numeroMesa);  
            string mesaOcupada = dtMesas.Rows[mesaAct-1][2].ToString();

            

            if (mesaOcupada == "0") {

                string comando = "INSERT INTO cuenta (fecha, total, nombreMesa,fk_id_mesa ) VALUES (NOW()," + 0 + ",'" + nombre + "'," + fk_id_mesa + ");";
                conBD.ejecutarQuery(comando);

                string comandoDos = "UPDATE mesa SET ocupada ='1' WHERE id_mesa='"+cbNumeroMesa.Text+"';";
                conBD.ejecutarQuery(comandoDos);
                pnlCuenta.Visible = true;

                DataTable dtCuenta = conBD.cargarDatos("SELECT * FROM cuenta");

                for (int i = 0; i < dtCuenta.Rows.Count; i++)
                {   
                    cbNombreMesa.ValueMember = dtCuenta.Rows[i][0].ToString();
                    cbNombreMesa.Items.Add(dtCuenta.Rows[i][3].ToString());
                }
            }
            else
            {
                MessageBox.Show("La mesa está ocupada");
            }
            
        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            DataTable dtPlato = conBD.cargarDatos("SELECT * FROM plato;");
            
            if (dtPlato != null)
            {
                for (int i = 0; i < dtPlato.Rows.Count; i++)
                {
                    if(dtPlato.Rows[i][1].ToString() == cbPlato.Text)
                    {
                        dgvPlatos.Rows.Add(dtPlato.Rows[i][1].ToString(), dtPlato.Rows[i][5].ToString(),txtCantidad.Text);
                        total += Int32.Parse(dtPlato.Rows[i][5].ToString()) * Int32.Parse(txtCantidad.Text);
                    }
                   
                    
                }

                int cantidad = Int32.Parse(txtCantidad.Text);
                int fk_id_plato = cbPlato.SelectedIndex+1;
                int fk_id_cuenta = cbNombreMesa.SelectedIndex+1;

                string comando = "INSERT INTO detalles_cuenta (cantidad, fk_id_plato,fkcuenta ) VALUES ("+cantidad+","+fk_id_plato+","+fk_id_cuenta+");";
                conBD.ejecutarQuery(comando);

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAceptarCuenta_Click(object sender, EventArgs e)
        {
            int totalUpdate = total;
            DataTable dtCuenta = conBD.cargarDatos("SELECT * FROM cuenta;");
            
            for (int i = 0; i < dtCuenta.Rows.Count; i++)
            {
                if (dtCuenta.Rows[i][3].ToString() == cbNombreMesa.Text)
                {
                    total += Int32.Parse(dtCuenta.Rows[i][2].ToString());
                }
                    
            }
            string nombreMesa = cbNombreMesa.Text;
            string comando = "UPDATE cuenta SET total=" + total + " WHERE nombreMesa='"+ nombreMesa+"';";
            conBD.ejecutarQuery(comando);
        }

        private void bntAgregarPlatillo_Click(object sender, EventArgs e)
        {
            pnlCuenta.Visible = true;
            DataTable dtCuenta = conBD.cargarDatos("SELECT * FROM cuenta");

            for (int i = 0; i < dtCuenta.Rows.Count; i++)
            {
                cbNombreMesa.ValueMember = dtCuenta.Rows[i][0].ToString();
                cbNombreMesa.Items.Add(dtCuenta.Rows[i][3].ToString());
            }
        }
    }
}
