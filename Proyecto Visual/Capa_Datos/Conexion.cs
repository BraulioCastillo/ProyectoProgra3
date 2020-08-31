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
    public class Conexion
    {
        SqlDataAdapter adaptador;
        DataTable tblProductos;
        DataTable tblUsuarios;
        DataTable tblClientes;
        private SqlConnection v_cnx;
        private SqlCommand v_cmd;
        public SqlCommand cmd;
        public SqlConnection cnx;
        public string conection = "Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=base_facturacion;Integrated Security=True";

        #region Open and Close Conexion
        public Conexion(string conn)
        {
            this.conection = conn;
        }
        public Conexion() 
        {

        }
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

        #region Metodos Validación
        public string[] validarIngreso(int ID, string Pass)
        {
            string[] usuario = new string[3];
          
            try
            {
                SqlConnection Conection = new SqlConnection(this.conection);
                SqlCommand Comando = new SqlCommand("Select * from Usuarios where ID = '" + ID + "' and Pass = '" + Pass + "'", Conection);
               
                Conection.Open();
                SqlDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario[0] = reader["ID"].ToString();
                    usuario[1] = (reader["Pass"].ToString());
                    usuario[2] = (reader["Roll"].ToString());
                }

                Conection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return usuario;
        }
        //*******************************************************************
        //*******************************************************************
        //*********************OBTENER NUMERO DE FACTURA

        public int obtener_numero_factura()
        {
            int lastId;
            try
            {
                SqlConnection Conection = new SqlConnection(this.conection);
                Conection.Open();
                string query = "select ISNULL(MAX(num_factura), 0) AS Num_Factura from Facturas";
                SqlCommand command = new SqlCommand(query, Conection);
                lastId = Convert.ToInt32(command.ExecuteScalar());
                Conection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return lastId;
        }
        //*******************************************************************
        #endregion

        #region Metodos Producto
        public bool insertar_Producto(Producto producto)
        {
            bool inserta = false;
            try
            {
                if (open())
                {
                    v_cmd = new SqlCommand("inserta_producto", v_cnx);
                    v_cmd.CommandType = CommandType.StoredProcedure;
                    v_cmd.Parameters.Add("@id_producto", SqlDbType.Int).Value = producto.ID_Producto;
                    v_cmd.Parameters.Add("@nombre_producto", SqlDbType.VarChar).Value = producto.Nombre_Producto;
                    v_cmd.Parameters.Add("@precio", SqlDbType.VarChar).Value = producto.Precio_Producto;
                    v_cmd.Parameters.Add("@stock", SqlDbType.VarChar).Value = producto.Stock;
                    v_cmd.ExecuteNonQuery();
                    inserta = true;
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
            return inserta;
        }
        //****************************************************************
        //CODIGO PARA REALIZAR CONSULTAS DE PRODUCTOS A LA BASE DE DATOS
        public DataTable Get_Productos()
        {
            try
            {
                v_cnx = new SqlConnection(this.conection);
                adaptador = new SqlDataAdapter("select * from Producto", v_cnx);
                tblProductos = new DataTable();

                v_cnx.Open();
                adaptador.Fill(tblProductos);
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
            return tblProductos;
        }
        //*******************************************************************
        public DataTable Get_Producto_Especfico(int idProducto)
        {
            try
            {
                v_cnx = new SqlConnection(this.conection);
                adaptador = new SqlDataAdapter("Select * from Productos where id_producto = '" + idProducto + "'", v_cnx);
                tblProductos = new DataTable();

                v_cnx.Open();
                adaptador.Fill(tblProductos);
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
            return tblProductos;
        }
        //*******************************************************************
        //*********************CONSULTAR PRODUCTO POR NOMBRE
        public DataTable Get_Producto_PorNombre(string nombreProducto)
        {
            try
            {
                v_cnx = new SqlConnection(this.conection);
                adaptador = new SqlDataAdapter("Select * from Producto where nombre_producto = '" + nombreProducto + "'", v_cnx);
                tblProductos = new DataTable();

                v_cnx.Open();
                adaptador.Fill(tblProductos);
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
            return tblProductos;
        }
        //*******************************************************************
        //*******************************************************************
        //*********************OBTENER ID PRODUCTO Y PRECIO POR NOMBRE

        public string[] obtener_id_producto(string nombreProducto)
        {
            string[] datosProducto = new string[1];

            try
            {
                SqlConnection Conection = new SqlConnection(this.conection);
                SqlCommand Comando1 = new SqlCommand("select id_producto from Producto where nombre_producto = '" + nombreProducto + "'", Conection);
                Conection.Open();
                SqlDataReader reader1 = Comando1.ExecuteReader();

                if (reader1.Read())
                {
                    datosProducto[0] = reader1["id_producto"].ToString();
                }

                Conection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return datosProducto;
        }
        //*******************************************************************
        public string[] obtener_precio_producto(string nombreProducto)
        {
            string[] datosProducto = new string[1];

            try
            {
                SqlConnection Conection = new SqlConnection(this.conection);
                SqlCommand Comando1 = new SqlCommand("select precio from Producto where nombre_producto = '" + nombreProducto + "'", Conection);
                Conection.Open();
                SqlDataReader reader1 = Comando1.ExecuteReader();

                if (reader1.Read())
                {
                    datosProducto[0] = reader1["precio"].ToString();
                }

                Conection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return datosProducto;
        }
        //*******************************************************************
        //*******************************************************************
        public bool update_Producto(Producto producto, int codigo)
        {
            bool updated = false;

            try
            {
                if (open())
                {
                    v_cmd = new SqlCommand("actualizar_Producto", v_cnx);
                    v_cmd.CommandType = CommandType.StoredProcedure;
                    v_cmd.Parameters.Add("@id_producto", SqlDbType.VarChar).Value = codigo;
                    v_cmd.Parameters.Add("@nombre_producto", SqlDbType.VarChar).Value = producto.Nombre_Producto;
                    v_cmd.Parameters.Add("@precio", SqlDbType.VarChar).Value = producto.Precio_Producto;
                    v_cmd.Parameters.Add("@stock", SqlDbType.VarChar).Value = producto.Stock;
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
        //**********************************
        public bool delete_Producto(Producto producto, int codigo)
        {
            bool deleted = false;

            try
            {
                if (open())
                {
                    v_cmd = new SqlCommand("eliminar_producto", v_cnx);
                    v_cmd.CommandType = CommandType.StoredProcedure;
                    v_cmd.Parameters.Add("@id_producto", SqlDbType.VarChar).Value = codigo;
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

        #endregion

        #region Metodos Usuario
       
        public bool insertar_Usuario(Usuarios Usuario)
        {
            bool inserta = false;
            try
            {
                if (open())
                {
                    v_cmd = new SqlCommand("inserta_usuario", v_cnx);
                    v_cmd.CommandType = CommandType.StoredProcedure;
                    v_cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Usuario.ID;
                    v_cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Usuario.Pass;
                    v_cmd.Parameters.Add("@Roll", SqlDbType.VarChar).Value = Usuario.Roll;
                    v_cmd.ExecuteNonQuery();
                    inserta = true;
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
            return inserta;
        }
        //****************************************************************
        //CODIGO PARA REALIZAR CONSULTAS DE USUARIOS A LA BASE DE DATOS
        public DataTable Get_Usuarios()
        {
            try
            {
                v_cnx = new SqlConnection(this.conection);
                adaptador = new SqlDataAdapter("select * from Usuarios", v_cnx);
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
        //*******************************************************************
        public bool update_usuario(Usuarios usuario, int codigo)
        {
            bool updated = false;

            try
            {
                if (open())
                {
                    v_cmd = new SqlCommand("actualizar_usuario", v_cnx);
                    v_cmd.CommandType = CommandType.StoredProcedure;
                    v_cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = codigo;
                    v_cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = usuario.Pass;
                    v_cmd.Parameters.Add("@Roll", SqlDbType.VarChar).Value = usuario.Roll;
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
        //**********************************
        public bool delete_usuario(Usuarios usuario, int codigo)
        {
            bool deleted = false;

            try
            {
                if (open())
                {
                    v_cmd = new SqlCommand("eliminar_usuario", v_cnx);
                    v_cmd.CommandType = CommandType.StoredProcedure;
                    v_cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = codigo;
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
        #endregion

        #region Metodos Clientes
        public bool insertar_cliente(Cliente cliente)
        {
            bool inserta = false;
            try
            {
                if (open())
                {
                    v_cmd = new SqlCommand("crear_cliente", v_cnx);
                    v_cmd.CommandType = CommandType.StoredProcedure;
                    v_cmd.Parameters.Add("@id_cliente", SqlDbType.Int).Value = cliente.ID_cliente;
                    v_cmd.Parameters.Add("@nombre_cliente", SqlDbType.VarChar).Value = cliente.Nombre_Cliente;
                    v_cmd.Parameters.Add("@nombre_empresa", SqlDbType.VarChar).Value = cliente.Nombre_Empresa;
                    v_cmd.Parameters.Add("@tipo_cliente", SqlDbType.VarChar).Value = cliente.Tipo_Cliente;
                    v_cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = cliente.Telefono;
                    v_cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = cliente.Direccion;
                    v_cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = cliente.Email;
                    v_cmd.ExecuteNonQuery();
                    inserta = true;
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
            return inserta;
        }
        //*******************************************************************
        public DataTable Get_Cliente_especifico(int idcliente)
        {
            try
            {
                v_cnx = new SqlConnection(this.conection);
                adaptador = new SqlDataAdapter("Select * from Clientes where id_cliente = '" + idcliente + "'", v_cnx);
                tblClientes = new DataTable();

                v_cnx.Open();
                adaptador.Fill(tblClientes);
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
            return tblClientes;
        }
        //*******************************************************************
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
