#pragma checksum "C:\ClonRepo\White-hats-G-6\MascotaFeliz.App.Frontend\Pages\Duenos\Listaduenos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ab5bc8e0cb0f25ab2f2d6701670325a5db2d902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Duenos.Pages_Duenos_Listaduenos), @"mvc.1.0.razor-page", @"/Pages/Duenos/Listaduenos.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Duenos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\ClonRepo\White-hats-G-6\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ab5bc8e0cb0f25ab2f2d6701670325a5db2d902", @"/Pages/Duenos/Listaduenos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Duenos_Listaduenos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Listado propietarios </h1>\r\n<table class=\"tabla\">\r\n     <tr>\r\n            \r\n            <th>Nombres</th>\r\n            <th>Apellidos</th>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 14 "C:\ClonRepo\White-hats-G-6\MascotaFeliz.App.Frontend\Pages\Duenos\Listaduenos.cshtml"
     foreach (var dueno in Model.listaDuenos)
    {
       

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\ClonRepo\White-hats-G-6\MascotaFeliz.App.Frontend\Pages\Duenos\Listaduenos.cshtml"
           Write(dueno.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\ClonRepo\White-hats-G-6\MascotaFeliz.App.Frontend\Pages\Duenos\Listaduenos.cshtml"
           Write(dueno.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr> \r\n");
#nullable restore
#line 22 "C:\ClonRepo\White-hats-G-6\MascotaFeliz.App.Frontend\Pages\Duenos\Listaduenos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n    ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ListaduenosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaduenosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaduenosModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ListaduenosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591