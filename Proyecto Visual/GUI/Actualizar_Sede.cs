using Capa_Datos;
using Capa_Entidad;
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
    public partial class Actualizar_Sede : Form
    {
        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String conexion
        conex_sede conex_Sede;
        public Actualizar_Sede()
        {
            InitializeComponent();
            conex_Sede = new conex_sede();
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

        }

        private void cmb_idSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Sede sede = conex_Sede.cargaDatosSede(int.Parse(cmb_idSede.Text));
                txb_idEncargado.Text = "" + sede.IDEncargado;
                txb_idSede.Text = "" + sede.IDSede;
                txb_localidadsede.Text = "" + sede.Localidad;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_acutualizarsede_Click(object sender, EventArgs e)
        {
            try
            {
                conex_Sede.modificaSede(int.Parse(cmb_idSede.Text), txb_localidadsede.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido actualizar la sede, por favor intente nuevamente");
            }
        }

        private void btn_acutualizarsede_Click_1(object sender, EventArgs e)
        {
            try
            {
                conex_Sede.modificaSede(int.Parse(cmb_idSede.Text), txb_localidadsede.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido actualizar la sede, por favor intente nuevamente");
            }
        }
    }
}
