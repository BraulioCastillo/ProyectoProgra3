﻿using Capa_Datos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Actualizar_Supermercado : Form
    {
        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "";
        conex_super conex_Super;
        public Actualizar_Supermercado()
        {
            InitializeComponent();
            InitializeComponent();
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Supermercado", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_Supermercado.Items.Add(dataReader["ID"].ToString());
            }
            cnx.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Actualizar_Supermercado_Load(object sender, EventArgs e)
        {

        }

        private void cmb_iddueñosupermercado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Capa_Negocio.Supermercado supermercado = conex_Super.cargaDatosSuper(int.Parse(cmb_Supermercado.Text));
            try
            {
                txb_localidad.Text = supermercado.Localidad;
                txb_nombresupermercado.Text = supermercado.Nombre;
                txb_idDueño.Text = "" + supermercado.IDEncargado;
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un problema, por favor intentelo nuevamente");
            }
        }

        private void btn_actualizarsupermercado_Click(object sender, EventArgs e)
        {
            try
            {
               conex_Super.modificaSuper(int.Parse(cmb_Supermercado.Text), txb_nombresupermercado.Text, txb_localidad.Text, int.Parse(txb_idDueño.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al actualizar, por favor intente nuevamente");
            }
        }
    }
}