using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Datos
{

    public class conex_detalle
    {
        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String de Conexion
        public int numeroFactura()
        {
            int contador = 0;
            try
            {
                cnx = new SqlConnection(conection);
                cnx.Open();
                cmd = new SqlCommand("select * from Factura", cnx);
                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    contador++;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return contador;
        }

        public void ingresaDetalle(int idArticulo, int idFactura, int valorArticulo, int cantidad, int valorTotal)
        {

            try
            {
                cnx = new SqlConnection(conection);
                cnx.Open();
                cmd = new SqlCommand("execute ingresaDetalle " + idArticulo + ", " + idFactura + ", " + valorArticulo + ", " + cantidad + ", " + valorTotal, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha agregado el detalle correctamente");
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Ha ocurrido un problema mientras se ingresaba el detalle");
            }


        }

    }
}
