using Equipos.DTO;
using Equipos.NEGOCIO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Equipos.Pages
{
    public class SeleccionesModel : PageModel
    {
        private readonly ISeleccionesNegocio _seleccionesNegocio;

        public SeleccionesModel(ISeleccionesNegocio seleccionesNegocio)
        {
            _seleccionesNegocio = seleccionesNegocio;
        }
        public List<SeleccionesDTO> Selecciones { get; set; }
        public void OnGet()
        {
            Selecciones = _seleccionesNegocio.ObtenerSelecciones();
        }
    }
}
