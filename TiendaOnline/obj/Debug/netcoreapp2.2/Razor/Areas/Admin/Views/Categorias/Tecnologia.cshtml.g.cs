#pragma checksum "C:\Users\Usuario\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\Tecnologia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00d85d7c3b2641bcc2223ff96595019d929e20db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categorias_Tecnologia), @"mvc.1.0.view", @"/Areas/Admin/Views/Categorias/Tecnologia.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Categorias/Tecnologia.cshtml", typeof(AspNetCore.Areas_Admin_Views_Categorias_Tecnologia))]
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
#line 1 "C:\Users\Usuario\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#line 1 "C:\Users\Usuario\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\Tecnologia.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d85d7c3b2641bcc2223ff96595019d929e20db", @"/Areas/Admin/Views/Categorias/Tecnologia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Categorias_Tecnologia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Productos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button boxed-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Usuario\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\Tecnologia.cshtml"
  
    ViewData["Title"] = "Tecnologia";

#line default
#line hidden
            BeginContext(101, 246, true);
            WriteLiteral("\r\n<br />\r\n<div class=\"container\">\r\n\r\n    <h2>Categoria Tecnología</h2>\r\n    <br />\r\n    <!--? Popular Items Start -->\r\n    <div class=\"popular-items\">\r\n        <div class=\"\">\r\n            <!-- Section tittle -->\r\n            <div class=\"row\">\r\n\r\n");
            EndContext();
#line 19 "C:\Users\Usuario\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\Tecnologia.cshtml"
                 foreach (var producto in Model)
                {

#line default
#line hidden
            BeginContext(416, 204, true);
            WriteLiteral("                    <div class=\"col-xl-4 col-lg-4 col-md-6 col-sm-6\">\r\n                        <div class=\"single-popular-items mb-50 text-center\">\r\n                            <div class=\"popular-img\">\r\n");
            EndContext();
            BeginContext(719, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(753, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "00d85d7c3b2641bcc2223ff96595019d929e20db6484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 763, "~/", 763, 2, true);
#line 26 "C:\Users\Usuario\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\Tecnologia.cshtml"
AddHtmlAttributeValue("", 765, producto.Imagen, 765, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(790, 111, true);
            WriteLiteral("\r\n                                <div class=\"img-cap\">\r\n                                    <span class=\"p-2\">");
            EndContext();
            BeginContext(901, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00d85d7c3b2641bcc2223ff96595019d929e20db8292", async() => {
                BeginContext(1020, 8, true);
                WriteLiteral("Detalles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\Usuario\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\Tecnologia.cshtml"
                                                                                                     WriteLiteral(producto.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1032, 386, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""favorit-items"">
                                    <span class=""flaticon-heart""></span>
                                </div>
                            </div>
                            <div class=""popular-caption"">
                                <h3><a href=""product_details.html"">");
            EndContext();
            BeginContext(1419, 15, false);
#line 35 "C:\Users\Usuario\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\Tecnologia.cshtml"
                                                              Write(producto.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1434, 51, true);
            WriteLiteral("</a></h3>\r\n                                <span> $");
            EndContext();
            BeginContext(1486, 15, false);
#line 36 "C:\Users\Usuario\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\Tecnologia.cshtml"
                                   Write(producto.Precio);

#line default
#line hidden
            EndContext();
            BeginContext(1501, 105, true);
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 40 "C:\Users\Usuario\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\Tecnologia.cshtml"

                }

#line default
#line hidden
            BeginContext(1627, 119, true);
            WriteLiteral("            </div>\r\n\r\n            <!-- Button -->\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!-- Popular Items End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Productos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
