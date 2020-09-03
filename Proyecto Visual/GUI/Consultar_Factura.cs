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
    public partial class Consultar_Factura : Form
    {
        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String conexion

        public Consultar_Factura()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("usuario", "Usuario");
            dataGridView1.Columns.Add("fecha", "Fecha");
            dataGridView1.Columns.Add("monto", "Monto");
            dataGridView1.Columns.Add("usuario", "Usuario");
            dataGridView1.Columns.Add("email", "Email");
            dataGridView1.Columns.Add("telefono", "Telefono");
            dataGridView1.Columns.Add("dirección", "Dirección");

            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("execute verFacturas", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridView1.Rows.Add(dataReader["ID"].ToString(), dataReader["fecha"].ToString(), dataReader["monto"].ToString(),
                    dataReader["nombre"].ToString() + dataReader["apellidos"].ToString(), dataReader["email"].ToString(), dataReader["telefono"].ToString(), 
                    dataReader["direccion"].ToString());
            }
            cnx.Close();

        }

        private void Consultar_Factura_Load(object sender, EventArgs e)
        {

        }
    }
}
