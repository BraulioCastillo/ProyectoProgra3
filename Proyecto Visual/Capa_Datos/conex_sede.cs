﻿using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class conex_sede
    {

        public SqlCommand cmd;
        public SqlConnection cnx;
        SqlDataReader dataReader;
        public string conection = "Data Source=BRAULIO\\SQSLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";//String de Conexion

        #region metodos

        #region ingresa sede

        public void ingresaSede(int id, string localidad, int idEncargado, int idSuper)
        {

            try
            {
                if (validaSede(id) == false)
                {
                    cnx = new SqlConnection(conection);
                    cnx.Open();
                    cmd = new SqlCommand("execute creaSede " + id + ", '" + localidad + "', " + idEncargado + ", " + idSuper, cnx);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sede agregada.");
                    cnx.Close();
                }
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Hubo un error al agregar la sede, por favor inténtelo nuevamente");
            }


        }

        private bool validaSede(int id)
        {
            bool valida = false;

            try
            {
                cnx = new SqlConnection(conection);
                cnx.Open();
                cmd = new SqlCommand("select * from Sede", cnx);
                cmd.ExecuteNonQuery();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader["ID"].ToString().Equals(id))
                    {
                        MessageBox.Show("La sede ya existe");
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Ha ocurrido un error, por favor inténtelo nuevamente");
            }

            return valida;
        }

        #endregion

        #region modifica sede

        public void modificaSede(int id, string localidad)
        {


            try
            {
                cnx = new SqlConnection(conection);
                cnx.Open();
                cmd = new SqlCommand("execute modificaSede " + id + ", '" + localidad + "'", cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Sede modificada");

            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Error al modificar la sede");
            }

        }

        public Sede cargaDatosSede(int id)
        {
            Sede sede = new Sede();
            try
            {
                cnx = new SqlConnection(conection);
                cnx.Open();
                cmd = new SqlCommand("select * from Sede where Id = " + id, cnx);
                cmd.ExecuteNonQuery();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    sede.IDEncargado = int.Parse(dataReader["ID_encargado"].ToString());
                    sede.Localidad = dataReader["localidad"].ToString();
                    sede.IDSuper = int.Parse(dataReader["ID_Supermercado"].ToString());
                    sede.IDSede = int.Parse(dataReader["Id"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Hubo un problema al cargar los datos, por favor intente nuevamente");
            }
            return sede;
        }

        public int contUser()
        {
            int cont = 0;
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Persona", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cont++;
            }
            return cont;
        }

        public string[] cargaIdUser()
        {
            string[] ID = new string[contUser()];
            int cont = 0;
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Persona", cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                ID[cont] = "" + dataReader["ID"].ToString();
                cont++;
            }

            return ID;
        }

        #endregion

        #region ver sede
        private int countSedes(int id)
        {
            int cont = 0;
            cnx = new SqlConnection(conection);
            cnx.Open();
            cmd = new SqlCommand("select * from Sede where Id = " + id, cnx);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cont++;
            }
            return cont;
        }


        #endregion

        //public object[] sedes(int idSuper)
        //{
        //    object sedes = new object[countSedes(idSuper)];
        //    Sede cd = new Sede();
        //    cnx = new SqlConnection(conection);
        //    cnx.Open();
        //    cmd = new SqlCommand("select * from Sede where Id = " + idSuper, cnx);
        //    cmd.ExecuteNonQuery();
        //    dataReader = cmd.ExecuteReader();
        //    while (dataReader.Read())
        //    {
        //        cd.
        //    }

        //    return sedes;
        //}

        #endregion
    }
}
