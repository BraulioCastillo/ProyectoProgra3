using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Datos
{
    class conex_super
    {

        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataAdapter adaptador;
        SqlDataReader dataReader;
        public string conection = "";


        #region metodos

        #region ingresaSuper
        public void ingresaSuper(int id, string nombre, string localidad, int IDDUeño)
        {
            try
            {
                if (validaIDSuper(id) == false)
                {
                    cnx = new SqlConnection(conection);
                    cnx.Open();
                    cmd = new SqlCommand("execute insertaSuper " + id + ", '" + nombre + "', '" + localidad + "', " + IDDUeño, cnx);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Súpermercado agregado.");
                    cnx.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error al ingresar el súpermercado, por favor intente nuevamente");
            }


        }

        private bool validaIDSuper(int id)
        {
            bool valida = false;

            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Supermercado" , cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            try
            {
                while (dataReader.Read())
                {
                    if (dataReader["ID"].ToString().Equals(id))
                    {
                        MessageBox.Show("El súpermercado ya existe");
                        return true;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, por favor inténtelo nuevamente");
            }
            cnx.Close();
            return valida;
        }

        #endregion


        #region modificaSuper
        public void modificaSuper(int id, string nombre, string localidad, string IDDueño)
        {

            
            try
            {
                cnx = new SqlConnection(conection);
                cnx.Open();
                cmd = new SqlCommand("execute modificaSuper " + id + ", '" + nombre + "', '" + localidad + "', " + IDDueño, cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al modificar el súpermercado");
            }

        }
        #endregion

        #endregion
    }
}
