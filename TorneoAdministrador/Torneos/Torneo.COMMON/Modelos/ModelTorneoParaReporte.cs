using System;
using System.Collections.Generic;
using System.Text;
using Torneo.COMMON.Entidades;

namespace Torneo.COMMON.Modelos
{
    public class ModelTorneoParaReporte
    {

        public string NumeroTorneo { get; set; }
        public string FechaTorneo { get; set; }
        public string Equipo { get; set; }
        public string Equipo2 { get; set; }           
        public ModelTorneoParaReporte(Torneos torneos) {
            Equipo = string.Format("{0} {1} ",  torneos.Equipo1, torneos.Marcador_1);
            Equipo2 = string.Format("{0} {1}", torneos.Equipo2, torneos.Marcador_2);
            FechaTorneo = torneos.FechaProgramada;
        }
    }
}
