using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DatosUsuario;
using Entidades.Entidades;

namespace Negocios.NegociosAparcar
{
    public class cl_neg_Aparcar
    {
        cl_dat_Aparcar datAparc = new cl_dat_Aparcar();
        public Boolean NuevoAparcado(cl_ent_aparcar aparcar)
        {
            return datAparc.InsertarAparcar(aparcar);
        }
    }
}
