using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using Torneo.COMMON.Entidades;

namespace Torneo.COMMON.Interfaz
{
   public interface IRepositorio<T> where T:Identificador 
    {

        bool Crear(T entidad);
        bool Editar(T entidad);
        bool Eliminar(ObjectId Id);
        List<T> Lista { get; }


    }
}
