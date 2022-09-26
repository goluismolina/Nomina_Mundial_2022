namespace Equipos.NEGOCIO
{
    public class Jugadores
    {
        //constructor de la clase
        //public Jugadores(string nombre)
        //{
        //    Nombre = nombre;
        //}
        //Atributos
        public string Nombre { get; set; }
        public string Equipo { get; set; }
        public string Posiciones { get; set; }
        public int Nacimiento { get; set; }

        // Metodos
        public string Presentarse()
        {
            string saludo = "Hola mi nombre es: " + Nombre;
            return saludo;
        }
    }
}
