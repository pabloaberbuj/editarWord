using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinForm
{
    public class Tratamiento
    {
        public string nombre { get; set; }
        public int numeroDeEtapas { get; set; } //antes en paciente
        public string tratemiento_de { get; set; } //antes en paciente
        public modalidad modalidad { get; set; } //antes en paciente y string. Ahora Enum. 0 para 3D, 1 para IMRT SyS, 2 para IMRT mod
        public double dosisTotal { get; set; } //qutiar, pasa a tratamiento
        public List<Plan> planes { get; set; }

    }
};
