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
using Capa_Datos;

namespace ProyectoFinal
{
    public partial class Agregar_Supermercado : Form
    {

        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String conexion

        public Agregar_Supermercado()
        {
            InitializeComponent();
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Persona", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_iddueñosupermercado.Items.Add(dataReader["ID"].ToString());
            }
            cnx.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregarsupermercado_Click(object sender, EventArgs e)
        {
            conex_super conex = new conex_super(); 
            conex.ingresaSuper(int.Parse(txb_idsupermercado.Text), txb_nombresupermercado.Text, txb_localidad.Text, int.Parse(cmb_iddueñosupermercado.Text));
            txb_idsupermercado.Text = "";
            txb_localidad.Text = "";
            txb_nombresupermercado.Text = "";
            cmb_iddueñosupermercado.Text = "";
        }

        private void Agregar_Supermercado_Load(object sender, EventArgs e)
        {

        }
    }
}
