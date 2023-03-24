using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        //PROPIEDADES
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public bool EstaActivo { get; set; }


        //CONSTRUCTORES
        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string nombre, string contraseña, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            EstaActivo = estaActivo;
        }
    }
}
