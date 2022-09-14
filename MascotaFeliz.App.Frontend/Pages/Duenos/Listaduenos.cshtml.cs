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
    public class ListaduenosModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno;

        public IEnumerable<Dueno> listaDuenos {get;set;}

        public ListaduenosModel()
        {
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        }
        public void OnGet()
        {
            listaDuenos = _repoDueno.GetAllDuenos();
        }
    }
}
