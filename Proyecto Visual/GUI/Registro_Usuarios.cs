using DATOS;
using Datos_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProyectoFinal
{
    public partial class Registro_Usuarios : Form
    {
        D_Users conexion = new D_Users("Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        public Registro_Usuarios()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Login1 login = new Login1();
            this.Close();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txb_apellidos.Text)) && (!string.IsNullOrEmpty(txb_contraseña.Text))
              && (!string.IsNullOrEmpty(txb_direccion.Text)) && (!string.IsNullOrEmpty(txb_email.Text)) &&
              (!string.IsNullOrEmpty(txb_id.Text)) && (!string.IsNullOrEmpty(txb_nombre.Text)) && (!string.IsNullOrEmpty(txb_rol.Text))
              && (!string.IsNullOrEmpty(txb_telefono.Text))
              )
            {
                int v_cod = int.Parse(txb_id.Text);
                string contraseña = txb_contraseña.Text;
                string nombre = txb_nombre.Text;
                string apellidos = txb_apellidos.Text;
                int telefono = int.Parse(txb_telefono.Text);
                string email = txb_email.Text;
                string direccion = txb_direccion.Text;
                string rol = txb_rol.Text;
               

                bool insertado = conexion.insertar_usuario(v_cod, contraseña, nombre, apellidos, telefono, email, direccion, rol);

                if (insertado)
                {
                    MessageBox.Show("Usuario Insertado con Exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Todos los Campos son requeridos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
