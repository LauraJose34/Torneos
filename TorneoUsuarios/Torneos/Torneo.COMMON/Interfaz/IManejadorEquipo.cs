using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Torneo.COMMON.Entidades;

namespace Torneo.COMMON.Interfaz
{
    public interface IManejadorEquipo : IManejadorGenerico<EquiposTorneos>
    {
        bool ContarNumeroTelefonico(string telefono);
        bool VerificarSiEsNumero(string telefono);
        IEnumerable BuscarEquipos(string palabra);
        int ContadorDeBuscarEquipo(string palabra);
       
        int Aleatorios(string palabra);

        // T Buscador(string Id);
    }
}
