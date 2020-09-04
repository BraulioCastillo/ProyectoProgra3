using ProyectoFinal;
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
            if (Login1.roll == "Admin")

            {
                btnsede.Enabled = true;
                btnventas.Enabled = true;
                btncompras.Enabled = true;
                btnbodega.Enabled = true;
                btnusuarios.Enabled = true;

                lblCargo.Text = "Administrador";
            }

            //Vendedores
            else if (Login1.roll == "Cliente")

            {
                btnsede.Enabled = false;
                btnventas.Enabled = false;
                btncompras.Enabled = true;
                btnbodega.Enabled = false;
                btnusuarios.Enabled = false;

                lblCargo.Text = "Cliente";
            }
            lblnombre.Text = Login1.usuario_nombre;
            lbl_apellidos.Text = Login1.apellidos;
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
            Consultar_facturasYdetalle consultar = new Consultar_facturasYdetalle();
            consultar.Show();
            Login1 login = new Login1();
            login.Close();
        }

        private void btnsede_Click(object sender, EventArgs e)
        {
            Supermercado super = new Supermercado();
            super.Show();
            Login1 login = new Login1();
            login.Hide();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {

            Carrito_compras carrito = new Carrito_compras();
            carrito.Show();
            Login1 login = new Login1();
            login.Close();

        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            Menu_Usuario menu = new Menu_Usuario();
            Login1 login = new Login1();
            menu.Show();
            login.Hide();

        }

        private void btnbodega_Click(object sender, EventArgs e)
        {

            Bodega bodega = new Bodega();
            Login1 login = new Login1();
            bodega.Show();
            login.Hide();


        }

        private void lblnombre_Click(object sender, EventArgs e)
        {

        }
    }
}
