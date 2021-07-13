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
        public string SCedJuParqueo { get => _sCedJuParqueo; set => _sCedJuParqueo = value; }
        public string SCedulaUsuario { get => _sCedulaUsuario; set => _sCedulaUsuario = value; }
        public string STipoVehiculo { get => _sTipoVehiculo; set => _sTipoVehiculo = value; }
        public string SPlacaVehiculo { get => _sPlacaVehiculo; set => _sPlacaVehiculo = value; }
        public string SMarca { get => _sMarca; set => _sMarca = value; }
        public string SModelo { get => _sModelo; set => _sModelo = value; }
        public DateTime DtFechaEntrada { get => dtFechaEntrada; set => dtFechaEntrada = value; }
        public DateTime DtFechaHoraSalida { get => _dtFechaHoraSalida; set => _dtFechaHoraSalida = value; }
        public bool BEstadVehiculo { get => _bEstadVehiculo; set => _bEstadVehiculo = value; }
        #endregion
    }
}
