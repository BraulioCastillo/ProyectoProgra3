using Capa_Datos;
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
    public partial class Agregar_Sede : Form
    {


        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "";//String conexion
        conex_sede conex_Sede;

        public Agregar_Sede()
        {
            InitializeComponent();
            InitializeComponent();
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Persona", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_idencargadosede.Items.Add(dataReader["ID"].ToString());
            }
            cmd.Cancel();
            cmd = new SqlCommand("select * from Superercado", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_idsupermercadosede.Items.Add(dataReader["ID"].ToString());
            }
            cnx.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregarsede_Click(object sender, EventArgs e)
        {
            conex_Sede.ingresaSede(int.Parse(txb_idsede.Text), txb_localidadsede.Text, int.Parse(cmb_idencargadosede.Text), int.Parse(cmb_idsupermercadosede.Text));
            txb_idsede.Text = "";
            txb_localidadsede.Text = "";
            cmb_idencargadosede.Text = "";
            cmb_idsupermercadosede.Text = "";
        }

        private void Agregar_Sede_Load(object sender, EventArgs e)
        {

        }
    }
}
