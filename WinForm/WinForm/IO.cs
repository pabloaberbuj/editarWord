using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinForm
{
    class IO
    {
        public static string[]  paths = File.ReadAllLines("Configuracion.txt");
        //public static string pathDestino = @"..\..\"; //PARA DEBUG
        public static string pathDestino = ""; 
        //public static string pathImagenes = "C:\\Users\\Casa\\source\\repos\\editarWord\\WinForm\\WinForm\\Abramidis";

        public static string pathProtocolos = @"..\..\";

        public static string pathImagenes()
        {
            return (paths[0].Split('\t'))[1];
        }
        public static void crearCarpetas(Paciente paciente)
        {
            string aux = paciente.apellidoNombre+ " " + paciente.ID;
            if (!Directory.Exists(pathDestino + aux))
            {
                Directory.CreateDirectory(pathDestino + aux);
            }
            if (!Directory.Exists(pathDestino + aux + "\\Plan"))
            {
                Directory.CreateDirectory(pathDestino + aux + "\\Plan");
            }
            if (paciente.numeroDeEtapas > 1)
            {
                for (int i = 1; i < paciente.numeroDeEtapas+1; i++)
                {
                    if (!Directory.Exists(pathDestino + aux + "\\Etapa " + i.ToString()))
                    {
                        Directory.CreateDirectory(pathDestino + aux + "\\Etapa " + i.ToString());
                    }
                }
            }
        }

        public static List<string> obtenerImagenes(Paciente paciente)
        {

            string apellido = paciente.apellido.Replace(' ', '_');
            //string nombre = paciente.nombre.Replace(' ', '_');
            //string apellidonombre = apellido + "_" + nombre.ToUpper();
            string patron = apellido + "*.bmp";
            return Directory.GetFiles(pathImagenes(), patron).ToList();
        }

        public static void moverImagenes(Paciente paciente, int etapa =0, bool esInformeVariasEtapas=false)
        {
            string aux = paciente.apellidoNombre + " " + paciente.ID;

            if (etapa>0 && !esInformeVariasEtapas)
            {
                aux += "\\Etapa " + etapa.ToString();
            }
            foreach (string imagen in obtenerImagenes(paciente))
            {
                string auxOrigen = imagen;
                string auxDestino = pathDestino + aux + "\\" + Path.GetFileName(imagen);
                if (!File.Exists(auxDestino))
                {
                    File.Move(imagen, auxDestino);
                }
            }
        }
    }
}
