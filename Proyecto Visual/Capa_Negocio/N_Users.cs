using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDAD;


namespace NEGOCIOS
{
    public class N_Users
    {

        D_Users objd = new D_Users();

        public DataTable N_user(E_Users obje) 
        {
            return objd.D_user(obje);
        }

    }
}
