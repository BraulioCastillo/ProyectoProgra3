using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Supermercado
    {

        int idSuper, idEncargado;
        string nombre, localidad;

        public int IDSuper
        {

            get { return idSuper; }
            set { idSuper = value; }

        }

        public string Nombre
        {

            get { return nombre; }
            set { nombre = value; }

        }
        public string Localidad
        {

            get { return localidad; }
            set { localidad = value; }

        }

        public int IDEncargado
        {

            get { return idEncargado; }
            set { idEncargado = value; }

        }

    }
}
