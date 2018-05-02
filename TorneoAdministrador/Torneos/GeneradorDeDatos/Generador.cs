using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo.COMMON.CacharDatosOxi;
using Torneo.COMMON.Interfaz;

namespace GeneradorDeDatos
{
    public class Generador
    {
       /*IManejadorTorneo manejadorTorneo;
        public Generador()
        {
            Puntos = new List<Puntos>();
            List NombreDeportes = new List<NombreDeportes>();
            manejadorTorneo = new ManejadorTorneo(new RepositorioTorneo());
        }

        public List<Puntos> Puntos { get; set; }

        private double Evaluar(double x)//aqui pasare mi lista de puntos
        {
            return Math.Pow(x, 2);
        }

        public List<Puntos> GeneradorDatos(double limiteInferior, double limiteSuperior, double incremento)
        {
            Puntos = new List<Puntos>();
            for (double x = limiteInferior; x < limiteSuperior; x += incremento)
            {
                Puntos.Add(new Puntos(x, Evaluar(x)));
            }
            return Puntos;
        }

        public void GenerarListas(string deporte, string fecha)
        {
            foreach (var item in manejadorTorneo.Lista)
            {
                if (item.Tipo_Deporte == Deporte && item.FechaProgramada == Fecha)
                {
                    NombreDeportes a = new NombreDeportes();
                    a.Nombre = item.Equipo1;
                    a.Numerador = NombreDeportes.Count + 1;
                    NombreDeportes.Add(a);
                }
                if (item.Tipo_Deporte == Deporte && item.FechaProgramada == Fecha)
                {
                    NombreDeportes a = new NombreDeportes();
                    a.Nombre = item.Equipo2;
                    a.Numerador = nombreDeporte.Count + 1;
                    nombreDeporte.Add(a);
                }
            }
        }
       */
    }
}
