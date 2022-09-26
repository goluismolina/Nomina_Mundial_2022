using Equipos.NEGOCIO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Equipos.Pages
{
    public class Eliminar_seleccionModel : PageModel
    {
        private readonly ISeleccionesNegocio _seleccionesNegocio;

        public Eliminar_seleccionModel(ISeleccionesNegocio seleccionesNegocio)
        {
            _seleccionesNegocio = seleccionesNegocio;
        }
        [BindProperty]
        public int Id { get; set; }
        public void OnGet(int id)
        {
            Id = id; 
        }
        public IActionResult Onpost()
        {
            _seleccionesNegocio.EliminarSeleccion(Id);
            return RedirectToPage("/Selecciones");
        }
    }
}
