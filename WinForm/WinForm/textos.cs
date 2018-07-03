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
        public static string encabezadoBEV1(Plan plan) //cambiar tabulado
        {
            return "Nombre: " + plan.apellidoNombre + "                       HC:" + plan.ID + "                      " + DateTime.Today.ToShortDateString();
        }
        
        public static string encabezadoBEV2(Plan plan) //centrado
        {
            return "Etapa " + plan.etapa + "   –   " + plan.iso + "   –   Equipo " + plan.equipo;
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
        
        public static string encabezadoInformeLinea1(Plan plan) //Times 14, negrita
        {
            return plan.modalidad + "	                            Centro Médico Mevaterapia	                            " + DateTime.Today.ToShortDateString();
        }
        
        public static string encabezadoInformeLinea2(Plan plan) //Times 12
        {
            return "Paciente: " + plan.apellidoNombre + "	                            	                            HC: " + plan.ID;
        }
        
        public static string encabezadoInformeLinea3(Plan plan) //Times 12 // centrado
        {
            string mod = "";
            if (plan.modalidad == "T3DC")
            {
                mod = "tridimensional conformado de ";
            }
            else
            {
                mod = "con intensidad modulada de ";
            }
            return "Tratamiento " + mod  + plan.patologia;
        }
        
        public static string axialInforme(Plan plan)
        {
            string aux = "Corte axial en isocentro de la lesión y planificación del tratamiento en una etapa, con campos de radiación ";
            if (plan.modalidad== "T3DC")
            {
                aux += "conformados";
            }
            else
            {
                aux += "modulados";
            }
            aux+= ". Las curvas representan niveles de dosis en % donde el 100% representa "
                + (Convert.ToDouble(plan.dosisTotal) / 100).ToString() + "Gy, indicados con diferentes colores.";
            return aux;
        }
        
        public static string coronalSagitalInforme()
        {
            return "Se muestra las vistas coronal y sagital reconstruidas a partir de los cortes tomográficos axiales. Las líneas azules son la proyección de la conformación de la lesión en cada corte axial.";
        }
        
        public static string tresDInforme(bool hayDosImagenes3D)
        {
            string aux = "";
            if (hayDosImagenes3D)
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
        
        public static string dvhInforme(Plan plan)
        {
            return "Histograma de distribución de dosis en los diferentes volúmenes delimitados en la tomografía.";
        }
        


    }
}
