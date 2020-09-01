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
using Capa_Datos;
using Capa_Entidad;

namespace ProyectoFinal
{
    public partial class Actualizar_Sede : Form
    {
        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "";
        public Actualizar_Sede()
        {
            InitializeComponent();
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Sede", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_idSede.Items.Add(dataReader["ID"].ToString());
            }
            cnx.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Actualizar_Sede_Load(object sender, EventArgs e)
        {
            try
            {
                conex_sede conex = new conex_sede();
                conex.modificaSede(int.Parse(cmb_idSede.Text), txb_localidadsede.Text);

                cmb_idSede.Text = "";
                txb_idEncargado.Text = "";
                txb_idSupermercado.Text = "";
                txb_localidadsede.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error, por favor intentelo nuevamente");
            }
        }

        private void cmb_idSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            conex_sede conex = new conex_sede();
            Sede sede = (Sede) conex.cargaDatosSede(int.Parse(cmb_idSede.Text));
            try
            {
                txb_idEncargado.Text = "" + sede.IDEncargado;
                txb_idSupermercado.Text = "" + sede.IDSuper;
                txb_localidadsede.Text = sede.Localidad;
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error, por favor intentelo nuevamente");
            }
        }
    }
}
