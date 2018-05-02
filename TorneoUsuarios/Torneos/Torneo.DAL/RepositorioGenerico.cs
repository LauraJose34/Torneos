using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using Torneo.COMMON.Entidades;
using Torneo.COMMON.Interfaz;

namespace Torneo.DAL
{
    public class RepositorioGenerico<T> : IRepositorio<T> where T : Identificador
    {
        private MongoClient client;
        private IMongoDatabase db;
        public RepositorioGenerico()
        {
            client = new MongoClient(new MongoUrl("mongodb://laujos:ghat5lth99@ds147659.mlab.com:47659/laujos"));
            db = client.GetDatabase("laujos");//nombre de mi base de datos
        }

        private IMongoCollection<T> Collection() {
            return db.GetCollection<T>(typeof(T).Name);
        }

        public List<T> Lista => Collection().AsQueryable().ToList();
         
        public bool Crear(T entidad)
        {
            try
            {
                Collection().InsertOne(entidad);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public bool Editar(T entidad)
        {
            try
            {
                return Collection().ReplaceOne(p=>p.Id==entidad.Id, entidad).ModifiedCount==1;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar(ObjectId Id)
        {
            try
            {
               return Collection().DeleteOne(p => p.Id == Id).DeletedCount ==1 ;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
