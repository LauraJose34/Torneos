using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Torneo.COMMON.Entidades
{
    public abstract class Identificador
    {
        public ObjectId Id { get; set; }
    }
}
