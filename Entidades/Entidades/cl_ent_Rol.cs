using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class cl_ent_Rol
    {
        #region variables
        private int _iIdRol;
        private string _sNombreRol;
        #endregion

        #region constructores
        public int IIdRol { get => _iIdRol; set => _iIdRol = value; }
        public string SNombreRol { get => _sNombreRol; set => _sNombreRol = value; }
        #endregion
    }
}
