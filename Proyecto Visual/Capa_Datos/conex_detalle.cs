using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Negocios;

namespace Datos_
{
    public class conex_detalle
    {
        private SqlConnection v_cnx;
        //private SqlCommand v_cmd;
        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataAdapter adaptador;
        DataTable tblDetalles;
        Conexion Objcon = new Conexion();
        public string conection = "Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=base_facturacion;Integrated Security=True";


        #region METODOS DETALLES
        public bool Inserta_detalle(Detalles detalle)
        {
            bool inserta = false;
            try
            {
                if (Objcon.Open_cnx())
                {
                    Objcon.cmd = new SqlCommand("Crear_detalle", Objcon.cnx);
                    Objcon.cmd.CommandType = CommandType.StoredProcedure;
                    Objcon.cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = detalle.c_cantidad;
                    Objcon.cmd.Parameters.Add("@precio_producto", SqlDbType.Int).Value = detalle.c_precio_producto;
                    Objcon.cmd.Parameters.Add("@nombre_art", SqlDbType.VarChar).Value = detalle.c_nombre_art;
                    Objcon.cmd.Parameters.Add("@total", SqlDbType.Int).Value = detalle.c_total;
                    Objcon.cmd.Parameters.Add("@id_producto", SqlDbType.Int).Value = detalle.c_id_producto;
                    Objcon.cmd.Parameters.Add("@num_factura", SqlDbType.Int).Value = detalle.c_num_factura;

                    Objcon.cmd.ExecuteNonQuery();
                    inserta = true;
                }
            }
            catch (Exception e)
            {

                throw e;
                //Console.WriteLine(e.ToString());
                //inserta = false;
            }

            return inserta;
        }
        public string m_numero_detalle()
        {
            SqlCommand cmd = new SqlCommand();

            Detalles objins = new Detalles();
            try
            {
                Objcon.Open_cnx();

                Objcon.cmd = new SqlCommand("ID_detalle", Objcon.cnx);
                Objcon.cmd.CommandType = CommandType.StoredProcedure;


                SqlDataReader ObjReader = Objcon.cmd.ExecuteReader();
                if (ObjReader.Read())
                {

                    objins.c_id_detalle = ObjReader["NumeroB"].ToString();
                }
                Objcon.cnx.Close();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return objins.c_id_detalle;
        }

        //****************************************************************
        //CODIGO PARA REALIZAR CONSULTAS DE PRODUCTOS A LA BASE DE DATOS
        public DataTable Get_Detalles(int numFactura)
        {
            try
            {
                v_cnx = new SqlConnection(this.conection);
                adaptador = new SqlDataAdapter("Select * from Detalles where num_factura = '" + numFactura + "'", v_cnx);
                tblDetalles = new DataTable();

                v_cnx.Open();
                adaptador.Fill(tblDetalles);
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
            return tblDetalles;
        }

        #endregion
        #region cnx
        public bool Open_cnx()
        {
            try
            {
                cnx = new SqlConnection(this.conection);
                cnx.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        private void Close_cnx()
        {
            try
            {
                cnx.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        #endregion
    }
}

