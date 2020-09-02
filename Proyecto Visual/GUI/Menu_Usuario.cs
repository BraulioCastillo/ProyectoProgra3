using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Menu_Usuario : Form
    {
        public Menu_Usuario()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrarusuario_Click(object sender, EventArgs e)
        {
            Registro_Usuarios frmusuarios = new Registro_Usuarios();
            frmusuarios.Show();
        }

        private void btn_actualizarusuario_Click(object sender, EventArgs e)
        {
            Actualizar_Usuario frmactualizarusuario = new Actualizar_Usuario();
            frmactualizarusuario.Show();
        }

        private void btn_consultarusuario_Click(object sender, EventArgs e)
        {
            Consultar_Usuario frmconsultarusuario = new Consultar_Usuario();
            frmconsultarusuario.Show();
        }

        private void btn_eliminarusuario_Click(object sender, EventArgs e)
        {
            Eliminar_Usuario frmeliminarusuario = new Eliminar_Usuario();
            frmeliminarusuario.Show();
        }
    }
}
