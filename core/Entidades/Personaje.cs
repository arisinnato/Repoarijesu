using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces.Entidades; 

namespace core.Entidades
{
    public class Personaje : IPersonaje
    {
        public int id {get;set;}
        public string nombre {get;set;}=string.Empty;
        public int nivel{get;set;}
        public int vida {get;set;}
        public int energia{get;set;}
        public int fuerza{get;set;}
        public int inteligencia{get;set;}
        public int habilidad{get;set;}
        public ICollection<Equipamiento> Equipamiento { get; set; } = new List<Equipamiento>();
        public ICollection<Habilidades> Habilidades { get; set; } = new List<Habilidades>();
        public int experiencia{get;set;}
    }

}