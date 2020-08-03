#pragma checksum "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Septiembre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9527360515bf39b17d79b2b600e086324db1927a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cumpleaños_Septiembre), @"mvc.1.0.view", @"/Areas/Admin/Views/Cumpleaños/Septiembre.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Cumpleaños/Septiembre.cshtml", typeof(AspNetCore.Areas_Admin_Views_Cumpleaños_Septiembre))]
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
#line 1 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#line 2 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9527360515bf39b17d79b2b600e086324db1927a", @"/Areas/Admin/Views/Cumpleaños/Septiembre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Cumpleaños_Septiembre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TiendaOnline.Models.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Septiembre.cshtml"
  
    ViewData["Title"] = "Cumpleaños Septiembre";

#line default
#line hidden
            BeginContext(114, 502, true);
            WriteLiteral(@"
<br />
<br />
<div class=""container"">

    <div class=""row"">
        <div class=""col-6"">
            <h2 class=""text-info"">Cumpleaños del mes de Septiembre</h2>

        </div>
    </div>
    <br />

    <div>
        <table class=""table table-striped border text-center"" id=""cumple"">
            <thead>
                <tr class=""table-info"">
                    <th>Correo</th>
                    <th>Fecha</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 27 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Septiembre.cshtml"
                 foreach (var k in Model)
                {

#line default
#line hidden
            BeginContext(678, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(733, 10, false);
#line 30 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Septiembre.cshtml"
                       Write(k.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(743, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(779, 17, false);
#line 31 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Septiembre.cshtml"
                       Write(k.fechaNacimiento);

#line default
#line hidden
            EndContext();
            BeginContext(796, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 33 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Septiembre.cshtml"

                }

#line default
#line hidden
            BeginContext(851, 64, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    </div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(936, 2443, true);
                WriteLiteral(@"
        <script type=""text/javascript"">

            //DataTable
            $(document).ready(function () {
                $('#cumple').DataTable({
                    ""language"": idioma_espanol,
                    dom: 'Bfrtip',
                    buttons: [
                        {
                            extend: 'copy',
                            text: 'COPIAR'
                        },
                        {
                            extend: 'pdf',
                            text: 'PDF'
                        },
                        {
                            extend: 'excel',
                            text: 'EXCEL'
                        },
                        {
                            extend: 'csv',
                            text: 'CSV'
                        },
                        {
                            extend: 'print',
                            text: 'IMPRIMIR'
                        }
                    ]
             ");
                WriteLiteral(@"   });
            });

            var idioma_espanol = {
                ""sProcessing"": ""Procesando..."",
                ""sLengthMenu"": ""Mostrar _MENU_ registros"",
                ""sZeroRecords"": ""No se encontraron resultados"",
                ""sEmptyTable"": ""Ningún dato disponible en esta tabla"",
                ""sInfo"": ""Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros"",
                ""sInfoEmpty"": ""Mostrando registros del 0 al 0 de un total de 0 registros"",
                ""sInfoFiltered"": ""(filtrado de un total de _MAX_ registros)"",
                ""sInfoPostFix"": """",
                ""sSearch"": ""Buscar:"",
                ""sUrl"": """",
                ""sInfoThousands"": "","",
                ""sLoadingRecords"": ""Cargando..."",
                ""oPaginate"": {
                    ""sFirst"": ""Primero"",
                    ""sLast"": ""Último"",
                    ""sNext"": ""Siguiente"",
                    ""sPrevious"": ""Anterior""
                },
                ""oAria""");
                WriteLiteral(@": {
                    ""sSortAscending"": "": Activar para ordenar la columna de manera ascendente"",
                    ""sSortDescending"": "": Activar para ordenar la columna de manera descendente""
                },
                ""buttons"": {
                    ""copy"": ""Copiar"",
                    ""colvis"": ""Visibilidad""
                }
            }

        </script>

    ");
                EndContext();
            }
            );
            BeginContext(3382, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TiendaOnline.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
