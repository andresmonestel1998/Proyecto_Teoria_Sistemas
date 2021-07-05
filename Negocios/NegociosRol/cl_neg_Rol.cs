using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DatosUsuario;

namespace Negocios.NegociosRol
{
    public class cl_neg_Rol
    {
        cl_dat_Rol datRol = new cl_dat_Rol();
        public DataTable cargarComboBox()
        {
            return datRol.cargarComboBoxRol();
        }
    }
}
