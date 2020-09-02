using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Administradores
            if (Login.area == "A1")

            {
                btn_supermercado.Enabled = true;
                btn_ventas.Enabled = true;
                btn_compras.Enabled = true;
                btn_bodega.Enabled = true;
                btn_usuarios.Enabled = true;

                lblCargo.Text = "Administración";
            }

            //Vendedores
            else if (Login.area == "A2")

            {
                btn_supermercado.Enabled = false;
                btn_ventas.Enabled = true;
                btn_compras.Enabled = true;
                btn_bodega.Enabled = false;
                btn_usuarios.Enabled = false;

                lblCargo.Text = "Clientes";
            }

            lblnombre.Text = Login.usuario_nombre;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }

        private void btnventas_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {

        }

        private void btn_supermercado_Click(object sender, EventArgs e)
        {
            Supermercado frmsupermercado = new Supermercado();
            frmsupermercado.Show();
        }

        private void btn_bodega_Click(object sender, EventArgs e)
        {
            Bodega frmbodega = new Bodega();
            frmbodega.Show();
        }
    }
}
