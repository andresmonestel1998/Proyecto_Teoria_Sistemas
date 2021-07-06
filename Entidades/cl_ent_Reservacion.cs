using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    class cl_ent_Reservacion
    {
        #region variables
        private int _iIdReservacion;
        private string _sCedJuParqueo, _iIdCampo, _sCedulaUsuario, _sPlacaVehiculo, _sMarca, _sModelo;
        private DateTime dtFechaEntrada, _dtFechaHoraSalida;
        #endregion

        #region constructores
        public int _IIdReservacion { get => _iIdReservacion; set => _iIdReservacion = value; }
        public string _SCedJuParqueo { get => _sCedJuParqueo; set => _sCedJuParqueo = value; }
        public string _IIdCampo { get => _iIdCampo; set => _iIdCampo = value; }
        public string _SCedulaUsuario { get => _sCedulaUsuario; set => _sCedulaUsuario = value; }
        public string _SPlacaVehiculo { get => _sPlacaVehiculo; set => _sPlacaVehiculo = value; }
        public string _SMarca { get => _sMarca; set => _sMarca = value; }
        public string _SModelo { get => _sModelo; set => _sModelo = value; }
        public DateTime _DtFechaEntrada { get => dtFechaEntrada; set => dtFechaEntrada = value; }
        public DateTime _DtFechaHoraSalida { get => _dtFechaHoraSalida; set => _dtFechaHoraSalida = value; }
        #endregion
    }
}
