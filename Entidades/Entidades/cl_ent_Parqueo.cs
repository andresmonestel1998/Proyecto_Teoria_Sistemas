using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class cl_ent_Parqueo
    {

        #region variables
            private string _sCedJuParqueo, _sNombre, _sProvincia, _sCanton, _sDistrito, _sCalle, _sTelefono;
        #endregion

        #region constructores
            public string _SCedJuParqueo { get => _sCedJuParqueo; set => _sCedJuParqueo = value; }
            public string _SNombre { get => _sNombre; set => _sNombre = value; }
            public string _SProvincia { get => _sProvincia; set => _sProvincia = value; }
            public string _SCanton { get => _sCanton; set => _sCanton = value; }
            public string _SDistrito { get => _sDistrito; set => _sDistrito = value; }
            public string _SCalle { get => _sCalle; set => _sCalle = value; }
            public string _STelefono { get => _sTelefono; set => _sTelefono = value; }
        #endregion
    }
}
