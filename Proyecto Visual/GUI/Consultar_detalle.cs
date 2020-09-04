using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Consultar_detalle : Form
    {
        public SqlCommand cmd, command;
        public SqlConnection cnx;
        SqlDataReader dataReader, dr;
        public string conection = "Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String conexion
        int idFactura;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbIDFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx = new SqlConnection(conection);
            cnx.Open();
            idFactura = int.Parse(cmbIDFactura.Text);
            cmd = new SqlCommand("select f.fecha, f.monto, p.nombre, p.apellidos from Factura f join Persona p on p.ID = f.ID_usuario where f.ID = " + 
                int.Parse(cmbIDFactura.Text), cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                txtFecha.Text = dataReader["fecha"].ToString();
                txtMonto.Text = dataReader["monto"].ToString();
                txtUsuario.Text = dataReader["nombre"].ToString() + " " + dataReader["apellidos"].ToString();
            }
            dataReader.Close();

            cmd = new SqlCommand("select df.ID, a.detalle as articulo, df.valor_Articulo, df.cantidad, df.valor_total from DetalleFactura df " +
                  "join Factura f on f.ID = df.ID_Factura join Articulo a on a.codigo = df.ID_Articulo where f.ID = " + idFactura, cnx);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["ID"].ToString(), dr["articulo"].ToString(), dr["valor_Articulo"].ToString(),
                    dr["cantidad"].ToString(), dr["valor_total"].ToString());
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtFecha.Text = "";
            txtMonto.Text = "";
            txtUsuario.Text = "";
            cmbIDFactura.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Consultar_detalle()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("articulo", "Articulo");
            dataGridView1.Columns.Add("valor individual", "Valor total");
            dataGridView1.Columns.Add("cantidad", "Cantidad");
            dataGridView1.Columns.Add("valor total", "Valor total");


            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Factura", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIDFactura.Items.Add(dataReader["ID"].ToString());
            }

        }

        private void Consultar_detalle_Load(object sender, EventArgs e)
        {
            //cnx = new SqlConnection(conection);
            //cnx.Open();
            //cmd = new SqlCommand("select df.ID, a.detalle as articulo, df.valor_Articulo, df.cantidad, df.valor_total from DetalleFactura df " +
            //    "join Factura f on f.ID = df.ID_Factura join Articulo a on a.codigo = df.ID_Articulo where f.ID = " + int.Parse(cmbIDFactura.ToString()), cnx);
            //cmd.ExecuteNonQuery();
            //dataReader = cmd.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    dataGridView1.Rows.Add(dataReader["ID"].ToString(), dataReader["articulo"].ToString(), dataReader["valor_Articulo"].ToString(), 
            //        dataReader["cantidad"].ToString(), dataReader["valor_total"].ToString());
            //}
        }
    }
}
