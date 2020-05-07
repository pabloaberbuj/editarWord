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
    public class Textos
    {
        public static string encabezadoBEV1(Paciente paciente) //cambiar tabulado
        {
            return "Nombre: " + paciente.apellidoNombre + "                                        HC:" + paciente.ID + "                                      " + DateTime.Today.ToShortDateString();
        }
        
        public static string encabezadoBEV2(Tratamiento tratamiento, int etapa, Iso iso) //centrado
        {
            return "Etapa " + etapa.ToString() + "   –   " + iso.ID + "   –   Equipo " + tratamiento.planes[etapa - 1].equipo;
        }
        
        public static string parametrosCampoTto(Campo campo)
        {
            string aux = "G=" + campo.gantry;
            if (Convert.ToInt32(campo.col) != 180 && Convert.ToInt32(campo.col) != 0)
            {
                aux+= ", Col=" + campo.col;
            }
            if (Convert.ToInt32(campo.camilla) != 180 && Convert.ToInt32(campo.camilla) != 0)
            {
                aux += ", Camilla=" + campo.camilla;
            }
            return aux;
        }
        public static string parametrosCampoSetUp(string gantry, string tamanoCampo)
        {
            return "G=" + gantry + ", " + tamanoCampo;
        }
        
        public static string encabezadoInformeLinea1(Tratamiento tratamiento) //Times 14, negrita
        {
            string centro = "";
            if (tratamiento.planes[0].equipo == "Avellaneda")
            {
                centro = "Centro de Radiaciones Avellaneda";
            }
            else if (tratamiento.planes[0].equipo == "Quilmes")
            {
                centro = "Centro de Radiaciones Quilmes";
            }
            else
            {
                centro = "Centro Médico Mevaterapia";
            }
            return tratamiento.planes[0].modalidad + "	                            "+ centro +"	                            " + DateTime.Today.ToShortDateString();
        }
        
        public static string encabezadoInformeLinea2(Paciente paciente) //Times 12
        {
            return "Paciente: " + paciente.apellidoNombre + "	                            	                            HC: " + paciente.ID;
        }
        
        public static string encabezadoInformeLinea3(Tratamiento tratamiento) //Times 12 // centrado
        {
            string mod = "";
            if (tratamiento.planes[0].modalidad == modalidad.tridimensional)
            {
                mod = "tridimensional conformado de ";
            }
            else
            {
                mod = "con intensidad modulada de ";
            }
            return "Tratamiento " + mod  + tratamiento.nombre;
        }
        
        public static string axialInforme(Tratamiento tratamiento)
        {
            string etapa = "";
            if (tratamiento.planes.Count()==1)
            {
                etapa = "una etapa";
            }
            else
            {
                etapa = tratamiento.planes.Count.ToString() + " etapas";
            }
            string aux = "Corte axial en isocentro de la lesión y planificación del tratamiento en " + etapa + ", con " + tratamiento.cantidadTotalDeCampos().ToString() + " campos de radiación ";
            if (tratamiento.planes[0].modalidad == modalidad.tridimensional)
            {
                aux += "conformados";
            }
            else
            {
                aux += "modulados";
            }
            aux+= ". Las curvas representan niveles de dosis en % donde el 100% representa "
                + (Convert.ToDouble(tratamiento.dosisAcumulada()) / 100).ToString() + "Gy, indicados con diferentes colores.";
            return aux;
        }
        
        public static string coronalSagitalInforme()
        {
            return "Se muestra las vistas coronal y sagital reconstruidas a partir de los cortes tomográficos axiales. Las líneas azules son la proyección de la conformación de la lesión en cada corte axial.";
        }
        
        public static string tresDInforme(bool hayDosImagenes3D, bool hayTresImagenes3D)
        {
            string aux = "";
            if (hayDosImagenes3D || hayTresImagenes3D)
            {
                aux+= "Imágenes tridimensionales del tratamiento sobre un corte axial, en las que están representadas las superficies del 95% ";
            }
            else
            {
                aux += "Imagen tridimensional del tratamiento sobre un corte axial, en el que está representada la superficie del 95% ";
            }
            aux+= "en entramado de color rosa que envuelve la lesión. Las líneas rectas representan diferentes incidencias de los campos conformados. La intersección de los órganos críticos con el isovolumen de referencia, dará lugar a los histogramas acumulativos de dosis.";
            return aux;
        }
        
        public static string dvhInforme()
        {
            return "Histograma de distribución de dosis en los diferentes volúmenes delimitados en la tomografía.";
        }
        
        public static string profundidadesEfectivas(string textoCrudo)
        {
            string[] aux = textoCrudo.Split('\n');
            List<string> textoLimpio = new List<string>();
            string[] lineasQuedan = new string[] { "Effective", "Fields", "REF", "ISO" };
            foreach (string linea in aux)
            {
                string lineaNueva=linea.Trim();
                //lineaNueva=lineaNueva.Replace("-","");
                foreach (string lineaQueda in lineasQuedan)
                {
                    if (lineaNueva.StartsWith(lineaQueda))
                    {
                        textoLimpio.Add(lineaNueva);
                    }
                }
            }
            return string.Join("\n", textoLimpio.ToArray<string>());
        }


    }
}
