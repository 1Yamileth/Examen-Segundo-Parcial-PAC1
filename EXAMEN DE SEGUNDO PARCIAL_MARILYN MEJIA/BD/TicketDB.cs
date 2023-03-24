using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public class TicketDB
    {
        string cadena = "server=localhost; user= root; database=examen_segundoparcial; password=Cinemax_tNt89";

        public bool GuardarTicket(Ticket ticket)
        {

            
                bool insertacion = false;
                int IdTicket = 0;
                try
                {
                    StringBuilder sqlFactura = new StringBuilder();
                    sqlFactura.Append("INSERT INTO ticket VALUES (@CodigoTicket,@Fecha, @CodigoUsuario, @IdentidadCliente, @TipoSoporte, @DescripcionSolicitud, @DescripcionRespuesta, @Precio, @Impuesto,  @Descuento, @Total) ;");
                    

                    using (MySqlConnection conexion = new MySqlConnection(cadena))
                    {
                        conexion.Open();
                        
                        try
                        {
                            using (MySqlCommand cmd = new MySqlCommand(sqlFactura.ToString(), conexion))
                            {
                                cmd.CommandType = System.Data.CommandType.Text;
                                cmd.Parameters.Add("@CodigoTicket", MySqlDbType.Int32).Value = ticket.CodigoTicket;
                                cmd.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = ticket.Fecha;
                              //  cmd.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 20).Value = ticket.CodigoUsuario;
                                cmd.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 20).Value = ticket.IdentidadCliente;
                           /**/ cmd.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 30).Value = ticket.TipoSoporte;
                                cmd.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 200).Value = ticket.DescripcionSolicitud;
                                cmd.Parameters.Add("@DescripcionRespuesta", MySqlDbType.VarChar, 200).Value = ticket.DescripcionRespuesta;
                                cmd.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = ticket.Precio;
                                cmd.Parameters.Add("@Impuesto", MySqlDbType.Decimal).Value = ticket.ISV;
                                cmd.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = ticket.Descuento;
                                cmd.Parameters.Add("@Total", MySqlDbType.Decimal).Value = ticket.Total;
                                cmd.ExecuteNonQuery();

                                
                                insertacion = true;
                            }
                        }
                        catch (System.Exception ex) {
                         MessageBox.Show("error al insertar: "+ ex.Message);
                         }
                     }
                }
                catch (System.Exception ex)
                {
                MessageBox.Show("error al insertar: "+ ex.Message);
            }
            return insertacion;
            
        }

    }
}
