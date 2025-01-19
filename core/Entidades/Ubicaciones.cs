using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces.Entidades;

namespace core.Entidades
{
    public class Ubicaciones : IUbicaciones
    {
        public int Id {get;set;}
        public string nombre {get;set;} = string.Empty;
        public string descripcion{get;set;} = string.Empty;
    }
}