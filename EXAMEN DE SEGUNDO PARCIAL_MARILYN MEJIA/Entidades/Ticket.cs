﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ticket
    {
        //PROPIEDADES
        public int CodigoTicket { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoUsuario { get; set; }
        public string IdentidadCliente { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public Ticket()
        {
        }

        public Ticket(int codigoTicket, DateTime fecha, string codigoUsuario, string identidadCliente, string tipoSoporte, string descripcionSolicitud, string descripcionRespuesta, decimal subtotal, decimal iSV, decimal descuento, decimal total)
        {
            CodigoTicket = codigoTicket;
            Fecha = fecha;
            CodigoUsuario = codigoUsuario;
            IdentidadCliente = identidadCliente;
            TipoSoporte = tipoSoporte;
            DescripcionSolicitud = descripcionSolicitud;
            DescripcionRespuesta = descripcionRespuesta;
            Subtotal = subtotal;
            ISV = iSV;
            Descuento = descuento;
            Total = total;
        }
    }
}
