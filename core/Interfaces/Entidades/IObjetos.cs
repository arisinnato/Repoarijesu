using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Interfaces.Entidades
{
    public interface IObjetos
    {
         public int Id {get;set;}
        public string Nombre {get;set;} 
        public string Descripcion {get;set;} 
        public string Tipo {get;set;} 
    }
}