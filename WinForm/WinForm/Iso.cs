using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinForm
{
    public class Iso
    {
        public string ID { get; set; }
        public string patMove { get; set; }
        public List<Plan> planes { get; set; }

        public int imagenesIsosAnteriores(Plan plan, bool hayImagenesSetup)
        {
            if (plan.isos.First().ID == ID)
            {
                return 0;
            }
            else
            {
                int numImagenes = 0;
                foreach (Iso isoF in plan.isos)
                {
                    if (isoF.ID == ID)
                    {
                        break;
                    }
                    else
                    {
                        numImagenes += isoF.camposConEsteIso(plan).Count();
                        if (hayImagenesSetup)
                        {
                            numImagenes += 2;
                        }
                    }
                }
                return numImagenes;
            }
        }
        public List<Campo> camposConEsteIso(Plan plan)
        {
            List<Campo> campos = new List<Campo>();
            foreach (Campo campo in plan.listaCampos)
            {
                if (campo.iso == ID)
                {
                    campos.Add(campo);
                }
            }
            return campos;
        }
    }


}
