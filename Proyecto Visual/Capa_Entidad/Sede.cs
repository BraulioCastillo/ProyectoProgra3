using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Sede
    {

        int idSede, idEncargado, idSuper;
        string localidad;

        public int IDSede
        {

            get { return idSede; }
            set { idSede = value; }

        }
        public int IDEncargado
        {

            get { return idEncargado; }
            set { idEncargado = value; }

        }
        public int IDSuper
        {

            get { return idSuper; }
            set { idSuper = value; }

        }
        public string Localidad
        {

            get { return localidad; }
            set { localidad = value; }

        }

    }
}
