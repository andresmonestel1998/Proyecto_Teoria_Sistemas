using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    class cl_ent_Campo
    {
        #region variables
        private int _iIdCampo, _iIdTipoCampo;
        private string _sCedJuParqueo;
        private bool _bEstado;
        #endregion

        #region constructores
        public int _IIdCampo { get => _iIdCampo; set => _iIdCampo = value; }
        public int _IIdTipoCampo { get => _iIdTipoCampo; set => _iIdTipoCampo = value; }
        public string _SCedJuParqueo { get => _sCedJuParqueo; set => _sCedJuParqueo = value; }
        public bool _BEstado { get => _bEstado; set => _bEstado = value; }
        #endregion

    }
}
