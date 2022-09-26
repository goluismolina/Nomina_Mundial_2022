using Equipos.DTO;
using Equipos.NEGOCIO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Equipos.Pages
{
    public class Nueva_SeleccionModel : PageModel
    {
        private readonly ISeleccionesNegocio _seleccionesNegocio;

        public Nueva_SeleccionModel(ISeleccionesNegocio seleccionesNegocio)
        {
            _seleccionesNegocio = seleccionesNegocio;
        }
        [BindProperty]
        [Required (ErrorMessage ="Campo Requerido")]
        [MaxLength(50)]
        public string Seleccion { get; set; }
        public void OnGet()
        {
        }
        public IActionResult  Onpost()
        {
            if(ModelState.IsValid)
            {
                var seleccionDTO = new SeleccionesDTO { Seleccion = Seleccion };
                _seleccionesNegocio.CrearSeleccion(seleccionDTO);
                return RedirectToPage("./Selecciones");
            }
            return Page();
           
        }
    }
}
