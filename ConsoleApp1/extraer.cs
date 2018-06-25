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
    public class Extraer
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
            return salida;
        }
        public static double extraerDouble(string[] fid, int linea)
        {
            return Convert.ToDouble(extraerString(fid, linea));
        }
		
		public static string numeroParametros(string[] fid)
		{
			return extraerString(fid,4);
		}
		public static int numeroCampos(string[] fid)
		{
			return Convert.ToInt32(extraerDouble(fid,5));
		}
		
		public static double dosisFraccion (string[] fid)
		{
			return extraerDouble(fid,6);
		}
		
		public static int numeroFracciones(string[] fid)
		{
			return Convert.ToInt32(extraerDouble(fid,8));
		}
		
		public static double dosisTotal(string[] fid)
		{
			return dosisFraccion(fid)*numeroFracciones(fid);
		}
		public static int modalidad(string[] fid)
		{
			if (extraerString(fid,10)=="CRT-3D")
			{
				return 0;
			}
			else if (extraerString(fid,10)=="IMRT(s&s)")
			{
				return 1;
			}
			else if (extraerString(fid,10)=="IMRT(mod)")
			{
				return 2;
			}
		}
			
		public static string nombrePaciente(string[] fid)
		{
			return extraerString(fid,12);
		}
		
		public static string IDPaciente (string[] fid)
		{
			return extraerString(fid,13);
		}
		
		public static string equipo (string[] fid)
		{
			return extraerString(fid,19);
		}
		
		
        
        public static campo extraerCampo(string[] fid, int numeroDeCampo, int parametros)
        {
            campo Campo = new campo()
            int tab = (parametros+1)*numeroDeCampo;
            int aux = Convert.ToInt32(extraerString(fid,21+tab);
            if (aux==0)
                {
                    break;
                }
                else
                {
                    
                    {
                        numero = numeroDeCampo,
                        iso = extraerString(fid,22+tab),
                        gantry = extraerString(fid,26+tab),
                        col = extraerString(fid,27+tab),
                        camilla = extraerString(fid,2+tab),
                    };
                }
            }
            return Campo;
            
            public static plan extraerPlan(string[] fid)
            {
                plan Plan = new Plan()
                {
                    nombre = nombrePaciente(fid),
                    ID = IDPaciente(fid),
                    dosisFraccion = dosisFraccion(fid),
					numeroFracciones = numeroFracciones(fid),
					dosisTotal = dosisTotal(fid),
					modalidad = modalidad(fid),
					equipo = equipo(fid),
					cantidadDeCampos = numeroCampos(fid),
					numeroParametros = numeroParametros(fid),
                }
                
                Plan.listaCampos = new List<campo>();
				for (int i=0;i<Plan.cantidadDeCampos;i++
				{
					Plan.listaCampos.Add(extraerCampo(fid,i+1,Plan.numeroParametros));
				});
				return Plan;
            }
            
            
        }
	}
	
	