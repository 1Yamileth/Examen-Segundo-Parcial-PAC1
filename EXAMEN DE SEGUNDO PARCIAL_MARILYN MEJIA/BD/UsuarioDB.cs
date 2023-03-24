using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace BD
{
    public class UsuarioDB
    {
        string cadena = "server=localhost; user= root; database=examen_segundoparcial; password=Cinemax_tNt89";

        public Usuario Autenticar(Login login)
        {
            Usuario usuario  = null;
            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT * FROM usuario WHERE CodigoUsuario=@CodigoUsuario AND Contrasena= @Contrasena");


                using (MySqlConnection conexion = new MySqlConnection(cadena))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), conexion))
                    {
                        comando.CommandType = CommandType.Text;


                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = login.Contraseña;

                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())/*VALIDAMOS SI EL DATA  READER TIENE ALGO */
                        {
                            usuario = new Usuario();

                            usuario.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            usuario.Nombre = dr["Nombre"].ToString();
                            usuario.Contraseña = dr["Contrasena"].ToString();
                            usuario.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);


                        }
                    }
                }

            }
            catch (Exception)//Devuelve el tipo de error que genero el try.
            {

            }

            return usuario;
        }
    }
}
