using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces.Entidades;

namespace core.Entidades
{
    public class Equipamiento : IEquipamiento
    {
        public int Id {get;set;} 
        public string Nombre {get;set;} = string.Empty; 
        public string Casco {get;set;} = string.Empty;
        public string Coraza {get;set;} = string.Empty;
        public string Arma1 {get;set;} = string.Empty;
        public string Arma2 {get;set;} = string.Empty;
        public string Guanteletes {get;set;} = string.Empty;
        public string Grebas {get;set;} = string.Empty;
        public string Estadisticas {get;set;} = string.Empty;
    }
}