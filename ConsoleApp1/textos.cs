using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Textos
	{
		public static string encabezadoBEV(string nombrePaciente, string HC, string etapa, string iso, string equipo)
		{
			return "Nombre: " + nombrePaciente + "\t HC: " + HC + "\t" + DateTime.Today().ToShortDateString() + "\p etapa " + etapa + " – " + iso + " – Equipo " + equipo;
		}
		public static string parametrosCampoTto(Campo campo)
		{
			string aux = "G=" + campo.Gantry + ", Col=" + campo.colimador;
			if (Convert.ToInt32(campo.camilla) !=180 && Convert.ToInt32(campo.camilla) !=0)
			{
				aux+=", Camilla=" + campo.camilla;
			}
			return aux;
		}
		public static string parametrosCampoSetUp(string gantry, string tamanoCampo)
		{
			return "G=" + gantry + ", " + tamanoCampo;
		}