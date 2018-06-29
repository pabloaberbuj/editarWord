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
            return salida;
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
            else //no deber�a caer ac�
            {
                return 3;
            }
            
		}
			
		public static string[] nombrePaciente(string[] fid)
		{
			string aux = extraerString(fid,12).Trim();
            string[] aux2 = aux.Split('^');
            aux2[0]=aux2[0].ToUpper();
            return aux2;
		}
		
		public static string IDPaciente (string[] fid)
		{
			return extraerString(fid,13);
		}
		
		public static string equipo (string[] fid)
		{
			return extraerString(fid,19);
		}



        public static Campo extraerCampo(string[] fid, int numeroDeCampo, int parametros)
        {
            Campo campo = new Campo();
            int tab = (parametros + 1) * numeroDeCampo;
            int aux = Convert.ToInt32(extraerStringSinSep(fid, 21 + tab));
            if (aux == 0)
            {
                MessageBox.Show("Qued� el Field0");
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
                nombre = nombrePaciente(fid),
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
	
	