using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Plan
    {
        public string nombre {get; set;}
		public string ID {get;set}
		public double dosisFraccion {get;set;}
		public int numeroFracciones {get;set;}
		public double dosisTotal {get;set;}
		public int modalidad {get; set;} //0 para 3D, 1 para IMRT SyS, 2 para IMRT mod
		public string equipo {get;set;}
		public int cantidadDeCampos {get; set;}
		public int numeroParametros {et;
		public List<campo> listaCampos {get;set;}
	}
}