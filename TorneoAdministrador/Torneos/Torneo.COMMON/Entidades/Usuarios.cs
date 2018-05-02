using System;
using System.Collections.Generic;
using System.Text;

namespace Torneo.COMMON.Entidades
{
    public  class Usuarios: Persona
    {
        public DateTime? FechaNacimiento { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Tipo { get; set; }
        public string Contraseña { get; set; }
        public string Deporte { get; set; }
        public override string ToString()
        {
            return NombreDeUsuario; 
        }
    }
}
