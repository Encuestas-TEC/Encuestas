#pragma checksum "C:\Users\Romar\OneDrive\Escritorio\Encuestas\EncuestasITESRC\EncuestasITESRC\Areas\Administrador\Views\Preguntas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acb720f28a31acc26ea00d58161b230dc6ae6a8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrador_Views_Preguntas_Index), @"mvc.1.0.view", @"/Areas/Administrador/Views/Preguntas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Administrador/Views/Preguntas/Index.cshtml", typeof(AspNetCore.Areas_Administrador_Views_Preguntas_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb720f28a31acc26ea00d58161b230dc6ae6a8f", @"/Areas/Administrador/Views/Preguntas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0016b6767730c936e45b5440b0aea7bd14cb65d3", @"/Areas/Administrador/Views/_ViewImports.cshtml")]
    public class Areas_Administrador_Views_Preguntas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Romar\OneDrive\Escritorio\Encuestas\EncuestasITESRC\EncuestasITESRC\Areas\Administrador\Views\Preguntas\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(73, 4818, true);
            WriteLiteral(@"
<section>
    <div class=""card "">

        <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
            <a class=""navbar-brand"" href=""#"" style=""overflow:hidden"">Lorem ipsum dolor sit amet consectetur adipisicing.</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarTogglerDemo02"" aria-controls=""navbarTogglerDemo02"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <svg class=""bi bi-three-dots-vertical"" width=""1em"" height=""1em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                    <path fill-rule=""evenodd"" d=""M9.5 13a1.5 1.5 0 11-3 0 1.5 1.5 0 013 0zm0-5a1.5 1.5 0 11-3 0 1.5 1.5 0 013 0zm0-5a1.5 1.5 0 11-3 0 1.5 1.5 0 013 0z"" clip-rule=""evenodd"" />
                </svg>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo02"">
                <ul class=""navbar-nav mr-auto mt-2 mt-lg-0"">


                    <li class=""nav-item dr");
            WriteLiteral(@"opdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-plus-circle""></i> Añadir pregunta
                        </a>
                        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                            <button class=""dropdown-item btn"" onclick=""addTextArea2()"">
                                <svg class=""bi bi-justify"" width=""1em"" height=""1em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                    <path fill-rule=""evenodd"" d=""M2 12.5a.5.5 0 01.5-.5h11a.5.5 0 010 1h-11a.5.5 0 01-.5-.5zm0-3a.5.5 0 01.5-.5h11a.5.5 0 010 1h-11a.5.5 0 01-.5-.5zm0-3a.5.5 0 01.5-.5h11a.5.5 0 010 1h-11a.5.5 0 01-.5-.5zm0-3a.5.5 0 01.5-.5h11a.5.5 0 010 1h-11a.5.5 0 01-.5-.5z"" clip-rule=""evenodd"" />
                                </svg> Respuesta libre
                       ");
            WriteLiteral(@"     </button>
                            <button class=""dropdown-item btn"" onclick=""addRange2()""><i class=""fas fa-arrows-alt-h""></i> Escala lineal</button>
                            <button class=""dropdown-item btn"" onclick=""addcheckbox3()"">
                                <svg class=""bi bi-list-task"" width=""1em"" height=""1em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                    <path fill-rule=""evenodd"" d=""M2 2.5a.5.5 0 00-.5.5v1a.5.5 0 00.5.5h1a.5.5 0 00.5-.5V3a.5.5 0 00-.5-.5H2zM3 3H2v1h1V3z"" clip-rule=""evenodd"" />
                                    <path d=""M5 3.5a.5.5 0 01.5-.5h9a.5.5 0 010 1h-9a.5.5 0 01-.5-.5zM5.5 7a.5.5 0 000 1h9a.5.5 0 000-1h-9zm0 4a.5.5 0 000 1h9a.5.5 0 000-1h-9z"" />
                                    <path fill-rule=""evenodd"" d=""M1.5 7a.5.5 0 01.5-.5h1a.5.5 0 01.5.5v1a.5.5 0 01-.5.5H2a.5.5 0 01-.5-.5V7zM2 7h1v1H2V7zm0 3.5a.5.5 0 00-.5.5v1a.5.5 0 00.5.5h1a.5.5 0 00.5-.5v-1a.5.5 0 00-.5-.5H2zm1 .5H2v1h1v-1z"" clip-r");
            WriteLiteral(@"ule=""evenodd"" />
                                </svg> Casilla de verificación
                            </button>
                            <button class=""dropdown-item btn"" style=""cursor:pointer;"" onclick=""addradio3()"">
                                <svg class=""bi bi-list-ul"" width=""1em"" height=""1em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                    <path fill-rule=""evenodd"" d=""M5 11.5a.5.5 0 01.5-.5h9a.5.5 0 010 1h-9a.5.5 0 01-.5-.5zm0-4a.5.5 0 01.5-.5h9a.5.5 0 010 1h-9a.5.5 0 01-.5-.5zm0-4a.5.5 0 01.5-.5h9a.5.5 0 010 1h-9a.5.5 0 01-.5-.5zm-3 1a1 1 0 100-2 1 1 0 000 2zm0 4a1 1 0 100-2 1 1 0 000 2zm0 4a1 1 0 100-2 1 1 0 000 2z"" clip-rule=""evenodd"" />
                                </svg> Opción multiple
                            </button>
                            <!-- <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">no sé que poner aqui xdxdxd</a> -->
                       ");
            WriteLiteral(@" </div>
                    </li>
                    <li class=""nav-item"">

                        <button type=""button"" class=""btn btn-light"" style=""color: #444;""><i class=""far fa-save""></i> Guardar</button>
                    </li>

                </ul>
                <div>
                    <i class=""fas fa-lock""></i>
                    <label class=""switch"">
                        <input type=""checkbox"">
                        <span class=""slider round""></span>
                    </label>
                    <i class=""fas fa-lock-open""></i>
                </div>
            </div>
        </nav>

        <div id=""contentPanel"">

        </div>



    </div>
</section>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591