using System.Collections.Generic;
using System.Linq;

namespace Visitas
{
    class Paciente
    {
        public string Nombre { get; set; }
        public string Horario { get; set; }
        public string Cedula { get; set; }

        public string Cama { get; set; }

        public string getPaciente()
        {
            return "Nombre: " + Nombre +
                "   Cedula: " + Cedula +
                "   Cama: " + Cama +
                "   Horario: " + Horario;
        }

        public string getPacienteResumen()
        {
            return "Nombre: " + Nombre +
                "   Cedula: " + Cedula;
        }

        private List<Visita> Visitas;

        public Paciente()
        {
            Nombre = "";
            Cedula = "";
            Cama = "";
            Horario = "";
            Visitas = new List<Visita>();
        }

        public Paciente(string n, string h, string id, string c)
        {
            Nombre = n;
            Horario = h;
            Cedula = id;
            Cama = c;
            Visitas = new List<Visita>();
        }

        public void addVisita(Visita visita)
        {
            Visitas.Add(visita);
        }

        public List<Visita> GetVisitas()
        {
            return Visitas;
        }

        public Visita getVisita(string id)
        {
            return Visitas.Single(v => v.cedula == id);
        }
    }
}
