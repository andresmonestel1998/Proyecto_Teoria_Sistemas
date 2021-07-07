using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DatosUsuario;
using Entidades.Entidades;

namespace Negocios.NegociosParqueo
{
    public class cl_neg_Parqueo
    {
        cl_dat_Parqueo DatPa = new cl_dat_Parqueo();
        public DataTable consultarPark()
        {
            return DatPa.consutlarParqueo();
        }
        public Boolean NuevoParqueo(cl_ent_Parqueo parqueo)
        {
            
            return DatPa.InsertarParqueo(parqueo);
        }
    }
}
