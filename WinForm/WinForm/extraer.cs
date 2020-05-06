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
                return File.ReadAllLines(archivo,Encoding.GetEncoding(28591));
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido abrir. Posiblemente el archivo esté en uso por otra aplicación" + e.ToString(), "Error abriendo el archivo");
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
            return Convert.ToInt32(extraerString(fid, 4));
        }
        public static int numeroCampos(string[] fid)
        {
            return Convert.ToInt32(extraerDouble(fid, 5));
        }

        public static double dosisFraccion(string[] fid)
        {
            return extraerDouble(fid, 6);
        }

        public static string CalculationMode(string[] fid)
        {
            string aux = extraerStringSinSep(fid, fid.Length-3).Trim();
            string[] aux2 = aux.Split(':');
            return aux2[1];

        }

        public static string DensityON(string[] fid)
        {
            string aux = extraerStringSinSep(fid, fid.Length - 1).Trim();
            string[] aux2 = aux.Split(' ');
            return aux2[2];

        }

        public static int numeroFracciones(string[] fid)
        {
            return Convert.ToInt32(extraerDouble(fid, 8));
        }

        public static double dosisTotal(string[] fid)
        {
            return dosisFraccion(fid) * numeroFracciones(fid);
        }
        public static modalidad modalidad(string[] fid)
        {
            if (extraerString(fid, 10) == "CRT-3D")
            {
                return WinForm.modalidad.tridimensional;
            }
            else if (extraerString(fid, 10) == "IMRT(s&s)")
            {
                return WinForm.modalidad.IMRT_MLC;
            }
            else //if (extraerString(fid, 10) == "IMRT(mod)")
            {
                return WinForm.modalidad.IMRT_moduladores;
            }
        }

        public static string apellidoPaciente(string[] fid)
        {
            string aux = extraerString(fid, 12).Trim();
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

        public static string IDPaciente(string[] fid)
        {
            return extraerString(fid, 13);
        }

        public static string equipo(string[] fid)
        {
            string aux = extraerString(fid, 19);
            if (Equipos.diccionario().ContainsKey(aux))
            {
                return Equipos.diccionario()[aux];
            }
            else
            {
                return "-1";
            }            

        }
        public static string norma(string[] fid)
        {
            string aux = extraerString(fid, 19);
            if (NormaEq.diccionario().ContainsKey(aux))
            {
                return NormaEq.diccionario()[aux];
            }
            else
            {
                return aux;
            }

        }


        public static Campo extraerCampo(string[] fid, int numeroDeCampo, int parametros, bool hayCampo0)
        {
            Campo campo = new Campo();
            int tab = (parametros + 1) * numeroDeCampo;
            if (hayCampo0)
            {
                tab += parametros + 1;
            }
            campo.numero = numeroDeCampo;
            campo.iso = extraerStringSinSep(fid, 22 + tab);
            campo.gantry = extraerStringSinSep(fid, 26 + tab);
            campo.col = extraerStringSinSep(fid, 28 + tab);
            campo.camilla = extraerStringSinSep(fid, 25 + tab);
            campo.Weight = Convert.ToDouble(extraerStringSinSep(fid, 29 + tab));
            campo.WDG = extraerStringSinSep(fid, 30 + tab);
            campo.WDG_ori = extraerStringSinSep(fid, 31 + tab);
            campo.SldFile = extraerStringSinSep(fid, 32 + tab);
            campo.TrayFactor = Convert.ToDouble(extraerStringSinSep(fid, 33 + tab));
            campo.Y2 = Convert.ToInt32(extraerStringSinSep(fid, 34 + tab));
            campo.Y1 = Convert.ToInt32(extraerStringSinSep(fid, 35 + tab));
            campo.X1 = Convert.ToInt32(extraerStringSinSep(fid, 36 + tab));
            campo.X2 = Convert.ToInt32(extraerStringSinSep(fid, 37 + tab));
            campo.SSD = Convert.ToDouble(extraerStringSinSep(fid, 38 + tab));
            campo.MU = Convert.ToDouble(extraerStringSinSep(fid, 41 + tab));
            campo.Y = Convert.ToInt32(extraerStringSinSep(fid, 23 + tab));
            campo.X = Convert.ToInt32(extraerStringSinSep(fid, 24 + tab));

            return campo;
        }
        public static Plan extraerPlan(string[] fid)
        {
            Plan plan = new Plan()
            {
                dosisFraccion = dosisFraccion(fid),
                numeroFracciones = numeroFracciones(fid),
                dosisTotal = dosisTotal(fid),
                equipo = equipo(fid),
				norma = norma(fid),			   
                cantidadDeCampos = numeroCampos(fid),
                numeroParametros = numeroParametros(fid),
                modalidad = modalidad(fid),
				DoseMode = CalculationMode(fid),
                DensCorrection = DensityON(fid),								
            };

            plan.listaCampos = new List<Campo>();
            int aux = Convert.ToInt32(extraerStringSinSep(fid, 21 + plan.numeroParametros + 1));
            bool hayCampo0 = false;
            if (aux == 0)
            {
                MessageBox.Show("Quedó activado el Field 0. Se cargaran los otros campos");
                hayCampo0 = true;
            }
            for (int i = 0; i < plan.cantidadDeCampos; i++)
            {
                plan.listaCampos.Add(extraerCampo(fid, i + 1, plan.numeroParametros,hayCampo0));
            };
            plan.iso = Plan.obtenerIso(plan);
            plan.obtenerIsos();
            return plan;
        }

        public static Paciente extraerPaciente(string[] fid)
        {
            Paciente paciente = new Paciente()
            {
                apellido = apellidoPaciente(fid),
                nombre = nombrePaciente(fid),
                apellidoNombre = apellidoNombrePaciente(fid),
                ID = IDPaciente(fid),
            };
            paciente.tratamientos = new List<Tratamiento>();
            return paciente;
        }

        

    }
}

