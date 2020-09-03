using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class conex_factura
    {

        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String de Conexion

        #region metodos

        #region agrega factura

        public void agregaFactura(string fecha, double monto, int IDUsuario)
        {
            try
            {
                cnx = new SqlConnection(conection);
                cnx.Open();
                cmd = new SqlCommand("execute ingresaFactura '" + fecha + "', " + monto + ", " + IDUsuario, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Su compra se ha completado");
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Hubo un problema al procesar la compra, por favor inténtelo nuevamente");
            }
            
        }

        #endregion

        #endregion

    }
}
