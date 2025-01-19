using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces.Entidades;

namespace core.Entidades
{
    public class Habilidades : IHabilidades
    {
        public int Id {get;set;} 
        public string Nombre {get;set;} = string.Empty;
        public string Descripcion {get;set;} = string.Empty;
        public int CostoEnergia {get;set;} 
        public int DañoBase {get;set;} 
        public int Curacion {get;set;} 
        public int Enfriamiento {get;set;} 
        public string Tipo {get;set;} = string.Empty; 

    }
}