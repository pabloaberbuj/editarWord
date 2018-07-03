using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public static class Extraer
    {
        public static string[] cargar(string archivo)
        {
            try
            {
                return File.ReadAllLines(archivo);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido abrir. Posiblemente el archivo est?? en uso por otra aplicaci??n\n\n" + e.ToString(), "Error abriendo el archivo");
                throw;
            }
        }
		
		public static string extraerString(string[] fid, int linea, char sep = '=')
        {
            string aux = fid[linea]; string[] aux2 = aux.Split(sep); string salida = aux2[1];
            return salida.Trim();
        }

        public static string extraerStringSinSep(string[] fid, int linea)
        {
            return fid[linea];
        }

        public static double extraerDouble(string[] fid, int linea)
        {
            return Convert.ToDouble(extraerString(fid, linea));
        }
		
		public static int numeroParametros(string[] fid)
		{
			return Convert.ToInt32(extraerString(fid,4));
		}
		public static int numeroCampos(string[] fid)
		{
			return Convert.ToInt32(extraerDouble(fid,5));
		}
		
		public static string dosisFraccion (string[] fid)
		{
			return extraerString(fid,6);
		}
		
		public static string numeroFracciones(string[] fid)
		{
			return extraerString(fid,8);
		}
		
		public static string dosisTotal(string[] fid)
		{
			return (Convert.ToDouble(dosisFraccion(fid))*Convert.ToDouble(numeroFracciones(fid))).ToString();
		}
		public static string modalidad(string[] fid)
		{
			if (extraerString(fid,10)=="CRT-3D")
			{
				return "T3DC";
			}
			else if (extraerString(fid,10)=="IMRT(s&s)")
			{
				return "IMRT";
			}
			else if (extraerString(fid,10)=="IMRT(mod)")
			{
				return "IMRT";
			}
            else //no debería caer acá
            {
                return "";
            }
            
		}
			
		public static string apellidoPaciente(string[] fid)
		{
			string aux = extraerString(fid,12).Trim();
            string[] aux2 = aux.Split('^');
            return aux2[0].ToUpper();
		}
        public static string nombrePaciente(string[] fid)
        {
            string aux = extraerString(fid, 12).Trim();
            string[] aux2 = aux.Split('^');
            return aux2[1];
        }

        public static string apellidoNombrePaciente(string[] fid)
        {
            return apellidoPaciente(fid) + ", " + nombrePaciente(fid);
        }

        public static string IDPaciente (string[] fid)
		{
			return extraerString(fid,13);
		}
		
		public static string equipo (string[] fid)
		{
            string aux = extraerString(fid, 19);
            if (Equipos.diccionario().ContainsKey(aux))
            {
                return Equipos.diccionario()[aux];
            }
            else
            {
                return aux;
            }
            
		}



        public static Campo extraerCampo(string[] fid, int numeroDeCampo, int parametros)
        {
            Campo campo = new Campo();
            int tab = (parametros + 1) * numeroDeCampo;
            int aux = Convert.ToInt32(extraerStringSinSep(fid, 21 + tab));
            if (aux == 0)
            {
                MessageBox.Show("Quedó el Field0");
            }
            else
            {
                campo.numero = numeroDeCampo;
                campo.iso = extraerStringSinSep(fid, 22 + tab);
                campo.gantry = extraerStringSinSep(fid, 26 + tab);
                campo.col = extraerStringSinSep(fid, 28 + tab);
                campo.camilla = extraerStringSinSep(fid, 25 + tab);
            }
            return campo;
        }
            public static Plan extraerPlan(string[] fid)
            {
            Plan plan = new Plan()
            {
                apellido = apellidoPaciente(fid),
                nombre = nombrePaciente(fid),
                apellidoNombre = apellidoNombrePaciente(fid),
                ID = IDPaciente(fid),
                dosisFraccion = dosisFraccion(fid),
                numeroFracciones = numeroFracciones(fid),
                dosisTotal = dosisTotal(fid),
                modalidad = modalidad(fid),
                equipo = equipo(fid),
                cantidadDeCampos = numeroCampos(fid),
                numeroParametros = numeroParametros(fid),
            };
                
                plan.listaCampos = new List<Campo>();
				for (int i=0;i<plan.cantidadDeCampos;i++)
				{
					plan.listaCampos.Add(extraerCampo(fid,i+1,plan.numeroParametros));
				};
                plan.iso = Plan.obtenerIso(plan);
				return plan;
            }
            
            
        }
	}
	
	