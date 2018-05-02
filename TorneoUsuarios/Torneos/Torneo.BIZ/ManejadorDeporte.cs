using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Torneo.COMMON.Entidades;
using Torneo.COMMON.Interfaz;

namespace Torneo.BIZ
{
    public class ManejadorDeporte:IManejadorDeporte
    {
        IRepositorio<Deportes> deportes;
        public ManejadorDeporte(IRepositorio<Deportes> deportes)
        {
            this.deportes = deportes;
        }

        public List<Deportes> Lista => deportes.Lista.OrderBy(p => p.Tipo_Deporte).ToList();

        public bool Agregar(Deportes entidad)
        {
            return deportes.Crear(entidad);
        }

        public Deportes Buscador(ObjectId Id)
        {
          /*  if (Lista.Where(e => e.Tipo_Deporte == Id)) {

            } else { }*/
            return Lista.Where(e=> e.Tipo_Deporte== Id.ToString()).SingleOrDefault();
        }

        public bool Eliminar(ObjectId Id)
        {
            return deportes.Eliminar(Id);
        }

        public bool Modificar(Deportes entidad)
        {
            return deportes.Editar(entidad);
        }
    }
}
