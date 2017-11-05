using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace practicaRestaurante
{
    class Conexion
    {
       

        public String strConexion = "server = localhost; user id = root; password = 123456; database = restaurant";

        public MySqlConnection conectar = new MySqlConnection("server = localhost; user id = root; password = 123456; database = restaurant");

        public void abrir() {
            try
            {
                conectar.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cerrar() {
            conectar.Close();
        }

        public DataTable cargarDatos(String query) {
            DataTable dt = new DataTable();
            try
            {
                abrir();
                MySqlDataAdapter comando = new MySqlDataAdapter(query, strConexion);
                comando.Fill(dt);
                cerrar();
                MessageBox.Show("Listo");
                return dt;

            }catch(Exception ex)
            {
                return dt;
            }
        }

        public bool ejecutarQuery(string query)
        {
            try
            {
                abrir();
                MySqlCommand comando = new MySqlCommand(query, conectar);
                comando.ExecuteNonQuery();
                cerrar();
                MessageBox.Show("Listo");
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
