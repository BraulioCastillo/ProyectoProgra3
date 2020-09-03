using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using ENTIDAD;
using System.Windows.Forms;

namespace DATOS
{
    public class D_Users
    {public string conexion = "";
        private SqlConnection v_cnx;
        private SqlCommand v_cmd;
        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlConnection cn = new SqlConnection("Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        public string conection = "Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";
        DataTable tblUsuarios;
        SqlDataAdapter adaptador;


        public D_Users(String conn)
        {
            this.conexion = conn;
        }
        public D_Users()
        {
            
        }
        public DataTable D_user(E_Users obje) 
        {
            SqlCommand cmd = new SqlCommand("Logueo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", obje.usuario);
            cmd.Parameters.AddWithValue("@contraseña", obje.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #region METODOS USUARIOS
        public Boolean insertar_usuario(int ID, string pass, string nombre, string apellidos, int telefono, string email, string direccion, string roll)
        {
            Boolean insertado = false;
            try
            {
                SqlConnection Conexion = new SqlConnection(this.conexion);
                SqlCommand Comando = new SqlCommand();

                SqlParameter p_ID = new SqlParameter("@ID", SqlDbType.Int);
                p_ID.Value = ID;

                SqlParameter p_contraseña = new SqlParameter("@contraseña", SqlDbType.VarChar);
                p_contraseña.Value = pass;

                SqlParameter p_nombre = new SqlParameter("@nombre", SqlDbType.VarChar);
                p_nombre.Value = nombre;

                SqlParameter p_detalles = new SqlParameter("@apellidos", SqlDbType.VarChar);
                p_detalles.Value = apellidos;

                SqlParameter p_telefono = new SqlParameter("@telefono", SqlDbType.Int);
                p_telefono.Value = telefono;

                SqlParameter p_email = new SqlParameter("@email", SqlDbType.VarChar);
                p_email.Value = email;

                SqlParameter p_direccion = new SqlParameter("@direccion", SqlDbType.VarChar);
                p_direccion.Value = direccion;

                SqlParameter p_rol = new SqlParameter("@rol", SqlDbType.VarChar);
                p_rol.Value = roll;

                Comando.Parameters.Add(p_ID);
                Comando.Parameters.Add(p_contraseña);
                Comando.Parameters.Add(p_nombre);
                Comando.Parameters.Add(p_detalles);
                Comando.Parameters.Add(p_telefono);
                Comando.Parameters.Add(p_email);
                Comando.Parameters.Add(p_direccion);
                Comando.Parameters.Add(p_rol);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "inserta_usuario";
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.ExecuteNonQuery();
                Conexion.Close();
                insertado = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return insertado;
        }

        //********************************************************************
        public Boolean actualizar_articulo(int ID, string pass, string nombre, string apellidos, int telefono, string email, string direccion, string roll)
        {
            Boolean insertado = false;
            try
            {
                SqlConnection Conexion = new SqlConnection(this.conexion);
                SqlCommand Comando = new SqlCommand();

                SqlParameter p_ID = new SqlParameter("@ID", SqlDbType.Int);
                p_ID.Value = ID;

                SqlParameter p_contraseña = new SqlParameter("@contraseña", SqlDbType.VarChar);
                p_contraseña.Value = pass;

                SqlParameter p_nombre = new SqlParameter("@nombre", SqlDbType.VarChar);
                p_nombre.Value = nombre;

                SqlParameter p_detalles = new SqlParameter("@apellidos", SqlDbType.VarChar);
                p_detalles.Value = apellidos;

                SqlParameter p_telefono = new SqlParameter("@telefono", SqlDbType.Int);
                p_telefono.Value = telefono;

                SqlParameter p_email = new SqlParameter("@email", SqlDbType.VarChar);
                p_email.Value = email;

                SqlParameter p_direccion = new SqlParameter("@direccion", SqlDbType.VarChar);
                p_direccion.Value = direccion;

                SqlParameter p_rol = new SqlParameter("@rol", SqlDbType.VarChar);
                p_rol.Value = roll;

                Comando.Parameters.Add(p_ID);
                Comando.Parameters.Add(p_contraseña);
                Comando.Parameters.Add(p_nombre);
                Comando.Parameters.Add(p_detalles);
                Comando.Parameters.Add(p_telefono);
                Comando.Parameters.Add(p_email);
                Comando.Parameters.Add(p_direccion);
                Comando.Parameters.Add(p_rol);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "actualizar_usuario";
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.ExecuteNonQuery();
                Conexion.Close();
                insertado = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return insertado;
        }

        #endregion
        //*****************************************************************************
        public DataSet Consultar_Persona(int id)
        {
            DataSet ds = new DataSet();

            try
            {
                SqlConnection n = new SqlConnection(conexion);
                SqlDataAdapter consulta = new SqlDataAdapter("select * from Persona", n);
                consulta.Fill(ds);
                n.Close();
            }

            catch (Exception e)
            {
                throw e;
            }
            return ds;
        }
        //*****************************************************************************
        public bool delete_usuario(int id)
        {
            bool deleted = false;

            try
            {
                if (open())
                {
                    v_cmd = new SqlCommand("eliminar_usuario", v_cnx);
                    v_cmd.CommandType = CommandType.StoredProcedure;
                    v_cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
                    v_cmd.ExecuteNonQuery();
                    deleted = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Close();
            }
            return deleted;
        }

        //**************************************************************************************
        public DataTable Get_Usuarios()
        {
            try
            {
                v_cnx = new SqlConnection(this.conection);
                adaptador = new SqlDataAdapter("select * from Persona", v_cnx);
                tblUsuarios = new DataTable();

                v_cnx.Open();
                adaptador.Fill(tblUsuarios);
                v_cnx.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                v_cnx.Close();
            }
            return tblUsuarios;
        }
        //***********************************
        #region Open and Close Conexion

        public bool open()
        {
            try
            {
                v_cnx = new SqlConnection(this.conection);
                v_cnx.Open();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Close()
        {
            try
            {
                v_cnx.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}
