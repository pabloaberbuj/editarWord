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
        public string dosisFraccion { get; set; }
        public string numeroFracciones { get; set; }
        public string dosisTotal { get; set; }

        public string equipo { get; set; }
        public int cantidadDeCampos { get; set; }
        public int numeroParametros { get; set; }
        public List<Campo> listaCampos { get; set; }
        //public string tratemiento_de {get;set;}
        public string etapa { get; set; }
        public string iso { get; set; }

        public List<Iso> isos { get; set; } //para usar después cuando agregue varios isos
        public TreeNode nodo { get; set; }
        public Tratamiento tratamiento { get; set; }

        public static string obtenerIso(Plan plan)
        {
            string iso = plan.listaCampos[0].isoID;
            {
                foreach (Campo campo in plan.listaCampos)
                {
                    if (campo.isoID != iso)
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
            iso1.ID = listaCampos[0].isoID;
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
                    if (campo.isoID != iso1.ID)
                    {
                        Iso isoN = new Iso();
                        isoN.ID = campo.isoID;
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
