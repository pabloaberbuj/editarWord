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
        public static void crearCarpetas(string nombre, string ID)
        {
            string aux = nombre + " " + ID;
            Directory.CreateDirectory(pathDestino + aux);
            Directory.CreateDirectory(pathDestino + aux + "\\Plan");
        }

        public static List<string> obtenerImagenes(string apellido)
        {
            string patron = apellido + "*.bmp";
            return Directory.GetFiles(pathImagenes(), patron).ToList();
        }

        public static void moverImagenes(Plan plan)
        {
            string aux = plan.apellidoNombre + " " + plan.ID;
            
            foreach (string imagen in obtenerImagenes(plan.apellido))
            {
                string auxOrigen = imagen;
                string auxDestino = pathDestino + aux + Path.GetFileName(imagen);
                File.Move(imagen, pathDestino + aux + "\\" + Path.GetFileName(imagen));
            }
        }
    }
}
