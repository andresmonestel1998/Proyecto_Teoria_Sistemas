using System;
using System.Collections.Generic;
using System.Configuration;//librería configuracion
using System.Data;
using System.Data.SqlClient;//librería configuracion
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades;



namespace Datos.DatosUsuario
{
    public class cl_dat_Usuario
    {
        #region conex
            SqlConnection Conextion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        #endregion

        #region metodos
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

            public bool InsertarUsuario(cl_ent_Usuario usuario)
            {
                SqlCommand Comando = new SqlCommand("NuevoUsuario", Conextion);

                Comando.Parameters.Add("@v_cedulaUsuario", SqlDbType.NVarChar).Value = usuario._SContrasena;
                Comando.Parameters.Add("@v_idRol", SqlDbType.Int).Value = usuario._IIdRol;
                Comando.Parameters.Add("@v_nombreCompleto", SqlDbType.NVarChar).Value = usuario._SNombre;
                Comando.Parameters.Add("@v_correo", SqlDbType.NVarChar).Value = usuario._SCorreo;
                Comando.Parameters.Add("@v_contra", SqlDbType.NVarChar).Value = usuario._SContrasena;
                Comando.Parameters.Add("@v_telefono", SqlDbType.NVarChar).Value = usuario._STelefono;

                Comando.CommandType = CommandType.StoredProcedure;

                Conextion.Open();
                Comando.ExecuteNonQuery();
                Conextion.Close();

                return true;
            }
            public DataTable consutlarUsuario()
            {
                SqlCommand comando = new SqlCommand("ConsultarUsuario", Conextion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                return tabla;
            }

            public DataTable BuscarUsuario(String cedula)
            {
                SqlCommand Comando = new SqlCommand("BuscarUsuario", Conextion);
                Comando.Parameters.Add("@v_cedulaUsuario", SqlDbType.NVarChar).Value = cedula;
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

            public bool EditarEmpleado(cl_ent_Usuario usuario)
            {

                SqlCommand Comando = new SqlCommand("EditarUsuario", Conextion);

                Comando.Parameters.Add("@v_cedulaUsuario", SqlDbType.NVarChar).Value = usuario._SContrasena;
                Comando.Parameters.Add("@v_idRol", SqlDbType.Int).Value = usuario._IIdRol;
                Comando.Parameters.Add("@v_nombreCompleto", SqlDbType.NVarChar).Value = usuario._SNombre;
                Comando.Parameters.Add("@v_correo", SqlDbType.NVarChar).Value = usuario._SCorreo;
                Comando.Parameters.Add("@v_contra", SqlDbType.NVarChar).Value = usuario._SContrasena;
                Comando.Parameters.Add("@v_telefono", SqlDbType.NVarChar).Value = usuario._STelefono;

                Comando.CommandType = CommandType.StoredProcedure;

                Conextion.Open();
                Comando.ExecuteNonQuery();
                Conextion.Close();
                return true;
            }

        #endregion

    }

}
