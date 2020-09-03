using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_
{
    public class conex_art
    {
        public string conexion = "";
        private SqlConnection v_cnx;
        private SqlCommand v_cmd;
        public SqlCommand cmd;
        public SqlConnection cnx;
        public string conection = "Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";


        public conex_art(String conn)
        {
            this.conexion = conn;
        }

        public SqlConnection con;

        public SqlConnection conecta()
        {
            return con = new SqlConnection(conexion);
        }
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
        #region METODOS ARTICULOS
        public Boolean insertar_articulo(int codigo, double precio, int stock, String detalle, PictureBox imagen)
        {
            Boolean insertado = false;
            try
            {
                SqlConnection Conexion = new SqlConnection(this.conexion);
                SqlCommand Comando = new SqlCommand();

                SqlParameter p_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                p_codigo.Value = codigo;

                SqlParameter p_costo = new SqlParameter("@precio", SqlDbType.Money);
                p_costo.Value = precio;

                SqlParameter p_stock = new SqlParameter("@existencias", SqlDbType.Int);
                p_stock.Value = stock;

                SqlParameter p_detalles = new SqlParameter("@detalle", SqlDbType.VarChar);
                p_detalles.Value = detalle;

                SqlParameter p_imagen = new SqlParameter("@imagen", SqlDbType.Image);
                p_imagen.Value = imagen;

                Comando.Parameters.Add(p_codigo);
                Comando.Parameters.Add(p_costo);
                Comando.Parameters.Add(p_stock);
                Comando.Parameters.Add(p_detalles);
                Comando.Parameters.Add(p_imagen);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Comando.Parameters["@imagen"].Value = ms.GetBuffer();

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "inserta_articulo";
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
        public Boolean actualizar_articulo(int codigo, double precio, int stock, String detalle, PictureBox imagen)
        {
            Boolean insertado = false;
            try
            {
                SqlConnection Conexion = new SqlConnection(this.conexion);
                SqlCommand Comando = new SqlCommand();

                SqlParameter p_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                p_codigo.Value = codigo;

                SqlParameter p_costo = new SqlParameter("@precio", SqlDbType.Money);
                p_costo.Value = precio;

                SqlParameter p_stock = new SqlParameter("@existencias", SqlDbType.Int);
                p_stock.Value = stock;

                SqlParameter p_detalles = new SqlParameter("@detalle", SqlDbType.VarChar);
                p_detalles.Value = detalle;

                SqlParameter p_imagen = new SqlParameter("@imagen", SqlDbType.Image);
                p_imagen.Value = imagen;

                Comando.Parameters.Add(p_codigo);
                Comando.Parameters.Add(p_costo);
                Comando.Parameters.Add(p_stock);
                Comando.Parameters.Add(p_detalles);
                Comando.Parameters.Add(p_imagen);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Comando.Parameters["@imagen"].Value = ms.GetBuffer();

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "actualizar_Articulo";
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
        public DataSet Consultar(int id)
        {
            DataSet ds = new DataSet();

            try
            {
                SqlConnection n = new SqlConnection(conexion);
                SqlDataAdapter consulta = new SqlDataAdapter("select * from Articulo where codigo = '" + id + "'", n);
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
        public bool delete_articulo(int codigo)
        {
            bool deleted = false;

            try
            {
                if (open())
                {
                    v_cmd = new SqlCommand("eliminar_articulo", v_cnx);
                    v_cmd.CommandType = CommandType.StoredProcedure;
                    v_cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
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
    }

}
