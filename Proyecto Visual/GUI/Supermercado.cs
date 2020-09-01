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
    public partial class Supermercado : Form
    {
        public Supermercado()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregarsupermercado_Click(object sender, EventArgs e)
        {
            Agregar_Supermercado frmagregar_supermercado = new Agregar_Supermercado();
            frmagregar_supermercado.Show();
        }

        private void btn_agregarnuevasede_Click(object sender, EventArgs e)
        {
            Agregar_Sede frmagregar_sede = new Agregar_Sede();
            frmagregar_sede.Show();
        }

        private void btn_consultarsupermercado_Click(object sender, EventArgs e)
        {
            Consulta_Supermercado frmconsulta_supermercado = new Consulta_Supermercado();
            frmconsulta_supermercado.Show();
        }

        private void btn_actualizarsupermercado_Click(object sender, EventArgs e)
        {
            Actualizar_Supermercado frmactualizar_supermercado = new Actualizar_Supermercado();
            frmactualizar_supermercado.Show();
        }

        private void btn_actualizarsede_Click(object sender, EventArgs e)
        {
            Actualizar_Sede frmactualizar_sede = new Actualizar_Sede();
            frmactualizar_sede.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
