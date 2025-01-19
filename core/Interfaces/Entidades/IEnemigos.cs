using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entidades;

namespace core.Interfaces.Entidades
{
    public interface IEnemigos
    {
        public int Id {get;set;}
        public string Nombre {get;set;} 
        public int NivelDAmenaza {get;set;}
        public int Recompensa {get;set;} 
        public ICollection<Habilidades> Habilidades { get; set; } 
        public int Salud {get;set;} 
        public int Energia {get;set;} 
        public int Fuerza {get;set;}
        public int Inteligencia {get;set;} 
        public int Agilidad {get;set;}
    }
}