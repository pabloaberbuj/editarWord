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
            return "Nombre: " + plan.nombre[0] + ", " + plan.nombre[1] + "\t HC: " + plan.ID + "\t" + DateTime.Today.ToShortDateString();
        }
        
        public static string encabezadooBEV(Plan plan) //centrado
        {
            return "\n etapa " + "etapaPONER" + " – " + "isoPoner" + " – Equipo " + plan.equipo;
        }
        
        public static string parametrosCampoTto(Campo campo)
        {
            string aux = "G=" + campo.gantry + ", Col=" + campo.col;
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
        
        public satic string encabezadoInformeLinea1(Plan plan) //Times 14, negrita
        {
            if (plan.modalidad==0)
            {
                string mod = "T3DC";
                //string modalidad = "tridimensional conformado"
            }
            else
            {
                string mod = "TIMRT";
                //string modalidad = "con intensidad modulada"
            }
            
            return mod + "	                        Centro Médico Mevaterapia		" + DateTime.Today.ToShortDateString();
        }
        
        public satic string encabezadoInformeLinea2(Plan plan) //Times 12
        {
            return "Paciente: " + plan.nombre[0] + ", " + plan.nombre[1] + "	             HC: " + plan.ID;
        }
        
        public static string encabezadoInformeLinea3(Plan plan) //Times 12 // centrado
        {
            return "Tratamiento tridimensional conformado de " plan.patologia;
        }
        
        public static string axialInforme(Plan plan)
        {
            return "Corte axial en isocentro de la lesión y planificación del tratamiento en una etapa, con campos de radiación conformados. Las curvas representan niveles de dosis en \% donde el 100\% representa "
                + (plan.dosisTotal/10).ToString() +"Gy, indicados con diferentes colores.";
        }
        
        public static string coronalSagitalInforme()
        {
            return "Se muestra las vistas coronal y sagital reconstruidas a partir de los cortes tomográficos axiales. Las líneas azules son la proyección de la conformación de la lesión en cada corte axial.";
        }
        
        public static string tresDInforme(Plan plan)
        {
            return "Imagen tridimensional del tratamiento sobre un corte axial, en el que está representada la superficie de " + (plan.dosisTotal/10).ToString() + "Gy en entramado de color rosa que envuelve la lesión. Las líneas rectas representan diferentes incidencias de los campos conformados. La intersección de los órganos críticos con el isovolumen de referencia, dará lugar a los histogramas acumulativos de dosis.";
        }
        
        public static string dvhInforme(Plan plan)
        {
            return "Histograma de distribución de dosis en los diferentes volúmenes delimitados en la tomografía.";
        }
        


    }
}
