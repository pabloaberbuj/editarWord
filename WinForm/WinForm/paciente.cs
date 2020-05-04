using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinForm
{
    public class Paciente
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string apellidoNombre { get; set; }
        public string ID { get; set; }
        public int numeroDeEtapas { get; set; } //quitar pasa a tratamiento
        public string tratemiento_de { get; set; } //quitar, pasa a tratamiento
        public string modalidad { get; set; } //0 para 3D, 1 para IMRT SyS, 2 para IMRT mod
        public double dosisTotal { get; set; } //qutiar, pasa a tratamiento
        public int cantidadDeCamposTotal { get; set; }
        public List<Tratamiento> tratamientos { get; set; } //Antes había lista de planes
        public List<Plan> planes { get; set; } //Quitar, ahora hay lista de tratamientos

        public void dosisTotalPaciente(Paciente paciente)
        {
            paciente.dosisTotal = 0;
            foreach (Plan plan in paciente.planes)
            {
                paciente.dosisTotal += Convert.ToDouble(plan.dosisTotal);
            }
        }

        public void cantidadTotalDeCampos(Paciente paciente)
        {
            paciente.cantidadDeCamposTotal = 0;
            foreach (Plan plan in paciente.planes)
            {
                paciente.cantidadDeCamposTotal += plan.cantidadDeCampos;
            }
        }
    }
}
