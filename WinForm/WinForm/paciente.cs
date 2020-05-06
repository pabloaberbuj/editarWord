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
        public int cantidadDeCamposTotal { get; set; }
        public List<Tratamiento> tratamientos { get; set; } //Antes había lista de planes


        public Paciente crear(string ppf)
        {
            {
                string[] fid = Extraer.cargar(ppf);
                Paciente paciente = new Paciente()
                {
                    apellido = Extraer.apellidoPaciente(fid),
                    nombre = Extraer.nombrePaciente(fid),
                    apellidoNombre = Extraer.apellidoNombrePaciente(fid),
                    ID = Extraer.IDPaciente(fid),
                };
                paciente.tratamientos = new List<Tratamiento>();
                return paciente;
            }


        }
    }
}
