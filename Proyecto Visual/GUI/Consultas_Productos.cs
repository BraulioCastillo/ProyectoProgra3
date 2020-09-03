using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_Datos;
using Datos_;

namespace ProyectoFinal
{
    public partial class Consultas_Productos : Form
    {
        public SqlCommand cmd, command;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";
        public Consultas_Productos()
        {
            InitializeComponent();
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Articulo", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_consultaId.Items.Add(dataReader["codigo"].ToString());
                cmb_consultaId2.Items.Add(dataReader["codigo"].ToString());

            }
            dataReader.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            conex_art conexion = new conex_art("Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"); //WARNING!!!!!!!!!!!!!!!!!!!!! STRING DE CONEXION
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            DataRow dr;

            string cadSql = "select codigo from Articulo where codigo = '" + int.Parse(cmb_consultaId.Text) + "'";
            SqlCommand comando = new SqlCommand(cadSql, conexion.conecta());
            conexion.con.Open();

            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                cmb_consultaId.Text = leer["codigo"].ToString();
                da = new SqlDataAdapter("Select imagen from Articulo where codigo = '" + int.Parse(cmb_consultaId.Text) + "'", conexion.conexion);
                ds = new DataSet();
                da.Fill(ds, "Articulo");
                byte[] datos = new byte[0];
                dr = ds.Tables["Articulo"].Rows[0];
                datos = (byte[])dr["imagen"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);

                ds = conexion.Consultar(int.Parse(cmb_consultaId.Text));
                dgv_productos.DataSource = ds.Tables[0];
                conexion.con.Close();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmb_consultaId2.Text))
            {
                conex_art conexion = new conex_art("");  //WARNING STRING DE CONEXION

                int codigo = int.Parse(cmb_consultaId2.Text);

                bool deleted = conexion.delete_articulo(codigo);
                if (deleted)
                {
                    MessageBox.Show("Producto Eliminado de la Base de Datos", "Procedimiento Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Favor digite el código del producto a eliminar", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Consultas_Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
