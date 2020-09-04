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
    public partial class Actualizar_Usuario : Form
    {
        public SqlCommand cmd, command;
        public SqlConnection cnx;
        SqlDataReader dataReader, dr;
        public string conection = "Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String conexion
        D_Users conexion = new D_Users("Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        public Actualizar_Usuario()
        {
            InitializeComponent();
            gbx_actualizar.Enabled = false;
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Persona", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_id_Actualizar.Items.Add(dataReader["ID"].ToString());
            }
            dataReader.Close();

            if (cmb_id_Actualizar.Text != null)
            {
                gbx_actualizar.Enabled = true;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_id_Actualizar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txb_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_actualizarusuario_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txb_apellidos.Text)) && (!string.IsNullOrEmpty(txb_contraseña.Text))
              && (!string.IsNullOrEmpty(txb_direccion.Text)) && (!string.IsNullOrEmpty(txb_email.Text)) &&
              (!string.IsNullOrEmpty(cmb_id_Actualizar.Text)) && (!string.IsNullOrEmpty(txb_nombre.Text)) && (!string.IsNullOrEmpty(txb_rol.Text))
              && (!string.IsNullOrEmpty(txb_telefono.Text))
              )
            {
                int v_cod = int.Parse(cmb_id_Actualizar.Text);
                string contraseña = txb_contraseña.Text;
                string nombre = txb_nombre.Text;
                string apellidos = txb_apellidos.Text;
                int telefono = int.Parse(txb_telefono.Text);
                string email = txb_email.Text;
                string direccion = txb_direccion.Text;
                string rol = txb_rol.Text;


                bool insertado = conexion.actualizar_articulo(v_cod, contraseña, nombre, apellidos, telefono, email, direccion, rol);

                if (insertado)
                {
                    MessageBox.Show("Usuario Actualizado con Exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Todos los Campos son requeridos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Actualizar_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
