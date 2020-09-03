using DATOS;
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
    public partial class Eliminar_Usuario : Form
    {
        public SqlCommand cmd, command;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String conexion
        public Eliminar_Usuario()
        {
            InitializeComponent();
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Persona", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_eliminiarusuario.Items.Add(dataReader["ID"].ToString());
            }
            dataReader.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualizarusuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmb_eliminiarusuario.Text))
            {
                D_Users conexion = new D_Users("Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");  //WARNING STRING DE CONEXION

                int codigo = int.Parse(cmb_eliminiarusuario.Text);

                bool deleted = conexion.delete_usuario(codigo);
                if (deleted)
                {
                    MessageBox.Show("Producto Eliminado de la Base de Datos", "Procedimiento Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor digite el código del producto a eliminar", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminar_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void cmb_eliminiarusuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
