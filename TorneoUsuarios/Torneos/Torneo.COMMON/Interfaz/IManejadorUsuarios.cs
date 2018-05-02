using System;
using System.Collections.Generic;
using System.Text;
using Torneo.COMMON.Entidades;

namespace Torneo.COMMON.Interfaz
{
    public interface IManejadorUsuarios:IManejadorGenerico<Usuarios>
    {
        bool ContarNumeroTelefonico(string telefono);
        bool VerificarSiEsNumero(string telefono);
    }
}
