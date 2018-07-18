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
            Directory.CreateDirectory(pathDestino + aux);
            Directory.CreateDirectory(pathDestino + aux + "\\Plan");
            if (paciente.numeroDeEtapas > 1)
            {
                for (int i = 1; i < paciente.numeroDeEtapas+1; i++)
                {
                    Directory.CreateDirectory(pathDestino + aux + "\\Etapa " + i.ToString());
                }
            }
        }

        public static List<string> obtenerImagenes(string apellido)
        {
            apellido = apellido.Replace(' ', '_');
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
            foreach (string imagen in obtenerImagenes(paciente.apellido))
            {
                string auxOrigen = imagen;
                string auxDestino = pathDestino + aux + Path.GetFileName(imagen);
                File.Move(imagen, pathDestino + aux + "\\" + Path.GetFileName(imagen));
            }
        }
    }
}
