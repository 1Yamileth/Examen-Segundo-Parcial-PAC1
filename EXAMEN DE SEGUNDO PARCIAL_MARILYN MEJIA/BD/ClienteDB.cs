using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public class ClienteDB
    {
        string cadena = "server=localhost; user= root; database=examen_segundoparcial; password=Cinemax_tNt89";
        public bool InsertarCliente(Cliente cliente)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();

              
                sql.Append("INSERT INTO cliente VALUES ");
                sql.Append("( @IdentidadCliente, @Nombre, @Email); ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        
                        comando.CommandType = CommandType.Text;

                       
                        comando.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 20).Value = cliente.IdentidadCliente;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = cliente.Nombre;
                        comando.Parameters.Add("@Email", MySqlDbType.VarChar, 45).Value = cliente.Email;
                        comando.ExecuteNonQuery();
                        inserto = true;
                    }
                }

            }
            catch (System.Exception ex)
            {
                //MessageBox.Show("error al insertar: "+ ex.Message);
            }

            return inserto;
        }
    }
}
