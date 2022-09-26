namespace Equipos.DATOS.Repositorios
{
    public interface ISeleccionesRepositorio
    {
        List<Selecciones> ObtenerTodas();

        void CrearSeleccion(Selecciones seleciones);
        Selecciones ObtenerPorId(int id);
        void ActualizarSeleccion(Selecciones seleciones);
        void EliminarSeleccion(int id);
    }
}
