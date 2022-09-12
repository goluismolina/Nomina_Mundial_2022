using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Equipos.Pages
{
    public class TestModel : PageModel
    {
        [BindProperty]
        public int Numero1 { get; set; }
        [BindProperty]
        public int Numero2 { get; set; }

        public int Resultado { get; set; }
        public void OnGet()
        {
            //this.Numero1 = 123;
            //this.Numero2 = 321;   
        }
        public void OnPost()
        {
            var resultado = this.Numero1 + this.Numero2;
            this.Resultado = resultado;
        }
    }
}
