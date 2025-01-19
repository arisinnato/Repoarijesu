using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces.Entidades;

namespace core.Entidades
{
    public class Mision : IMision
    {
        public int Id {get;set;}
        public string Nombre {get;set;} = string.Empty;
        public string Descripcion {get;set;} = string.Empty;
        public ICollection<string> Objetivos {get;set;} = new List<string>();
        public string Recompensas {get;set;} = string.Empty;
        public string Estado {get;set;} = "Activa";

        public void CompletarMision()
        {
            Estado = "mision Completada";
        }
        public void AbadndonarMision()
        {
            Estado = "mision abandonada";
        }
    }
}