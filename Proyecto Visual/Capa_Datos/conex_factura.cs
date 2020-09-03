using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    class conex_factura
    {

        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String de Conexion

        #region metodos

        #region agrega factura

        public void agregaFactura(string fecha, double monto, int IDUsuario)
        {
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("execute ingresaFactura '" + fecha + "', " + 10000 + ", "+ 123, cnx);
            cmd.ExecuteNonQuery();
        }

        #endregion

        #endregion

    }
}
