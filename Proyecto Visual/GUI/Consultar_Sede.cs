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
            dataGridView1.Columns.Add("ubicación", "Ubicación");
            dataGridView1.Columns.Add("supermercado", "Supermercado");
            dataGridView1.Columns.Add("Encargado", "Encargado");


            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select s.Id, s.localidad, sm.nombre as super, p.nombre, p.apellidos " +
                "from Sede s left join Persona p on p.ID = s.ID_encargado left join Supermercado sm on sm.ID = s.ID_encargado", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridView1.Rows.Add(dataReader["ID"].ToString(), dataReader["localidad"].ToString(), dataReader["super"].ToString(), 
                    dataReader["nombre"].ToString() + " " + dataReader["apellidos"].ToString()) ;
            }
            cnx.Close();
        }

        private void Consultar_Sede_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
