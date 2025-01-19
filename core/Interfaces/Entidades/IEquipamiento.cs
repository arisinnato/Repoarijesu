using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Interfaces.Entidades
{
    public interface IEquipamiento
    {
        public int Id {get;set;} 
        public string Nombre {get;set;}  
        public string Casco {get;set;} 
        public string Coraza {get;set;} 
        public string Arma1 {get;set;} 
        public string Arma2 {get;set;} 
        public string Guanteletes {get;set;} 
        public string Grebas {get;set;} 
        public string Estadisticas {get;set;} 
    }
}