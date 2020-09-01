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
    public partial class Bodega : Form
    {
        public Bodega()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bodega_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregarsupermercado_Click(object sender, EventArgs e)
        {
            Consultas_Productos frmconsultas_productos = new Consultas_Productos();
            frmconsultas_productos.Show();
        }

        private void btn_agregarnuevasede_Click(object sender, EventArgs e)
        {
            Actualizar_Articulo frmactualizar_articulo = new Actualizar_Articulo();
            frmactualizar_articulo.Show();
        }

        private void btn_ingresararticulos_Click(object sender, EventArgs e)
        {
            Ingresar_Articulos frmingresar_articulo = new Ingresar_Articulos();
            frmingresar_articulo.Show();
        }
    }
}
