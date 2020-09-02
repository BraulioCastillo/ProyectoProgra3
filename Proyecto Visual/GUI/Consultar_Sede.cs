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
    public partial class Consultar_Sede : Form
    {
        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String conexion
        public Consultar_Sede()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("ID sede", "ID Sede");
            dataGridView1.Columns.Add("", "ID Supermercado");
            dataGridView1.Columns.Add("ID supermercado", "ID Supermercado");
            dataGridView1.Columns.Add("ID supermercado", "ID Supermercado");


            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Supermercado", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_idSupermercado.Items.Add("ID: " + dataReader["ID"].ToString() + ", Supermercado: " + dataReader["nombre"].ToString());
            }
            cnx.Close();
        }

        private void Consultar_Sede_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supermercado super = new Supermercado();
            super.Show();
            this.Hide();
        }
    }
}
