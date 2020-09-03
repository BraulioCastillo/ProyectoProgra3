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

namespace ProyectoFinal
{
    public partial class Ingresar_Articulos : Form
    {

        conex_art conexion = new conex_art("Data Source=YASHIN-PC\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");  //WARNING STRING DE CONEXION
        public Ingresar_Articulos()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cargar_img_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();

                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pb_imagen.Load(this.openFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen" + ex.ToString());

            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txb_detalles_insertar.Text)) && (!string.IsNullOrEmpty(txb_ID_insertar.Text))
               && (!string.IsNullOrEmpty(txb_precio_insertar.Text)) && (!string.IsNullOrEmpty(txb_stock_insertar.Text))
               )
            {
                int v_cod = int.Parse(txb_ID_insertar.Text);
                double v_precio = double.Parse(txb_precio_insertar.Text);
                int v_stock = int.Parse(txb_stock_insertar.Text);
                String v_detalle = txb_detalles_insertar.Text;

                bool insertado = conexion.insertar_articulo(v_cod, v_precio, v_stock, v_detalle, pb_imagen);

                if (insertado)
                {
                    MessageBox.Show("Articulo Insertado con Exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Todos los Campos son requeridos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Ingresar_Articulos_Load(object sender, EventArgs e)
        {

        }
    }
}
