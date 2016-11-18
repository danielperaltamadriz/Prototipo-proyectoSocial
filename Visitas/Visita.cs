namespace Visitas
{
    class Visita
    {
        public string nombre { get; set; }
        public string cedula { get; set; }

        public bool visitando { get; set; }

        public string getVisita()
        {
            return "Nombre: " + nombre +
                "   Cedula: " + cedula;
        }
    }
}
