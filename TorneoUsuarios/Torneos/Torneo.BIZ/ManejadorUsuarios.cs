using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Torneo.COMMON.Entidades;
using Torneo.COMMON.Interfaz;

namespace Torneo.BIZ
{
    public class ManejadorUsuarios : IManejadorUsuarios
    {
        IRepositorio<Usuarios> usuario;
        public ManejadorUsuarios(IRepositorio<Usuarios> usuario) {
            this.usuario = usuario;
        }

        public List<Usuarios> Lista => usuario.Lista.OrderBy(p => p.Nombre).OrderBy(e => e.NombreDeUsuario).ToList();

        public bool Agregar(Usuarios entidad)
        {
            return usuario.Crear(entidad);
        }

        public Usuarios Buscador(ObjectId Id)
        {
            return Lista.Where(e => e.Id == Id).SingleOrDefault();
        }

        public bool ContarNumeroTelefonico(string telefono)
        {

            //que me ayuden a contar los datos que no sea espacion es blanco
            int var = 0;
            for (int i=0; i<=telefono.Count(); i++) {

                if (i!=32) {

                    var++;
                }
            }
            if (var == 11)
            {
                return true;
            }
            else {
                return false;
            }

            
            //que me ayuden a contar los datos que no sea espacion es blanco
        }

        public bool Eliminar(ObjectId Id)
        {
            return usuario.Eliminar(Id);
        }

        public bool Modificar(Usuarios entidad)
        {
            return usuario.Editar(entidad);
        }

        public bool VerificarSiEsNumero(string telefono)
        {
            foreach (var item in telefono)
            {
                if (!(char.IsNumber(item)))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            return true;
        }
    }
}
