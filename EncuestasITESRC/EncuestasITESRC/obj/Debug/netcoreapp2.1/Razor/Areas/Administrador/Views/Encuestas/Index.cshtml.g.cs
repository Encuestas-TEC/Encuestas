#pragma checksum "F:\ProyectoEncuestasITESRC\EncuestasITESRC\EncuestasITESRC\Areas\Administrador\Views\Encuestas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "974d60882b37ec8dff570a90e841fcbffaaa4ef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrador_Views_Encuestas_Index), @"mvc.1.0.view", @"/Areas/Administrador/Views/Encuestas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Administrador/Views/Encuestas/Index.cshtml", typeof(AspNetCore.Areas_Administrador_Views_Encuestas_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"974d60882b37ec8dff570a90e841fcbffaaa4ef7", @"/Areas/Administrador/Views/Encuestas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0016b6767730c936e45b5440b0aea7bd14cb65d3", @"/Areas/Administrador/Views/_ViewImports.cshtml")]
    public class Areas_Administrador_Views_Encuestas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EncuestasITESRC.Models.Encuesta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Administrador/AgregarEncuestas"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#addQModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#editModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Administrador/Encuestas/EliminarEncuesta"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\ProyectoEncuestasITESRC\EncuestasITESRC\EncuestasITESRC\Areas\Administrador\Views\Encuestas\Index.cshtml"
  
    ViewData["Title"] = "Encuestas";
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(128, 148, true);
            WriteLiteral("<div class=\"card mb-3\">\r\n    <div class=\"card-header\">\r\n        <h3> <i class=\"fa fa-table\"></i> <span>Lista de  las Encuestas</span></h3>\r\n        ");
            EndContext();
            BeginContext(276, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d916154533b84a7f8156203d2ca7b264", async() => {
                BeginContext(319, 86, true);
                WriteLiteral(" <i class=\"fas fa-plus\"></i> <span>Añadir una nueva encuesta a la base de datos</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(409, 479, true);
            WriteLiteral(@"
    </div>
    <div class=""card-body"">
        <table id=""tableCarreras"" class=""display responsive nowrap"" style=""width:100%"">
            <thead>
                <tr>
                    <th>Estado</th>
                    <th>Nombre</th>
                    <th>Categoria</th>
                    <th>Descripcion</th>
                    <th>N° Preguntas</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 24 "F:\ProyectoEncuestasITESRC\EncuestasITESRC\EncuestasITESRC\Areas\Administrador\Views\Encuestas\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(953, 182, true);
            WriteLiteral("                    <tr>\r\n                        <th style=\"text-align: center;\"><span class=\"staus inactive\"><i class=\"fas fa-circle\"></i></span></th>\r\n                        <th>");
            EndContext();
            BeginContext(1136, 11, false);
#line 28 "F:\ProyectoEncuestasITESRC\EncuestasITESRC\EncuestasITESRC\Areas\Administrador\Views\Encuestas\Index.cshtml"
                       Write(item.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1183, 16, false);
#line 29 "F:\ProyectoEncuestasITESRC\EncuestasITESRC\EncuestasITESRC\Areas\Administrador\Views\Encuestas\Index.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
            EndContext();
            BeginContext(1199, 130, true);
            WriteLiteral("</th>\r\n                        <th>\r\n                            <div class=\"encuestas-actions\">\r\n                                ");
            EndContext();
            BeginContext(1329, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aad8a4dcaa34d1ca13f2511560e6f24", async() => {
                BeginContext(1426, 40, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i><span></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1338, "~/Administrador/AgregarPreguntas/", 1338, 33, true);
#line 32 "F:\ProyectoEncuestasITESRC\EncuestasITESRC\EncuestasITESRC\Areas\Administrador\Views\Encuestas\Index.cshtml"
AddHtmlAttributeValue("", 1371, item.Id, 1371, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1470, 72, true);
            WriteLiteral("\r\n                                <br>\r\n                                ");
            EndContext();
            BeginContext(1542, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d32668653934dbbb8f8a293064e4341", async() => {
                BeginContext(1637, 40, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i><span></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1551, "~/Administrador/EditarEncuesta/", 1551, 31, true);
#line 34 "F:\ProyectoEncuestasITESRC\EncuestasITESRC\EncuestasITESRC\Areas\Administrador\Views\Encuestas\Index.cshtml"
AddHtmlAttributeValue("", 1582, item.Id, 1582, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1681, 74, true);
            WriteLiteral("\r\n                                <br>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1755, "\"", 1791, 3);
            WriteAttributeValue("", 1762, "javascript:eliminar(", 1762, 20, true);
#line 36 "F:\ProyectoEncuestasITESRC\EncuestasITESRC\EncuestasITESRC\Areas\Administrador\Views\Encuestas\Index.cshtml"
WriteAttributeValue("", 1782, item.Id, 1782, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1790, ")", 1790, 1, true);
            EndWriteAttribute();
            BeginContext(1792, 411, true);
            WriteLiteral(@">
                                    <i class=""fas fa-trash-alt""></i>
                                    <span>Eliminar Encuesta</span>
                                </a>
                                <br> <a href="""" data-toggle=""modal"" data-target=""#seeModal""><i class=""fas fa-eye""></i> <span></span></a>
                            </div>
                        </th>
                    </tr>
");
            EndContext();
#line 44 "F:\ProyectoEncuestasITESRC\EncuestasITESRC\EncuestasITESRC\Areas\Administrador\Views\Encuestas\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2222, 50, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        ");
            EndContext();
            BeginContext(2272, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ed5123ee5d404cb697c02a95189b4c", async() => {
                BeginContext(2344, 73, true);
                WriteLiteral("\r\n            <input name=\"id\" id=\"idEncuesta\" type=\"hidden\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2424, 2437, true);
            WriteLiteral(@"

        <script>
            function eliminar(idEncuesta) {
                document.getElementById(""idEncuesta"").value = idEncuesta;
                if (confirm('¿Desea eliminar esta encuesta?')) {
                    document.forms[0].submit()
                };
            }
        </script>

    </div>
    <script>
        var tableC = $('#tableCarreras').DataTable({
            ""language"": {
                ""sProcessing"": ""Procesando..."",
                ""sLengthMenu"": ""Mostrar _MENU_ "",
                ""sZeroRecords"": ""No se encontraron resultados"",
                ""sEmptyTable"": ""Ningún dato disponible en esta tabla"",
                ""sInfo"": ""Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros"",
                ""sInfoEmpty"": ""Mostrando registros del 0 al 0 de un total de 0 registros"",
                ""sInfoFiltered"": ""(filtrado de un total de _MAX_ registros)"",
                ""sInfoPostFix"": """",
                ""sSearch"": """",
                ""sSearchP");
            WriteLiteral(@"laceholder"": ""Buscar..."",
                ""sUrl"": """",
                ""sInfoThousands"": "","",
                ""sLoadingRecords"": ""Cargando..."",
                ""oPaginate"": {
                    ""sFirst"": ""Primero"",
                    ""sLast"": ""Último"",
                    ""sNext"": ""Siguiente"",
                    ""sPrevious"": ""Anterior""
                },
                ""oAria"": {
                    ""sSortAscending"": "": Activar para ordenar la columna de manera ascendente"",
                    ""sSortDescending"": "": Activar para ordenar la columna de manera descendente""
                },
                ""buttons"": {
                    ""copy"": ""Copiar"",
                    ""colvis"": ""Visibilidad""
                }
            },

        });

        tableC({
            responsive: {
                details: {
                    renderer: $.fn.dataTable.Responsive.renderer.tableAll({ tableClass: 'ui table' })
                }
            }
        });
        tableC('respons");
            WriteLiteral(@"ive-resize', function (e, datatable, columns) {
            var count = columns.reduce(function (a, b) {
                return b === false ? a + 1 : a;
            }, 0);

            console.log(count + ' column(s) are hidden');
        });
        tableC({
            ""autoWidth"": true
        });
        tableC({
            ""autoWidth"": true
        });
    </script>
");
            EndContext();
            BeginContext(4986, 3906, true);
            WriteLiteral(@"    <!-- modals -->
    <!-- delete -->
    <div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Eliminar Encuesta</h5>
                    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">¿Desea eliminar esta encuesta?</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancelar</button>
                    <a class=""btn btn-primary"" href=""#"">Eliminar</a>
                </div>
            </div>
        </div>
    </div>
    <!-- Editar -->
    <div class=""mod");
            WriteLiteral(@"al fade"" id=""editModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Editar encuesta</h5>
                    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">¿Desea editar la información de la encuesta?</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancelar</button>
                    <a class=""btn btn-primary"" href=""#"">Editar</a>
                </div>
            </div>
        </div>
    </div>
    <!-- ver   -->
    <div class=""modal fade"" id=""seeModal"" tabindex=""-1"" role=""dialog"" ari");
            WriteLiteral(@"a-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Ver Encuesta</h5>
                    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">¿Desea visualizar la encuesta?</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancelar</button>
                    <a class=""btn btn-primary"" href=""#"">Ver</a>
                </div>
            </div>
        </div>
    </div>
    <div class=""modal fade"" id=""addQModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""");
            WriteLiteral(@"document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Añadir preguntas</h5>
                    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">Actualmente la encuesta cuenta con {#} preguntas ¿Desea agregar preguntas?</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancelar</button>
                    <a class=""btn btn-primary"" href=""#"">Agregar Preguntas</a>
                </div>
            </div>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EncuestasITESRC.Models.Encuesta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
