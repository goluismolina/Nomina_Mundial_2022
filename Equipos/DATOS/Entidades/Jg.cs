namespace Equipos.DATOS.Entidades
{
    public class Jg
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Equipo { get; set; }
        public string Posicion { get; set; }

        public DateTime Nacimiento { get; set; }
        public int SeleccionId { get; set; }
        public string ImagenUrl { get; set; }

    }
}
