using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DatosUsuario;
using Entidades.Entidades;

namespace Negocios.NegociosUsuario
{
    public class cl_neg_Usuario
    {
        cl_dat_Usuario datUser = new cl_dat_Usuario();
        public DataTable consultarUser()
        {
            return datUser.consutlarUsuario();
        }

        public DataTable BuscarUser(String cedula)
        {
            return datUser.BuscarUsuario(cedula);
        }

        public Boolean NuevoUser(cl_ent_Usuario usuarios)
        {
            return datUser.InsertarUsuario(usuarios);
        }

        public Boolean EditarEmpleado(cl_ent_Usuario usuarios)
        {
            return datUser.EditarEmpleado(usuarios);
        }
    }
}
