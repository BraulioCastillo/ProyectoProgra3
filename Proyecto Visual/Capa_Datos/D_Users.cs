using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using ENTIDAD;

namespace DATOS
{
    public class D_Users
    {

        SqlConnection cn = new SqlConnection("Data Source = BRAULIO\\SQSLEXPRESS; Initial Catalog = ProyectoFinal; Integrated Security = True");

        //ConfigurationManager.ConnectionStrings["sql"].ConnectionString

        public DataTable D_user(E_Users obje) 
        {

            SqlCommand cmd = new SqlCommand("Logueo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@clave", obje.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
