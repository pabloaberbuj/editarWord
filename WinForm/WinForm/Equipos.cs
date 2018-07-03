using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinForm
{
    class Equipos
    {
        public static Dictionary<string,string> diccionario()
        {
            Dictionary<string, string> Diccionario = new Dictionary<string, string>();
            Diccionario.Add("CETRO_Fotones_06MV", "Cetro");

            return Diccionario;

        }
        
        
        
    }
}
