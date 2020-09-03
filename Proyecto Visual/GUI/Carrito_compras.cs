using Datos_;
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
using WindowsFormsApp1;

namespace ProyectoFinal
{
    public partial class Carrito_compras : Form
    {
        public SqlCommand cmd, command;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";

        public Carrito_compras()
        {
            Login1 login = new Login1();
            login.Close();
            InitializeComponent();
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Articulo", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_consultaId.Items.Add(dataReader["codigo"].ToString());

            }
            dataReader.Close();
            dataGridView1.Columns.Add("código", "Código");
            dataGridView1.Columns.Add("artículo", "Artículo");
            dataGridView1.Columns.Add("existencias", "existencias");
            dataGridView1.Columns.Add("cantidad", "Cantidad");
            dataGridView1.Columns.Add("precio unitario", "Precio unitario");
            dataGridView1.Columns.Add("total", "Total");
        }

        private void Carrito_compras_Load(object sender, EventArgs e)
        {

        }

        private void gbx_consultar_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double precio, totalArticulo = 0, totalFactura = 0;
            int existencias = 0;
            double cant;
            if (rbtnEfectivo.Checked || rbtnTarjeta.Checked)
            {
                if (!string.IsNullOrEmpty(txtDetalle.Text) || !string.IsNullOrEmpty(txtExistencias.Text) || !string.IsNullOrEmpty(txtPrecio.Text) ||
                    !string.IsNullOrEmpty(cmb_consultaId.Text) || !string.IsNullOrEmpty(nudCantidad.Value.ToString()))
                {
                    existencias = int.Parse(txtExistencias.Text);
                    precio = double.Parse(txtPrecio.Text);
                    if (nudCantidad.Value > 0)
                    {
                        cant = double.Parse(nudCantidad.Value.ToString());
                        if (existencias >= nudCantidad.Value)
                        {
                            if (rbtnEfectivo.Checked)
                            {
                                totalArticulo = (precio * 1.07) + cant;
                                totalFactura += totalArticulo;
                            }
                            else if (rbtnTarjeta.Checked)
                            {
                                totalArticulo = (precio * 1.13) * cant;
                                totalFactura += totalArticulo;
                            }
                            dataGridView1.Rows.Add(cmb_consultaId.Text, txtDetalle.Text, txtExistencias.Text, nudCantidad.Value, precio, totalArticulo);
                            txtDetalle.Text = "";
                            txtExistencias.Text = "";
                            txtPrecio.Text = "";
                            nudCantidad.Value = 0;
                            cmb_consultaId.Text = "";
                        }
                    }

                }
            }
            else if (existencias < nudCantidad.Value || existencias == 0)
            {
                MessageBox.Show("La cantidad de productos que desea comprar sobrepasa nuestras existencias");
            }
            else if (string.IsNullOrEmpty(txtDetalle.Text) || string.IsNullOrEmpty(txtExistencias.Text) || string.IsNullOrEmpty(txtPrecio.Text) ||
                    string.IsNullOrEmpty(cmb_consultaId.Text) || string.IsNullOrEmpty(nudCantidad.Value.ToString()))
            {
                MessageBox.Show("Por favor complete los datos solicitados");
            }
            else if (nudCantidad.Value == 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad válida");
            }
            else if (!rbtnEfectivo.Checked || !rbtnTarjeta.Checked)
            {
                MessageBox.Show("Por favor seleccione un método de pago");
            }

        }

        private void cmb_consultaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Articulo where codigo = " + int.Parse(cmb_consultaId.Text), cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                txtPrecio.Text = dataReader["precio"].ToString();
                txtDetalle.Text = dataReader["detalle"].ToString();
                txtExistencias.Text = dataReader["existencias"].ToString();
            }
            cnx.Close();
        }

        private void btn_consultar_Click_1(object sender, EventArgs e)
        {


        
        }
    }
}
