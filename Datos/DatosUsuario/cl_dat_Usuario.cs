using System;
using System.Collections.Generic;
using System.Configuration;//librería configuracion
using System.Data;
using System.Data.SqlClient;//librería configuracion
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Datos.DatosUsuario
{
    public class cl_dat_Usuario
    {
        SqlConnection Conextion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable LoginUsuario(String user, String pass)
        {
            SqlCommand Comando = new SqlCommand("Autentificacion", Conextion);
            Comando.Parameters.Add("@correo", SqlDbType.NVarChar).Value = user;
            Comando.Parameters.Add("@contrasena", SqlDbType.NVarChar).Value = pass;
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
    }

}
