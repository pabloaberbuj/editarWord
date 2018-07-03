using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WinForm
{
    class Equipos
    {
        public static Dictionary<string,string> diccionario()
        {
            Dictionary<string, string> Diccionario = new Dictionary<string, string>();
            string[] equiposTxt = File.ReadAllLines("Equipos.txt");
            foreach (string eq in equiposTxt)
            {
                string[] aux = eq.Split('\t');
                Diccionario.Add(aux[0], aux[1]);
            }
            return Diccionario;
        }
    }
}
