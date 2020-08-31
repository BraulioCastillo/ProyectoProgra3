using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                btnsede.Enabled = true;
                btnventas.Enabled = true;
                btncompras.Enabled = true;
                btnbodega.Enabled = true;
                btnusuarios.Enabled = true;

                lblCargo.Text = "Administrador";
            }

            //Vendedores
            else if (Login.area == "A2")

            {
                btnsede.Enabled = false;
                btnventas.Enabled = true;
                btncompras.Enabled = false;
                btnbodega.Enabled = true;
                btnusuarios.Enabled = true;

                lblCargo.Text = "Ventas";
            }

            //Bodega
            else if (Login.area == "A3")

            {
                btnsede.Enabled = false;
                btnventas.Enabled = true;
                btncompras.Enabled = true;
                btnbodega.Enabled = true;
                btnusuarios.Enabled = false;

                lblCargo.Text = "Bodega";
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
    }
}
