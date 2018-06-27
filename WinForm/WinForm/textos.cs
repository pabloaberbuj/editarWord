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
        public static string encabezadoBEV(Plan plan)
        {
            return "Nombre: " + plan.nombre[0] + ", " + plan.nombre[1] + "\t HC: " + plan.ID + "\t" + DateTime.Today.ToShortDateString() + "\n etapa " + "etapaPONER" + " – " + "isoPoner" + " – Equipo " + plan.equipo;
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
        
        
Tratamiento tridimensional conformado de 

    }
}
