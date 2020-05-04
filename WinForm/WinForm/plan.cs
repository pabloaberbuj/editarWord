using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public class Plan
    {
        //public string apellido { get; set; }
        //public string nombre {get; set;}
        //public string apellidoNombre { get; set; }
        //public string ID { get; set; }
		public string dosisFraccion {get;set;}
		public string numeroFracciones {get;set;}
		public string dosisTotal {get;set;}
		
		public string equipo {get;set;}
		public int cantidadDeCampos {get; set;}
		public int numeroParametros { get; set; }
        public List<Campo> listaCampos {get;set;}
	    //public string tratemiento_de {get;set;}
        public string etapa { get; set; }
        public string iso { get; set; }

        

        public static string obtenerIso(Plan plan)
        {
            string iso = plan.listaCampos[0].iso;
            {
                foreach (Campo campo in plan.listaCampos)
                {
                    if (campo.iso != iso)
                    {
                        iso = "Hay más de un ISO";
                    }
                }
                return iso;
            }
        }
        
    }

    
}
