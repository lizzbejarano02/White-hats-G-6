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
    public class AsignarModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario (new Persistencia.AppContext());
        
        [BindProperty]
        public Mascota mascota {get;set;}
        public Dueno dueno {get;set;}
        public Veterinario veterinario {get;set;}

        public IEnumerable<Dueno> duenos{get;set;}
        public IEnumerable<Veterinario> veterinarios{get;set;}

        public AsignarModel()
        {
            this._repoMascota = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext()); 
        }
        public void OnGet(int ? mascotaId)
        {
            duenos = _repoDueno.GetAllDuenos();
            veterinarios = _repoVeterinario.GetAllVeterinarios();

            if(mascotaId.HasValue)
            {
                mascota = _repoMascota.GetMascota(mascotaId.Value);

            }
            if(mascota == null)
            {
                RedirectToPage("./NotFound");
            }
            else
            {
                Page();
            }

        }

        public IActionResult OnPost(Mascota mascota,int duenoId, int veterinarioId)
        {
            if (ModelState.IsValid)
            {
                dueno = _repoDueno.GetDueno(duenoId);
                veterinario= _repoVeterinario.GetVeterinario(veterinarioId);
                
                if(mascota.Id > 0)
                {
                    mascota.Veterinario = veterinario;
                    mascota.Dueno = dueno;
                    _repoMascota.UpdateMascota(mascota);
                    _repoMascota.AsignarDueno(mascota.Id,duenoId);
                    _repoMascota.AsignarVeterinario(mascota.Id,veterinarioId);
                }

                
            }
            return RedirectToPage("./ListaMascotas");
        }
    }
}
