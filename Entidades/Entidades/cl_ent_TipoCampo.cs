using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class cl_ent_TipoCampo
    {
        #region variables
            private int _iIdTipoCampo;
            private double _dPrecio;
            private string _sNombre, _sDetalle;
        #endregion

        #region constructores
            public int _IIdTipoCampo { get => _iIdTipoCampo; set => _iIdTipoCampo = value; }
            public double _DPrecio { get => _dPrecio; set => _dPrecio = value; }
            public string _SNombre { get => _sNombre; set => _sNombre = value; }
            public string _SDetalle { get => _sDetalle; set => _sDetalle = value; }
        #endregion
    }
}
