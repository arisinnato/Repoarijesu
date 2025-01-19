using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entidades;

namespace core.Interfaces.Entidades
{
    public interface IPersonaje
    {
        public int id {get;set;}
        public string nombre {get;set;}
        public int nivel{get;set;}
        public int vida {get;set;}
        public int energia{get;set;}
        public int fuerza{get;set;}
        public int inteligencia{get;set;}
        public int habilidad{get;set;}
        ICollection<Equipamiento> Equipamiento { get; set; }
        ICollection<Habilidades> Habilidades { get; set; }
        
    }
}