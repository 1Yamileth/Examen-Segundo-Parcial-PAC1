using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        //PROPIEDADES
        public string IdentidadCliente { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public Cliente()
        {
        }

        public Cliente(string identidadCliente, string nombre, string email)
        {
            IdentidadCliente = identidadCliente;
            Nombre = nombre;           
            Email = email;
        }
    }
}
