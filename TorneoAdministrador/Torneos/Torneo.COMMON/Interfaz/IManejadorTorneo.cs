using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Torneo.COMMON.Entidades;

namespace Torneo.COMMON.Interfaz
{
    public interface IManejadorTorneo : IManejadorGenerico<Torneos>
    {
        int VerificarSiEsNumero(string text);
    }
}
