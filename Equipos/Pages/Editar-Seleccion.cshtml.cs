using Equipos.DTO;
using Equipos.NEGOCIO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Equipos.Pages
{
    public class Editar_SeleccionModel : PageModel
    {
        private readonly ISeleccionesNegocio _seleccionesNegocio;

        public Editar_SeleccionModel(ISeleccionesNegocio seleccionesNegocio)
        {
            _seleccionesNegocio = seleccionesNegocio;
        }
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        [Required(ErrorMessage ="El campo es requerido")]
        public string Seleccion { get; set; }
        public void OnGet(int id)
        {
            var seleccionDTO = _seleccionesNegocio.ObtenerSeleccionPorId(id);
            Seleccion = seleccionDTO.Seleccion;
            Id = id;
        }
        public IActionResult Onpost()
        {
            if (ModelState.IsValid)
            {
                var selecciones = new SeleccionesDTO { Id = Id, Seleccion = Seleccion };
                _seleccionesNegocio.ActualizarSeleccion(selecciones);
                return RedirectToPage("./Selecciones");
            }
            return Page();
        }
    }
}
