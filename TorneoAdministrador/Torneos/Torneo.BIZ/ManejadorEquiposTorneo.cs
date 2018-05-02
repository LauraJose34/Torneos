
using MongoDB.Bson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Torneo.COMMON.Entidades;
using Torneo.COMMON.Interfaz;

namespace Torneo.BIZ
{
    public class ManejadorEquiposTorneo:IManejadorEquipo
    {
        IRepositorio<EquiposTorneos> equi;
        public ManejadorEquiposTorneo(IRepositorio<EquiposTorneos> usuario)
        {
            this.equi = usuario;
        }

        public List<EquiposTorneos> Lista => equi.Lista.OrderBy(p => p.Nombre).OrderBy(e => e.Tipo_De_Deporte).ToList();

        public bool Agregar(EquiposTorneos entidad)
        {
            return equi.Crear(entidad);
        }

        

        public int Aleatorios(string palabra)
        {
           int valor= ContadorDeBuscarEquipo(palabra);
            Random a = new Random();
            int v = 0;
            return v = a.Next(1, valor);
        }

        public EquiposTorneos Buscador(ObjectId Id)
        {
            return Lista.Where(e => e.Tipo_De_Deporte == Id.ToString()).SingleOrDefault();
        }

        public IEnumerable BuscarEquipos(string palabra)
        {
            return Lista.Where(e => e.Tipo_De_Deporte == palabra).ToList();
        }

       

        public int ContadorDeBuscarEquipo(string palabra)
        {
            return Lista.Where(e => e.Tipo_De_Deporte == palabra).ToList().Count();
        }

        public bool ContarNumeroTelefonico(string telefono)
        {

            //que me ayuden a contar los datos que no sea espacion es blanco
            int var = 0;
            for (int i = 0; i <= telefono.Count(); i++)
            {

                if (i != 32)
                {

                    var++;
                }
            }
            if (var == 10)
            {
                return true;
            }
            else
            {
                return false;
            }


            //que me ayuden a contar los datos que no sea espacion es blanco
        }

        public bool Eliminar(ObjectId Id)
        {
            return equi.Eliminar(Id);
        }

        public bool Modificar(EquiposTorneos entidad)
        {
            return equi.Editar(entidad);
        }

        public bool VerificarSiEsNumero(string telefono)
        {
            foreach (var item in telefono)
            {
                if (!(char.IsNumber(item)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
