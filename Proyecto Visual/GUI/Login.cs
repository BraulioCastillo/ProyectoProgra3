using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDAD;
using NEGOCIOS;
using ProyectoFinal;

namespace WindowsFormsApp1
{
    public partial class Login1 : Form
    {

        E_Users objeuser = new E_Users();
        N_Users objnuser = new N_Users();
        Principal frm1 = new Principal();

        public static string usuario_nombre, roll, apellidos;

        void p_logueo() 
        {

            DataTable dt = new DataTable();
            objeuser.usuario = txtusuario.Text;
            objeuser.clave = txtpass.Text;

            dt = objnuser.N_user(objeuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][0].ToString();
                apellidos = dt.Rows[0][1].ToString();
                roll = dt.Rows[0][2].ToString();

                frm1.ShowDialog();

                Login1 login = new Login1();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new Principal());

                txtusuario.Clear();
                txtpass.Clear();


            }
            else 
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        public Login1()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_logueo();
            this.Hide();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registro_Usuarios frmusuarios = new Registro_Usuarios();
            frmusuarios.Show();
            this.Hide();
        }
    }
}
