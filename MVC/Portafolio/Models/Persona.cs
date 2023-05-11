namespace Portafolio.Models
{
    public class Persona
    {
        public String? Nombre { get; set; }
        public int Edad { get; set; }

        public Persona()
        { }
        public Persona(String nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
