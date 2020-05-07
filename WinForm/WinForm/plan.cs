using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public class Plan
    {
        //public string apellido { get; set; }
        //public string nombre {get; set;}
        //public string apellidoNombre { get; set; }
        //public string ID { get; set; }
        public string pathPPF { get; set; }
        public string etiquetaPPF { get; set; }
        public double dosisFraccion { get; set; }
        public double numeroFracciones { get; set; }
        public double dosisTotal { get; set; }

        public modalidad modalidad { get; set; } //antes en paciente y string. Ahora Enum. 0 para 3D, 1 para IMRT SyS, 2 para IMRT mod
        public string equipo { get; set; }
        public string norma { get; set; }
        public int cantidadDeCampos { get; set; }
        public int numeroParametros { get; set; }

        public string DoseMode { get; set; }
        public string DensCorrection { get; set; }
        public List<Campo> listaCampos { get; set; }
        
        //public string etapa { get; set; }
        public string iso { get; set; }

        public List<Iso> isos { get; set; } //para usar después cuando agregue varios isos
        public TreeNode nodo { get; set; }
        public Tratamiento tratamiento { get; set; }

        public static string obtenerIso(Plan plan)
        {
            string iso = plan.listaCampos[0].iso;
            {
                foreach (Campo campo in plan.listaCampos)
                {
                    if (campo.iso != iso)
                    {
                        iso = "Hay más de un ISO";
                    }
                }
                return iso;
            }
        }

        public void obtenerIsos()
        {
            Iso iso1 = new Iso();
            iso1.ID = listaCampos[0].iso;
            isos = new List<Iso>();
            iso1.planes = new List<Plan>();
            isos.Add(iso1);
            if (!iso1.planes.Contains(this))
            {
                iso1.planes.Add(this);
            }
            {
                foreach (Campo campo in listaCampos)
                {
                    if (campo.iso != iso1.ID)
                    {
                        Iso isoN = new Iso();
                        isoN.ID = campo.iso;
                        isoN.planes = new List<Plan>();
                        isos.Add(isoN);
                        if (!isoN.planes.Contains(this))
                        {
                            isoN.planes.Add(this);
                        }
                    }
                }
            }

        }

       
    }
}
