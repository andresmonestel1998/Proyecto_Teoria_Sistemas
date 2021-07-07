using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades;

namespace Datos.DatosUsuario
{
    public class cl_dat_Parqueo
    {
        SqlConnection Conextion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public bool InsertarParqueo(cl_ent_Parqueo parqueo)
        {
            SqlCommand Comando = new SqlCommand("NuevoParqueo", Conextion);

            Comando.Parameters.Add("@CedulaJuridicaParqueo", SqlDbType.NVarChar).Value = parqueo._SCedJuParqueo;
            Comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = parqueo._SNombre;
            Comando.Parameters.Add("@Provincia", SqlDbType.NVarChar).Value = parqueo._SProvincia;
            Comando.Parameters.Add("@Canton", SqlDbType.NVarChar).Value = parqueo._SCanton;
            Comando.Parameters.Add("@Distrito", SqlDbType.NVarChar).Value = parqueo._SDistrito;
            Comando.Parameters.Add("@Calle", SqlDbType.NVarChar).Value = parqueo._SCalle;
            Comando.Parameters.Add("@Detalle", SqlDbType.NVarChar).Value = parqueo._SDetalle;

            Comando.CommandType = CommandType.StoredProcedure;

            Conextion.Open();
            Comando.ExecuteNonQuery();
            Conextion.Close();

            return true;
        }

        public DataTable consutlarParqueo()
        {
            SqlCommand comando = new SqlCommand("ConsularParqueo", Conextion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
    }
}
