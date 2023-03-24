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
       

        public Cliente DevolverClientePorId(string identidadCliente)
        {
            Cliente clien = null;

            try
            {
                StringBuilder sql = new StringBuilder();

                
                sql.Append("SELECT * FROM cliente WHERE IdentidadCliente=@IdentidadCliente  ");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                       
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 20).Value = identidadCliente;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            clien = new Cliente();
                            clien.IdentidadCliente = identidadCliente;
                            clien.Nombre = dr["Nombre"].ToString();
                        }
                    }
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("error al insertar: "+ ex.Message);
            }

                return clien;
        }

    }
}
