using System;
using System.Collections.Generic;
using System.Text;

namespace Torneo.COMMON.Entidades
{
    public class EquiposTorneos: Identificador
    {
        public string Nombre { get; set; }
        public string Director { get; set; }
       // public List<Integrantes> IntegrantesEquipo { get; set; }
        public string Tipo_De_Deporte { get; set; }

        public override string ToString()
        {
            return Nombre; 
        }
    }
}
