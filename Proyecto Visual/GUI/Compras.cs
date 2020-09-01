using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            conex_art conexion = new conex_art("Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"); //WARNING STRING DE CONEXION
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            DataRow dr;

            string cadSql = "select codigo from Articulo where codigo = '" + int.Parse(txb_consulta_id.Text) + "'";
            SqlCommand comando = new SqlCommand(cadSql, conexion.conecta());
            conexion.con.Open();

            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txb_consulta_id.Text = leer["codigo"].ToString();
                da = new SqlDataAdapter("Select imagen from Articulo where codigo = '" + int.Parse(txb_consulta_id.Text) + "'", conexion.conexion);
                ds = new DataSet();
                da.Fill(ds, "Articulo");
                byte[] datos = new byte[0];
                dr = ds.Tables["Articulo"].Rows[0];
                datos = (byte[])dr["imagen"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);

                ds = conexion.Consultar(int.Parse(txb_consulta_id.Text));
                dgv_productos.DataSource = ds.Tables[0];
                conexion.con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
