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
    public partial class Consultar_facturasYdetalle : Form
    {
        public Consultar_facturasYdetalle()
        {
            Login1 login = new Login1();
            login.Close();
            InitializeComponent();
        }

        private void btnConsultaFactura_Click(object sender, EventArgs e)
        {
            Consultar_Factura factura = new Consultar_Factura();
            factura.Show();
            Login1 login = new Login1();
            login.Close();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultar_detalle detalle = new Consultar_detalle();
            detalle.Show();
            this.Hide();
        }

        private void Consultar_facturasYdetalle_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
