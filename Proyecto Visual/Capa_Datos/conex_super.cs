using Capa_Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class conex_super
    {

        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String de conexion


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
        public void modificaSuper(int id, string nombre, string localidad, int IDDueño)
        {

            
            try
            {
                cnx = new SqlConnection(conection);
                cnx.Open();
                cmd = new SqlCommand("execute modificaSuper " + id + ", '" + nombre + "', '" + localidad + "', " + IDDueño, cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Súpermercado actualizado.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar el súpermercado");
            }

        }

        public Supermercado cargaDatosSuper(int id)
        {
            Supermercado super = new Supermercado();
            try
            {
                cnx = new SqlConnection(conection);
                cnx.Open();
                cmd = new SqlCommand("select * from Supermercado where ID =" + id, cnx);
                cmd.ExecuteNonQuery();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    super.IDEncargado = int.Parse(dataReader["ID_dueno"].ToString());
                    super.IDSuper = int.Parse(dataReader["ID"].ToString());
                    super.Nombre = dataReader["nombre"].ToString();
                    super.Localidad = dataReader["localidad"].ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al cargar los datos, por favor intente nuevamente");
            }
            return super;
        }

        #endregion

        #endregion
    }
}
