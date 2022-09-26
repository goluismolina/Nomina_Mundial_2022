using Equipos.DATOS;
using Equipos.DTO;

namespace Equipos.NEGOCIO
{
    public interface ISeleccionesNegocio
    {
        List<SeleccionesDTO> ObtenerSelecciones();
        void CrearSeleccion(SeleccionesDTO seleccionesDTO);
        SeleccionesDTO ObtenerSeleccionPorId(int id);
        void ActualizarSeleccion(SeleccionesDTO seleccionesDTO);
        void EliminarSeleccion(int id);
    }
}
