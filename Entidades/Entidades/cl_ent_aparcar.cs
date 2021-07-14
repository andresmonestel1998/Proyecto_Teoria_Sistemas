using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class cl_ent_aparcar
    {
        #region variables
            private string _sCedJuParqueo, _sCedulaUsuario, _sTipoVehiculo ,_sPlacaVehiculo, _sMarca, _sModelo;
            private DateTime dtFechaEntrada, _dtFechaHoraSalida;
            private Boolean _bEstadVehiculo;

        #endregion
        #region get set
        public string _SCedJuParqueo { get => _sCedJuParqueo; set => _sCedJuParqueo = value; }
        public string _SCedulaUsuario { get => _sCedulaUsuario; set => _sCedulaUsuario = value; }
        public string _STipoVehiculo { get => _sTipoVehiculo; set => _sTipoVehiculo = value; }
        public string _SPlacaVehiculo { get => _sPlacaVehiculo; set => _sPlacaVehiculo = value; }
        public string _SMarca { get => _sMarca; set => _sMarca = value; }
        public string _SModelo { get => _sModelo; set => _sModelo = value; }
        public DateTime _DtFechaEntrada { get => dtFechaEntrada; set => dtFechaEntrada = value; }
        public DateTime _DtFechaHoraSalida { get => _dtFechaHoraSalida; set => _dtFechaHoraSalida = value; }
        public bool _BEstadVehiculo { get => _bEstadVehiculo; set => _bEstadVehiculo = value; }
        #endregion
    }
}
