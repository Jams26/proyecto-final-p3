#pragma checksum "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Octubre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d66f57f10681bdcadc0bbcec30c47e57e7524553"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cumpleaños_Octubre), @"mvc.1.0.view", @"/Areas/Admin/Views/Cumpleaños/Octubre.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Cumpleaños/Octubre.cshtml", typeof(AspNetCore.Areas_Admin_Views_Cumpleaños_Octubre))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d66f57f10681bdcadc0bbcec30c47e57e7524553", @"/Areas/Admin/Views/Cumpleaños/Octubre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Cumpleaños_Octubre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TiendaOnline.Models.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Octubre.cshtml"
  
    ViewData["Title"] = "Cumpleaños Octubre";

#line default
#line hidden
            BeginContext(111, 412, true);
            WriteLiteral(@"
<br />
<br />
<div class=""row"">
    <div class=""col-6"">
        <h2 class=""text-info"">Cumpleaños del mes de Octubre</h2>

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
#line 25 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Octubre.cshtml"
             foreach (var k in Model)
            {

#line default
#line hidden
            BeginContext(577, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(624, 10, false);
#line 28 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Octubre.cshtml"
                   Write(k.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(634, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(666, 17, false);
#line 29 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Octubre.cshtml"
                   Write(k.fechaNacimiento);

#line default
#line hidden
            EndContext();
            BeginContext(683, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "C:\Users\javie\source\repos\TiendaOnline\TiendaOnline\Areas\Admin\Views\Cumpleaños\Octubre.cshtml"

            }

#line default
#line hidden
            BeginContext(730, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(787, 2203, true);
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
            });
        });

        var idioma_espanol = {
            ""sProcessing"": ""Procesando..."",
            ""sLe");
                WriteLiteral(@"ngthMenu"": ""Mostrar _MENU_ registros"",
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
            ""oAria"": {
                ""sSortAscending"": "": Activar para ordenar la columna de manera ascendente"",
                ""sSortDescending"": "": Activar para ordenar la columna de manera descendente""
        ");
                WriteLiteral("    },\r\n            \"buttons\": {\r\n                \"copy\": \"Copiar\",\r\n                \"colvis\": \"Visibilidad\"\r\n            }\r\n        }\r\n\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(2993, 4, true);
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
