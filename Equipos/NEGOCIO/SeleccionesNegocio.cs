using Equipos.DATOS;
using Equipos.DATOS.Repositorios;
using Equipos.DTO;

namespace Equipos.NEGOCIO
{
    public class SeleccionesNegocio : ISeleccionesNegocio
    {
        private readonly ISeleccionesRepositorio _seleccionesRepositorio;

        public SeleccionesNegocio(ISeleccionesRepositorio seleccionesRepositorio)
        {
            _seleccionesRepositorio = seleccionesRepositorio;
        }
        public List<SeleccionesDTO> ObtenerSelecciones()
        {
            var ListaSeleccionesDTO = new List<SeleccionesDTO>();
            var ListaSeleccionesEntidades = _seleccionesRepositorio.ObtenerTodas();
            foreach (var categoria in ListaSeleccionesEntidades)
            {
                var seleccionDTO = new SeleccionesDTO {Id = categoria.Id, Seleccion = categoria.Seleccion};
                ListaSeleccionesDTO.Add(seleccionDTO);
            }
            return ListaSeleccionesDTO;
        }
        public void CrearSeleccion(SeleccionesDTO seleccionesDTO)
        {
            var seleccion = new Selecciones { Seleccion = seleccionesDTO.Seleccion };
            _seleccionesRepositorio.CrearSeleccion(seleccion);
        }
         
        public SeleccionesDTO ObtenerSeleccionPorId (int id) 
        {
            var seleccion = _seleccionesRepositorio.ObtenerPorId(id);
            var SeleccionDTO = new SeleccionesDTO { Id = seleccion.Id, Seleccion = seleccion.Seleccion };
            return SeleccionDTO; 
        }
        public void ActualizarSeleccion(SeleccionesDTO seleccionesDTO)
        {
            var seleccion = new Selecciones {Id = seleccionesDTO.Id, Seleccion = seleccionesDTO.Seleccion };
            _seleccionesRepositorio.ActualizarSeleccion(seleccion);
        }
        public void EliminarSeleccion(int id)
        {
            _seleccionesRepositorio.EliminarSeleccion(id);
        }
    }
}
