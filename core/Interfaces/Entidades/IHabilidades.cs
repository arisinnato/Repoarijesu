using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Interfaces.Entidades
{
    public interface IHabilidades
    {
        public int Id {get;set;} 
        public string Nombre {get;set;} 
        public string Descripcion {get;set;} 
        public int CostoEnergia {get;set;} 
        public int DañoBase {get;set;} 
        public int Curacion {get;set;} 
        public int Enfriamiento {get;set;} 
        public string Tipo {get;set;} 
    }
}