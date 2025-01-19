using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces.Entidades;

namespace core.Entidades
{
    public class Objetos : IObjetos
    {
        public int Id {get;set;}
        public string Nombre {get;set;} = string.Empty;
        public string Descripcion {get;set;} = string.Empty;
        public string Tipo {get;set;} = string.Empty;
    }
}