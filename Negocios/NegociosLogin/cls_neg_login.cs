using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DatosUsuario;
using Entidades.Entidades;

namespace Negocios.NegociosLogin
{
    public class cls_neg_login
    {
        public DataTable DatosLogin(cl_ent_Usuario entidades)
        {
            cl_dat_Usuario DatLog = new cl_dat_Usuario();
            return DatLog.LoginUsuario(entidades._SCorreo,entidades._SContrasena);
        }
    }
}
