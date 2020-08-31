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
    public class conex_factura
    {
        private SqlConnection v_cnx;
        private SqlCommand v_cmd;
        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataAdapter adaptador;
        DataTable tblfactura;
        Conexion Objcon = new Conexion();
        public string conection = "Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=base_facturacion;Integrated Security=True";


        #region METODOS FACTURA
        public bool Inserta_factura(factura Factura)
        {
            bool inserta = false;
            try
            {
                if (Objcon.Open_cnx())
                {
                    Objcon.cmd = new SqlCommand("Crear_factura", Objcon.cnx);
                    Objcon.cmd.CommandType = CommandType.StoredProcedure;
                    Objcon.cmd.Parameters.Add("@fecha", SqlDbType.VarChar).Value = Factura.c_fecha;
                    Objcon.cmd.Parameters.Add("@modalidad_pago", SqlDbType.VarChar).Value = Factura.c_modalidad_pago;
                    Objcon.cmd.Parameters.Add("@monto_total", SqlDbType.Int).Value = Factura.c_monto_total;
                    Objcon.cmd.Parameters.Add("@impuestos", SqlDbType.Int).Value = Factura.c_impuestos;
                    Objcon.cmd.Parameters.Add("@id_cliente", SqlDbType.VarChar).Value = Factura.c_id_cliente;
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

        public bool update_Factura(factura fact, int ID)
        {
            bool updated = false;

            try
            {
                if (open())
                {
                    v_cmd = new SqlCommand("actualizar_Factura", v_cnx);
                    v_cmd.CommandType = CommandType.StoredProcedure;
                    v_cmd.Parameters.Add("@num_factura", SqlDbType.Int).Value = ID;
                    v_cmd.Parameters.Add("@monto_total", SqlDbType.Int).Value = fact.c_monto_total;
                    v_cmd.Parameters.Add("@impuestos", SqlDbType.Int).Value = fact.c_impuestos;
                    v_cmd.ExecuteNonQuery();
                    updated = true;
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
            return updated;
        }
        //*******************************************************************
        public DataTable Get_factura(int idFactura)
        {
            try
            {
                v_cnx = new SqlConnection(this.conection);
                adaptador = new SqlDataAdapter("Select * from Facturas where num_factura = '" + idFactura + "'", v_cnx);
                tblfactura = new DataTable();

                v_cnx.Open();
                adaptador.Fill(tblfactura);
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
            return tblfactura;
        }
        //*******************************************************************
        //**********************************
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
