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
    public class Chequear
    {
        public static bool numeroDeImagenes(int numeroDeImagenesEsperadas, int numeroDeImagenesEncontradas)
        {
            return numeroDeImagenesEsperadas == numeroDeImagenesEncontradas;
        }
        public static bool field0(int numeroDeCampo1)
        {
            return numeroDeCampo1 != 0;
        }

        public static bool archivoConfiguracion()
        {
            return (File.Exists("Configuracion.txt"));
        }

        public static bool archivoEquipos()
        {
            return (File.Exists("Equipos.txt"));
        }

        public static bool directorioExport()
        {
            return (Directory.Exists(IO.pathImagenes()));
        }
    }
}
		
	