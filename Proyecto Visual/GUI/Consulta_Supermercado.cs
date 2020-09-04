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
    public partial class Consulta_Supermercado : Form
    {
        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String conexion
        public Consulta_Supermercado()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("ID supermercado", "ID Supermercado");
            dataGridView1.Columns.Add("nombre supermercado", "Nombre Supermercado");
            dataGridView1.Columns.Add("ubicacion", "Ubicacion");
            dataGridView1.Columns.Add("persona encargada", "Persona encargada");


            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select s.ID, s.nombre, s.localidad, p.nombre as persona, p.apellidos from Supermercado s join Persona p on s.ID_dueno = p.ID", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridView1.Rows.Add(dataReader["ID"].ToString(), dataReader["nombre"].ToString(), dataReader["localidad"].ToString(), 
                    dataReader["persona"].ToString() + " " + dataReader["apellidos"].ToString());
            }
            cnx.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consulta_Supermercado_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}