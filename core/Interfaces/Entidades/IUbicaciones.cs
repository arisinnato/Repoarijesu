using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Interfaces.Entidades
{
    public interface IUbicaciones
    {
          public int Id {get;set;}
        public string nombre {get;set;} 
        public string descripcion{get;set;} 
    }
}