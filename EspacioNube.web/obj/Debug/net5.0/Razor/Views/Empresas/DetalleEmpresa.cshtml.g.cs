#pragma checksum "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\Empresas\DetalleEmpresa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5730ebdf15749236f904aa45ed7a238324d1b2ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresas_DetalleEmpresa), @"mvc.1.0.view", @"/Views/Empresas/DetalleEmpresa.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\_ViewImports.cshtml"
using EspacioNube.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\_ViewImports.cshtml"
using EspacioNube.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\_ViewImports.cshtml"
using EspacioNube.web.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5730ebdf15749236f904aa45ed7a238324d1b2ba", @"/Views/Empresas/DetalleEmpresa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aebf15dec159ef010893d2bc3a7c4151922caea3", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresas_DetalleEmpresa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsultarEmpresas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Empresas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-light not"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\Empresas\DetalleEmpresa.cshtml"
 foreach (var item in ViewBag.empresaDetail)
{   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Postulantes</h1>\r\n");
#nullable restore
#line 6 "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\Empresas\DetalleEmpresa.cshtml"
     foreach (var p in item.Postulantes)
    {   


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead>
            <tr>
                <th class=""col"">Nombre</th>
                <th class=""col"">Dni</th>
                <th class=""col"">Telefono</th>
                <th class=""col"">Email</th>
            </tr>
            </thead>
            <tbody>
                <tr>
                <td>");
#nullable restore
#line 20 "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\Empresas\DetalleEmpresa.cshtml"
               Write(p.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\Empresas\DetalleEmpresa.cshtml"
               Write(p.DNI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\Empresas\DetalleEmpresa.cshtml"
               Write(p.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\Empresas\DetalleEmpresa.cshtml"
               Write(p.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n            \r\n                \r\n                \r\n            \r\n        </table>\r\n");
#nullable restore
#line 31 "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\Empresas\DetalleEmpresa.cshtml"
     
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Matias\Desktop\CODIGO\comIT\HiredIn\EspacioNube.web\Views\Empresas\DetalleEmpresa.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button type=\"button\" class=\"btn btn-primary\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5730ebdf15749236f904aa45ed7a238324d1b2ba6923", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>");
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
