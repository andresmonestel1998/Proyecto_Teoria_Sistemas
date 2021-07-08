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
        #region conex
            SqlConnection Conextion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        #endregion

        #region metodos
        public bool InsertarParqueo(cl_ent_Parqueo parqueo)
        {
            SqlCommand Comando = new SqlCommand("NuevoParqueo", Conextion);

            Comando.Parameters.Add("@CedulaJuridicaParqueo", SqlDbType.NVarChar).Value = parqueo._SCedJuParqueo;
            Comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = parqueo._SNombre;
            Comando.Parameters.Add("@Provincia", SqlDbType.NVarChar).Value = parqueo._SProvincia;
            Comando.Parameters.Add("@Canton", SqlDbType.NVarChar).Value = parqueo._SCanton;
            Comando.Parameters.Add("@Distrito", SqlDbType.NVarChar).Value = parqueo._SDistrito;
            Comando.Parameters.Add("@Calle", SqlDbType.NVarChar).Value = parqueo._SCalle;
            Comando.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = parqueo._STelefono;
            Comando.Parameters.Add("@cantidadCampos", SqlDbType.Int).Value = parqueo._ICamposDisponibles;

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

        public DataTable BuscarParqueo(String cedula)
        {
            SqlCommand Comando = new SqlCommand("BuscarParqueo", Conextion);
            Comando.Parameters.Add("@CedulaJuridica", SqlDbType.NVarChar).Value = cedula;
            Comando.CommandType = CommandType.StoredProcedure;
            Conextion.Open();
            SqlDataReader ObjReader = Comando.ExecuteReader();

            if (ObjReader.Read())
            {
                ObjReader.Close();
                SqlDataAdapter data = new SqlDataAdapter(Comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                Conextion.Close();
                return tabla;
            }
            else
            {
                Conextion.Close();
                return null;
            }
        }

        public bool EditarParqueo(cl_ent_Parqueo parqueo)
        {

            SqlCommand Comando = new SqlCommand("EditarParqueo", Conextion);

            Comando.Parameters.Add("@CedulaJuridicaParqueo", SqlDbType.NVarChar).Value = parqueo._SCedJuParqueo;
            Comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = parqueo._SNombre;
            Comando.Parameters.Add("@Provincia", SqlDbType.NVarChar).Value = parqueo._SProvincia;
            Comando.Parameters.Add("@Canton", SqlDbType.NVarChar).Value = parqueo._SCanton;
            Comando.Parameters.Add("@Distrito", SqlDbType.NVarChar).Value = parqueo._SDistrito;
            Comando.Parameters.Add("@Calle", SqlDbType.NVarChar).Value = parqueo._SCalle;
            Comando.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = parqueo._STelefono;
            Comando.Parameters.Add("@cantidadCampos", SqlDbType.Int).Value = parqueo._ICamposDisponibles;

            Comando.CommandType = CommandType.StoredProcedure;

            Conextion.Open();
            Comando.ExecuteNonQuery();
            Conextion.Close();
            return true;
        }


        #endregion

    }
}
