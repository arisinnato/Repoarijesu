using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Interfaces.Entidades
{
    public interface IMision
    {
        public int Id {get;set;}
        public string Nombre {get;set;} 
        public string Descripcion {get;set;} 
        public ICollection<string> Objetivos {get;set;} 
        public string Recompensas {get;set;} 
        public string Estado {get;set;} 
    }
}