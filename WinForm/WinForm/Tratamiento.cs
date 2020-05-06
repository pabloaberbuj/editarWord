using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public class Tratamiento
    {
        public string nombre { get; set; }
        public string tratemiento_de { get; set; } //antes en paciente
        
        //public double dosisTotal { get; set; } //qutiar, pasa a tratamiento
        public List<Plan> planes { get; set; }
        public TreeNode nodo { get; set; }

        public double dosisAcumulada()
        {
            double _dosisAcumulada=0;
            foreach (Plan plan in planes)
            {
                _dosisAcumulada += plan.dosisTotal;
            }
            return _dosisAcumulada;
        }

        public int cantidadTotalDeCampos()
        {
            int _cantidadDeCampos = 0;
            foreach (Plan plan in planes)
            {
                _cantidadDeCampos += plan.cantidadDeCampos;
            }
            return _cantidadDeCampos;
        }

    }


};
