using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using Torneo.COMMON.Entidades;

namespace Torneo.COMMON.Interfaz
{
    public interface IManejadorGenerico<T> where T : Identificador
    {
        bool Agregar(T entidad);
        List<T> Lista { get;}
        bool Eliminar(ObjectId Id);
        bool Modificar(T entidad);
        T Buscador(ObjectId Id);
    }
}
