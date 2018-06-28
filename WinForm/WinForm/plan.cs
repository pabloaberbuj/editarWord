using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public class Plan
    {
        public string[] nombre {get; set;}
        public string ID { get; set; }
		public double dosisFraccion {get;set;}
		public int numeroFracciones {get;set;}
		public double dosisTotal {get;set;}
		public int modalidad {get; set;} //0 para 3D, 1 para IMRT SyS, 2 para IMRT mod
		public string equipo {get;set;}
		public int cantidadDeCampos {get; set;}
		public int numeroParametros { get; set; }
		public List<Campo> listaCampos {get;set;}
	    public string patologia {get;set;}
        public string etapa { get; set; }
        public string iso { get; set; }
	}
}
