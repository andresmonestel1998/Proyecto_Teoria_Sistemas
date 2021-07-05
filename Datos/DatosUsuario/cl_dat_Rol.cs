using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DatosUsuario
{
    public class cl_dat_Rol
    {
        SqlConnection Conextion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public DataTable cargarComboBoxRol()
        {
            SqlCommand Comando = new SqlCommand();

            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "BuscarRoles";
            Conextion.Open();
            Comando.Connection = Conextion;
            Comando.ExecuteNonQuery();
            SqlDataAdapter data = new SqlDataAdapter(Comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            Conextion.Close();
            return tabla;
        }
    }
}
