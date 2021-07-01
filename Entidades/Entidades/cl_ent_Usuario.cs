using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class cl_ent_Usuario
    {
        #region variables
            private int _iIdRol;
            private string _sCedulaUsuario, _sNombre, _sApellidos, _sCorreo, _sContrasena, _sTelefono, _sPlacaCarro, _sMarca, _sModelo;
        #endregion

        #region constructores
            public int _IIdRol { get => _iIdRol; set => _iIdRol = value; }
            public string _SCedulaUsuario { get => _sCedulaUsuario; set => _sCedulaUsuario = value; }
            public string _SNombre { get => _sNombre; set => _sNombre = value; }
            public string _SApellidos { get => _sApellidos; set => _sApellidos = value; }
            public string _SCorreo { get => _sCorreo; set => _sCorreo = value; }
            public string _SContrasena { get => _sContrasena; set => _sContrasena = value; }
            public string _STelefono { get => _sTelefono; set => _sTelefono = value; }
            public string _SPlacaCarro { get => _sPlacaCarro; set => _sPlacaCarro = value; }
            public string _SMarca { get => _sMarca; set => _sMarca = value; }
            public string _SModelo { get => _sModelo; set => _sModelo = value; }
        #endregion
    }
}
