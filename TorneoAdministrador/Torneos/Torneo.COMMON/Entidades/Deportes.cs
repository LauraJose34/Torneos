using System;
using System.Collections.Generic;
using System.Text;

namespace Torneo.COMMON.Entidades
{
    public class Deportes:Identificador
    {
        
        public string Tipo_Deporte { get; set; }
        public override string ToString()
        {
            return Tipo_Deporte;     
        }
    }
}
