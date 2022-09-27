using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class VisitasMascotasModel : PageModel
    {
        private readonly IRepositorioVisitaPyP _repoVisitaPyP;
        
        [BindProperty]
        public VisitaPyP visitaPyP {get; set;}
        

        public VisitasMascotasModel()
        {
            this._repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        }

        public IActionResult OnGet(int? visitaPyPId)
        {
            if(visitaPyPId.HasValue)
            {
                visitaPyP = _repoVisitaPyP.GetVisitaPyP(visitaPyPId.Value);
            }
            else
            {
                visitaPyP = new VisitaPyP();
            }
            if(visitaPyP == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

        public IActionResult OnPost()
        {

            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(visitaPyP.Id > 0)
            {     
                 visitaPyP = _repoVisitaPyP.UpdateVisitaPyP(visitaPyP);   
            }
            else
            {
                _repoVisitaPyP.AddVisitaPyP(visitaPyP);
            }
            
            return Page();
        }
    }
}